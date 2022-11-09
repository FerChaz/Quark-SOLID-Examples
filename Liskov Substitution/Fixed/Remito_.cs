using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution.Fixed
{
    class Remito_
    {
        public Remito_(int numero, DateTime fecha, int bultos)
        {
            CantBultos = bultos;
            Numero = numero;
            Fecha = fecha;
        }

        public int CantBultos { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }

        public string Descripcion()
        {
            return $"Remito nro {Numero} de fecha {Fecha.ToShortDateString()} con {CantBultos}";
        }

        public string Imprimir()
        {
            return $"Imprimiendo remito {Descripcion()}";
        }
    }
}
