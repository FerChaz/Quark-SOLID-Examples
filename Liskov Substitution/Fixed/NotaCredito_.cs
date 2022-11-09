using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution.Fixed
{ 
    class NotaCredito_ : Documento_
    {
        public NotaCredito_(int numero, DateTime fecha) : base(numero, fecha)
        {
            _sigla = "NC";
        }
    }
}
