using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
