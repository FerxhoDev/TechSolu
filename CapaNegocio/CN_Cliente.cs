﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {

        private CD_Cliente objcd_Cliente = new CD_Cliente();

        public List<Cliente> Listar()
        {
            return objcd_Cliente.Listar();
        }


        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty; // declara mensaj como Cadena vacia para no ser null

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Cliente\n";
            }
            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario la Direccion del Cliente\n";
            }
            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el Correo del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Cliente.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty; // declara mensaj como Cadena vacia para no ser null

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Cliente\n";
            }
            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario la Direccion del Cliente\n";
            }
            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el Correo del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Cliente.Editar(obj, out Mensaje);
            }


        }

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            return objcd_Cliente.Eliminar(obj, out Mensaje);
        }

    }
}
