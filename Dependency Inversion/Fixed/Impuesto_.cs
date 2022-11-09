using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion.Fixed
{
    public abstract class Impuesto_ : IImprimible
    {
        public Impuesto_(double importe)
        {
            Importe = importe;
        }

        public double Importe { get; set; }

        public abstract void Imprimir();
    }
}
