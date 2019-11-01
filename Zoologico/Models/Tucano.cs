using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class Tucano: Animal, IVoador
    {
        public string Voar()
        {
            return this.GetType() + "pode voar";
        }
    }
}