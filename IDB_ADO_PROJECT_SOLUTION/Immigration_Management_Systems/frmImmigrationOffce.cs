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
    public partial class frmImmigrationOffce : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9VEOBD4;Initial Catalog=ImmigarationManagementDB;Integrated Security=True");
        public frmImmigrationOffce()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LoadCombo()
        {


            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT immigrationOfficerId,officerName FROM ImmigrationOfficer", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbOfficerName.DataSource = dt;
            cmbOfficerName.DisplayMember = "officerName";
            cmbOfficerName.ValueMember = "immigrationOfficerId";

            con.Close();


        }

        private void frmImmigrationOffce_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }
    }
}
