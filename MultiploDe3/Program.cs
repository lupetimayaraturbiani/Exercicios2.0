using System;

namespace MultiploDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;

            System.Console.Write("Digite o número desejado: ");
            num = double.Parse(Console.ReadLine()) ;

            if ((num % 3) != 0)
            {
                System.Console.WriteLine("O número não é múltiplo de 3.");
            }
            else
            {
                System.Console.WriteLine("O número é múltiplo de 3.");
            }
        }
    }
}
