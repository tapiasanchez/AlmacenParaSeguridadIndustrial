using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Inventario
    {
        private CD_Inventario objcd_inventario = new CD_Inventario();
        public void Registrar(Inventario obj)
        {
            objcd_inventario.Registrar(obj);
        }

    }
}
