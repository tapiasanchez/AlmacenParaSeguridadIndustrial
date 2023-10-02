using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_PuestoDeTrabajo
    {
        private CD_PuestoDeTrabajo objcd_puestoDeTrabajo = new CD_PuestoDeTrabajo();

        public List<PuestoDeTrabajo> Listar()
        {
            return objcd_puestoDeTrabajo.Listar();
        }

        public int Registrar(PuestoDeTrabajo obj, out string Mensaje)
        {
            return objcd_puestoDeTrabajo.Registrar(obj, out Mensaje);
        }

        public PuestoDeTrabajo GetPuestoDeTrabajo(string nombre)
        {
            return objcd_puestoDeTrabajo.GetPuestoDeTrabajo(nombre);
        }
    }
}
