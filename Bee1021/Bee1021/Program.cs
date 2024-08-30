using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int centavos = (int)(N * 100 + 0.5);

            Console.WriteLine("NOTAS:");
            int nota100 = centavos / 10000;
            Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
            centavos %= 10000;

            int nota50 = centavos / 5000;
            Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
            centavos %= 5000;

            int nota20 = centavos / 2000;
            Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
            centavos %= 2000;

            int nota10 = centavos / 1000;
            Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
            centavos %= 1000;

            int nota5 = centavos / 500;
            Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
            centavos %= 500;

            int nota2 = centavos / 200;
            Console.WriteLine($"{nota2} nota(s) de R$ 2.00");
            centavos %= 200;

            Console.WriteLine("MOEDAS:");
            int moeda1 = centavos / 100;
            Console.WriteLine($"{moeda1} moeda(s) de R$ 1.00");
            centavos %= 100;

            int moeda50 = centavos / 50;
            Console.WriteLine($"{moeda50} moeda(s) de R$ 0.50");
            centavos %= 50;

            int moeda25 = centavos / 25;
            Console.WriteLine($"{moeda25} moeda(s) de R$ 0.25");
            centavos %= 25;

            int moeda10 = centavos / 10;
            Console.WriteLine($"{moeda10} moeda(s) de R$ 0.10");
            centavos %= 10;

            int moeda5 = centavos / 5;
            Console.WriteLine($"{moeda5} moeda(s) de R$ 0.05");
            centavos %= 5;

            int moeda01 = centavos / 1;
            Console.WriteLine($"{moeda01} moeda(s) de R$ 0.01");
        }
    }
}