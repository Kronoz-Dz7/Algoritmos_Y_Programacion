using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_DZ
{
    internal class Program
    {
        // Pide un numero al usuario y determina si es par o impar
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par.");

            }
            else {
                Console.WriteLine("El numero es impar.");
            }
        }
    }
}
