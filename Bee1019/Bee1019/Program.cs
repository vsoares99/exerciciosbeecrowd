using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N =int.Parse(Console.ReadLine());

            int horas = N / 3600;
            int minutos = (N % 3600) / 60;
            int segundos = N % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}