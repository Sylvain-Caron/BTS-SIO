using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuPFC
{
    class Joueur
    {
        private String pseudo;

        public Joueur(String lePseudo)
        {
            pseudo = lePseudo;
        }

        public String getPseudo()
        {
            return pseudo;
        }
    }
}
