using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

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

        public Producto GetByID(int id)
        {
            return objcd_producto.GetByID(id);
        }

        public void UpdateStock(Producto obj)
        {
            objcd_producto.UpdateStock(obj);
        }
    }
}
