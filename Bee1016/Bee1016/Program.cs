using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distancia = int.Parse(Console.ReadLine());

            int tempo = distancia * 2;

            Console.WriteLine($"{tempo} minutos");
        }
    }
}