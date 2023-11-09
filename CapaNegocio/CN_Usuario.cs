using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private readonly CD_Usuarios objcd_usuario = new CD_Usuarios();

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            return objcd_usuario.Registrar(obj, out Mensaje);
        }

        public Usuario GetByCiAndNombre(string ci, string nombre)
        {
            return objcd_usuario.GetByIdAndName(ci, nombre);
        }
        public Usuario GetByIdUsuario(int id)
        {
            return objcd_usuario.GetByIdUsuario(id);
        }
        public void Update(Usuario obj)
        {
            objcd_usuario.Update(obj);
        }
    }
}
