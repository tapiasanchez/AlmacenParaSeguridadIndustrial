using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public  class CD_Personal
    {
        public List<Personal> GetUser()
        {
            List<Personal> lista = new List<Personal>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("Select p.IDPersonal, p.NombreCompleto, p.CI, p.UserName, p.Contrasena, c.NombreCargo from Personal p  ");
                    query.AppendLine("inner join Cargo c on c.IDCargo = p.IdCargo ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion)
                    {
                        CommandType = CommandType.Text
                    };
                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Personal()
                            {
                                IdPersona = Convert.ToInt32(reader["IDPersonal"]),
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                Ci = reader["CI"].ToString(),
                                UserName = reader["UserName"].ToString(),
                                Contrasena = reader["Contrasena"].ToString(),

                                Cargo = new Cargo() { Nombre = reader["NombreCargo"].ToString() }
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
        public void Registrar(Personal obj)
        {
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPERSONAL", oconexion);
                    cmd.Parameters.AddWithValue("nombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("ci", obj.Ci);
                    cmd.Parameters.AddWithValue("userName", obj.UserName);
                    cmd.Parameters.AddWithValue("contrasena", obj.Contrasena);
                    cmd.Parameters.AddWithValue("idCargo", obj.Cargo.IdCargo);
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
