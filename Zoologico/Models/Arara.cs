using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class Arara: Animal, IVoador
    {
        public string Voar()
        {
            return this.GetType().Name + "pode voar";
        }
    }
}