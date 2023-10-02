using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Cargo
    {
        private CD_Cargo objcd_cargo = new CD_Cargo();

        public List<Cargo> Listar()
        {
            return objcd_cargo.Listar();
        }

        public int Registrar(Cargo obj, out string Mensaje)
        {
            return objcd_cargo.Registrar(obj, out Mensaje);
        }

        public Cargo GetId(string nombre) {
            return objcd_cargo.GetId(nombre);
        }
    }
}
