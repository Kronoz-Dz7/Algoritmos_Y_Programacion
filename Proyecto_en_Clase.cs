using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Menu
{
    //Crea un programa que muestre un menu con 3 opciones y ejecute
    //una acción dependiendo de la opción seleccionada.
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crea un Programa en C# que ssolicite al usuario 5 numeros enteros. Utiliza
             * una estructura repetitiva For para leer los numeros y contar cuantos de ellos son positivos.
             * (Al finalizar, muestra en la pantalla la cantidad de numeros positivos). */

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese el numero" + i + ": ");
            }

        }
    }
}
