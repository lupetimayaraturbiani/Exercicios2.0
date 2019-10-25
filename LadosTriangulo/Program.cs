using System;

namespace LadosTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1;
            int lado2;
            int lado3;

            System.Console.WriteLine("Insira o valor correspondente ao lado 1 : ");
            lado1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Insira o valor correspondente ao lado 2 : ");
            lado2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Insira o valor correspondente ao lado 3 : ");
            lado3 = int.Parse(Console.ReadLine());

            if ((lado1 + lado2) > lado3)
            {
                System.Console.WriteLine($"Lado 1 : {lado1}");
                System.Console.WriteLine($"Lado 2 : {lado2}");
                System.Console.WriteLine($"Lado menor : {lado3}");
            }
            else if ((lado3 + lado1) > lado2)
            {
                System.Console.WriteLine($"Lado 1 : {lado1}");
                System.Console.WriteLine($"Lado 2 : {lado3}");
                System.Console.WriteLine($"Lado menor : {lado2}");
            }
            else if ((lado2 + lado3) > lado1)
            {
                System.Console.WriteLine($"Lado 1 : {lado2}");
                System.Console.WriteLine($"Lado 2 : {lado3}");
                System.Console.WriteLine($"Lado menor : {lado1}");
            }
            else
            {
                System.Console.WriteLine("Os lados inseridos não podem fazer parte de um triângulo.");
            }

        }
    }
}
