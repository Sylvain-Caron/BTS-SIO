using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuPFC
{
    class Jeu
    {
        private Joueur joueur1;

        public Jeu(String lePseudo)
        {
            joueur1 = new Joueur(lePseudo);
        }

        public String botPlay()
        {
            String signeBot = "";
            Random rnd = new Random();
            int val = rnd.Next(1, 4);
            switch(val)
            {
                case 1: signeBot = "Pierre";
                    break;
                case 2: signeBot = "Feuille";
                    break;
                case 3: signeBot = "Ciseaux";
                    break;
            }

            return signeBot;
        }

        public void testGagnant(String lePseudo, String signeJoueur, String signeBot)
        {
            if(signeJoueur == "Ciseaux" && signeBot == "Feuille")
            {
                MessageBox.Show("Le Gagnant est : " + lePseudo);
                //Console.WriteLine("Le Gagnant est : " + Convert.ToString(lePseudo));
            }
            else 
                if(signeJoueur == "Ciseaux" && signeBot == "Pierre")
                {
                    MessageBox.Show("Le Gagnant est : Le Bot");
                    //Console.WriteLine("Le Gagnant est : Le Bot");
                }
                else
                    if (signeJoueur == "Pierre" && signeBot == "Ciseaux")
                    {
                        MessageBox.Show("Le Gagnant est : " + lePseudo);
                        //Console.WriteLine("Le Gagnant est : " + Convert.ToString(lePseudo));
                    }
                    else 
                        if (signeJoueur == "Pierre" && signeBot == "Feuille")
                        {
                            MessageBox.Show("Le Gagnant est : Le Bot");
                            //Console.WriteLine("Le Gagnant est : Le Bot");
                        }
                        else 
                            if (signeJoueur == "Feuille" && signeBot == "Pierre")
                            {
                                MessageBox.Show("Le Gagnant est : " + lePseudo);
                                //Console.WriteLine("Le Gagnant est : " + Convert.ToString(lePseudo));
            }
                            else 
                                if (signeJoueur == "Feuille" && signeBot == "Ciseaux")
                                {
                                    MessageBox.Show("Le Gagnant est : Le Bot");
                                    //Console.WriteLine("Le Gagnant est : Le Bot");
                                }
                                else 
                                    if (signeJoueur == signeBot)
                                    {
                                        MessageBox.Show("Egalité");
                                        //onsole.WriteLine("Egalité");
                                    }
        }
    }
}
