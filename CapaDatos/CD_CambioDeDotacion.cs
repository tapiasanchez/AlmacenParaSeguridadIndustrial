using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_CambioDeDotacion
    {
        public void Registrar(CambioDotacion obj)
        {
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCAMBIODOTACION", oconexion);
                    cmd.Parameters.AddWithValue("idUsuario", obj.Usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("idPersonal", obj.Personal.IdPersona);
                    cmd.Parameters.AddWithValue("idProducto", obj.Producto.IdProducto);
                    cmd.Parameters.AddWithValue("cantidad", obj.Cantidad);
                    cmd.Parameters.AddWithValue("comentario", obj.Comentario);
                    cmd.Parameters.AddWithValue("fechaCambioDeDotacion", obj.Fecha);
                    cmd.Parameters.AddWithValue("codigoFormulario", obj.CodFormulario);
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
        public List<CambioDotacion> GetCambioDeDotacion(int idUser) 
        {
            List<CambioDotacion> lista = new List<CambioDotacion>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_GETCAMBIODEDOTACION", oconexion);
                    cmd.Parameters.AddWithValue("idUsuario", idUser);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CambioDotacion()
                            {
                                Usuario = new Usuario() { 
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    Ci = reader["CI"].ToString()
                                },
                                Producto = new Producto()
                                {
                                    NombreProducto = reader["NombreProducto"].ToString(),
                                    Talla = new Talla()
                                    {
                                        Nombre = reader["NombreTalla"].ToString()
                                    },
                                    Color = reader["Color"].ToString(),
                                    Unidad = reader["Unidad"].ToString()
                                },
                                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                Comentario = reader["Comentario"].ToString(),
                                Fecha = DateTime.Parse(reader["Fecha"].ToString())
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
        public List<CambioDotacion> GetCambioList(DateTime fechaInicio, DateTime fechaFin)
        {
            List<CambioDotacion> lista = new List<CambioDotacion>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_GETCAMBIODOTACIONPORFECHAS", oconexion);
                    cmd.Parameters.AddWithValue("FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("FechaFin", fechaFin);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CambioDotacion()
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
                                Cantidad = Convert.ToInt32(reader["CantidadTotal"])
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
