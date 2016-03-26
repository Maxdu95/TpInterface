using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3
{
    class Epee : IUtiliserArme
    {
        public Epee()
        {
        }

        public void UtiliserArme()
        {
            Console.WriteLine("Je frappe de taille et d'estoc");
        }
    }
}
