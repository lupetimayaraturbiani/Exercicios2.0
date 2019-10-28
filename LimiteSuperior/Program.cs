using System;

namespace LimiteSuperior
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            System.Console.Write("Digte um número para ser o limite superior: ");
            num = int.Parse(Console.ReadLine());

                System.Console.WriteLine($"Limite superior: {num}");
            for(int i = 1;i < num; i += 2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
