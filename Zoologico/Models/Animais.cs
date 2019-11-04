using System.Collections.Generic;

namespace Zoologico.Models
{
    public class Animais
    {
        public static Dictionary<int, Animal> animais = new Dictionary<int, Animal>()
        {
            { 1, new TubaraoMartelo()},
            { 2, new Arara()},
            { 3, new Tucano()},
            { 4, new Leao()},
            { 5, new Orangotango()},
            { 6, new Chimpanze()},
            { 7, new Pinguim()},
            { 8, new Tartaruga()},
            { 9, new Golfinho()}
        };
    }
}