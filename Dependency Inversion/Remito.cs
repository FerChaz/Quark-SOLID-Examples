using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion
{
    class Remito
    {
        public Remito(int numero, DateTime fecha, int bultos)
        {
            CantBultos = bultos;
            Numero = numero;
            Fecha = fecha;
        }

        public int CantBultos { get; set; }
        public DateTime Fecha { get; set; }
        public int Numero { get; set; }
    }
}
