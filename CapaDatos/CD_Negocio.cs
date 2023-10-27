using CapaEntidad;
using System;
using System.Data.SqlClient;

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

            }



            return objNegocio;
        }


    }
}
