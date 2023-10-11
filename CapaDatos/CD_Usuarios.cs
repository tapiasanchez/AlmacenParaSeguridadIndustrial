using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        public List<Usuario> Listar() { 
        
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select  us.IDUsuario,us.Item, us.CI, us.Nombre,us.Apellido, c.NombreCargo, u.NombreUnidad, p.NombrePuesto from Usuario us ");
                    query.AppendLine("inner join Cargo c on c.IDCargo = us.IdCargo ");
                    query.AppendLine("inner join Unidad u on u.IDUnidad = us.IdUnidad");
                    query.AppendLine("inner join PuestoDeTrabajo p on p.IDPuestoDeTrabajo = us.IdPuestoDeTrabajo");
                    
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Usuario (){ 

                                IdUsuario = Convert.ToInt32(reader["IDUsuario"]),
                                Item = reader["Item"].ToString(),
                                Ci = reader["CI"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                NombreCargo = new Cargo() { Nombre = reader["NombreCargo"].ToString() },
                                NombreUnidad = new Unidad() { Nombre = reader["NombreUnidad"].ToString() },
                                NombrePuesto = new PuestoDeTrabajo() { Nombre = reader["NombrePuesto"].ToString() }, 
                            });
                        }
                    }

                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return lista;
        }
        public int Registrar(Usuario obj,out string Mensaje){
            int idUsuarioGenerado = 0;
            Mensaje = string.Empty;

            try {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) {

                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("item", obj.Item);
                    cmd.Parameters.AddWithValue("ci", obj.Ci);
                    cmd.Parameters.AddWithValue("nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("apellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("idCargo", obj.NombreCargo.IdCargo);
                    cmd.Parameters.AddWithValue("idUnidad", obj.NombreUnidad.IdUnidad);
                    cmd.Parameters.AddWithValue("idPuestoDeTrabajo", obj.NombrePuesto.IdPuestoDeTrabajo);
                    cmd.Parameters.Add("idUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    idUsuarioGenerado = Convert.ToInt32(cmd.Parameters["idUsuarioResultado"].Value);

                }
            }
            catch (Exception ex) {
                idUsuarioGenerado = 0;
                Mensaje = ex.Message;
                Console.WriteLine(ex.Message);
            }
            return idUsuarioGenerado;
        }
        public Usuario GetByIdAndName(string ci, string nombre)
        {
            Usuario usuario = new Usuario();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select  us.IDUsuario, us.CI, us.Nombre,us.Apellido, c.NombreCargo, u.NombreUnidad, p.NombrePuesto from Usuario us ");
                    query.AppendLine("inner join Cargo c on c.IDCargo = us.IdCargo ");
                    query.AppendLine("inner join Unidad u on u.IDUnidad = us.IdUnidad");
                    query.AppendLine("inner join PuestoDeTrabajo p on p.IDPuestoDeTrabajo = us.IdPuestoDeTrabajo");
                    query.AppendLine("where us.CI ='" + ci + "'");
                    query.AppendLine("and us.Nombre ='" + nombre + "'");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuario.IdUsuario = Convert.ToInt32(reader["IDUsuario"]);
                            usuario.Ci = reader["CI"].ToString();
                            usuario.Nombre = reader["Nombre"].ToString();
                            usuario.Apellido = reader["Apellido"].ToString();
                            usuario.NombreCargo = new Cargo() { Nombre = reader["NombreCargo"].ToString() };
                            usuario.NombreUnidad = new Unidad() { Nombre = reader["NombreUnidad"].ToString() };
                            usuario.NombrePuesto = new PuestoDeTrabajo() { Nombre = reader["NombrePuesto"].ToString() };
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return usuario;
        }
    }
}
