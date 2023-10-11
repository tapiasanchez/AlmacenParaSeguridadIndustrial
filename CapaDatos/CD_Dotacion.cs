using CapaEntidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Dotacion
    {
        public void Registrar(Dotacion obj)
        {
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) 
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARDOTACION", oconexion);
                    cmd.Parameters.AddWithValue("idUsuario", obj.usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("comentario", obj.Comentario);
                    cmd.Parameters.AddWithValue("fechaDotacion", obj.FechaDotacion);
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
        public Dotacion GetUltimaDotacion()
        {
            Dotacion dotacion = new Dotacion();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_GETULTIMADOTACION", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dotacion.IdDotacion = Convert.ToInt32(reader["IDDotacion"]);
                            dotacion.usuario = new Usuario() { IdUsuario = Convert.ToInt32(reader["IdUsuario"]) };
                            dotacion.Comentario = reader["Comentario"].ToString();
                            dotacion.FechaDotacion = DateTime.Parse(reader["FechaDotacion"].ToString());
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dotacion;

        }
    }
}
