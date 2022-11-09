using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Sinlge_Responsability.Fixed
{
    class Factura_
    {
        public Factura_ (int numero, Cliente cliente)
        {
            Numero = numero;
            Cliente = cliente;
            Items = new List<Item_>();
        }

        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public List<Item_> Items { get; set; }


        public double Total()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.Subtotal();
            }
            return total;
        }
    }
}
