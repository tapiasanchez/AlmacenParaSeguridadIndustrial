using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class CD_Producto
    {
        public List<Producto> Listar()
        {

            List<Producto> lista = new List<Producto>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select  p.IDProducto,p.Codigo, p.NombreProducto, p.Descripcion,p.Cantidad, t.NombreTalla from Product p");
                    query.AppendLine("inner join Talla t on t.IDTalla = p.IdTalla ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Producto()
                            {

                                IdProducto = Convert.ToInt32(reader["IDProducto"]),
                                Codigo = reader["Codigo"].ToString(),
                                NombreProducto = reader["NombreProducto"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                Talla = new Talla() { Nombre = reader["NombreTalla"].ToString() },
                                //Fecha = DateTime.Parse(reader["Fecha"].ToString()),
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

        public void Registrar(Producto obj)
        {
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPRODUCTO", oconexion);
                    cmd.Parameters.AddWithValue("codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("nombreProducto", obj.NombreProducto);
                    cmd.Parameters.AddWithValue("descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("cantidad", obj.Cantidad);
                    cmd.Parameters.AddWithValue("idTalla", obj.Talla.IdTalla);
                    cmd.Parameters.AddWithValue("fecha", obj.Fecha);
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
        public Producto GetByID(int id)
        {
            Producto obj = new Producto();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("Select * from Product ");
                    query.AppendLine("Where IDProducto = '" + id + "'");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            obj.IdProducto = Convert.ToInt32(reader["IDProducto"]);
                            obj.Codigo = reader["Codigo"].ToString();
                            obj.NombreProducto = reader["NombreProducto"].ToString();
                            obj.Descripcion = reader["Descripcion"].ToString();
                            obj.Cantidad = Convert.ToInt32(reader["Cantidad"]);
                            obj.Talla = new Talla() { Nombre = reader["NombreTalla"].ToString() };
                            obj.Fecha = DateTime.Parse(reader["Fecha"].ToString());

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return obj;
        }
        public void UpdateStock(Producto obj)
        {
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ACTUALIZARSTOCK", oconexion);
                    cmd.Parameters.AddWithValue("idProducto", obj.IdProducto);
                    cmd.Parameters.AddWithValue("NuevoCantidad", obj.Cantidad);
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
