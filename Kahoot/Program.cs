using System;

namespace Kahoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                {10, 15, 48},
                {56, 97, 77},
                {2, 100, 33},
            };
            
            int soma;
            foreach (var item in matrix)
            {
                StringComparer() += item;
            }

            System.Console.WriteLine(soma);
        }
    }
}
