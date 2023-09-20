using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la base: ");
            int numbase = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el exponente: ");
            int exponente = int.Parse(Console.ReadLine());

            int potencia = 0;

            for (int i = 0; i < exponente; i++)
            {
                potencia = numbase * (numbase);
            }

            Console.WriteLine("La potencia es: " + potencia);
            Console.ReadKey();


        }
    }
}
