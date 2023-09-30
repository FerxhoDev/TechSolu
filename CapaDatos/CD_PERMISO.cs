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
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idusuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select P.id_Rol, nombreMenu from PERMISO p");
                    query.AppendLine("inner join ROL r on r.idRol = p.id_Rol");
                    query.AppendLine("inner join Usuario u on u.id_Rol = r.idRol");
                    query.AppendLine("where u.idUsuario = @idusuario");
                    

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idusuario", idusuario);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso
                            {
                                oRol = new Rol { IdRol = Convert.ToInt32(dr["id_Rol"])},
                                NombreMenu = dr["nombreMenu"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }
                return lista;
            }
        }
    }
}
