using System;

class Program
{
    static void Main()
    {
        int opcion = 0;

        while (opcion != 5)
        {
            Console.WriteLine("\n--- MENÚ DE FIGURAS ---");
            Console.WriteLine("1. Cuadrado ");
            Console.WriteLine("2. Triangulo Rectangulo ");
            Console.WriteLine("3. Piramide Centrada ");
            Console.WriteLine("4. Rombo ");
            Console.WriteLine("5. Salir ");
            Console.WriteLine("Seleccione una opción: ");
            
            string entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion))
            {
                opcion = 0;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n--- Cuadrado Hueco ---");
                    Console.Write("Ingresa el tamaño (n) para el cuadrado: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    Console.WriteLine("\n--- Triángulo Rectángulo Invertido ---");
                    int alturaTriangulo = 5;

                    for (int i = 0; i < alturaTriangulo; i++)
                    {
                        for (int j = 0; j < alturaTriangulo - i; j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;

                case 3:
                    Console.WriteLine("\n--- Pirámide Centrada ---");
                    int alturaPiramide = 5;

                    for (int i = 0; i < alturaPiramide; i++)
                    {
                        for (int j = 0; j < alturaPiramide - i - 1; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int k = 0; k < (i * 2) + 1; k++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;

                case 4:
                    Console.WriteLine("\n--- Rombo ---");
                    int romboN = 3;

                    for (int i = 0; i <= romboN; i++)
                    {
                        for (int j = 0; j < romboN - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < (2 * i + 1); k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }

                    for (int i = romboN - 1; i >= 0; i--)
                    {
                        for (int j = 0; j < romboN - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < (2 * i + 1); k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 5:
                    Console.WriteLine("\n¡Saliendo del programa. ¡Mucho éxito en tu sustentación!");
                    break;

                default:
                    Console.WriteLine("\nOpción no válida. Por favor, elige un número del 1 al 5.");
                    break;

            }
            if (opcion != 5)
            {
                Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
