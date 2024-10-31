//N00458733
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Sem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDeElementos;
            Console.WriteLine("Ingrese la cantidad de números aleatorios que desee generar: ");
            numeroDeElementos=int.Parse(Console.ReadLine());
            Random aleatorio = new Random();
            int[] numeros = new int[numeroDeElementos];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i]=aleatorio.Next(1,51);

            }
            Console.WriteLine("Los números ingresados son: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"{i+1}) {numeros[i]} ");
            }
            Console.ReadKey();
        }
    }
}
