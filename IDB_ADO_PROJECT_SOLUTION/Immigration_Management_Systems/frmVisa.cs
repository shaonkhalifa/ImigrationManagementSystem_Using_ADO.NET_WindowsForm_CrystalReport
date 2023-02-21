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
    public partial class frmVisa : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9VEOBD4;Initial Catalog=ImmigarationManagementDB;Integrated Security=True");
        public frmVisa()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Visa VALUES(@vt,@vn,@idate,@edate)", con))
            {

                cmd.Parameters.AddWithValue("@vt", cmbvisaType.SelectedItem);
                cmd.Parameters.AddWithValue("@vn", txtVisaNumber.Text);
                cmd.Parameters.AddWithValue("@idate", issuedateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@edate", ExpiredateTimePicker2.Value.Date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully!!!");
                
                con.Close();
                RemoveAll();
                LoadGridData();
            }
        }

        private void LoadGridData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT visaId,visaType ,visaNumber,issueDate,expireDate FROM Visa ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.visainfodataGridView1.DataSource = dt;

        }

        private void visainfodataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.visainfodataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)this.visainfodataGridView1.SelectedRows[0].Cells[0].Value;
                SqlCommand cmd = new SqlCommand("SELECT visaId,visaType ,visaNumber,issueDate,expireDate FROM Visa where visaId=@vi", con);
                cmd.Parameters.AddWithValue("@vi", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cmbvisaType .SelectedItem = dr.GetSqlValue(1).ToString(); 
                    txtVisaNumber.Text = dr.GetString(2).ToString();
                    issuedateTimePicker1.Value = dr.GetDateTime(3).Date;
                    issuedateTimePicker1.Value = dr.GetDateTime(4).Date;
                    

                }
                con.Close();
            }
        }

        private void frmVisa_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = (int)this.visainfodataGridView1.SelectedRows[0].Cells[0].Value;
            SqlCommand cmd = new SqlCommand(@"UPDATE Visa SET  visaType=@vt ,visaNumber=@vn,issueDate=@idate,expireDate=@edate FROM Visa where visaId=@i", con);
            cmd.Parameters.AddWithValue("@i", id);
            cmd.Parameters.AddWithValue("@vt", cmbvisaType.SelectedItem);
            cmd.Parameters.AddWithValue("@vn", txtVisaNumber.Text);
            cmd.Parameters.AddWithValue("@idate", issuedateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@edate", ExpiredateTimePicker2.Value.Date);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated successfully!!!");
            con.Close();
            RemoveAll();
            LoadGridData();
        }

        private void RemoveAll()
        {
            cmbvisaType.SelectedIndex = -1;
            txtVisaNumber.Clear();
            issuedateTimePicker1.ResetText();
            ExpiredateTimePicker2.ResetText();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = (int)this.visainfodataGridView1.SelectedRows[0].Cells[0].Value;
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Visa  WHERE visaId=@i", con);
            cmd.Parameters.AddWithValue("@i", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted successfully!!!");
            con.Close();
            RemoveAll();
            LoadGridData();
        }
    }
}
