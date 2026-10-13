// pide números enteros y acomula su suma hasta que ingrese 0. Muestra la suma
// total. cúantos números se ingresaron y el promedio.
using System;

    public class HelloWorld
{
    public static void Main(string[] args)
    {
        int numero;
        int suma = 0;
        int contador = 0;

        do{
            Console.WriteLine("Ingrese un Número (0 para Salir)");
            numero = int.Parse(Console.ReadLine());
            if(numero != 0)
            {
                suma += numero;
                contador++;
            }
        }while(numero != 0);
        Console.WriteLine($"\nSuma Total: {suma}");
        Console.WriteLine($"Cantidad de número es: {contador}");

        if (contador > 0) {
            Console.WriteLine($"Promedio: {(double)suma / contador:F2}");

        }
        else
        {
            Console.WriteLine($"No se ingresaron números.");
        }
       

    }


}
