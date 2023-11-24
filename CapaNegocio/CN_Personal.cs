using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Personal
    {
        private CD_Personal objcd_person = new CD_Personal();

        public List<Personal> Listar()
        {
            return objcd_person.getUser();
        }
        public void Registrar(Personal obj)
        {
            objcd_person.Registrar(obj);
        }
    }
}
