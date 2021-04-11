using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A891932.Actividad02
{
    class Producto
    {
        internal int Id { get; }
        internal string Nombre { get; }
        internal int Stock { get; private set; }

        internal Producto(int id, string nombre, int stock)
        {
            Id = id;
            Nombre = nombre;
            Stock = stock;
        }

        public void AumentarStock(int cantidad)
        {
            Stock += cantidad;
        }

        public void DisminuirStock(int cantidad)
        {
            if (Stock - cantidad < 0)
            {
                Console.WriteLine("El stock no es suficiente para realizar la operacion.");
                Console.ReadKey();
            }
            else
            {
                Stock -= cantidad;
            }
        }
    }

}
