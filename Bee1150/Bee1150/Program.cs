using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, z;
            x = int.Parse(Console.ReadLine());

            do
            {
                z = int.Parse(Console.ReadLine());
            } while (z <= x);

            int somaNumeros = 0;
            int numeroAtual = x;
            int contador = 0;
            while (somaNumeros < z)
            {
                somaNumeros = somaNumeros + numeroAtual;
                numeroAtual++;
                contador++;
            }

            Console.WriteLine(contador);
        }
    }
}