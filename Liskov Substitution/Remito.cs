﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution
{
    class Remito : Documento
    {
        public Remito(int numero, DateTime fecha, int bultos) : base(numero, fecha)
        {
            CantBultos = bultos;
        }

        public int CantBultos { get; set; }

        public override string Descripcion()
        {
            return $"Remito nro {Numero} de fecha {Fecha.ToShortDateString()} con {CantBultos}";
        }
    }
}
