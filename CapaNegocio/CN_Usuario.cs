using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuarios objcd_usuario = new CD_Usuarios();

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            return objcd_usuario.Registrar(obj, out Mensaje);
        }
    }
}
