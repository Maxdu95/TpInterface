using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TpInterface
{
    class numerator : System.Collections.IEnumerable
    {
       string chaine;

        public System.Collections.IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public System.Collections.IEnumerator GetInverse()
        {
            IEnumerable reverse = chaine.Reverse();
            foreach (IEnumerator c in reverse)
                return c;
        }
    }
}
