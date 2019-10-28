using System;

namespace Endocrinologista
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double imc;

            System.Console.WriteLine("Informe seu peso em Kg: ");
            peso = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Informe sua altura em metros: ");
            altura = double.Parse(Console.ReadLine());


            imc = peso / (altura * altura);


            if (imc < 20)
            {
                System.Console.WriteLine($"Seu IMC: {imc}");
                System.Console.WriteLine("Abaixo do peso.");
            }
            else if ((imc > 20) && (imc < 25)) 
            {
                System.Console.WriteLine($"Seu IMC: {imc}");
                System.Console.WriteLine("Normal.");
            }
            else if ((imc > 25) && (imc < 30))
            {
                System.Console.WriteLine($"Seu IMC: {imc}");
                System.Console.WriteLine("Excesso de peso.");
            }
            else if ((imc > 30) && (imc < 35))
            {
                System.Console.WriteLine($"Seu IMC: {imc}");
                System.Console.WriteLine("Obesidade.");
            }
            else if (imc > 35)
            {
                System.Console.WriteLine($"Seu IMC: {imc}");
                System.Console.WriteLine("Obesidade Mórbida.");
            }
        }
    }
}
