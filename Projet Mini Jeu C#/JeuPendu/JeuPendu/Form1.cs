using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuPendu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Jeu leJeu;
        string motGene;

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            leJeu.checkLettre(Convert.ToChar(TBLettre.Text.ToUpper()));
            leJeu.tour();
            TBLettre.Clear();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            leJeu = new Jeu(TBJoueur1.Text, TBJoueur2.Text);
            motGene = leJeu.genereMot();
        }

        private void buttonMot_Click(object sender, EventArgs e)
        {
            leJeu.checkMot(TBMot.Text.ToUpper(), motGene);
            leJeu.tour();
        }
    }
}
