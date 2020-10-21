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
    public partial class Form2 : Form
    {
        int id;
        public Form2(int pId)
        {
            InitializeComponent();
            id = pId;
        }

        private void btnDeclarer_Click(object sender, EventArgs e)
        {
            incident unIncid = new incident(TBprobleme.Text, Convert.ToInt32(numUrgence.Value), Convert.ToString(DateTime.Now), Convert.ToInt32(numEtat.Value), "Reçu", Convert.ToInt32(TBposte.Text),0, id);
            BD.ajouteIncid(unIncid);
        }

        private void btnAffIncident_Click(object sender, EventArgs e)
        {
            labelIncid.Text = BD.consulteIncid(TBposte2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formCo = new Form1();
            formCo.Show();
            this.Hide();
        }
    }
}
