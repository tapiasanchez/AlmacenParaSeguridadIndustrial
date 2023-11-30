using System;

namespace CapaEntidad
{
    public class Permiso
    {
        public int IdPermiso { get; set; }
        public Cargo Cargo { get; set; }
        public string NombreMenu { get; set; }
        public DateTime Fecha { get; set; }
    }
}
