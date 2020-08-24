using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Appli_Pokémon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String nomBD;
        String laRequete;

        MySqlCommand leResultat;
        MySqlDataReader uneLigne;

        private void Form1_Load(object sender, EventArgs e)
        {
            nomBD = "Server=127.0.0.1;Database=bd-pokemon;Uid=root;Password=;";

            //Chargement de tout les Types
            MySqlConnection conn = new MySqlConnection(nomBD);
            conn.Open();

            laRequete = "Select nomType FROM type";
            leResultat = conn.CreateCommand();
            leResultat.CommandText = laRequete;
            uneLigne = leResultat.ExecuteReader();
            while(uneLigne.Read())
            {
                listBox2.Items.Add(uneLigne["nomType"]);
            }
            conn.Close();

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(nomBD);
            conn.Open();

            laRequete = "INSERT INTO pokemon(nomP,noTypeP,anneeNaissanceP) VALUES('" + TBNom.Text + "', (SELECT noType FROM type WHERE nomType ='" + listBox2.SelectedItem + "'), '" + TBAnnee.Text + "')";
            leResultat = conn.CreateCommand();
            leResultat.CommandText = laRequete;

            leResultat.ExecuteNonQuery();

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(nomBD);
            conn.Open();

            laRequete = "INSERT INTO type(nomType) VALUES(@nomType)";
            leResultat = conn.CreateCommand();
            leResultat.Parameters.AddWithValue("@nomType", TBTypeAdd.Text);
            leResultat.CommandText = laRequete;
            leResultat.ExecuteNonQuery();

            conn.Close();
        }

        private void buttonAffTen_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(nomBD);
            conn.Open();

            laRequete = "SELECT nomP FROM pokemon JOIN type ON pokemon.noTypeP = type.noType WHERE nomType = 'Tenebres' ";
            leResultat = conn.CreateCommand();
            leResultat.CommandText = laRequete;
            uneLigne = leResultat.ExecuteReader();
            while(uneLigne.Read())
            {
                listBox1.Items.Add(uneLigne["nomP"]);
            }
            conn.Close();
            //Compte Nb de Ténèbres
            conn.Open();

            laRequete = "SELECT COUNT(*) as nb FROM pokemon JOIN type ON pokemon.noTypeP = type.noType WHERE nomType = 'Tenebres' ";
            leResultat = conn.CreateCommand();
            leResultat.CommandText = laRequete;
            uneLigne = leResultat.ExecuteReader();
            uneLigne.Read();
            NbTen.Text = uneLigne["nb"].ToString();
            conn.Close();
        }

        private void buttonPJ_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(nomBD);
            conn.Open();

            int Annee;
            int Age;

            laRequete = "SELECT MAX(anneeNaissanceP) as Annee FROM pokemon";
            leResultat = conn.CreateCommand();
            leResultat.CommandText = laRequete;
            uneLigne = leResultat.ExecuteReader();
            uneLigne.Read();
            Annee = Convert.ToInt32(uneLigne["Annee"]);
            Age = 2020 - Annee;
            conn.Close();

            conn.Open();
            laRequete = "SELECT nomP FROM pokemon WHERE anneeNaissanceP =" + Annee;
            leResultat = conn.CreateCommand();
            leResultat.CommandText = laRequete;
            uneLigne = leResultat.ExecuteReader();
            uneLigne.Read();

            label5.Text = "Le Pokémon le plus jeune est " + uneLigne["nomP"] + " qui a " + Age + " an(s).";

            conn.Close();

        }
    }
}
