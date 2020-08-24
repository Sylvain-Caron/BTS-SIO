using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuPFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Jeu leJeu;

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            String signeJoueur = "";
            if(radioCiseaux.Checked)
            {
                //signeJoueur = Convert.ToString(radioCiseaux);
                signeJoueur = "Ciseaux";
            }
            else if(radioFeuille.Checked)
            {
                //signeJoueur = Convert.ToString(radioFeuille);
                signeJoueur = "Feuille";
            }
            else if(radioPierre.Checked)
            {
                //signeJoueur = Convert.ToString(radioPierre);
                signeJoueur = "Pierre";
            }

            labelJoueur.Text = Convert.ToString(signeJoueur);
            labelBot.Text = Convert.ToString(leJeu.botPlay());
            String signeBot = leJeu.botPlay();

            //Console.WriteLine(signeBot); //Test

            leJeu.testGagnant(TBPseudo.Text, signeJoueur, signeBot);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leJeu = new Jeu(TBPseudo.Text);
        }
    }
}
