using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double volume = (4.0 / 3) * pi * raio * raio * raio;

            Console.WriteLine($"VOLUME  = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}