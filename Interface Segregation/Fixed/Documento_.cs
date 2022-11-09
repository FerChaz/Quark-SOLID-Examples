using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interface_Segregation.Fixed
{
    public abstract class Documento_ : IImprimible
    {
        public Documento_(int numero, DateTime fecha)
        {
            Fecha = fecha;
            Numero = numero;
        }

        public DateTime Fecha { get; set; }
        public int Numero { get; set; }

        public abstract void Imprimir();
    }
}
