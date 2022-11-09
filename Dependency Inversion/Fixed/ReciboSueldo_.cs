using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion.Fixed
{
    class ReciboSueldo_ : IImprimible
    {
        public ReciboSueldo_(int legajo, double total)
        {
            Total = total;
            Legajo = legajo;
        }

        public double Total { get; set; }
        public int Legajo { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo recibo de sueldo del legajo {reciboSueldo.Legajo} por un total de {reciboSueldo.Total}");
        }
    }
}
