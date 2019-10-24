using System;

namespace ImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            System.Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                System.Console.WriteLine("Esse número é par.");
            }
            else
            {
                System.Console.WriteLine("Esse número é ímpar.");
            }
        }
    }
}
