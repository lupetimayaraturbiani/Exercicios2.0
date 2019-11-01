using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class Leao: Animal, ITerrestre
    {
        public string Andar()
        {
            return this.GetType().Name + "capz de caminhar";
        }
    }
}