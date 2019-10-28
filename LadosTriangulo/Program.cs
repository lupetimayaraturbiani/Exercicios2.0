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

            if((lado1 < lado2 +lado3) && (lado2 < lado1 + lado3) && (lado3 < lado1 + lado2) )
            {
                System.Console.WriteLine("Os valores fornecidos formam um tiângulo.");
                
                if((lado1 == lado2) && (lado2 != lado3) || (lado2 == lado3) && (lado3 != lado1) || (lado3 == lado1) && (lado1 != lado2))
                {
                    System.Console.WriteLine("Esse triângulo é isóceles.");
                }
                else if((lado1 == lado2) && (lado2 == lado3))
                {
                    System.Console.WriteLine("Esse triângulo é equilátero.");
                }
                else 
                {
                    System.Console.WriteLine("Esse triângulo é escaleno.");
                }
            }
            else
            {
                System.Console.WriteLine("Os valores fornecidos não formam um triângulo.");
            }

        }
    }
}
