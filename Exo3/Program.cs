using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerrier conan = new Guerrier();
            Epee durandal = new Epee();
            Arc artemis = new Arc();

            conan.UtiliserArme();
            conan.Equiper(durandal);
            conan.UtiliserArme();
            conan.Equiper(artemis);
            conan.UtiliserArme();

            Console.ReadLine();
        }
    }
}
