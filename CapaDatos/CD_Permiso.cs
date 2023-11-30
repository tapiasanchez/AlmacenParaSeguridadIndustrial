using System;
using System.Collections.Generic;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> GetPermisos()
        {
            List<Permiso> lista = new List<Permiso>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("Select IDPermiso, NombreMenu, IdCargo from Permiso  ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion)
                    {
                        CommandType = CommandType.Text
                    };
                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                IdPermiso = Convert.ToInt32(reader["IDPermiso"]),
                                NombreMenu = reader["NombreMenu"].ToString(),
                                Cargo = new Cargo() { IdCargo = Convert.ToInt32(reader["IdCargo"]) }
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
        public List<Permiso> Listar(int id)
        {
            List<Permiso> lista = new List<Permiso>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("Select p.IdCargo, p.NombreMenu from Permiso p");
                    query.AppendLine("inner join Cargo c on c.IDCargo = p.IdCargo");
                    query.AppendLine("inner join Personal per on per.IdCargo = c.IDCargo");
                    query.AppendLine("where per.IDPersonal = @idPersonal");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.AddWithValue("@idPersonal", id);
                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                Cargo = new Cargo() { 
                                IdCargo = Convert.ToInt32(reader["IdCargo"])
                                },
                                NombreMenu= reader["NombreMenu"].ToString()

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
        public void Registrar(Permiso obj)
        {
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPERMISO", oconexion);
                    cmd.Parameters.AddWithValue("idCargo", obj.Cargo.IdCargo);
                    cmd.Parameters.AddWithValue("nombreMenu", obj.NombreMenu);
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
        public void Delete(Permiso obj)
        {
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELINARPERMISO", oconexion);
                    cmd.Parameters.AddWithValue("idPermiso", obj.IdPermiso);
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
