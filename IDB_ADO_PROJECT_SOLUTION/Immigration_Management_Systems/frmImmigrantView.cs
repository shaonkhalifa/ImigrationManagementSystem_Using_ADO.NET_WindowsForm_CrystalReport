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
    
    public partial class frmImmigrantView : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9VEOBD4;Initial Catalog=ImmigarationManagementDB;Integrated Security=True");
        public frmImmigrantView()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT immigrantId,immigrantName,dateOfBirth,gender,passportId,nidNumber,email,phone,countryId,image From Immigrant", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ImmigrantdataGridView.DataSource = dt;
            con.Close();
        }

        private void frmImmigrantView_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
  
}
