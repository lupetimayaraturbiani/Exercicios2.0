using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class Chimpanze: Animal, IArborículo
    {
        public string EscalarArvores()
        {
            return this.GetType().Name + "consegue escalar árvores";
        }
    }
}