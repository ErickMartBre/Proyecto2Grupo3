using Sistema_de_Seguridad.Repository;
using Sistema_de_Seguridad.Validations;
using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace Sistema_de_Seguridad
{
    public partial class login : Page
    {
        protected void Login_Click(object sender, EventArgs e)
        {
            string username = Text1.Text;
            string password = Password1.Text;

            Db database = new Db();

            try
            {
                ClsUsuario usuario = database.Login(username, password);
                if (usuario != null)
                {
                    Session["Usuario"] = usuario;
                    Response.Redirect("Details.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Usuario o contraseña incorrectos');</script>");
                }
            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }


        }


        protected void SignUp_Click(object sender, EventArgs e)
        {


            ClsUsuario usuario = new ClsUsuario();
            usuario.NombreUsuario = Text2.Text;
            usuario.Email = Email1.Text;
            usuario.PrimerNombre = Text3.Text;
            usuario.SegundoNombre = Text4.Text;
            usuario.PrimerApellido = Text5.Text;
            usuario.SegundoApellido = Text6.Text;
            usuario.Direccion = Text7.Text;
            usuario.Telefono = Text8.Text;
            usuario.Clave = Password2.Text;
            usuario.FechaRegistro = DateTime.Now;
            string confirmarClave = Password3.Text;


            if (!ValidacionUsuario.ValidarEmail(usuario.Email))
            {
                Response.Write("<script>alert('El email no es válido');</script>");
                return;
            }
            if (!ValidacionUsuario.ValidarTamanioClave(usuario.Clave))
            {
                Response.Write("<script>alert('La contraseña debe tener al menos 6 caracteres');</script>");
                return;
            }

            if (!ValidacionUsuario.ValidarClavesIguales(usuario.Clave, confirmarClave))
            {
                Response.Write("<script>alert('Las contraseñas no coinciden');</script>");
                return;
            }

            if (ValidacionUsuario.ValidarUsuarioRepetido(usuario.NombreUsuario))
            {
                Response.Write("<script>alert('El usuario ya existe');</script>");
                return;
            }


            Db database = new Db();

            try
            {
                ClsUsuario usuarioRegistrado = database.SignUp(usuario);
                if (usuarioRegistrado != null)
                {
                    Session["Usuario"] = usuarioRegistrado;
                    Response.Redirect("Details.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Error al registrar el usuario');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }



        }
    }
}