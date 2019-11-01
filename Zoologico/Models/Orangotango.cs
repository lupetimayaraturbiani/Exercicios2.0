using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class Orangotango: Animal, IArborículo
    {
        public string EscalarArvores()
        {
            return this.GetType().Name + "consegue escalar";
        }
    }
}