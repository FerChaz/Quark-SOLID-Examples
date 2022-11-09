using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Sinlge_Responsability.Fixed
{
    class Item_
    {
        public Item_(Producto_ producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public Producto_ Producto { get; set; }
        public int Cantidad { get; set; }


        public double Subtotal()
        {
            return Cantidad * Producto.Precio;
        }
    }
}
