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
    public partial class frmTransport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9VEOBD4;Initial Catalog=ImmigarationManagementDB;Integrated Security=True");
        public frmTransport()
        {
            InitializeComponent();
        }

        private void frmTransport_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void LoadCombo()
        {


            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT transportId,transportType FROM Transports", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbtransportType.DataSource = dt;
            cmbtransportType.DisplayMember = "transportType";
            cmbtransportType.ValueMember = "transportId";

            
            con.Close();


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlTransaction ts = con.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Transaction = ts;
                cmd.CommandText = "INSERT INTO TransportsCompany(companyName) VALUES(@name) SELECT @@IDENTITY";
                cmd.Parameters.AddWithValue("@name", txtCompanyName.Text);
              

                int id = Convert.ToInt32(cmd.ExecuteScalar());
                for (int i = 0; i < transportinfodataGridView1.Rows.Count; i++)
                {
                    if (transportinfodataGridView1.Rows[i].Cells["cmbtransportType"].Value != null && transportinfodataGridView1.Rows[i].Cells["txtTransNumber"].Value != null)
                    {
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = con;
                        cmd2.Transaction = ts;
                        cmd2.CommandText = "INSERT INTO TransportsDetails(transportId,companyId,TransportNumber) VALUES(@transportId,@companyId,@TransportNumber)";
                        
                        cmd2.Parameters.AddWithValue("@transportId", transportinfodataGridView1.Rows[i].Cells["cmbtransportType"].Value);
                        cmd2.Parameters.AddWithValue("@companyId", id);
                        cmd2.Parameters.AddWithValue("@TransportNumber", transportinfodataGridView1.Rows[i].Cells["txtTransNumber"].Value);

                        cmd2.ExecuteNonQuery();
                    }
                }
                ts.Commit();
                MessageBox.Show("Data saved successfully!!!!");
            }
            catch (Exception ex)
            {
                ts.Rollback();
                MessageBox.Show(ex.Message + "\nData not saved!!!");
            }
            con.Close();
            AllClear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AllClear()
        {
            txtCompanyName.Clear();
            

        }
    }
}
