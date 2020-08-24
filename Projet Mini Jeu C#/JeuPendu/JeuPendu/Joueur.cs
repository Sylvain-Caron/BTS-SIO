using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuPendu
{
    class Joueur
    {
        private string pseudo;

        public Joueur(string lePseudo)
        {
            pseudo = lePseudo;
        }

        public string getPseudo()
        {
            return pseudo;
        }
    }
}
