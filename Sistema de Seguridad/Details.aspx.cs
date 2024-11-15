using System;

namespace Sistema_de_Seguridad
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Recuperar los datos del usuario de la sesión
                ClsUsuario usuario = Session["Usuario"] as ClsUsuario;

                if (usuario != null)
                {
                    // Mostrar los datos del usuario en los controles de la página
                    lblNombreUsuario.Text = "Nombre de Usuario: " + usuario.NombreUsuario;
                    lblEmail.Text = "Email: " + usuario.Email;
                    lblPrimerNombre.Text = "Primer Nombre: " + usuario.PrimerNombre;
                    lblSegundoNombre.Text = "Segundo Nombre: " + usuario.SegundoNombre;
                    lblPrimerApellido.Text = "Primer Apellido: " + usuario.PrimerApellido;
                    lblSegundoApellido.Text = "Segundo Apellido: " + usuario.SegundoApellido;
                    lblDireccion.Text = "Dirección: " + usuario.Direccion;
                    lblTelefono.Text = "Teléfono: " + usuario.Telefono;
                    lblFechaRegistro.Text = "Fecha de Registro: " + usuario.FechaRegistro.ToString("dd/MM/yyyy");
                }
                else
                {
                    // Redirigir a la página de login si no hay datos de usuario en la sesión
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}
