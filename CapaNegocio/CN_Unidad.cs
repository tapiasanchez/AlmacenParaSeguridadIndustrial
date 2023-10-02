using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Unidad
    {
        private CD_Unidad objcd_unidad = new CD_Unidad();

        public List<Unidad> Listar()
        {
            return objcd_unidad.Listar();
        }

        public int Registrar(Unidad obj, out string Mensaje)
        {
            return objcd_unidad.Registrar(obj, out Mensaje);
        }

        public Unidad GetUnidad(string nombreUnidad)
        {
            return objcd_unidad.GetUnidad(nombreUnidad);
        }
    }
}
