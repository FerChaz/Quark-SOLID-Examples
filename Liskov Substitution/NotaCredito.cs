using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution
{
    class NotaCredito : Documento
    {
        public NotaCredito(int numero, DateTime fecha) : base(numero, fecha)
        {
            _sigla = "NC";
        }
    }
}
