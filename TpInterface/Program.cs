using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exo1
{
    class Program 
    {
        static void Main(string[] args)
        {
            string h = "hello";
            string w = "";
     

            string[] bonjour = { "h", "e", "l", "l", "o" };
 
            foreach (char l in h)
            {
                if (w != "")
                {
                    w = w + "." + l;
                }
                else
                {
                    w = w + l;
                 }
            }
            Console.WriteLine(w);

            IEnumerator liste = bonjour.GetEnumerator();
            while (liste.MoveNext())
            {
               string m = (string)liste.Current;
                Console.WriteLine(m.ToString());
            }
            
            Console.ReadLine();

            string[] bonjour2 = { "h", "e", "l", "l", "o" };

            IEnumerator liste2 = bonjour2.GetEnumerator();
            while (liste2.MoveNext())
            {
                string m = (string)liste2.Current;
                Console.WriteLine(m.ToString());
            }
            Console.ReadLine();
        }
    }
}
