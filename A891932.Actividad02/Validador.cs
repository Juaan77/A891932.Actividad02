using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A891932.Actividad02
{
    class Validador
    {
        public static int SolicitarCantidad(string texto)
        {
            int numero;
            bool valido = false;
            

            Console.WriteLine(texto);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("No ha ingresado un numero, intente nuevamente.");
                    Console.ReadKey();
                }
                else if (numero <= 0)
                {
                    Console.WriteLine("El numero a ingresar debe ser mayor a cero");
                    Console.ReadKey();
                }
                else
                {
                    valido = true;
                }
            } while (valido == false);

            return numero;
        }
    }
}
