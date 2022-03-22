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

namespace PC.Vues
{
    public partial class Fournisseur : Form
    {
        private readonly FournisseurInfo _info;
        public string idFournisseur, nomFournisseur, adresse;
        public Fournisseur(FournisseurInfo info)
        {
            InitializeComponent();
            _info = info;
        }
        public void UpdateProduit()
        {
            lbltext.Text = "Update Fournisseur";
            btnAjt.Text = "Modifier";
            txtNom.Text = nomFournisseur;
            txtAdresse.Text = adresse;

        }
        public void Clear()
        {
            txtNom.Text = txtAdresse.Text= string.Empty;
        }
        private void btnAjt_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nom du fournisseur vide");
                return;
            }
            if (txtAdresse.Text.Trim().Length == 0)
            {
                MessageBox.Show("Adresse du fournisseur vide");
                return;
            }

            if (btnAjt.Text == "Ajout")
            {
                FournisseurClass fournisseur = new FournisseurClass(txtNom.Text.Trim(), txtAdresse.Text.Trim());
                //dBFournisseur.AddFournisseur(fournisseur);
                dBFournisseur.AddFournisseur(fournisseur);
                Clear();
            }
            if (btnAjt.Text == "Modifier")
            {
                FournisseurClass fournisseur = new FournisseurClass(txtNom.Text.Trim(), txtAdresse.Text.Trim());
                dBFournisseur.UpdateFournisseur(fournisseur, idFournisseur);
            }
            _info.Display();
        }
    }
}
