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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            user unUser = new user("ad", "nom", "prenom", "adresse", " ABCD", "date", "region", "objectif", 1000, "aucun", 10000);

            MessageBox.Show(unUser.NomUser); // Get
            MessageBox.Show(unUser.NomUser = "un autre nom");
            */
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if(radioUser.Checked)
            {
                int id = BD.connexionUser(TBmatricule.Text, TBmdp.Text);
                //MessageBox.Show(Convert.ToString(id)); Aide Affichage
                if (id != 0)
                {
                    Form2 formUsers = new Form2(id);
                    formUsers.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erreur MDP ou Matricule");
                }
            }
            else if(radioTech.Checked)
            {
                int id = BD.connexionTech(TBmatricule.Text, TBmdp.Text);
                //MessageBox.Show(Convert.ToString(id)); Aide Affichage
                if (id != 0)
                {
                    Form3 formTech = new Form3(id);
                    formTech.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erreur MDP ou Matricule");
                }
                
            }
            else if(radioResp.Checked)
            {
                int id = BD.connexionResp(TBmatricule.Text, TBmdp.Text);
                //MessageBox.Show(Convert.ToString(id)); Aide Affichage
                if(id != 0)
                {
                    Form4 formResp = new Form4(id);
                    formResp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erreur MDP ou Matricule");
                }
                    
            }

        }
    }
}
