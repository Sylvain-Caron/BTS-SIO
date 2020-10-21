using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GSB
{
    class incident
    {
        private String objet;
        private int nivUrgence;
        private String dateIncid;
        private int etatIncid;
        private String typePriseCharge;
        private int idMat;
        private int idTech;
        private int idUser;

        public incident(String pObjet, int pNivUrgence, String pDateIncid, int pEtatIncid, String pTypePriseCharge, int pIdMat, int pIdTech, int pIdUser)
        {
            objet = pObjet;
            nivUrgence = pNivUrgence;
            dateIncid = pDateIncid;
            etatIncid = pEtatIncid;
            typePriseCharge = pTypePriseCharge;
            idMat = pIdMat;
            idTech = pIdTech;
            idUser = pIdUser;
        }

        //GETTER SETTER 
        public string Objet { get => objet; set => objet = value; }
        public int NivUrgence { get => nivUrgence; set => nivUrgence = value; }
        public string DateIncid { get => dateIncid; set => dateIncid = value; }
        public int EtatIncid { get => etatIncid; set => etatIncid = value; }
        public string TypePriseCharge { get => typePriseCharge; set => typePriseCharge = value; }
        public int IdMat { get => idMat; set => idMat = value; }
        public int IdTech { get => idTech; set => idTech = value; }
        public int IdUser { get => idUser; set => idUser = value; }
    }
}
