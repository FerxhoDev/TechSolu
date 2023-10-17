using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty; // declara mensaj como Cadena vacia para no ser null

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del usuario\n";
            }
            if (obj.UserName == "")
            {
                Mensaje += "Es necesario el nombre del nombre de Usuario\n";
            }
            if (obj.Password == "")
            {
                Mensaje += "Es necesario el nombre del La Contraseña\n";
            }

            if (Mensaje != string.Empty){
                return 0;
            }
            else
            {
                return objcd_usuario.Registrar(obj, out Mensaje);
            }
            
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty; // declara mensaj como Cadena vacia para no ser null

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del usuario\n";
            }
            if (obj.UserName == "")
            {
                Mensaje += "Es necesario el nombre del nombre de Usuario\n";
            }
            if (obj.Password == "")
            {
                Mensaje += "Es necesario el nombre del La Contraseña\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Editar(obj, out Mensaje);
            }

            
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objcd_usuario.Eliminar(obj, out Mensaje);
        }
    }
}
