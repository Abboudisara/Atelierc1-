using System;
using System.Collections.Generic;

namespace collect
{
    class Program
    {
        static void Main(string[] args)




        {

            List<string> moisdanee = new List<string> { "janvier", "fevrier", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "desembre" };


            foreach (string moisdanees in moisdanee)
            {
                Console.WriteLine(moisdanees);
            }

            Console.WriteLine("le mois de troisieme liste");
            Console.WriteLine(moisdanee[2]);


            Console.WriteLine("le mois de troisieme l'index 5");
            Console.WriteLine(moisdanee[5]);



            /* Console.WriteLine("la des mois liste");
              for(int i = 0; i < moisdanee.Length; i++)
              {
                  Console.WriteLine(moisdanee[i]);
              };
            */


            //modification aout
            Console.WriteLine(moisdanee[7] = "Août");


            //ajout de php au premier 

            foreach (string moisdanees in moisdanee)
            {
                Console.WriteLine(moisdanees);
            }

            // supprission de troissième de cette liste
            moisdanee.Remove("PHP");
            Console.WriteLine("la liste après la suppression de PHP:");
            foreach (string moisdanees in moisdanee)
            {
                Console.WriteLine(moisdanees);
            }
            // recherche élément
            int cherche = moisdanee.IndexOf("mars");

            // trie des élemants de la liste
            moisdanee.Sort();
            Console.WriteLine();
            Console.WriteLine("les élément aprés le tri :");
            foreach (string moisdanees in moisdanee)
            {
                Console.WriteLine(moisdanees);
            }

            // copie de la liste dans une autre liste
            Console.WriteLine("copier les élement de tableau");

            string[] mois = new string[12];
            moisdanee.CopyTo(0, mois, 0, 12);
            foreach (string moisd in mois)
            {
                Console.WriteLine(moisd);
            }


        }
    }
}