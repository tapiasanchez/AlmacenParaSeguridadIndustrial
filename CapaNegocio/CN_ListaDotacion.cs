using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{   
    public class CN_ListaDotacion
    {
        private CD_ListaDotacion objcd_lista = new CD_ListaDotacion();
        public void Registrar(ListaDotacion obj)
        {
            objcd_lista.Registrar(obj);
        }

        public List<Producto> GetListProductByPuesto(string puesto)
        {
            return objcd_lista.GetListProducts(puesto);
        }
    }
}
