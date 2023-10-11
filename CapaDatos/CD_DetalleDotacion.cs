using CapaEntidad;
using System;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_DetalleDotacion
    {
        public void Registrar(DetalleDotacion obj)
        {
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARDETALLEDOTACION", oconexion);
                    cmd.Parameters.AddWithValue("idDotacion", obj.dotacion.IdDotacion);
                    cmd.Parameters.AddWithValue("idProducto", obj.producto.IdProducto);
                    cmd.Parameters.AddWithValue("cantidad", obj.Cantidad);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
