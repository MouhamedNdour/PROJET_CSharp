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
using MySql.Data.MySqlClient;

namespace PC
{
    public partial class Produit : Form
    {
        private readonly ProduitInfo _info;
        public string idProduit, nomProduit, categorie, quantite, dateAjout, fournisseur, commentaire;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCommentaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFournisseur_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategorie_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Produit_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "datasource=localhost;port=3306;username=root;password=root;database=projetc";
                MySqlConnection conn = new MySqlConnection(sql);
                string selectQuery = "SELECT * FROM fournisseur";
                conn.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, conn);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("NomFournisseur"));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbltext_Click(object sender, EventArgs e)
        {

        }

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
            txtCommentaire.Text = commentaire;
        }
        public void Clear()
        {
            txtNom.Text = txtCategorie.Text = txtQuantite.Text = txtCommentaire.Text = string.Empty;
        }
        private void btnAjt_Click(object sender, EventArgs e)
        {
            fournisseur = comboBox1.SelectedItem.ToString();
            dateAjout = dateTimePicker1.Text;
            
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


            if (txtCommentaire.Text.Trim().Length == 0)
            {
                MessageBox.Show("Commentaire du produit vide");
                return;
            }

            if (btnAjt.Text == "Ajout"){
                ProduitClass produit = new ProduitClass(txtNom.Text.Trim(), txtCategorie.Text.Trim(), Int32.Parse(txtQuantite.Text.Trim()), dateAjout, fournisseur, txtCommentaire.Text.Trim());
                dBProduit.AddProduit(produit);
                Clear();
            }
            if (btnAjt.Text == "Modifier")
            {
                ProduitClass produit = new ProduitClass(txtNom.Text.Trim(), txtCategorie.Text.Trim(), Int32.Parse(txtQuantite.Text.Trim()), dateAjout, fournisseur, txtCommentaire.Text.Trim());
                dBProduit.UpdateProduit(produit, idProduit);
            }
            _info.Display();
        }

       
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
