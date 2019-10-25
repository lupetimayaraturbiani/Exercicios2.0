using System;

namespace OrdemAlfabetica
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nomes = new string [2];    

            for(int i =0; i < nomes.Length; i++)
            {
                System.Console.WriteLine("Entre com o nome: ");
                nomes[i] = Console.ReadLine();
            }

            Array.Sort(nomes);
            System.Console.WriteLine($"Os nomes em ordem alfabética estão dispostos em: {nomes[0]} e {nomes[1]}");
        }
    }
}
