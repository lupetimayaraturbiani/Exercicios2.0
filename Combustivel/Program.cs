using System;

namespace Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            double litrosUsados;
            double tempo;
            double velocidade;
            double distancia;

            System.Console.WriteLine("Informe o tempo, em horas, gasto na viagem: ");
            tempo = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Informe a velocidade média usada na viagem: ");
            velocidade = double.Parse(Console.ReadLine());

            distancia = tempo * velocidade;
            litrosUsados = distancia / 12;

            System.Console.WriteLine($"A quantidade de litos usada foi de {litrosUsados}L");

        }
    }
}
