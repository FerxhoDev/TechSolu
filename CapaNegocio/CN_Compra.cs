using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Compra
    {
        private CD_Compra objcd_compra = new CD_Compra();
        public int ObtenerCorrelativo()
        {
            return objcd_compra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra obj,DataTable DetalleCompram, out string Mensaje)
        {           
             return objcd_compra.Registrar(obj,DetalleCompram, out Mensaje);
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra oCompra = objcd_compra.ObtenerCompra(numero);

            if (oCompra.IdCompra != 0)
            {
                List<Detalle_Compra> oDetatalleCompra = objcd_compra.ObtenerDetalleCompra(oCompra.IdCompra);

                oCompra.oDetalleComrpa = oDetatalleCompra;
            }

            return oCompra;
        }
    }
}
