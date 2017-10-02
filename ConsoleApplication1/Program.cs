using BiblioDemoGit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3Salarie;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {         
                Personne p1 = new Personne("Safaryan", "edgar");
                Personne p2 = new Personne("Deschamps", "Dider");
                Console.WriteLine(p1);
                Salarie s1 = new Salarie(1000, "Daridon", "Will");
                Console.WriteLine(s1.Nom);

                Console.ReadKey();           

        }
    }
}
