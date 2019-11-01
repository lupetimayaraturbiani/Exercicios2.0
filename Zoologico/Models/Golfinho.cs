using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class Golfinho: Animal, IAquatico
    {
        public string SabeNadar()
        {
            return this.GetType().Name + "consegue nadar";
        }
    }
}