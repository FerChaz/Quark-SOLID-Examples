using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution
{
    class Impresora
    {
        public void ImprimirRemito(Remito unRemito)
        {
            Console.WriteLine(unRemito.Imprimir());
        }

        public void ImprimirFactura(Factura unafactura)
        {
            Console.WriteLine(unafactura.Imprimir());
        }

        public void ImprimirNotaCredito(NotaCredito unaNotaCredito)
        {
            Console.WriteLine(unaNotaCredito.Imprimir());
        }
    }
}
