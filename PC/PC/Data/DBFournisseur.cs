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
    class dBFournisseur
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

        public static void AddFournisseur(FournisseurClass fournisseur)
        {
            string sql = "INSERT INTO fournisseur(NomFournisseur, Adresse ) VALUES (@NomFournisseur, @Adresse)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@NomFournisseur", MySqlDbType.VarChar).Value = fournisseur.NomFournisseur;
            cmd.Parameters.Add("@Adresse", MySqlDbType.VarChar).Value = fournisseur.Adresse;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouté avec succés.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Fournisseur non ajouté. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateFournisseur(FournisseurClass fournisseur, string idFournisseur)
        {
            string sql = "UPDATE fournisseur SET NomFournisseur = @NomFournisseur, Adresse = @Adresse WHERE IdFournisseur = @Idfournisseur ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDFournisseur", MySqlDbType.VarChar).Value = idFournisseur;
            cmd.Parameters.Add("@NomFournisseur", MySqlDbType.VarChar).Value = fournisseur.NomFournisseur;
            cmd.Parameters.Add("@Adresse", MySqlDbType.VarChar).Value = fournisseur.Adresse;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modifié avec succés.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Fournisseur non modifié. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void Deletefournisseur(string idFournisseur)
        {
            string sql = "DELETE FROM fournisseur WHERE IdFournisseur = @Idfournisseur";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDFournisseur", MySqlDbType.VarChar).Value = idFournisseur;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supprimé avec succés.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Fournisseur non supprimé. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
