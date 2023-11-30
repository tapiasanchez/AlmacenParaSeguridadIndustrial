using System;

namespace CapaEntidad
{
    public class Inventario
    {
        public int IdInventario { get; set; }
        public int Ingreso { get; set; }
        public int Salida { get; set; }
        public Producto Producto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
