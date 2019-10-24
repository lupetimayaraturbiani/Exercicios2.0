using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;

            System.Console.Write("Digite a altura do triângulo: ");
            altura = int.Parse(Console.ReadLine());

            for (int lin = 0; lin <= altura; ++lin)
            {
                for (int col = altura; col > lin; --col)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}