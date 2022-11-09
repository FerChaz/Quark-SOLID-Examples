using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion.Fixed
{
    class Factura_ : DocumentoContable_
    {
        public Factura_(int numero, DateTime fecha, double importe) : base(numero, fecha, importe)
        {
            _sigla = "FC";
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura {Numero} del {Fecha} por un importe de {Importe}");
        }

        public override double Total()
        {
            return Importe * 1.21;
        }


    }
}
