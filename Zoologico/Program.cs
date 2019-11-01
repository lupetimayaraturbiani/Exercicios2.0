using System;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int animal;

            
            Console.Clear();
            System.Console.WriteLine("=========------------------=========");
            System.Console.WriteLine("========= Menu - Zoológico =========");
            System.Console.WriteLine("=========------------------=========");
            System.Console.WriteLine("==  1  ==--Tubarão Martelo-=========");
            System.Console.WriteLine("==  2  ==------Tucano------=========");
            System.Console.WriteLine("==  3  ==------Arara-------=========");
            System.Console.WriteLine("==  4  ==-------Leão-------=========");
            System.Console.WriteLine("==  5  ==----Orangotango---=========");
            System.Console.WriteLine("==  6  ==-----Chimpanzé----=========");
            System.Console.WriteLine("==  7  ==------Pinguim-----=========");
            System.Console.WriteLine("==  8  ==-----Tartaruga----=========");
            System.Console.WriteLine("==  9  ==-----Golfinho-----=========");

            System.Console.WriteLine("Digite o código correspondente ao animal:");
            animal = int.Parse(Console.ReadLine());

            switch (animal)
            {
                case 1:
                System.Console.WriteLine("Este animal deve ir para o Aquário.");
                break;

                case 2:
                System.Console.WriteLine("Este animal deve ir para a Gaiola.");
                break;

                case 3:
                System.Console.WriteLine("Este animal deve ir para a Gaiola.");
                break;

                case 4: 
                System.Console.WriteLine("Este animal deve ir para o Pasto.");
                break;

                case 5:
                System.Console.WriteLine("Este animal deve ir para a Casa em Árvore");
                break;

                case 6: 
                System.Console.WriteLine("Este animal deve ir para a Caverna de Pedra.");
                break;

                case 7:
                System.Console.WriteLine("Este animal deve ir para a Piscina Gelada.");
                break;

                case 8:
                System.Console.WriteLine("Este animal deve ir para o Aquário ou para a Piscina.");
                break;

                case 9:
                System.Console.WriteLine("Este animal deve ir para o Aquário.");
                break;
                
            }
            
        }
        
    }
}
