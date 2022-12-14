using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Sinlge_Responsability
{
    class Factura
    {
        public Factura (int numero, string apellido, string nombre)
        {
            Numero = numero;
            Apellido = apellido;
            Nombre = nombre;
            Items = new List<Item>();
        }

        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public List<Item> Items { get; set; }


        public double Total()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.Cantidad * item.Producto.Precio;
            }
            return total;
        }
    }
}
