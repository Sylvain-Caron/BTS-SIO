using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GSB
{
    public partial class Form3 : Form
    {
        int id;
        public Form3(int pId)
        {
            InitializeComponent();
            id = pId;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            materiel unMat = new materiel(TBproco.Text, Convert.ToInt32(TBmemoire.Text), TBdisque.Text, TBlogiciel.Text, Convert.ToString(DateTime.Now) , Convert.ToInt32(numGarantie.Value), TBfournisseur.Text, id);
            BD.ajoutMateriel(unMat);
            MessageBox.Show("Ajout Réussi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BD.consulteMat(TBid.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BD.supprMat(TBdelMat.Text);
            MessageBox.Show("Suppression Réussi !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            int nb = BD.nbIncid(); // Compte le nombre d'incident pour  créé un tableau en proportion

            MessageBox.Show(Convert.ToString(nb)); // Aide Affichage

            String[] tabIncid = new String[nb]; // Nouveau Tableau qui va récup le tableau d'incident de la BD
            tabIncid = BD.afficheIncid();
            for(int i = 0; i<nb; i++)
            {
                MessageBox.Show(Convert.ToString(tabIncid[i]));
                listBoxIncid.Items.Add(tabIncid[i]);
            }
            */

            listBoxIncid.Items.Clear();

            List<incident> lesIncidents = BD.afficheIncidCollection();
            int id = 0;
            foreach(incident unIncident in lesIncidents)
            {
                ++id;
                listBoxIncid.Items.Add("id : " + id + " Etat : " + unIncident.TypePriseCharge + " " + " Niv D'urgence : " + unIncident.NivUrgence + " " + " Objet : " + unIncident.Objet);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BD.etat1(Convert.ToInt32(numIncid.Value), id);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BD.etat2(Convert.ToInt32(numIncid.Value), id);
        }

        private void btnDC_Click(object sender, EventArgs e)
        {
            Form1 formCo = new Form1();
            formCo.Show();
            this.Hide();
        }
    }
}
