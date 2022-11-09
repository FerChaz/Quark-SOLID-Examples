using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interface_Segregation.Fixed
{
    class Factura_ : Documento_
    {
        public Factura_(int numero, DateTime fecha) : base(numero, fecha) { }
        public string CAI { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura {Numero} del dia {Fecha}");
        }
    }
}
