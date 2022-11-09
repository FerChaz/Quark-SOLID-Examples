using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Open_Closed.Fixed
{
    class NotaCredito_: DocumentoContable_
    {
        public NotaCredito_(int numero):base(numero)
        {

        }

        public override string Descripcion()
        {
            return $"NC-{Numero}";
        }
    }
}
