using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string NombreProducto { get; set;}
        public string Descripcion { get; set; }
        public int Cantidad {  get; set; }
        public Talla Talla { get; set; }
        public DateTime Fecha { get; set; }
        public int IdProducto { get; set; }
    }
}
