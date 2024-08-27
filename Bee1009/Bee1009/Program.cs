using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, vendas, totalSalario;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            totalSalario = vendas * 0.15 + salarioFixo;

            Console.WriteLine($"TOTAL  = R$ {totalSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}