using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc10_Act1_Inc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TOTAL_SELLOS = 8;

            Console.WriteLine("BIENVENIDO A LA BARBERIA PRESII");

            for (int i = 1; i < TOTAL_SELLOS; i++)
            {
                Console.WriteLine("\nSellos actuales: {0} de {1}", i, TOTAL_SELLOS);
                Console.WriteLine("Presione cualquier tecla para registrar esta visita...");
                Console.ReadKey();

                Console.WriteLine(">> sellos #{0} registrado correctamente-", i);
            }

            Console.WriteLine("\n*******************************************");
            Console.WriteLine("¡CUPONERA COMPLETADA!");
            Console.WriteLine("Mauricio, te has ganado un corte de cabello GRATIS...");
            Console.WriteLine("*******************************************");
        }
    }
}
