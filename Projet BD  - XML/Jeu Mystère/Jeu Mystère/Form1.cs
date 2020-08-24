using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jeu_Mystère
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] tabPseudo = new string[10];
        int[] tabScores = new int[10];
        string pseudo;
        int nbMystere, nbScores, nbCoups;

        void insererScores(int nb, string name)
        {
            int i, j;
            i = 0;
            while(tabScores[i] < nb && i < nbScores)
            {
                i++;
            }
            if(nbScores < 10)
            {
                nbScores++;
            }
            for(j=0;j<nbScores;j++)
            {
                tabScores[j] = tabScores[j - 1];
                tabPseudo[j] = tabPseudo[j - 1];
            }
            tabScores[j] = nb;
            tabPseudo[j] = name;
        }

        void sauvFichier()
        {
            File.Delete((@"C:\Scores.txt"));
            StreamWriter fichScores = new StreamWriter((@"C:\Scores.txt"));
            for (int i = 0; i < nbScores;i++)
            {
                fichScores.WriteLine(tabPseudo[i]);
                fichScores.WriteLine(tabScores[i]);
            }
            fichScores.Close();
        }

        void affichScores()
        {
            listBoxScores.Items.Clear();
            for(int i = 0; i<nbScores;i++)
            {
                listBoxScores.Items.Add(tabPseudo[i] + " : " + tabScores[i]);
            }
        }

        private void buttonNombreTest_Click(object sender, EventArgs e)
        {
            nbCoups++;
            if(numericUpDown.Value > nbMystere)
            {
                Console.WriteLine("Trop Grand");
            }
            else
            {
                if(numericUpDown.Value < nbMystere)
                {
                    Console.WriteLine("Trop Petit");
                }
                else
                {
                    Console.WriteLine("Gagné en " + nbCoups);
                    if(nbScores == 0)
                    {
                        tabScores[0] = nbCoups;
                        tabPseudo[0] = pseudo;
                        nbScores++;
                        sauvFichier();
                        affichScores();
                    }
                    else
                    {
                        if(nbScores <= 10 || nbCoups < tabScores[nbScores-1])
                        {
                            insererScores(nbCoups, pseudo);
                            sauvFichier();
                            affichScores();
                        }
                    }
                }
            }
        }

        private void buttonDebuter_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int aleatoire = rnd.Next(1,5);
            nbMystere = aleatoire;
            nbCoups = 0;
            pseudo = textBoxPseudo.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;
            StreamReader fichScores = new StreamReader(@"C:\Scores.txt");

            while(!fichScores.EndOfStream)
            {
                tabPseudo[i] = fichScores.ReadLine();
                tabScores[i] = Convert.ToInt32(fichScores);
                i++;
            }
            nbScores = i;

            fichScores.Close();

        }
    }
}
