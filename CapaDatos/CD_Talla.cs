using CapaEntidad;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

namespace CapaDatos
{
    public class CD_Talla
    {
        public List<Talla> Listar()
        {
            List<Talla> lista = new List<Talla>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select * from Talla";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Talla()
                            {
                                IdTalla = Convert.ToInt32(reader["IDTalla"]),
                                Nombre = reader["NombreTalla"].ToString(),

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

        public int Registrar(Talla obj, out string Mensaje)
        {
            int idTallaGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARTALLA", oconexion);
                    cmd.Parameters.AddWithValue("nombre", obj.Nombre);
                    cmd.Parameters.Add("idTallaResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    idTallaGenerado = Convert.ToInt32(cmd.Parameters["idTallaResultado"].Value);

                }
            }
            catch (Exception ex)
            {
                idTallaGenerado = 0;
                Mensaje = ex.Message;
                Console.WriteLine(Mensaje);
            }

            return idTallaGenerado;
        }
        public Talla GetId(String nombre)
        {
            Talla talla = new Talla();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_GETTALLA", oconexion);
                    cmd.Parameters.AddWithValue("nombre", nombre);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            talla.IdTalla = Convert.ToInt32(reader["IDTalla"]);
                            talla.Nombre = reader["NombreTalla"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return talla;
        }
    }
}
