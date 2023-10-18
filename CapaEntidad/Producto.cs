using System;

namespace CapaEntidad
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string NombreProducto { get; set;}
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public string Unidad { get; set; }
        public int Cantidad {  get; set; }
        public Talla Talla { get; set; }
        public DateTime Fecha { get; set; }
        public int IdProducto { get; set; }
    }
}
