using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class TubaraoMartelo: Animal, IAquatico, IBranquiado
    {
        public string SabeNadar()
        {
            return this.GetType().Name + "consegue nadar";
        }

        public string TemBranquias()
        {
            return this.GetType().Name + "respira de baixo da água";
        }
    }
}