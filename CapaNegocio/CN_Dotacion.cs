using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Dotacion
    {
        private readonly CD_Dotacion objcd_dotacion = new CD_Dotacion();
        public void Registrar(Dotacion dotacion)
        {
            objcd_dotacion.Registrar(dotacion);
        }

        public Dotacion GetUltimaDotacion()
        {
            return objcd_dotacion.GetUltimaDotacion();
        }
    }
}
