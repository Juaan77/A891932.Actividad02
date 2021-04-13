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
            // Variables y constantes a utilizar
            string opcionElegida;
            int idProducto;
            string nombreProducto;
            int stockProducto;
            const string solicitarID = "Ingrese el ID del producto:";            
            const string solicitarNombreProducto = "Ingrese el NOMBRE del producto:";            
            const string solicitarStockProducto = "Ingrese el STOCK INICIAL del producto:";
            const string solicitarCantidad = "Ingrese la CANTIDAD del producto:";
            const string menuPrincipal = "P - Pedidos\nE - Entregas\nI - Añadir producto al catalogo\nL - Mostrar el catalogo actual\nS - SALIR\n";

            // Catalogo de productos
            Dictionary<int, Producto> Catalogo = new Dictionary<int, Producto>();
        
            void ListarCatalogo()
            {
                Console.WriteLine("\tCatalogo de Productos actual:\n");

                if (Catalogo.Count == 0)
                {
                    Console.WriteLine("El catalogo no tiene productos actualmente.\n");
                }

                foreach (KeyValuePair<int, Producto> producto in Catalogo)
                {
                    Console.WriteLine($"- ID: {producto.Key} | '{producto.Value.Nombre}' \tStock: {producto.Value.Stock}");                    
                }

                Console.ReadKey();
            }


            // Funcion Principal
            do
            {
                Console.WriteLine("\tBienvenido al Sistema de Control de Stock!" + "\n\n" + menuPrincipal);
                opcionElegida = Console.ReadLine().ToLower();                

                switch (opcionElegida)
                {
                    case "p":
                        
                        idProducto = Validador.SolicitarNumero(solicitarID);

                        if (!Catalogo.ContainsKey(idProducto))
                        {
                            Console.WriteLine("El producto solicitado no existe.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {                            
                            if(Catalogo[idProducto].DisminuirStock(Validador.SolicitarNumero(solicitarCantidad)) == true)
                            {
                                Console.WriteLine("Operacion Exitosa! Se ha realizado el pedido.\n");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("La operacion ha sido cancelada.\n");
                                Console.ReadKey();
                            }
                            
                        }
                        break;

                    case "e":

                        idProducto = Validador.SolicitarNumero(solicitarID);

                        if (!Catalogo.ContainsKey(idProducto))
                        {
                            Console.WriteLine("El producto solicitado no existe.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            stockProducto = Validador.SolicitarNumero(solicitarCantidad);
                            Catalogo[idProducto].AumentarStock(Validador.SolicitarNumero(solicitarCantidad));
                            Console.WriteLine("Operacion Exitosa! Se ha realizado la entrega.\n");
                            Console.ReadKey();
                        }
                        break;

                    case "i":

                        idProducto = Validador.SolicitarNumero(solicitarID);
                        Console.WriteLine(solicitarNombreProducto);
                        nombreProducto = Console.ReadLine();
                        stockProducto = Validador.SolicitarNumero(solicitarStockProducto);
                        Catalogo.Add(idProducto, new Producto(idProducto, nombreProducto, stockProducto));
                        Console.WriteLine($"Se ha agregado el producto {idProducto} '{nombreProducto}', con {stockProducto} unidades iniciales.\n");
                        Console.ReadKey();
                        break;

                    case "l":
                        ListarCatalogo();
                        break;
                }


            } while (opcionElegida != "s");

            //  Imprime el estado final del catalogo de productos al salir.
            Console.Clear();
            ListarCatalogo();            
            Console.ReadKey();
        }
    }
}
