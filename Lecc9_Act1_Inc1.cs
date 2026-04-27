using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc9_Act1_Inc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pesoAcumulado = 0;
            double pesoManzana = 0;
            const double META = 1000;
            while (pesoAcumulado<META) 
            {
                Console.WriteLine("Faltan {0}g para el kilo", META - pesoAcumulado);
                Console.Write("Ingrese el peso de la manzana (100-300g):");
                string entrada=Console.ReadLine();
                if (double.TryParse(entrada, out pesoManzana))
                {
                    if (pesoManzana >= 100 && pesoManzana <= 300)
                    {
                        pesoAcumulado += pesoManzana;
                        Console.WriteLine("Agregada. Total: {0}g", pesoAcumulado);
                    }
                    else
                    {
                        Console.WriteLine("Error: La manzana no cumple con el peso");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada es invalida, ingrese solo numeros");
                }
            }
                Console.WriteLine("\n--------------------------");
                Console.WriteLine("Ya tiene el kilo de manzanas! total {0}g", pesoAcumulado);
                Console.WriteLine("--------------------------\n");

                Console.WriteLine("Presione una tecla para salir...");
                Console.ReadKey();
        }
    }
}
    

