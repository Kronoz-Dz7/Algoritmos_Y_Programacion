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
            Console.WriteLine("1. Informacion Academica ");
            Console.WriteLine("2. Mostrar Fecha ");
            Console.WriteLine("3. Ingrese sus datos ");
            Console.WriteLine("4. Contactenos ");
            Console.WriteLine("5. Salir ");
            Console.WriteLine("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("1. Ingrese su Nombre: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Ingrese su Edad: ");
                    string age = Console.ReadLine();

                    Console.WriteLine("Ingrese su Genero F/M: ");
                    string gender = Console.ReadLine();

                    Console.WriteLine("Ingrese su Facultad: ");
                    string faculty = Console.ReadLine();

                    Console.WriteLine("Ingrese su Programa Academico: ");
                    string program = Console.ReadLine();

                    break;

                case 2:
                    Console.WriteLine("La fecha actual es: " + DateTime.Now);

                    break;

                case 3:
                    Console.WriteLine("1. Nombre completo: ");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("2. Documento de identidad: ");
                    string document = Console.ReadLine();

                    Console.WriteLine("3. Correo: ");
                    string mail = Console.ReadLine();

                    break;
                case 4:
                    Console.WriteLine("contacto@gmail.com");

                    break;
                case 5:
                    Console.WriteLine("Programa finalizado!!!");

                    break;
                default:
                    Console.WriteLine("Opción no valida!!");
                    break;

            }
        }
    }
}

