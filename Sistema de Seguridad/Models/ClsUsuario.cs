using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Seguridad
{
    public class ClsUsuario
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Clave { get; set; }
        public DateTime FechaRegistro { get; set; }  // Agregar fecha de registro

        public ClsUsuario()
        {
            // Constructor vacío
        }


    }
}
