using PC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC
{
    public partial class Produit : Form
    {
        private readonly ProduitInfo _info;
        public string idProduit, nomProduit, categorie, quantite, dateAjout, fournisseur, commentaire;


        public Produit(ProduitInfo info)
        {
            InitializeComponent();
            _info = info;
        }

        public void UpdateProduit()
        {
            lbltext.Text = "Update Produit";
            btnAjt.Text = "Modifier";
            txtNom.Text = nomProduit;
            txtCategorie.Text = categorie;
            txtQuantite.Text = quantite;
            txtDate.Text = dateAjout;
            txtFournisseur.Text = fournisseur;
            txtCommentaire.Text = commentaire;
        }
        public void Clear()
        {
            txtNom.Text = txtCategorie.Text = txtQuantite.Text = txtDate.Text = txtFournisseur.Text = txtCommentaire.Text = string.Empty;
        }
        private void btnAjt_Click(object sender, EventArgs e)
        {
            if(txtNom.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nom du produit vide");
                return;
            }
            if (txtCategorie.Text.Trim().Length == 0)
            {
                MessageBox.Show("Categorie du produit vide");
                return;
            }
            if (txtQuantite.Text.Trim().Length == 0)
            {
                MessageBox.Show("Quantite du produit vide");
                return;
            }
            if (txtDate.Text.Trim().Length == 0)
            {
                MessageBox.Show("Date d'ajout du produit vide");
                return;
            }
            if (txtFournisseur.Text.Trim().Length == 0)
            {
                MessageBox.Show("Fournisseur du produit vide");
                return;
            }
            if (txtCommentaire.Text.Trim().Length == 0)
            {
                MessageBox.Show("Commentaire du produit vide");
                return;
            }

            if (btnAjt.Text == "Ajout"){
                ProduitClass produit = new ProduitClass(txtNom.Text.Trim(), txtCategorie.Text.Trim(), txtQuantite.Text.Trim(), txtDate.Text.Trim(), txtFournisseur.Text.Trim(), txtCommentaire.Text.Trim());
                dBProduit.AddProduit(produit);
                Clear();
            }
            if (btnAjt.Text == "Modifier")
            {
                ProduitClass produit = new ProduitClass(txtNom.Text.Trim(), txtCategorie.Text.Trim(), txtQuantite.Text.Trim(), txtDate.Text.Trim(), txtFournisseur.Text.Trim(), txtCommentaire.Text.Trim());
                dBProduit.UpdateProduit(produit, idProduit);
            }
            _info.Display();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
