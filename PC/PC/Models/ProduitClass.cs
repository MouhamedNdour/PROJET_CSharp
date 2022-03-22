using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
    internal class ProduitClass
    {
        public string NomProduit { get; set; }
        public string Categorie { get; set; }
        public int Quantite { get; set; }
        public string DateAjout { get; set; }
        public string Fournisseur { get; set; }
        public string Commentaire { get; set; }

        public ProduitClass(string nomProduit, string categorie, int quantite, string dateAjout, string fournisseur, string commentaire)
        {
            NomProduit = nomProduit;
            Categorie = categorie;
            Quantite = quantite;
            DateAjout = dateAjout;
            Fournisseur = fournisseur;
            Commentaire = commentaire;
        }
    }
}
