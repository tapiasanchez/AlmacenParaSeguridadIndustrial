using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
                Console.WriteLine(ex.Message);
            }

        }

        public List<Inventario> GetInventarioList(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Inventario> lista = new List<Inventario>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_GETIINVENTARIO", oconexion);
                    cmd.Parameters.AddWithValue("fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("fechaFin", fechaFin);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Inventario()
                            {   
                                Producto = new Producto()
                                {
                                   Codigo = reader["Codigo"].ToString(),
                                   NombreProducto = reader["NombreProducto"].ToString(),
                                   Talla = new Talla()
                                   {
                                       Nombre = reader["NombreTalla"].ToString()
                                   },
                                   Color = reader["Color"].ToString(),
                                  Unidad = reader["Unidad"].ToString(),
                                  Cantidad = Convert.ToInt32(reader["Cantidad"])
                                },
                                Ingreso = Convert.ToInt32(reader["IngresoTotal"]),
                                Salida = Convert.ToInt32(reader["SalidasTotal"])
                            });

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }
    }
}
