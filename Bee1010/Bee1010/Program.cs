using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] linha1 = Console.ReadLine().Split(' ');

            int codigo = int.Parse(linha1[0]);
            int qtd = int.Parse(linha1[1]);
            double preco = double.Parse(linha1[2], CultureInfo.InvariantCulture);

            string[] linha2 = Console.ReadLine().Split(' ');

            int codigo2 = int.Parse(linha2[0]);
            int qtd2 = int.Parse(linha2[1]);
            double preco2 = double.Parse(linha2[2], CultureInfo.InvariantCulture);

            double soma = (qtd * preco) + (qtd2 * preco2);

            Console.WriteLine($"VALOR A PAGAR: R$ {soma.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}