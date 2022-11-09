using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion.Fixed
{
    class Remito_ : IImprimible
    {
        public Remito_(int numero, DateTime fecha, int bultos)
        {
            CantBultos = bultos;
            Numero = numero;
            Fecha = fecha;
        }



        public int CantBultos { get; set; }
        public DateTime Fecha { get; set; }
        public int Numero { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo remito numero {Numero} del {Fecha} con un numero de bultos de {CantBultos}");
        }
    }
}
