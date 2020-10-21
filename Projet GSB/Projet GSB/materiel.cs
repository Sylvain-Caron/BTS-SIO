using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GSB
{
    class materiel
    {
        private String processeur;
        private int memoire;
        private String disque;
        private String logiciel;
        private String dateAchatLoc;
        private int garantie;
        private String fournisseur;
        private int idTech;

        public materiel(String pProcesseur, int pMmemoire, String pDisque, String pLogiciel, String pDateAchatLoc, int pGarantie, String pFournisseur, int pIdTech)
        {
            processeur = pProcesseur;
            memoire = pMmemoire;
            disque = pDisque;
            logiciel = pLogiciel;
            dateAchatLoc = pDateAchatLoc;
            garantie = pGarantie;
            fournisseur = pFournisseur;
            idTech = pIdTech;
        }

        public string Processeur { get => processeur; set => processeur = value; }
        public int Memoire { get => memoire; set => memoire = value; }
        public string Disque { get => disque; set => disque = value; }
        public string Logiciel { get => logiciel; set => logiciel = value; }
        public string DateAchatLoc { get => dateAchatLoc; set => dateAchatLoc = value; }
        public int Garantie { get => garantie; set => garantie = value; }
        public string Fournisseur { get => fournisseur; set => fournisseur = value; }
        public int IdTech { get => idTech; set => idTech = value; }
        
    }


}
