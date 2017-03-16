using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgence_N_1_Néo
{
    class Urgence1
    {
        static void Main(string[] args)
        {
            // Recrues! Ici le Commandant Morrison, chef suprème des héros!
            // Notre QG à été attaqué, et notre système informatique détruit!
            // Il va vous falloir le réparer en urgence!
            //
            // Nous avons besoin de crypter nos messages avec un pictogramme visuel.
            // Avec ce que vous avez appris aujourd'hui, il vous faut afficher
            // un rectange de LxH (Largeur fois hauteur) qui ressemble à ce qui suit:
            //
            // Exemple 1: L = 5, H = 3
            //
            // O---O
            // |   |
            // O---O
            //
            // Exemple 2: L = 9, H = 2
            //
            // O-------O
            // O-------O
            //
            // Exemple 3: L = 3, H = 5
            //
            // O-O
            // | |
            // | |
            // | |
            // O-O
            //
            //
            // Vous devrez bien évidement prouvez à votre code Guru que ce système marche avec n'importe
            // quelles valeurs pour L et H comprises entre 1 et 50!

            // Interdiction de modifier ce code!!!
            char Coin = '0';
            char Hor = '-';
            char Ver = '|';
            char Centre = ' ';

            int L = 0;
            int H = 0;
            Console.Write("Valeur pour la Largeur : ");
            int.TryParse(Console.ReadLine(), out L);
            Console.Write("Valeur pour la Hauteur : ");
            int.TryParse(Console.ReadLine(), out H);
            // Fin d'interdiction






            // VOTRE CODE ICI






        }
    }
}
