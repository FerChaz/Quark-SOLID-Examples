﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interface_Segregation
{
    class Factura : Documento
    {
        public Factura(int numero, DateTime fecha) : base(numero, fecha) { }
        public string CAI { get; set; }


        public override void EnviarPorEmail()
        {
            //No es valido
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura {Numero} del dia {Fecha}");
        }
    }
}
