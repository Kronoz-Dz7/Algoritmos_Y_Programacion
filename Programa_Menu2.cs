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
            Console.WriteLine("MENÚ");
            Console.WriteLine("1. Saludar ");
            Console.WriteLine("2. Mostrar Fecha ");
            Console.WriteLine("3. Ingrese sus datos ");
            Console.WriteLine("4. Contactenos ");
            Console.WriteLine("5. Salir ");
            Console.WriteLine("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1: Console.WriteLine("¡Hola! Bienbenido!!");
                       
                   break;

                case 2: Console.WriteLine("La fecha actual es: " + DateTime.Now);

                    break;

                case 3: Console.WriteLine("Nombre completo,Documento de identidad,Correo.");

                    break;
                case 4: Console.WriteLine("contacto@gmail.com");

                    break;
                case 5: Console.WriteLine("Programa finalizado!!!");

                    break;
                default:
                        Console.WriteLine("Opción no valida!!");
                    break;

            }
        }
    }
}
