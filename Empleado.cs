using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_10_ejercicio_4
{
    public abstract class Empleado : IPorPagar
    {
        private string nombre;
        private string numeroSeguroSocial;

     

        public Empleado() { }

        public Empleado(string nombre, string nss)
        {
            this.nombre = nombre;
            this.numeroSeguroSocial = nss;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string NumeroSeguroSocial
        {
            get { return numeroSeguroSocial; }
        }

        public override string ToString()
        {
            return string.Format("{0}\nnúmero de seguro social: {1}",
                Nombre,NumeroSeguroSocial);
        }

        public abstract decimal ObtenerMontoPago();
    }
}
