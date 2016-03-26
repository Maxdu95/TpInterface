using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_2
{
    class Jardinier
    {
        private string prenom;
        private IDemarable outil;

        internal IDemarable Outil
        {
            get { return outil; }
            set { outil = value; }
        }

        public Jardinier(string prenom)
        {
            this.prenom = prenom;
        }

        public void startTravail(IDemarable outil)
        {
            this.outil = outil;
        }

        public void stopTravail()
        {
            this.outil = null;
         }
    }
}
