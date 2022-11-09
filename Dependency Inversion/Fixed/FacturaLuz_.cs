using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion.Fixed
{
    class FacturaLuz_ : Impuesto_
    {
        public FacturaLuz_(double importe, string codigoPago) : base(importe)
        {
            CodigoPago = codigoPago;
        }

        public string CodigoPago { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura de luz con codigo de pago nro {CodigoPago} por un importe de {Importe}");
        }
    }
}
