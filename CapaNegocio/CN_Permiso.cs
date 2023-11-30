using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private readonly CD_Permiso objcd_permiso = new CD_Permiso();

        public List<Permiso> Listar(int id)
        {
            return objcd_permiso.Listar(id);
        }
        public List<Permiso> GetPermisos()
        {
            return objcd_permiso.GetPermisos();
        }
        public void Registar(Permiso permiso)
        {
            objcd_permiso.Registrar(permiso);
        }
        public void Delete(Permiso permiso)
        {
            objcd_permiso.Delete(permiso);
        }
    }
}
