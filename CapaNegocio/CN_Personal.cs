using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Personal
    {
        private readonly CD_Personal objcd_person = new CD_Personal();

        public List<Personal> Listar()
        {
            return objcd_person.GetUser();
        }
        public void Registrar(Personal obj)
        {
            objcd_person.Registrar(obj);
        }
        public void Actualizar(Personal obj)
        {
            objcd_person.Actualizar(obj);
        }
    }
}
