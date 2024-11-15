using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistema_de_Seguridad.Repository
{
    public class Db 
    {

        public ClsUsuario Login(string username, string password)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            string query = "SELECT * FROM Usuarios WHERE NombreUsuario = @Username AND Clave = @Password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ClsUsuario usuario = new ClsUsuario();
                                usuario.UsuarioID = Convert.ToInt32(reader.GetValue(0).ToString());
                                usuario.NombreUsuario = reader.GetValue(1).ToString();
                                usuario.Email = reader.GetValue(2).ToString();
                                usuario.PrimerNombre = reader.GetValue(3).ToString();
                                usuario.SegundoNombre = reader.GetValue(4).ToString();
                                usuario.PrimerApellido = reader.GetValue(5).ToString();
                                usuario.SegundoApellido = reader.GetValue(6).ToString();
                                usuario.Direccion = reader.GetValue(7).ToString();
                                usuario.Telefono = reader.GetValue(8).ToString();
                                usuario.Clave = reader.GetValue(9).ToString();
                                usuario.FechaRegistro = Convert.ToDateTime(reader.GetValue(10).ToString());

                                return usuario;
                            }
                            else
                            {
                                return null; // Usuario no encontrado
                            }
                        }

                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                    //Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public ClsUsuario SignUp(ClsUsuario usuario)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            string query = "INSERT INTO Usuarios (NombreUsuario, Email, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Direccion, Telefono, Clave, FechaRegistro) " +
                           "OUTPUT INSERTED.UsuarioID " +
                           "VALUES (@NombreUsuario, @Email, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Direccion, @Telefono, @Clave, @FechaRegistro)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                        cmd.Parameters.AddWithValue("@Email", usuario.Email);
                        cmd.Parameters.AddWithValue("@PrimerNombre", usuario.PrimerNombre);
                        cmd.Parameters.AddWithValue("@SegundoNombre", usuario.SegundoNombre);
                        cmd.Parameters.AddWithValue("@PrimerApellido", usuario.PrimerApellido);
                        cmd.Parameters.AddWithValue("@SegundoApellido", usuario.SegundoApellido);
                        cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                        cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        cmd.Parameters.AddWithValue("@Clave", usuario.Clave);
                        cmd.Parameters.AddWithValue("@FechaRegistro", usuario.FechaRegistro);

                        // Ejecutar la consulta y obtener el UsuarioID generado
                        usuario.UsuarioID = (int)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }

            return usuario;
        }


        public bool ValidarUsuarioRepetido(string username)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @Username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            return true; // Usuario repetido
                        }
                        else
                        {
                            return false; // Usuario no repetido
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

    }
}