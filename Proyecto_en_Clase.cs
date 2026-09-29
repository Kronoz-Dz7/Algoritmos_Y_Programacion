using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_En_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crea un Programa en C# que ssolicite al usuario 5 numeros enteros. Utiliza
               una estructura repetitiva For para leer los numeros y contar cuantos de ellos son positivos.
               (Al finalizar, muestra en la pantalla la cantidad de numeros positivos). */

            int contador = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese el numero" + i + ": ");
                int num = int.Parse(Console.ReadLine());

                if (num > 0) contador++;

            }
            Console.WriteLine("Cantidad de numeros positivos es:" + contador);
        }
    }
}
