using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
