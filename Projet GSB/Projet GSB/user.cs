using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GSB
{
    class user
    {
        private String mdpUser;
        private String nomUser;
        private String prenomUser;
        private String adresseUser;
        private String matriculeUser;
        private String dateUser;
        private String regionUser;
        private String objectif;
        private float prime;
        private String avantage;
        private float budget;
        private int idResp;

        public user(String pMdpUser,String pNomUser,String pPrenomUser,String pAdresseUser,String pMatriculeUser,String pDateUser,String pRegionUser,String pObjectif,int pPrime,String pAvantage,int pBudget, int pIdResp)
        {
            mdpUser = pMdpUser;
            nomUser = pNomUser;
            prenomUser = pPrenomUser;
            adresseUser = pAdresseUser;
            matriculeUser = pMatriculeUser;
            dateUser = pDateUser;
            regionUser = pRegionUser;
            objectif = pObjectif;
            prime = pPrime;
            avantage = pAvantage;
            budget = pBudget;
            idResp = pIdResp;

            //dateTimePicker1.Value.ToShortDateString();
        }

        //GETTER SETTER 
        public string MdpUser { get => mdpUser; set => mdpUser = value; }
        public string NomUser { get => nomUser; set => nomUser = value; }
        public string PrenomUser { get => prenomUser; set => prenomUser = value; }
        public string AdresseUser { get => adresseUser; set => adresseUser = value; }
        public string MatriculeUser { get => matriculeUser; set => matriculeUser = value; }
        public string DateUser { get => dateUser; set => dateUser = value; }
        public string RegionUser { get => regionUser; set => regionUser = value; }
        public string Objectif { get => objectif; set => objectif = value; }
        public float Prime { get => prime; set => prime = value; }
        public string Avantage { get => avantage; set => avantage = value; }
        public float Budget { get => budget; set => budget = value; }
        public int IdResp { get => idResp; set => idResp = value; }
    }
}
