using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GSB
{
    class responsable
    {
        private String mdpResp;
        private String nomResp;
        private String prenomResp;
        private String adresseResp;
        private String matriculeResp;
        private String dateResp;
        
        public responsable(String pMdpResp, String pNomResp, String pPrenomResp, String pAdresseResp, String pMatriculeResp, String pDateResp)
        {
            mdpResp = pMdpResp;
            nomResp = pNomResp;
            prenomResp = pPrenomResp;
            adresseResp = pAdresseResp;
            matriculeResp = pMatriculeResp;
            dateResp = pDateResp;
        }

        //GETTER SETTER 
        public string MdpResp { get => mdpResp; set => mdpResp = value; }
        public string NomResp { get => nomResp; set => nomResp = value; }
        public string PrenomResp { get => prenomResp; set => prenomResp = value; }
        public string AdresseResp { get => adresseResp; set => adresseResp = value; }
        public string MatriculeResp { get => matriculeResp; set => matriculeResp = value; }
        public string DateResp { get => dateResp; set => dateResp = value; }
    }
}
