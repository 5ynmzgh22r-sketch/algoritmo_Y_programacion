using System;
namespace Sistemas
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int cantidadArchivos = 0;
            do
            {
                Console.WriteLine("ingrese la cantidad de archivos a descargas");
                if (!int.TryParse(Console.ReadLine(), out cantidadArchivos))
                {
                    cantidadArchivos = 0;
                }


            } while (cantidadArchivos <= 0);

            int archivosDescargado = 0;
            double totalMB = 0;

            for (int i = 1; i <= cantidadArchivos; i++)
            {
                Console.WriteLine($"/Archiuvo#{i} - nombre (escriba 'salir' para detener):");
                string nombre = Console.ReadLine().Trim();

                if (nombre.ToLower() == "salir")
                {
                    Console.WriteLine(">>proceso de descarga cancelado!!!");
                    break;
                }
                Console.WriteLine("tamaño en MB:");
                double tamanio = 0;

                if (!double.TryParse(Console.ReadLine(), out tamanio) || tamanio <= 0)
                {
                    Console.WriteLine(">> tamaño invalido. Archivo omitido");
                    continue;
                }



                Console.WriteLine($">> descargando '{nombre}'({tamanio} MB)...OK");
                archivosDescargado++;
                totalMB += tamanio;
            }
            Console.WriteLine("/n====== RESUMEN DE DESCARGA ========");
            Console.WriteLine($"archivos DESCARGADO : {archivosDescargado}");
            Console.WriteLine($"total descargado:{totalMB}MB");
            Console.WriteLine("========================================");

        }

    }
}


