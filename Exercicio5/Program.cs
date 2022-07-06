using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            Console.WriteLine("Programa para encontrar todos os numeros pares de 1 a 100." +
                "\n Aperte qualquer tecla para continuar...");
            Console.ReadKey();

            while (cont <= 100)
            {
                if (cont % 2 == 0)
                {
                    Console.WriteLine($"Número {cont}");
                    cont++;
                }
                else
                {
                    cont++;
                }
            }

            Console.ReadKey();
        }
    }
}
