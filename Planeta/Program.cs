using System;

namespace Planeta
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesoPlaneta;
            double peso;
            double mercurio = 0.37;
            double venus = 0.88;
            double marte = 0.38;
            double jupiter = 2.64;
            double saturno = 1.15;
            double urano = 1.17;

            
            string planeta = "";
            System.Console.WriteLine("|   |-------------------|          |");
            System.Console.WriteLine("|   |     Gravidade     | Planeta  |");
            System.Console.WriteLine("|   |-------------------|          |");
            System.Console.WriteLine("| 1 |        0,37       | Mercúrio |");
            System.Console.WriteLine("| 2 |        0,88       |   Vênus  |");
            System.Console.WriteLine("| 3 |        0,38       |   Marte  |");
            System.Console.WriteLine("| 4 |        2,64       |  Júpiter |");
            System.Console.WriteLine("| 5 |        1,15       |  Saturno |");
            System.Console.WriteLine("| 6 |        1,17       |   Urano  |");

            System.Console.WriteLine("Selecione um planeta: ");
            planeta = Console.ReadLine();

            switch (planeta)
            {
                case "1":
                    System.Console.Write("Entre com o peso na Terra: ");
                    peso = double.Parse(Console.ReadLine());
                    pesoPlaneta = (peso / 10) * mercurio;
                    System.Console.WriteLine($"O peso neste planeta será: {pesoPlaneta}");
                    System.Console.WriteLine("Para parar digite: sair");
                    break;

                case "2":
                    System.Console.Write("Entre com o peso na Terra: ");
                    peso = double.Parse(Console.ReadLine());
                    pesoPlaneta = (peso / 10) * venus;
                    System.Console.WriteLine($"O peso neste planeta será: {pesoPlaneta}");
                    break;

                case "3":
                    System.Console.Write("Entre com o peso na Terra: ");
                    peso = double.Parse(Console.ReadLine());
                    pesoPlaneta = (peso / 10) * marte;
                    System.Console.WriteLine($"O peso neste planeta será: {pesoPlaneta}");
                    break;

                case "4":
                    System.Console.Write("Entre com o peso na Terra: ");
                    peso = double.Parse(Console.ReadLine());
                    pesoPlaneta = (peso / 10) * jupiter;
                    System.Console.WriteLine($"O peso neste planeta será: {pesoPlaneta}");
                    break;

                case "5":
                    System.Console.Write("Entre com o peso na Terra: ");
                    peso = double.Parse(Console.ReadLine());
                    pesoPlaneta = (peso / 10) * saturno;
                    System.Console.WriteLine($"O peso neste planeta será: {pesoPlaneta}");
                    break;

                case "6":
                    System.Console.Write("Entre com o peso na Terra: ");
                    peso = double.Parse(Console.ReadLine());
                    pesoPlaneta = (peso / 10) * urano;
                    System.Console.WriteLine($"O peso neste planeta será: {pesoPlaneta}");
                    break;

            }
            
        }
    }
}
