using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int IdUsiario { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Rol oRol { get; set; }
        public bool Estado { get; set; }
        public string Direccion { get; set; }
        public string FechaRegistro { get; set; }
    }
}
