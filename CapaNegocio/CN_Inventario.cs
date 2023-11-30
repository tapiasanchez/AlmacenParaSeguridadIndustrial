using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Inventario
    {
        private readonly CD_Inventario objcd_inventario = new CD_Inventario();
        public void Registrar(Inventario obj)
        {
            objcd_inventario.Registrar(obj);
        }

        public List<Inventario> GETInventario(DateTime fechaInicio, DateTime fechaFin)
        {
            return objcd_inventario.GetInventarioList(fechaInicio, fechaFin);
        }

    }
}
