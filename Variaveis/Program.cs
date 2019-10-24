using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            double var1;
            double var2;
            double var1Depois;
            double var2Depois;

            System.Console.WriteLine("Informe um valor para a primeira variável: ");
            var1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Informe um valor para a segunda variável: ");
            var2 = double.Parse(Console.ReadLine());

            var1Depois = var2;
            var2Depois = var1;

            System.Console.WriteLine($"Primeira variável: {var1Depois}");
            System.Console.WriteLine($"Segunda variável: {var2Depois}");

        }
    }
}
