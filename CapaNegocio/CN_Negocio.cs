using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Negocio
    {

        private CD_Negocio objcd_Negocio = new CD_Negocio();

        public Negocio ObtenerDatos()
        {
            return objcd_Negocio.ObtenerDatos();
        }

        public bool GuardarDatos(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty; // declara mensaj como Cadena vacia para no ser null

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Negocio\n";
            }
            if (obj.Direcion == "")
            {
                Mensaje += "Es necesario la Direccion de Negocio\n";
            }
            if (obj.NIT == "")
            {
                Mensaje += "Es necesario el NIT del Negocio\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Negocio.GuardarDatos(obj, out Mensaje);
            }

        }

        public byte[] obtenerLogo(out bool obtenido)
        {
            return objcd_Negocio.obtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] image, out string mensaje)
        {
            return objcd_Negocio.ActualizarLogo( image, out mensaje);
        }

    }
}
