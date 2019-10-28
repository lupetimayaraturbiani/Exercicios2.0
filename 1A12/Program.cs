using System;

namespace _1A12 {
    class Program {
        static void Main (string[] args) {
            int num;

            System.Console.Write ("Entre com um número inteiro de 1 a 12: ");
            num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                System.Console.WriteLine("Mês correspondente: Janeiro");
            }
            else if(num == 2)
            {
                System.Console.WriteLine("Mês correspondente: Fevereiro");
            }
            else if(num == 3)
            {
                System.Console.WriteLine("Mês correspondente: Março");
            }
            else if(num == 4)
            {
                System.Console.WriteLine("Mês correspondente: Abril");
            }
            else if(num == 5)
            {
                System.Console.WriteLine("Mês correspondente: Maio");
            }
            else if(num == 6)
            {
                System.Console.WriteLine("Mês correspondente: Junho");
            }
            else if(num == 7)
            {
                System.Console.WriteLine("Mês correspondente: Julho");
            }
            else if(num == 8)
            {
                System.Console.WriteLine("Mês correspondente: Agosto");
            }
            else if(num == 9)
            {
                System.Console.WriteLine("Mês correspondente: Setembro");
            }
            else if(num == 10)
            {
                System.Console.WriteLine("Mês correspondente: Outubro");
            }
            else if(num == 11)
            {
                System.Console.WriteLine("Mês correspondente: Novembro");
            }
            else if(num == 12)
            {
                System.Console.WriteLine("Mês correspondente: Dezembro");
            }
            else if(num > 12)
            {
                System.Console.WriteLine("Esse número não corresponde a nenhum mês.");
            }
        }
    }
}