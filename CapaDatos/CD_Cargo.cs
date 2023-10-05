using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Cargo
    {
        public List<Cargo> Listar()
        {
            List<Cargo> lista = new List<Cargo>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select * from Cargo";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Cargo()
                            {
                                IdCargo = Convert.ToInt32(reader["IDCargo"]),
                                Nombre= reader["NombreCargo"].ToString(),
                                
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

        public int Registrar(Cargo obj, out string Mensaje)
        {
            int idCargoGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCARGO", oconexion);
                    cmd.Parameters.AddWithValue("nombre", obj.Nombre);
                    cmd.Parameters.Add("idCargoResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    idCargoGenerado = Convert.ToInt32(cmd.Parameters["idCargoResultado"].Value);

                }
            }
            catch (Exception ex)
            {
                idCargoGenerado = 0;
                Mensaje = ex.Message;
                Console.WriteLine(Mensaje);
            }

            return idCargoGenerado;
        }

        public Cargo GetId(String nombre)
        {
            Cargo cargo = new Cargo();
           
                try
                {
                    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                    {
                        SqlCommand cmd = new SqlCommand("SP_GETCARGO", oconexion);
                        cmd.Parameters.AddWithValue("nombre", nombre);
                        cmd.CommandType = CommandType.StoredProcedure;
                        oconexion.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader()) {
                         while (reader.Read())
                         {
                            cargo.IdCargo = Convert.ToInt32(reader["IDCargo"]);
                            cargo.Nombre = reader["NombreCargo"].ToString();
                         }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
             return cargo;
        }
    }
}

