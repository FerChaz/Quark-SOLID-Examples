using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution.Fixed
{
    class Impresora_
    {
        public void ImprimirRemito(Remito unRemito)
        {
            Console.WriteLine(unRemito.Imprimir());
        }

        public void ImprimirDocumento(Documento unDocumento)
        {
            Console.WriteLine(unDocumento.Imprimir());
        }
    }
}
