using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuPendu
{
    class Jeu
    {
        private Joueur joueur1;
        private Joueur joueur2;
        private Joueur joueurActif;

        private char[] charTableau; // Tableau de CHAR pour couper le mot
        private List<char> charValide = new List<char>(); // Collection vide

        public Jeu(string lePseudo1, string lePseudo2)
        {
            joueur1 = new Joueur(lePseudo1);
            joueur2 = new Joueur(lePseudo2);
            joueurActif = joueur1;
            MessageBox.Show("Let's Go !!!");
            MessageBox.Show("à toi : " + joueur1.getPseudo());
        }

        public void tour()
        {
            if(joueurActif == joueur1)
            {
                joueurActif = joueur2;
                MessageBox.Show("à toi : " + joueur2.getPseudo());

            }
            else
            {
                joueurActif = joueur1;
                MessageBox.Show("à toi : " + joueur1.getPseudo());
            }
        }

        public string genereMot()
        {
            string leMot = "CHIMIQUE";
            // COLLECITION de mot puis tirage aléatoire possible.

            charTableau = leMot.ToCharArray();


            int nbChar = charTableau.Length;
            Console.WriteLine(charTableau);
            Console.WriteLine(" ");

            return leMot;
        }

        public void checkLettre(char lettre)
        {
            int nb = 0;
            bool trouve = false;

            for (int i = 0; i < charTableau.Length; i++)
            {
                if (charTableau[i] == Convert.ToChar(lettre))
                {
                    nb = nb + 1;
                    MessageBox.Show("La lettre apparait " + nb + " fois");
                    charValide.Add(Convert.ToChar(lettre));
                    trouve = true;
                }
            }
            if(trouve == false)
            {
                MessageBox.Show("La lettre n'est pas dans le mot");
            }
            // AFFICHE LA COLLECTION DE LETTRE 
            Console.WriteLine(" ");
            Console.WriteLine("Lettre dans la Liste : ");
            foreach (char ch in charValide)
            {
                Console.WriteLine(ch);
            }

            Console.WriteLine("Affichage du mot avec Lettre valide : ");
            for (int i = 0; i < charTableau.Length; i++)
            {
                if (charValide.Contains(charTableau[i]))
                {
                    Console.Write(charTableau[i]);
                }
                else
                {
                    Console.Write("_");
                }
            }
            Console.WriteLine(" ");
            
        }

        public void checkMot(string motProposer, string motRechercher)
        {
            if(motProposer == motRechercher)
            {
                MessageBox.Show(joueurActif.getPseudo() + " à trouver le mot !!!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Non ce n'est pas ça !");
            }
        }
    }
}
