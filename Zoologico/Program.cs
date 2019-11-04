using System;
using Zoologico.Interfaces;
using Zoologico.Models;
using System.Linq;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            var querSair = false;
                
            do
            {
            
                #region menu principal
            var numAnimal = 0;
            Console.Clear();
            System.Console.WriteLine("=========------------------=========");
            System.Console.WriteLine("========= Menu - Zoológico =========");
            System.Console.WriteLine("=========------------------=========");
            
            foreach (var item in Animais.animais.Values)
            {
                System.Console.WriteLine($"{++numAnimal}{" "}======= {item.GetType().Name}");
            }
                #endregion 
            System.Console.WriteLine();
            System.Console.Write($"Insira o número correspondente ao animal desejado: ");

            try 
            {
                var opcaoUsuario = int.Parse(Console.ReadLine());
                var animal =  Animais.animais[opcaoUsuario];
                ClassificarAnimal(animal);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Entre com um valor válido.");
                Console.ReadLine();
            }
            } while (!querSair);
        }

        

        public static void ClassificarAnimal(Animal animal)
        {
            var classe = animal.GetType();
            var @interfaces = classe.GetInterfaces().FirstOrDefault();

            if ((typeof(IAquatico)).Equals(@interfaces))
            {
                System.Console.WriteLine($"========= {classe.Name} deve ir para para a Piscina =========");

            }
            else if ((typeof(IArborículo)).Equals(@interfaces))
            {
                System.Console.WriteLine($"========= {classe.Name} deve ir para a Casa em Árvore =========");
            }
            else if ((typeof(IBranquiado)).Equals(@interfaces))
            {
                System.Console.WriteLine($"========= {classe.Name} deve ir para o Aquário =========");
            }
            else if ((typeof(IVoador)).Equals(@interfaces))
            {
                System.Console.WriteLine($"========= {classe.Name} deve ir para a Gaiola =========");
            }
            else if ((typeof(ITerrestre)).Equals(@interfaces))
            {
                System.Console.WriteLine($"========= {classe.Name} deve ir para o Pasto ou Caverna de Pedras =========");
            }
            else if ((typeof(IPolar)).Equals(@interfaces))
            {
                System.Console.WriteLine($"========= {classe.Name} deve ir para a Piscina Gelada =========");
            }
        }
        
    }
}
