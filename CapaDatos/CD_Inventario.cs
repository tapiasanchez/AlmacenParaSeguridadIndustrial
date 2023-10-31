using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Inventario
    {
        public void Registrar(Inventario obj)
        {
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARINVENTARIO", oconexion);
                    cmd.Parameters.AddWithValue("ingreso", obj.Ingreso);
                    cmd.Parameters.AddWithValue("salida", obj.Salida);
                    cmd.Parameters.AddWithValue("idProducto", obj.Producto.IdProducto);
                    cmd.Parameters.AddWithValue("fecha", obj.Fecha);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                //Mensaje = ex.Message;
                Console.WriteLine(ex.Message);
            }

        }
    }
}
