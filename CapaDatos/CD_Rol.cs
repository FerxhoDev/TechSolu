using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select idRol, Descriptcion from Rol");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Rol()
                            {

                                IdRol = Convert.ToInt32(dr["idRol"]),
                                Descripcion = dr["Descriptcion"].ToString(),
                                
                            }) ;
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Rol>();
                }
                return lista;
            }
        }
    }
}

