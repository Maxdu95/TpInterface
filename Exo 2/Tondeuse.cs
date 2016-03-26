using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_2
{
    class Tondeuse : IDemarable
    {
        private bool etat;

        public bool Etat
        {
            get { return etat; }
            set { etat = value; }
        }

        private int cadence;

        public int Cadence
        {
            get { return cadence; }
            set { cadence = value; }
        }

        public Tondeuse()
        {
            this.etat = false;
            this.cadence = 0;
        }

        public void switchOn()
        {
            this.etat = true;
            this.cadence = 1000;
        }

        public void switchOff()
        {
            this.etat = false;
            this.cadence = 0;
        }
    }
}
