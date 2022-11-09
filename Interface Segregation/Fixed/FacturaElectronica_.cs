using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interface_Segregation.Fixed
{
    class FacturaElectronica_ : Documento_, IEmaileable
    {
        public FacturaElectronica_(int numero, DateTime fecha) : base(numero, fecha) { }
        public string CAE { get; set; }


        public void EnviarPorEmail()
        {

            Console.WriteLine($"Enviando por email la factura electronica {Numero} del dia {Fecha}");
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura electronica {Numero} del dia {Fecha}");
        }
    }
}
