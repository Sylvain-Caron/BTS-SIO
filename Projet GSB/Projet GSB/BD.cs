using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projet_GSB
{

    class BD
    {
        static string connexion = "Server=127.0.0.1;Database=gsb;Uid=root;Password=;";

        //Connexion Responsable
        public static int connexionResp(string pMatricule, string pMdp)
        {
            int id = 0;

            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_resp FROM responsable WHERE matricule_resp = '" + pMatricule + "' AND mdp_resp = '" + pMdp + "'";

            MySqlDataReader uneLigne = cmd.ExecuteReader();
            while(uneLigne.Read())
            {
                id = Convert.ToInt32(uneLigne["id_resp"]);
            }
            
            return id;
        }

        //Connexion Utilisateur
        public static int connexionUser(string pMatricule, string pMdp)
        {
            int id = 0;

            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_user FROM user WHERE matricule_user = '" + pMatricule + "' AND mdp_user = '" + pMdp + "'";

            MySqlDataReader uneLigne = cmd.ExecuteReader();
            while (uneLigne.Read())
            {
                id = Convert.ToInt32(uneLigne["id_user"]);
            }

            return id;
        }

        //Connexion Technicien
        public static int connexionTech(string pMatricule, string pMdp)
        {
            int id = 0;

            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_tech FROM technicien WHERE matricule_tech = '" + pMatricule + "' AND mdp_tech = '" + pMdp + "'";

            MySqlDataReader uneLigne = cmd.ExecuteReader();
            while (uneLigne.Read())
            {
                id = Convert.ToInt32(uneLigne["id_tech"]);
            }

            return id;
        }


        //Ajoute User
        public static void ajouteUser(user unUser)
        {
            MySqlConnection conn = new MySqlConnection(connexion);

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO user(mdp_user,nom_user,prenom_user,adresse_user,matricule_user,date_embauche_user,region_user,objectif,prime,avantage,budget,id_resp)" +
                              "VALUES(@mdpUser, @nomUser, @prenomUser, @adresseUser, @matriculeUser, @dateUser, @regionUser,  @objectif, @prime, @avantage, @budget,@idResp)";
            cmd.Parameters.AddWithValue("@mdpUser", unUser.MdpUser);
            cmd.Parameters.AddWithValue("@nomUser", unUser.NomUser);
            cmd.Parameters.AddWithValue("@prenomUser", unUser.PrenomUser);
            cmd.Parameters.AddWithValue("@adresseUser", unUser.AdresseUser);
            cmd.Parameters.AddWithValue("@matriculeUser", unUser.MatriculeUser);
            cmd.Parameters.AddWithValue("@dateUser", unUser.DateUser);
            cmd.Parameters.AddWithValue("@regionUser", unUser.RegionUser);
            cmd.Parameters.AddWithValue("@objectif", unUser.Objectif);
            cmd.Parameters.AddWithValue("@prime", unUser.Prime);
            cmd.Parameters.AddWithValue("@avantage", unUser.Avantage);
            cmd.Parameters.AddWithValue("@budget", unUser.Budget);
            cmd.Parameters.AddWithValue("@idResp", unUser.IdResp);


            cmd.ExecuteNonQuery();

            conn.Close();

        }

        //Ajoute Technicien
        public static void ajouteTech(technicien unTech)
        {
            MySqlConnection conn = new MySqlConnection(connexion);

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO technicien(mdp_tech,nom_tech,prenom_tech,adresse_tech,matricule_tech,date_embauche_tech,region_tech,niveau_tech,formation_tech,competence_tech,id_resp)" +
                              "VALUES(@mdpTech, @nomTech, @prenomTech, @adresseTech, @matriculeTech, @dateTech, @regionTech,  @nivTech, @formationTech, @competenceTech,@idResp)";
            cmd.Parameters.AddWithValue("@mdpTech", unTech.MdpTech);
            cmd.Parameters.AddWithValue("@nomTech", unTech.NomTech);
            cmd.Parameters.AddWithValue("@prenomTech", unTech.PrenomTech);
            cmd.Parameters.AddWithValue("@adresseTech", unTech.AdresseTech);
            cmd.Parameters.AddWithValue("@matriculeTech", unTech.MatriculeTech);
            cmd.Parameters.AddWithValue("@dateTech", unTech.DateTech);
            cmd.Parameters.AddWithValue("@regionTech", unTech.RegionTech);
            cmd.Parameters.AddWithValue("@nivTech", unTech.NivInter);
            cmd.Parameters.AddWithValue("@formationTech", unTech.Formation);
            cmd.Parameters.AddWithValue("@competenceTech", unTech.Competence);
            cmd.Parameters.AddWithValue("@idResp", unTech.IdResp);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        //Modification Utilisateur
        public static void modifUser(String pMatricule, String pAdresse, String pRegion)
        {
            MySqlConnection conn = new MySqlConnection(connexion);

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE user SET adresse_user = '" + pAdresse + "', region_user = '" + pRegion + "' WHERE matricule_user = '" + pMatricule + "'";

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //Modification Technicien
        public static void modifTech(String pMatricule, String pAdresse, String pRegion)
        {
            MySqlConnection conn = new MySqlConnection(connexion);

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE technicien SET adresse_tech = '" + pAdresse + "', region_tech = '" + pRegion + "' WHERE matricule_tech = '" + pMatricule + "'";

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //Supprime User
        public static void supprUser(String pMatricule)
        {
            MySqlConnection conn = new MySqlConnection(connexion);

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM user WHERE matricule_user = '" + pMatricule + "'";

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //Supprime Yechnicien
        public static void supprTech(String pMatricule)
        {
            MySqlConnection conn = new MySqlConnection(connexion);

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM technicien WHERE matricule_tech = '" + pMatricule + "'";

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //Ajout Matériel
        public static void ajoutMateriel(materiel unMat)
        {
            MySqlConnection conn = new MySqlConnection(connexion);

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO materiel(processeur,memoire,disque,logiciel,date_achat_loc,garantie,fournisseur,id_tech)" +
                              "VALUES(@processeur, @memoire, @disque, @logiciel, @dateAchatLoc, @garantie,  @fournisseur,@idTech)";
            cmd.Parameters.AddWithValue("@processeur", unMat.Processeur);
            cmd.Parameters.AddWithValue("@memoire", unMat.Memoire);
            cmd.Parameters.AddWithValue("@disque", unMat.Disque);
            cmd.Parameters.AddWithValue("@logiciel", unMat.Logiciel);
            cmd.Parameters.AddWithValue("@dateAchatLoc", unMat.DateAchatLoc);
            cmd.Parameters.AddWithValue("@garantie", unMat.Garantie);
            cmd.Parameters.AddWithValue("@fournisseur", unMat.Fournisseur);
            cmd.Parameters.AddWithValue("@idTech", unMat.IdTech);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //Consulte Matériel
        public static String consulteMat(String pId)
        {
            String consult = "";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT processeur, memoire, disque FROM materiel WHERE id_mat = '" + pId + "'";

            MySqlDataReader uneLigne = cmd.ExecuteReader();
            while (uneLigne.Read())
            {
                consult = Convert.ToString("Processeur : " + uneLigne["processeur"]);
                consult = consult + Convert.ToString(" Mémoire : " + uneLigne["memoire"]);
                consult = consult + Convert.ToString(" Disque : " + uneLigne["disque"]);
            }

            return consult;
        }

        //Supprime Materiel

        public static void supprMat(String pId)
        {
            MySqlConnection conn = new MySqlConnection(connexion);

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM materiel WHERE id_mat = '" + pId + "'";

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //Ajoute incident
        public static void ajouteIncid(incident unIncid)
        {
            MySqlConnection conn = new MySqlConnection(connexion);

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO incident(objet_incid,niv_urgence_incid,date_incid,etat_incid,type_charge_incid,id_mat,id_tech,id_user)" +
                              "VALUES(@objet, @nivUrgence, @date, @etat, @priseCharge, @idMat,  @idTech,@idUser)";
            cmd.Parameters.AddWithValue("@objet", unIncid.Objet);
            cmd.Parameters.AddWithValue("@nivUrgence", unIncid.NivUrgence);
            cmd.Parameters.AddWithValue("@date", unIncid.DateIncid);
            cmd.Parameters.AddWithValue("@etat", unIncid.EtatIncid);
            cmd.Parameters.AddWithValue("@priseCharge", unIncid.TypePriseCharge);
            cmd.Parameters.AddWithValue("@idMat", unIncid.IdMat);
            cmd.Parameters.AddWithValue("@idTech", unIncid.IdTech);
            cmd.Parameters.AddWithValue("@idUser", unIncid.IdUser);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //Consulte incident
        public static String consulteIncid(String pId)
        {
            String consult = "";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT type_charge_incid FROM incident WHERE id_mat = '" + pId + "'";

            MySqlDataReader uneLigne = cmd.ExecuteReader();
            while (uneLigne.Read())
            {
                consult = Convert.ToString(uneLigne["type_charge_incid"]);
            }

            conn.Close();

            return consult;
        }

        //Affiche incident
        public static String[] afficheIncid()
        {
            String[] tabIncid = new String[50];
            int n = 0;
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_incid, objet_incid, niv_urgence_incid FROM incident WHERE type_charge_incid != 'Resolu'";

            MySqlDataReader uneLigne = cmd.ExecuteReader();
            while (uneLigne.Read())
            {
                //tabIncid[n] = Convert.ToString(uneLigne["id_incid" + " " + "objet_incid" + " " + "niv_urgence_incid"]);
                tabIncid[n] = Convert.ToString("id : " + uneLigne["id_incid"]);
                tabIncid[n] = tabIncid[n] + Convert.ToString(" Problème : " + uneLigne["objet_incid"]);
                tabIncid[n] = tabIncid[n] + Convert.ToString(" Niveau d'urgence : " + uneLigne["niv_urgence_incid"]);
                //MessageBox.Show(Convert.ToString(tabIncid[n])); Aide Affichage
                n++;
            }

            conn.Close();

            return tabIncid;
        }

        public static List<incident> afficheIncidCollection()
        {
            incident unIncident;
            List<incident> lesIncidents = new List<incident>();

            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT objet_incid, niv_urgence_incid, date_incid, etat_incid, type_charge_incid, id_mat, id_tech, id_user FROM incident";

            MySqlDataReader uneLigne = cmd.ExecuteReader();
            while (uneLigne.Read())
            {
                unIncident = new incident(Convert.ToString(uneLigne["objet_incid"]),Convert.ToInt32(uneLigne["niv_urgence_incid"]), Convert.ToString(uneLigne["date_incid"]), Convert.ToInt32(uneLigne["etat_incid"]), Convert.ToString(uneLigne["type_charge_incid"]), Convert.ToInt32(uneLigne["id_mat"]), Convert.ToInt32(uneLigne["id_tech"]), Convert.ToInt32(uneLigne["id_user"]));
                lesIncidents.Add(unIncident);
            }

            conn.Close();

            return lesIncidents;
        }

        //Changement Etat
        public static void etat1(int pId, int idTech)
        {
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE incident SET type_charge_incid = 'Prise en Charge', id_tech = '" + idTech  + "' WHERE id_incid = '" + pId + "'";
            cmd.ExecuteNonQuery();

            conn.Close();

        }
        public static void etat2(int pId, int idTech)
        {
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE incident SET type_charge_incid = 'Resolu', id_tech = '" + idTech + "' WHERE id_incid = '" + pId + "'";
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        //STATISTIQUE

        //Compte nombre d'incident
        public static int nbIncid()
        {
            int nb = 0;

            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM incident";
            nb = Convert.ToInt16(cmd.ExecuteScalar());
           

            conn.Close();

            return nb;
        }

        public static int nbEnCharge()
        {
            int nb = 0;

            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM incident WHERE type_charge_incid LIKE 'P%'";
            nb = Convert.ToInt16(cmd.ExecuteScalar());

            conn.Close();

            return nb;
        }

        public static int nbResolu()
        {
            int nb = 0;

            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM incident WHERE type_charge_incid = 'Resolu'";
            nb = Convert.ToInt16(cmd.ExecuteScalar());

            conn.Close();

            return nb;
        }

        public static int nbResoluTech()
        {
            int nb = 0;

            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM incident WHERE type_charge_incid = 'Resolu' and id_tech != 0";
            nb = Convert.ToInt16(cmd.ExecuteScalar());

            conn.Close();

            return nb;
        }

        public static int nbChargeTech()
        {
            int nb = 0;

            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM incident WHERE type_charge_incid != 'Resolu' and id_tech != 0";
            nb = Convert.ToInt16(cmd.ExecuteScalar());

            conn.Close();

            return nb;
        }
    }
}
