using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class Pinguim: Animal, IPolar
    {
        public string ResistirAoFrio()
        {
            return this.GetType().Name + "resistente ao frio";
        }
    }
}