using PC.Models;
using PC.Vues;
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
    public partial class FournisseurInfo : Form
    {
        Fournisseur form;
        public FournisseurInfo()
        {
            InitializeComponent();
            form = new Fournisseur(this);
        }


        public void Display()
        {
            dBFournisseur.DisplayAndsearch(" SELECT IdFournisseur, NomFournisseur, Adresse FROM fournisseur", dataGridView);
        }


        private void ProduitInfo_Shown(object sender, EventArgs e)
        {
             Display();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Modifier
                form.Clear();
                form.idFournisseur = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.nomFournisseur = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.adresse = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.UpdateProduit();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //Supprimer
                if (MessageBox.Show("Voulez-vous supprimer", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    dBFournisseur dBFournisseur = new dBFournisseur();
                    dBFournisseur.Deletefournisseur(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dBFournisseur.DisplayAndsearch(" SELECT IdFournisseur, NomFournisseur, Adresse FROM fournisseur WHERE NomFournisseur LIKE '%" + txtSearch.Text + "%'", dataGridView);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
