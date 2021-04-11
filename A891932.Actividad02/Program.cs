using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A891932.Actividad02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea un catalogo cuyo identificador de productos va a ser su ID.
            Dictionary<int, Producto> Catalogo = new Dictionary<int, Producto>();
            string opcionElegida;

            do
            {

            } while (opcionElegida != "s");

            // Imprime el estado final del catalogo de productos al salir.
            Console.WriteLine("\tCatalogo de Productos actual:");

            foreach(KeyValuePair<int, Producto> producto in Catalogo)
            {
                Console.WriteLine($"- ID: {producto.Key} | '{producto.Value.Nombre}' \tStock: {producto.Value.Stock}");
            }

            Console.ReadKey();
        }
    }
}
