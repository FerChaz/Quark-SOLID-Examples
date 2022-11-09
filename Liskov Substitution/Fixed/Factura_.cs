using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution.Fixed
{
    class Factura_ : Documento_
    {
        public Factura_(int numero, DateTime fecha) : base(numero, fecha)
        {
            _sigla = "FC";
        }
    }
}
