using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_2
{
    class TailleHaie : IDemarable
    {
        private bool etat;

        public bool Etat
        {
            get { return etat; }
            set { etat = value; }
        }
        private int coupeMinute;

        public int CoupeMinute
        {
            get { return coupeMinute; }
            set { coupeMinute = value; }
        }

        public TailleHaie()
        {
            this.etat = false;
            this.coupeMinute = 0;
        }

        public void switchOn()
        {
            this.etat = true;
            this.coupeMinute = 4500;
        }

        public void switchOff()
        {
            this.etat = false;
            this.coupeMinute = 0;
        }
    }
}
