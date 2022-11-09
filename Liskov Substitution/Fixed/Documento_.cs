using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution.Fixed
{
    public abstract class Documento_
    {
        protected string _sigla;

        public Documento_(int numero, DateTime fecha)
        {
            Numero = numero;
            Fecha = fecha;
        }

        public DateTime Fecha { get; set; }
        public int Numero { get; set; }


        public string Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }

        public string Descripcion()
        {
            return $"{_sigla} nro {Numero} de fecha {Fecha.ToShortDateString()}";
        }
    }
}
