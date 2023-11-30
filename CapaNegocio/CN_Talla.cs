using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Talla
    {
        private readonly CD_Talla objcd_talla = new CD_Talla();

        public List<Talla> Listar()
        {
            return objcd_talla.Listar();
        }

        public int Registrar(Talla obj, out string Mensaje)
        {
            return objcd_talla.Registrar(obj, out Mensaje);
        }

        public Talla GetId(string nombre)
        {
            return objcd_talla.GetId(nombre);
        }
    }
}
