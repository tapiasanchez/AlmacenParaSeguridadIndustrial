﻿using CapaEntidad;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

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
        public List<DetalleDotacion> GetListaDotacionById(int id)
        {
            List<DetalleDotacion> lista = new List<DetalleDotacion>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_GETLISTADOTACION", oconexion);
                    cmd.Parameters.AddWithValue("idDotacion", id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DetalleDotacion() { 
                                producto = new Producto()
                                {
                                    NombreProducto = reader["NombreProducto"].ToString(),
                                    Talla = new Talla()
                                    {
                                        Nombre = reader["NombreTalla"].ToString()
                                    }
                                } ,
                            Cantidad = Convert.ToInt32(reader["Cantidad"]),
                        });
                           
                        }

                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }
        public List<DetalleDotacion> GetDetalleDotacionPorUsuario(int id)
        {
            List<DetalleDotacion> lista = new List<DetalleDotacion>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_GETDOTACIONPORUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("idUsuario", id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DetalleDotacion()
                            {
                                dotacion = new Dotacion() 
                                { 
                                    FechaDotacion = DateTime.Parse(reader["FechaDotacion"].ToString()),
                                    Comentario = reader["Comentario"].ToString()

                                },
                                producto = new Producto()
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
        public string VerificarProducto(int id)
        {
            string result = "";
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_VERIFICARTRANSACCIONDEPRODUCTO", oconexion);
                    cmd.Parameters.AddWithValue("idProducto", id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                             result = reader["Resultado"].ToString();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
