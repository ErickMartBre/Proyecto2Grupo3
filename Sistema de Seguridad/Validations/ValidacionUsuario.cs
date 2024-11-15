using Sistema_de_Seguridad.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_Seguridad.Validations
{
    public class ValidacionUsuario
    {
        public static bool ValidarEmail(string email)
        {
            // Verificar que el email sea válido (esto es solo un ejemplo básico)
            return email.Contains("@") && email.Contains(".");
        }

        public static bool ValidarTamanioClave(string clave)
        {
            // Aquí puedes agregar más validaciones según las reglas de tu aplicación
            return clave.Length >= 6; // Contraseña debe tener al menos 6 caracteres
        }

        public static bool ValidarClavesIguales(string clave, string confirmarClave)
        {
            return clave == confirmarClave;
        }

        public static bool ValidarUsuarioRepetido(string username)
        {
            Db database = new Db();

            try
            {
                if (database.ValidarUsuarioRepetido(username))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}