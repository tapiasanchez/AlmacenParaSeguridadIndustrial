using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_DetalleDotacion
    {
        private readonly CD_DetalleDotacion objcd_detalleDotacion = new CD_DetalleDotacion();

        public void Registrar(DetalleDotacion obj)
        {
             objcd_detalleDotacion.Registrar(obj);
        }

        public List<DetalleDotacion> GetProductoByIdDotacion(int id)
        {
            return objcd_detalleDotacion.GetListaDotacionById(id);
        }

        public List<DetalleDotacion> GetDetalleDeDotacionByIdUsuario(int idUser)
        {
            return objcd_detalleDotacion.GetDetalleDotacionPorUsuario(idUser);
        }
        public string VerificarProducto(int id)
        {
            return objcd_detalleDotacion.VerificarProducto(id);
        }
        public List<DetalleDotacion> GetDotacionesList(DateTime fechaInicio, DateTime fechaFin)
        {
            return objcd_detalleDotacion.GetDotacionesList(fechaInicio, fechaFin);
        }
    }
}
