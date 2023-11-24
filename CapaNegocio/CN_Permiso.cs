using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private CD_Permiso objcd_permiso = new CD_Permiso();

        public List<Permiso> Listar(int id)
        {
            return objcd_permiso.Listar(id);
        }
        public List<Permiso> GetPermisos()
        {
            return objcd_permiso.getPermisos();
        }
        public void Registar(Permiso permiso)
        {
            objcd_permiso.Registrar(permiso);
        }
    }
}
