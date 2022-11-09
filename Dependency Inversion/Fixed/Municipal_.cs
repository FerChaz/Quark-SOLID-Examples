using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion.Fixed

{
    class Municipal_ : Impuesto_
    {
        public Municipal_(double importe, string partida) : base(importe)
        {
            Partida = partida;
        }

        public string Partida { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo impuesto municipal de partida {Partida} por un importe de {Importe}");
        }
    }
}
