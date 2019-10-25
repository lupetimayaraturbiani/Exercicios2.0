using System;

namespace OrdemCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int [3];

            for (int i = 0; i < numeros.Length; i++)
            {
                System.Console.Write("Digite um número: ");
                numeros [i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);
            System.Console.WriteLine($"Os números em ordem crescente são: {numeros[0]}, {numeros[1]} e {numeros[2]}.");
        }
    }
}
