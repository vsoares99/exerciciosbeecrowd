using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            
            int notas100 = N / 100;
            N %= 100;

            int notas50 = N / 50;
            N %= 50;

            int notas20 = N / 20;
            N %= 20;

            int notas10 = N / 10;
            N %= 10;

            int notas5 = N / 5;
            N %= 5;

            int notas2 = N / 2;
            N %= 2;

            int notas1 = N / 1;
            N %= 1;

            Console.WriteLine($"{notas100} nota(s) de R$ 100,00");
            Console.WriteLine($"{notas50} nota(s) de R$ 50,00");
            Console.WriteLine($"{notas20} nota(s) de R$ 20,00");
            Console.WriteLine($"{notas10} nota(s) de R$ 10,00");
            Console.WriteLine($"{notas5} nota(s) de R$ 5,00");
            Console.WriteLine($"{notas2} nota(s) de R$ 2,00");
            Console.WriteLine($"{notas1} nota(s) de R$ 1,00");
        }
    }
}