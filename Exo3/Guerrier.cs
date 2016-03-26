using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3
{
    class Guerrier
    {
        IUtiliserArme utiliserUneArme;

        public Guerrier()
        {
            
        }

        public void Equiper(IUtiliserArme utiliserUneArme)
        {
            this.utiliserUneArme = utiliserUneArme;
        }

        public void UtiliserArme()
        {
            if (utiliserUneArme == null)
            {
                Console.WriteLine("oups... vous avez du oublier votre arme quelque part");
            }
        }
    }
}
