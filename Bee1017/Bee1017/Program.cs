using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            double consumo = velocidade * tempo / 12.0;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}