namespace Zoologico.Models
{
    public class Animais
    {
        public static Dictionary<int, Animal> Animais = new Dictionary<int, Animal>()
        {
            { 1, new TubarãoMartelo()},
            { 2, new Arara()},
            { 3, new Tucano()},
            { 4, new Leão()},
            { 5, new Orangotango()},
            { 6, new Chimpanzé()},
            { 7, new Pinguim()},
            { 8, new Tartaruga()},
            { 9, new Golfinho()}
        };
    }
}