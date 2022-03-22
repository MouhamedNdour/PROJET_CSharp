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
    public partial class ProduitInfo : Form
    {
        Produit form;
        public ProduitInfo()
        {
            InitializeComponent();
            form = new Produit(this); 
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Modifier
                form.Clear();
                form.idProduit = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.nomProduit = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.categorie = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.quantite = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.dateAjout = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.fournisseur = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.commentaire = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.UpdateProduit();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //Supprimer
                if (MessageBox.Show("Voulez-vous supprimer", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    dBProduit dBProduit = new dBProduit();
                    dBProduit.Deleteproduit(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    //Console.WriteLine(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        public void Display()
        {
            dBProduit.DisplayAndsearch(" SELECT IdProduit, NomProduit, Categorie, Quantite, Date, Fournisseur, Commentaire FROM produit", dataGridView);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            //Produit form = new Produit(this);
            form.Clear();
            form.ShowDialog();
        }

        private void ProduitInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }


        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            dBProduit.DisplayAndsearch(" SELECT IdProduit, NomProduit, Categorie, Quantite, Date, Fournisseur, Commentaire FROM produit WHERE NomProduit LIKE '%" + txtSearch.Text + "%'", dataGridView);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
