using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto objcd_producto = new CD_Producto();
        public List<Producto> Listar()
        {
            return objcd_producto.Listar();
        }

        public void Registrar(Producto obj)
        {
            objcd_producto.Registrar(obj);
        }
    }
}
