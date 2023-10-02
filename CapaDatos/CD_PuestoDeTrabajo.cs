using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_PuestoDeTrabajo
    {
        public List<PuestoDeTrabajo> Listar()
        {
            List<PuestoDeTrabajo> lista = new List<PuestoDeTrabajo>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select * from PuestoDeTrabajo";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new PuestoDeTrabajo()
                            {
                                IdPuestoDeTrabajo = Convert.ToInt32(reader["IDPuestoDeTrabajo"]),
                                Nombre = reader["NombrePuesto"].ToString(),

                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<PuestoDeTrabajo>();
                }
            }
            return lista;
        }

        public int Registrar(PuestoDeTrabajo obj, out string Mensaje)
        {
            int idPuestoDeTrabajoGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPUESTODETRABAJO", oconexion);
                    cmd.Parameters.AddWithValue("nombre", obj.Nombre);
                    cmd.Parameters.Add("idPuestoDeTrabajoResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    idPuestoDeTrabajoGenerado = Convert.ToInt32(cmd.Parameters["idPuestoDeTrabajoResultado"].Value);

                }
            }
            catch (Exception ex)
            {
                idPuestoDeTrabajoGenerado = 0;
                Mensaje = ex.Message;
            }

            return idPuestoDeTrabajoGenerado;

        }
        public PuestoDeTrabajo GetPuestoDeTrabajo(String nombre)
        {
            PuestoDeTrabajo puesto = new PuestoDeTrabajo();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_GETPUESTODETRABAJO", oconexion);
                    cmd.Parameters.AddWithValue("nombrePuesto", nombre);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            puesto.IdPuestoDeTrabajo = Convert.ToInt32(reader["IDPuestoDeTrabajo"]);
                            puesto.Nombre = reader["NombrePuesto"].ToString();
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                puesto = new PuestoDeTrabajo();
            }
            return puesto;
        }

    }
}
