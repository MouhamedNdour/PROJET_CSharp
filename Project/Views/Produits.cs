using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project.Views
{
    public partial class Produits : Form
    {
        SqlDataAdapter sda;
        SqlCommand scb;
        DataTable dt;

       

        public Produits()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            init();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu home = new Menu();
            home.ShowDialog();
        }

        private void init()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Project\Database.mdf;Integrated Security=True");
            sda = new SqlDataAdapter(@"SELECT * FROM Produits", conn);

            dt = new DataTable();   
            sda.Fill(dt);   
            dataGridView1.DataSource = dt;  
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
