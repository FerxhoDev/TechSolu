using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Compra
    {

        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from COMPRA");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    idcorrelativo = Convert.ToInt32( cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
                return idcorrelativo;
            }

            return idcorrelativo;
        }

        public bool Registrar(Compra objCompra, DataTable DetalleCompra, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_RegistrarCompra".ToString(), oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario",objCompra.oUsuario.IdUsiario);
                    cmd.Parameters.AddWithValue("IdProveedor",objCompra.oProveedor.idProveedor);
                    cmd.Parameters.AddWithValue("TipoDocumento",objCompra.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocumento",objCompra.NumeroDocumento);
                    cmd.Parameters.AddWithValue("MontoTotal", objCompra.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleCompra", DetalleCompra);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();


                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                    
                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }
                return Respuesta;
            }


        }

        public Compra ObtenerCompra(string numero)
        {
            Compra objCompra = new Compra();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select c.IdCompra,");
                    query.AppendLine("u.Nombre,");
                    query.AppendLine("pr.nombre, pr.telefono,");
                    query.AppendLine("c.tipoDocumento, c.numeroDocumento, costoTotal, CONVERT(char(10), c.fechaRegistro,103)[FechaRegistro]");
                    query.AppendLine("from COMPRA c");
                    query.AppendLine("inner join USUARIO u on u.idUsuario = c.id_Usuario");
                    query.AppendLine("inner join PROVEEDOR pr on pr.idProveedor = c.id_Proveedor");
                    query.AppendLine("where c.numeroDocumento = @numero");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);

                    cmd.Parameters.AddWithValue("@numero", numero);

                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objCompra = new Compra()
                            {
                                IdCompra = Convert.ToInt32(dr["IdCompra"]),
                                oUsuario = new Usuario()
                                {
                                    Nombre = dr["Nombre"].ToString(),
                                },
                                oProveedor = new Proveedor()
                                {
                                    Nombre = dr["nombre"].ToString(),
                                    Telefono = dr["telefono"].ToString(),
                                },
                                TipoDocumento = dr["tipoDocumento"].ToString(),
                                NumeroDocumento = dr["numeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal( dr["costoTotal"].ToString()),
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                            };
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    objCompra = new Compra();
                }
            }
            return objCompra;
        }

        public List<Detalle_Compra> ObtenerDetalleCompra(int idcompra)
        {
            List<Detalle_Compra> oLista = new List<Detalle_Compra>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    StringBuilder query = new StringBuilder();
 
                    query.AppendLine("select p.Nombre, dc.Costo, dc.Cantidad, dc.MontoTotal from DETALLECOMPRA dc");
                    query.AppendLine("inner join PRODUCTO p on p.IdProducto = dc.id_producto");
                    query.AppendLine("where dc.id_Compra = @idcompra");



                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idcompra", idcompra);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                         while (dr.Read())
                         {
                            oLista.Add(new Detalle_Compra()
                            {
                                oProducto = new Producto() { Nombre = dr["Nombre"].ToString() },
                                Costo = Convert.ToDecimal(dr["Costo"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                            });   
                         }
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                oLista = new List<Detalle_Compra>();
            }
            return oLista;
        }
    }
}
