using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion.Fixed
{
    class Impresora_
    {
        public void Imprimir(IImprimible imprimible)
        {
            imprimible.Imprimir();
        }
    }
}
