using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseRet;
            double alturaRet;
            double perimetro;
            double area;
            double diagonal;
            System.Console.WriteLine("Digite a base do retângulo:");
            baseRet = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a altura do retângulo: ");
            alturaRet = double.Parse(Console.ReadLine());

            perimetro = 2 * (baseRet + alturaRet);

            area = baseRet * alturaRet;

            diagonal = ((baseRet * baseRet) + (alturaRet * alturaRet)) /2;

            

            System.Console.WriteLine($"A área do retângulo é:{area}");
            System.Console.WriteLine($"O perímetro do retângulo é:{perimetro}");
            System.Console.WriteLine($"A diagonal do retângulo é:{diagonal}");
        }
    }
}
