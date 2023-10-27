using CapaEntidad;
using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Negocio
    {
        public Negocio ObtenerDatos()
        {
            Negocio objNegocio = new Negocio();

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "select idNegocio, Nombre, Nit, Direccion from NEGOCIO where idNegocio = 1";

                    SqlCommand cmd = new SqlCommand(query, conexion);

                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objNegocio = new Negocio()
                            {
                                IdNegocio = int.Parse(dr["idNegocio"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                NIT = dr["Nit"].ToString(),
                                Direcion = dr["Direccion"].ToString()
                            };
                        }
                    }
                }

            }catch (Exception ex)
            {
                objNegocio = new Negocio();
            }



            return objNegocio;
        }

        public bool GuardarDatos(Negocio objNegocio, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update NEGOCIO set Nombre = @Nombre,");
                    query.AppendLine("Nit = @Nit,");
                    query.AppendLine("Direccion = @Direccion");
                    query.AppendLine("where idNegocio = 1");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);

                    cmd.Parameters.AddWithValue("@Nombre", objNegocio.Nombre);
                    cmd.Parameters.AddWithValue("@Nit", objNegocio.NIT);
                    cmd.Parameters.AddWithValue("@Direccion", objNegocio.Direcion);


                    cmd.CommandType = System.Data.CommandType.Text;

                    if(cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = mensaje + "No se pudieron guardar los datos";
                        respuesta = false;
                    }
                }

            }
            catch (Exception ex)
            {
                mensaje = mensaje + " " + ex.Message;
                respuesta=false;
            }

            return respuesta;
        }

        public byte[] obtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] LogoBytes = new byte[0];


            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "select Logo  from NEGOCIO where idNegocio = 1";

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);                   
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            LogoBytes = (byte[])reader["logo"];
                        }
                    }
                }

            }
            catch (Exception ex)
            {
               obtenido = false;
               LogoBytes=new byte[0];
            }
            return LogoBytes;
        }

        public bool ActualizarLogo(byte[] image, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            byte[] LogoBytes = new byte[0];


            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    //string query = "select Logo  from NEGOCIO where idNegocio = 1";
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update NEGOCIO set Logo = @image");
                    query.AppendLine("where idNegocio = 1");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.CommandType = System.Data.CommandType.Text;

                    if(cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar el Logo";
                        respuesta = false;
                    }
                }

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }
            return respuesta;
        }
    }
}
