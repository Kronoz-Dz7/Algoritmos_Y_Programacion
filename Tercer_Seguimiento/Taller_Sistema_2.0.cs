using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadArchivos = 0;

            do{
                Console.WriteLine("Ingrese la cantidad de archivos a Descargar: ");
                if (!int.TryParse(Console.ReadLine(), out cantidadArchivos)) {
                    cantidadArchivos = 0;
                }

            }while (cantidadArchivos <= 0 );

            double espacioDisponible = 0;
            do {
                Console.WriteLine("Ingrese el espacio total disponible en disco (en MB): ");
                if (!double.TryParse(Console.ReadLine(), out espacioDisponible) || espacioDisponible <= 0) {
                    espacioDisponible = 0;
                }

            } while (espacioDisponible <= 0);

            int archivosDescargados = 0;
            double totalMB = 0;
            for( int i = 1; i <= cantidadArchivos; i++) {
                Console.WriteLine($"\nArchivo #{i} - Nombre (Escriba `Salir` para detener): ");
                string nombre = Console.ReadLine().Trim();

                if(nombre.ToLower() == "salir"){
                    Console.WriteLine(">> Proceso de descarga Cancelado!!!");
                    break;
                }

                if (nombre.Length == 0 || nombre.Length > 20) {
                Console.WriteLine(">> Nombre de archivo inválido. Omitido.");
                continue;
                }
                
                Console.Write("Tamaño en MB: ");
                double tamanio = 0;

                if (!double.TryParse(Console.ReadLine(), out tamanio) || tamanio <= 0){
                    Console.WriteLine(">> Tamaño Imválido. Archivo omitido");
                    continue;
                }

                if (tamanio > espacioDisponible) {
                    Console.WriteLine(">> Espacio insuficiente en disco. Descarga detenida.");
                    break;
                }
                espacioDisponible -= tamanio;

                string categoria = "";
                if (tamanio < 1) {
                    categoria = "Pequeño";
                } else if (tamanio <= 10) {
                    categoria = "Mediano";
                } else {
                    categoria = "Grande";
                }
               
                Console.WriteLine($">> Descargando `{nombre}` ({tamanio} MB) - [{categoria}]... Descarga completada.");
                archivosDescargados++;
                totalMB += tamanio;
            }
            Console.WriteLine("\n======== RESUMEN DE DESCARGA ========");
            Console.WriteLine($"Archivos Descargados: {archivosDescargados}");
            Console.WriteLine($"Total descargado: {totalMB} MB");
            Console.WriteLine($"Espacio restante en disco: {espacioDisponible} MB");
            Console.WriteLine("=======================================");
        }
    }
}
