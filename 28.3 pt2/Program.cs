using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._3_pt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Immobile immobile = new Immobile();
            immobile.Tipologia = "Appartamento";
            immobile.Cap = 41056;
            immobile.Citta = "Milano";
            immobile.Superficie = 150;
            immobile.Codice = "ab09em";
            immobile.Indirizzo = "Via roma";
            Console.WriteLine("L'immobile {0}: {1}, in {2},a {3}, di cap {4} e di superficie {5}", immobile.Codice,immobile.Tipologia, immobile.Indirizzo, immobile.Citta, immobile.Cap, immobile.Superficie);
            

            
            Console.ReadLine();
        }
    }
}
