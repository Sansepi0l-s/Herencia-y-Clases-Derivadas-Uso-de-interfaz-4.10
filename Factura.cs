using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_10_ejercicio_4
{
    public class Factura : IPorPagar
    {
        private string numeroPieza;

        public string NumeroPieza
        {
            get { return numeroPieza; }
            set { numeroPieza = value; }
        }
        private string descripcionPieza;

        public string DescripcionPieza
        {
            get { return descripcionPieza; }
            set { descripcionPieza = value; }
        }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private decimal precioPorArticulo;

        public decimal PrecioPorArticulo
        {
            get { return precioPorArticulo; }
            set { precioPorArticulo = value; }
        }

        public Factura() { }

        public Factura(string pieza, string descripcion, int cuenta, decimal precio)
        {
            NumeroPieza = pieza;
            DescripcionPieza = descripcion;
            Cantidad = cuenta;
            PrecioPorArticulo = precio;
        }

        public override string ToString()
        {
            return string.Format("{0}: \n{1}: {2} ({3}) \n{4}: {5} \n{6}: {7:C}","factura", "numero de pieza",NumeroPieza,DescripcionPieza,
                "cantidad",Cantidad,"precio por articulo",PrecioPorArticulo);
        }

        public decimal ObtenerMontoPago()
        {
            return cantidad * precioPorArticulo; 
        }
    }
}
