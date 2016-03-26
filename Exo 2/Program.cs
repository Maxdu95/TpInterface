using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDemarable t = new Tondeuse();
            IDemarable c = new TailleHaie();
            

            Jardinier j = new Jardinier("Gilbert");

            j.startTravail(t);

            Console.WriteLine(j.Outil);
            

            Console.ReadLine();


        }
    }
}
