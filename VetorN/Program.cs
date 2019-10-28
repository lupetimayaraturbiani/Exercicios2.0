using System;

namespace VetorN
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            System.Console.WriteLine("Insira um número inteiro: ");
            num = int.Parse(Console.ReadLine());
            int [] numeros = new int [num];

            for (int i = 0;i >= num; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0;i >= num; i++)
            {
                System.Console.WriteLine("Os números adicionados foram" + numeros[i]);
            }
        }
    }
}
