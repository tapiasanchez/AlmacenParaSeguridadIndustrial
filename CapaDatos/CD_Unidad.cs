using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Unidad
    {
        public List<Unidad> Listar()
        {
            List<Unidad> lista = new List<Unidad>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select * from Unidad";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Unidad()
                            {
                                IdUnidad = Convert.ToInt32(reader["IDUnidad"]),
                                Nombre = reader["NombreUnidad"].ToString(),

                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Unidad>();
                }

            }
            return lista;
        }

        public int Registrar(Unidad obj, out string Mensaje)
        {
            int idUnidadGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUNIDAD", oconexion);
                    cmd.Parameters.AddWithValue("nombre", obj.Nombre);
                    cmd.Parameters.Add("idUnidadResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    idUnidadGenerado = Convert.ToInt32(cmd.Parameters["idUnidadResultado"].Value);

                }
            }
            catch (Exception ex)
            {
                idUnidadGenerado = 0;
                Mensaje = ex.Message;
            }

            return idUnidadGenerado;

        }
        public Unidad GetUnidad(String nombreUnidad)
        {
            Unidad unidad = new Unidad();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_GETUNIDAD", oconexion);
                    cmd.Parameters.AddWithValue("nombreUnidad", nombreUnidad);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            unidad.IdUnidad = Convert.ToInt32(reader["IDUnidad"]);
                            unidad.Nombre = reader["NombreUnidad"].ToString();
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                unidad = new Unidad();
            }
           return unidad;
        }
    }
}


