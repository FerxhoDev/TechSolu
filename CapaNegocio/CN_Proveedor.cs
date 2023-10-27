﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {

        private CD_Proveedor objcd_Proveedor = new CD_Proveedor();

        public List<Proveedor> Listar()
        {
            return objcd_Proveedor.Listar();
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty; // declara mensaj como Cadena vacia para no ser null

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Proveedor\n";
            }
            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el Telefono del Proveedor\n";
            }
            if (obj.Direccion == "")
            {
                Mensaje += "Es necesarioa la Direcció del proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Proveedor.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty; // declara mensaj como Cadena vacia para no ser null

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Proveedor\n";
            }
            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el Teléfono del nombre de Proveedor\n";
            }
            if (obj.Direccion == "")
            {
                Mensaje += "Es necesaria la direccion del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Proveedor.Editar(obj, out Mensaje);
            }


        }

        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            return objcd_Proveedor.Eliminar(obj, out Mensaje);
        }

    }
}
