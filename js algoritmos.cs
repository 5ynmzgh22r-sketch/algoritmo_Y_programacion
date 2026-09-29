using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmosyprogramacionjs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Menú =====");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Mostrar Fecha");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Seleccione un opcion");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Hola, Bienvenido");
                    break;
                case 2:
                    Console.WriteLine("La fecha actual es: " + DateTime.Now);
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Error!! opcion no v alida");
                    break;

            }

        }
    }
}