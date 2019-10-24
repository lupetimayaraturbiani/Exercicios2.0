using System;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double cent;
            double fahr;

            System.Console.Write("Entre com a temperatura em centígrados: ");
            cent = double.Parse(Console.ReadLine());

            fahr = (9 * cent + 160) / 5;

            System.Console.Write($"Em Fahrenheit: {fahr}");
        }
    }
}
