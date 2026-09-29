using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_En_Clase_2_Inicio_o_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crea un programa que simule un sistema de inicio de sesión
               el ususario debe ingresar un correo con dominio unicaribe.edu.co y su contraseña
               el usuario tendrá como datos correctos:

               Usuario: yourmail@unicaribe.edu.co
               password: ny12345@

               - El programa debe permitir maximo 3 intentos, si los datos son correctos debe mostrar
               "Bienvenido a la plataforma de UNICARIBE"
               - Despues de 3 intentos incorrectos, debe mostrar
               "Usuario Bloqueado - Comunicate con T.I.". */

            string correoCorrecto = "dmauricioalvarez@unicaribe.edu.co";
            string passCorrecta = "ny12345@";

            string email = "";
            string pass = "";

            int intentos = 0;
            while (intentos < 3)
            {
                Console.WriteLine("Ingrese su correo: ");
                email = Console.ReadLine();

                Console.WriteLine("Ingrese su contraseña: ");
                pass = Console.ReadLine();

                if (email == correoCorrecto && pass == passCorrecta)
                {
                    Console.WriteLine("Bienvenido a la plataforma de UNICARIBE!!");
                    break;
                }
                else
                {
                    intentos++;
                    Console.WriteLine("Correo o Contraseña INCORRECTOS!!");
                    Console.WriteLine("Intententos Restantes" + (3 - intentos));
                }
                if (intentos  == 3)
                {
                    Console.WriteLine("Usuario Bloqueado - Comunicate Con T.I. - UNICARIBE");


                }
            }
        }

    }
}
