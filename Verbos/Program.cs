using System;

namespace Verbos
{
    class Program
    {
        static void Main(string[] args)
        {
            string verbo;
            
            System.Console.WriteLine("Entre com um verbo no infinitivo: ");
            verbo = Console.ReadLine();

            if (verbo.EndsWith("ar"))
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Verbo na primeira conjugação.");
                System.Console.WriteLine();
            }
            else if (verbo.EndsWith("er"))
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Verbo na segunda conjugação.");
                System.Console.WriteLine();
            }
            else if (verbo.EndsWith("ir"))
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Verbo na terceira conjugação.");
                System.Console.WriteLine();
            }
            else 
            {
                System.Console.WriteLine("Este verbo não se encontra no infinitivo.");
            }

        }
    }
}
