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
using System.Configuration;

namespace Immigration_Management_Systems
{
    public partial class frmCountry : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9VEOBD4;Initial Catalog=ImmigarationManagementDB;Integrated Security=True");
        public frmCountry()
        {
            InitializeComponent();
        }

 

        private void btnCountryInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Country VALUES(@c)", con))
            {
                cmd.Parameters.AddWithValue("@c", txtcountryName.Text);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully!!!");
                txtcountryName.Clear();
                con.Close();
                LoadGrid();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadGrid()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT countryId, countryName as 'Country' From Country", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            countryDatagridView.DataSource = dt;
            con.Close();
        }

        private void frmCountry_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
