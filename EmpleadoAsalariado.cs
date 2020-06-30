using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_10_ejercicio_4
{
    public class EmpleadoAsalariado : Empleado
    {
        private decimal salarioSemanal;

        public decimal SalarioSemanal
        {
            get { return salarioSemanal; }
            set { salarioSemanal = value < 0 ? 0 : value; }
        }

        public EmpleadoAsalariado() { }

        public EmpleadoAsalariado(string nombre, string nss, decimal salario)
            : base(nombre, nss)
        {
            SalarioSemanal = salario;
        }

        public override decimal ObtenerMontoPago()
        {
            return SalarioSemanal;
        }

        public override string ToString()
        {
            return string.Format("empleado asalariado: {0}\n{1}: {2}", 
                base.ToString(), "salario Semanal", SalarioSemanal);
        }
    }
}
