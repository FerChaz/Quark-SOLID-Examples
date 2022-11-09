using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Open_Closed.Fixed
{
    class Factura_ : DocumentoContable_
    {
        public Factura_(int numero) : base(numero)
        {

        }

        public override string Descripcion()
        {
            return $"FC-{Numero}";
        }
    }
}
