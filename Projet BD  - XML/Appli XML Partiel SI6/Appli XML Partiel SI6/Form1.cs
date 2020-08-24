using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Appli_XML_Partiel_SI6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument fichXml = new XmlDocument(); // Création de l'objet

        XmlNodeList lesAdmins;
        XmlNode unAdmin;

        private void Form1_Load(object sender, EventArgs e)
        {
            fichXml.Load(@"C:\test\admin.xml");
        }

        private void ButtonAffAdmin_Click(object sender, EventArgs e)
        {
            listAdmin.Items.Clear();
            lesAdmins = fichXml.GetElementsByTagName("nom");
            foreach(XmlNode unAdmin in lesAdmins)
            {
                listAdmin.Items.Add(unAdmin.InnerText);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lesAdmins = fichXml.GetElementsByTagName("nom");
            foreach(XmlNode unAdmin in lesAdmins)
            {
                XmlNode prenom = unAdmin.NextSibling;
                if(unAdmin.InnerText == "Dupont" && prenom.InnerText == "Jean")
                {
                    XmlNode specialite = prenom.NextSibling;
                    specialite.InnerText = "Windows";
                }
            }
            fichXml.Save("admin.xml");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            XmlNode noeudnom = fichXml.CreateNode(XmlNodeType.Element, "nom", "");
            XmlText textnom = fichXml.CreateTextNode("");
            textnom.Value = "Martin";
            noeudnom.AppendChild(textnom);

            XmlNode noeudprenom = fichXml.CreateNode(XmlNodeType.Element, "prenom", "");
            XmlText textprenom = fichXml.CreateTextNode("");
            textprenom.Value = "Sophie";
            noeudprenom.AppendChild(textprenom);

            XmlNode noeudspecialite = fichXml.CreateNode(XmlNodeType.Element, "specialite", "");
            XmlText textspecialite = fichXml.CreateTextNode("");
            textspecialite.Value = "Sophie";
            noeudspecialite.AppendChild(textspecialite);

            XmlNode noeudAdmin = fichXml.CreateNode(XmlNodeType.Element, "admin", "");

            //Une fois les variables associé on les ajoutes au noeud Admin
            noeudAdmin.AppendChild(noeudnom);
            noeudAdmin.AppendChild(noeudprenom);
            noeudAdmin.AppendChild(noeudspecialite);

            XmlNode noeudRacine = fichXml.DocumentElement;
            noeudRacine.AppendChild(noeudAdmin);
            fichXml.Save("admin.xml");
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            XmlNode noeudRacine = fichXml.DocumentElement;
            XmlNode unnoeud = null;
            bool trouve = false;
            lesAdmins = fichXml.GetElementsByTagName("nom");
            foreach (XmlNode unAdmin in lesAdmins)
            {
                XmlNode prenom = unAdmin.NextSibling;
                if (unAdmin.InnerText == "Dupont" && prenom.InnerText == "Jean")
                {
                    unnoeud = unAdmin.ParentNode;
                    trouve = true;
                }
            }
            if (trouve == true)
            {
                noeudRacine.RemoveChild(unnoeud);
            }
            fichXml.Save("admin.xml");
        }
    }
}
