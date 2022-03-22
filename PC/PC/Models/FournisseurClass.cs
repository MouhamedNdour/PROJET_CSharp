using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
    internal class FournisseurClass
    {
        public string NomFournisseur { get; set; }
        public string Adresse { get; set; }

        public FournisseurClass(string nomFournisseur, string adresse)
        {
            NomFournisseur = nomFournisseur;
            Adresse = adresse;
        }
    }
}
