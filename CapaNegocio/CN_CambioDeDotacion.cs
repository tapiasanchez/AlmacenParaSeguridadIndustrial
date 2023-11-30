using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_CambioDeDotacion
    {
        private readonly CD_CambioDeDotacion objcd_dotacion = new CD_CambioDeDotacion();
        public void Registrar(CambioDotacion dotacion)
        {
            objcd_dotacion.Registrar(dotacion);
        }
        public List<CambioDotacion> GetCambioDeDotacion(int id) => objcd_dotacion.GetCambioDeDotacion(id);

        public List<CambioDotacion> GetCambios(DateTime fechaInicio, DateTime fechaFin)
        {
            return objcd_dotacion.GetCambioList(fechaInicio, fechaFin);
        }
    }
}
