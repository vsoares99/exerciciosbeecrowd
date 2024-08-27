using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (A * 3.5 + B * 7.5) / (3.5 + 7.5);

            Console.WriteLine($"MEDIA = {media.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}