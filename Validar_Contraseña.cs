using System;

    public class HelloWorld
{
    public static void Main(string[] args)
    {


        const string passCorrect = "Saturno123";
        string clave;
        int intentosFallidos = 0;

        do
        {
            Console.WriteLine("Ingrese su contraseña");
            clave = Console.ReadLine();
            if (clave != passCorrect)
            {
                intentosFallidos++;
                Console.WriteLine("Contraseña incorrecta. Intentalo de nuevo.");
            }

        } while (clave != passCorrect);
        Console.WriteLine("\n Acceso concedido.");
        Console.WriteLine($"Intentos Fallidos: {intentosFallidos}");

    }


}
