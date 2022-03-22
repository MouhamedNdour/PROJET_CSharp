using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC.Models
{
    class dBProduit
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=root;database=projetc";
            MySqlConnection conn = new MySqlConnection(sql);
            try { conn.Open(); }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);        
            }
            return conn;
        }

        public static void AddProduit(ProduitClass produit)
        {
            string sql = "INSERT INTO produit(NomProduit, Categorie, Quantite, Date, Fournisseur, Commentaire ) VALUES (@NomProduit, @Categorie, @Quantite, @Date, @Fournisseur, @Commentaire)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@NomProduit", MySqlDbType.VarChar).Value = produit.NomProduit;
            cmd.Parameters.Add("@Categorie", MySqlDbType.VarChar).Value = produit.Categorie;
            cmd.Parameters.Add("@Quantite", MySqlDbType.Int32).Value = produit.Quantite;
            cmd.Parameters.Add("@Date", MySqlDbType.VarChar).Value = produit.DateAjout;
            cmd.Parameters.Add("@Fournisseur", MySqlDbType.VarChar).Value = produit.Fournisseur;
            cmd.Parameters.Add("@Commentaire", MySqlDbType.VarChar).Value = produit.Commentaire;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouté avec succés.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Produit non ajouté. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateProduit(ProduitClass produit, string idProduit)
        {
            string sql = "UPDATE produit SET NomProduit = @NomProduit, Categorie = @Categorie, Quantite = @Quantite, Date = @Date, Fournisseur = @Fournisseur, Commentaire = @Commentaire WHERE IdProduit = @Idproduit ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDProduit", MySqlDbType.VarChar).Value = idProduit;
            cmd.Parameters.Add("@NomProduit", MySqlDbType.VarChar).Value = produit.NomProduit;
            cmd.Parameters.Add("@Categorie", MySqlDbType.VarChar).Value = produit.Categorie;
            cmd.Parameters.Add("@Quantite", MySqlDbType.VarChar).Value = produit.Quantite;
            cmd.Parameters.Add("@Date", MySqlDbType.VarChar).Value = produit.DateAjout;
            cmd.Parameters.Add("@Fournisseur", MySqlDbType.VarChar).Value = produit.Fournisseur;
            cmd.Parameters.Add("@Commentaire", MySqlDbType.VarChar).Value = produit.Commentaire;
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modifié avec succés.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Produit non modifié. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void Deleteproduit(string idProduit)
        {
            string sql = "DELETE FROM produit WHERE IdProduit = @Idproduit";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDProduit", MySqlDbType.VarChar).Value = idProduit;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supprimé avec succés.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Produit non supprimé. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndsearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}
