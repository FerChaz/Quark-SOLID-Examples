using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion
{
    public abstract class DocumentoContable
    {
        protected string _sigla;

        public DocumentoContable(int numero, DateTime fecha, double importe)
        {
            Numero = numero;
            Fecha = fecha;
            Importe = importe;
        }

        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }

        public abstract double Total();
    }
}
