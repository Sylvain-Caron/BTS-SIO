using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GSB
{
    class technicien
    {
        private String mdpTech;
        private String nomTech;
        private String prenomTech;
        private String adresseTech;
        private String matriculeTech;
        private String dateTech;
        private String regionTech;
        private int nivInter;
        private String formation;
        private String competence;
        private int idResp;

        public technicien(String pMdpTech, String pNomTech,String pPrenomTech,String pAdresseTech,String pMatriculeTech,String pDateTech,String pRegionTech,int pNivInter,String pFormation,String pCompetence, int pIdResp)
        {
            mdpTech = pMdpTech;
            nomTech = pNomTech;
            prenomTech = pPrenomTech;
            adresseTech = pAdresseTech;
            matriculeTech = pMatriculeTech;
            dateTech = pDateTech;
            regionTech = pRegionTech;
            nivInter = pNivInter;
            formation = pFormation;
            competence = pCompetence;
            idResp = pIdResp;
        }

        //GETTER SETTER 
        public string MdpTech { get => mdpTech; set => mdpTech = value; }
        public string NomTech { get => nomTech; set => nomTech = value; }
        public string PrenomTech { get => prenomTech; set => prenomTech = value; }
        public string AdresseTech { get => adresseTech; set => adresseTech = value; }
        public string MatriculeTech { get => matriculeTech; set => matriculeTech = value; }
        public string DateTech { get => dateTech; set => dateTech = value; }
        public string RegionTech { get => regionTech; set => regionTech = value; }
        public int NivInter { get => nivInter; set => nivInter = value; }
        public string Formation { get => formation; set => formation = value; }
        public string Competence { get => competence; set => competence = value; }
        public int IdResp { get => idResp; set => idResp = value; }
    }

    
    

    
}
