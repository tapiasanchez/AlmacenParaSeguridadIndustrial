using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_DetalleDotacion
    {
        private CD_DetalleDotacion objcd_detalleDotacion = new CD_DetalleDotacion();

        public void Registrar(DetalleDotacion obj)
        {
             objcd_detalleDotacion.Registrar(obj);
        }
    }
}
