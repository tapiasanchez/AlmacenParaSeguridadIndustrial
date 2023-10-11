using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class CD_ListaDotacion
    {
        public void Registrar(ListaDotacion obj)
        {

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_REGISTRARLISTADOTACION", oconexion);
                    
                    cmd.Parameters.AddWithValue("idProducto", obj.NombreProducto.IdProducto);
                    cmd.Parameters.AddWithValue("idPuestoDeTrabajo", obj.NombrePuesto.IdPuestoDeTrabajo);
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
        public List<Producto> GetListProducts(string puesto)
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.IDProducto, p.NombreProducto from ListaDotacion l ");
                    query.AppendLine("inner join Product p on p.IdProducto = l.IdProducto ");
                    query.AppendLine("inner join PuestoDeTrabajo pu on pu.IDPuestoDeTrabajo = l.IdPuestoDeTrabajo ");
                    query.AppendLine("WHERE pu.NombrePuesto = '"+ puesto + "'");
                    query.AppendLine(" GROUP BY p.IDProducto, p.NombreProducto");

                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = oconexion,
                        CommandText = query.ToString(),
                        CommandType = CommandType.Text
                     };
                    
                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Producto()
                            {
                                IdProducto = Convert.ToInt32(reader["IDProducto"]),
                                NombreProducto = reader["NombreProducto"].ToString(),
                               
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return lista;
        }

    }
}
