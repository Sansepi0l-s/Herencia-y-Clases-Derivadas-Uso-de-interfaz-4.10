using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_10_ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPorPagar> objetosPorPagar = new List<IPorPagar>();

            objetosPorPagar.Add(new Factura("01234", "asiento", 2, 375.00M));
            objetosPorPagar.Add(new Factura("56789", "llanta", 4, 79.95M));
            objetosPorPagar.Add(new EmpleadoAsalariado("Simon Pedro", "11111", 800.00M));
            objetosPorPagar.Add(new EmpleadoAsalariado("Esteban", "22222", 1200.00M));

            Console.WriteLine("Facturas y Empleados procesados e forma polimórfica:\n");
            foreach (IPorPagar porPagarActual in objetosPorPagar)
            {
                Console.WriteLine("{0} \n{1}: {2}\n", porPagarActual, "Pago vencido", porPagarActual.ObtenerMontoPago());
            }

            Console.Write("Presione cualquier tecla");
            Console.ReadKey(true);
        }
    }
}
