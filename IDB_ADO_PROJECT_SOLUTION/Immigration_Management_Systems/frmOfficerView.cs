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

namespace Immigration_Management_Systems
{
    public partial class frmOfficerView : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9VEOBD4;Initial Catalog=ImmigarationManagementDB;Integrated Security=True");
        public frmOfficerView()
        {
            InitializeComponent();
        }

        private void frmOfficerView_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * From ImmigrationOfficer", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OfficerinfodataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
