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
    public partial class Form4 : Form
    {
        int id;
        public Form4(int pId)
        {
            InitializeComponent();
            id = pId;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(id));
            if(radioUser.Checked)
            {
                user unUser = new user(TBmdp.Text, TBnom.Text, TBprenom.Text, TBadresse.Text, TBmatricule.Text, dateTimePicker1.Value.ToString(), TBregion.Text, TBobjectif.Text, Convert.ToInt32(TBprime.Text), TBavantage.Text, Convert.ToInt32(TBbudget.Text), id);
                BD.ajouteUser(unUser);
                MessageBox.Show("Ajout Réussi !");
            }
            else if(radioTech.Checked)
            {
                technicien unTech = new technicien(TBmdp.Text, TBnom.Text, TBprenom.Text, TBadresse.Text, TBmatricule.Text, dateTimePicker1.Value.ToString(), TBregion.Text, Convert.ToInt32(TBniv.Text), TBformation.Text, TBcompetence.Text, id);
                BD.ajouteTech(unTech);
                MessageBox.Show("Ajout Réussi !");
            }
            else
            {
                MessageBox.Show("Veuillez choisir le type d'ajout !");
            }
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(rdModifUser.Checked)
            {
                BD.modifUser(TBmodifMatricule.Text, TBmodifAdresse.Text, TBmodifRegion.Text);
                MessageBox.Show("Modification Réussi !");
            }
            else if(rdModifTech.Checked)
            {
                BD.modifTech(TBmodifMatricule.Text, TBmodifAdresse.Text, TBmodifRegion.Text);
                MessageBox.Show("Modification Réussi !");
            }
            else
            {
                MessageBox.Show("Veuillez choisir le type que vous voulez modifier !");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(rdDelUser.Checked)
            {
                BD.supprUser(TBdelMatricule.Text);
                MessageBox.Show("Suppression Réussi !");
            }
            else if(rdDelTech.Checked)
            {
                BD.supprTech(TBdelMatricule.Text);
                MessageBox.Show("Suppression Réussi !");
            }
            else
            {
                MessageBox.Show("Veuillez choisir le type de suppression !");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelIncidResolu.Text = Convert.ToString(BD.nbResolu());
            labelIncidCharge.Text = Convert.ToString(BD.nbEnCharge());
            labelNbIncid.Text = Convert.ToString(BD.nbIncid());
            labelNbTechReso.Text = Convert.ToString(BD.nbResoluTech());
            labelNbTechCharge.Text = Convert.ToString(BD.nbChargeTech());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioTech_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdModifTech_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdModifUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdDelUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDC_Click(object sender, EventArgs e)
        {
            Form1 formCo = new Form1();
            formCo.Show();
            this.Hide();
        }
    }
}
