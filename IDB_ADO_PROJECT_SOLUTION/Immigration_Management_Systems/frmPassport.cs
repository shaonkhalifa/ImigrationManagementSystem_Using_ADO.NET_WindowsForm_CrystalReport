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
    public partial class frmPassport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9VEOBD4;Initial Catalog=ImmigarationManagementDB;Integrated Security=True");
        public frmPassport()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Passport VALUES(@vn,@idate,@edate,@vt)", con))
            {
                cmd.Parameters.AddWithValue("@vn", txtPassportNumber.Text);
                cmd.Parameters.AddWithValue("@idate", issuedateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@edate", ExpiredateTimePicker2.Value.Date);
                cmd.Parameters.AddWithValue("@vt", cmbVisaType.SelectedValue);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully!!!");

                con.Close();
                RemoveAll();
                LoadGridData();
            }
        }
        private void LoadCombo()
        {


            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT visaId,visaType FROM Visa", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbVisaType.DataSource = dt;
            cmbVisaType.DisplayMember = "visaType";
            cmbVisaType.ValueMember = "visaId";
            con.Close();


        }
        private void LoadGridData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT passportID ,passportNumber,issueDate,expireDate,visaId FROM Passport ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.psaaportinfodataGridView1.DataSource = dt;
           
        }

        private void frmPassport_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadGridData();
        }

        private void psaaportinfodataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.psaaportinfodataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)this.psaaportinfodataGridView1.SelectedRows[0].Cells[0].Value;
                SqlCommand cmd = new SqlCommand("SELECT passportID, passportNumber,issueDate,expireDate,visaId FROM Passport where passportID=@pn", con);
                cmd.Parameters.AddWithValue("@pn", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtPassportNumber.Text = dr.GetString(1).ToString();
                    issuedateTimePicker1.Value = dr.GetDateTime(2).Date;
                    issuedateTimePicker1.Value = dr.GetDateTime(3).Date;
                    cmbVisaType.SelectedItem = dr.GetInt32(4).ToString();

                }
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = (int)this.psaaportinfodataGridView1.SelectedRows[0].Cells[0].Value;
            SqlCommand cmd = new SqlCommand(@"UPDATE Passport SET passportNumber=@pn,issueDate=@isu,expireDate=@ex,visaId=@vi WHERE passportID=@i", con);
            cmd.Parameters.AddWithValue("@i", id);
            cmd.Parameters.AddWithValue("@pn", txtPassportNumber.Text);
            cmd.Parameters.AddWithValue("@isu", issuedateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@ex", ExpiredateTimePicker2.Value.Date);
            cmd.Parameters.AddWithValue("@vi", cmbVisaType.SelectedValue);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated successfully!!!");
            con.Close();
            RemoveAll();
            LoadGridData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            con.Open();
            int id = (int)this.psaaportinfodataGridView1.SelectedRows[0].Cells[0].Value;
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Passport  WHERE passportID=@i", con);
            cmd.Parameters.AddWithValue("@i", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted successfully!!!");
            con.Close();
            RemoveAll();
            LoadGridData();
            
        }
        private void RemoveAll()
        {
            txtPassportNumber.Clear();
            
            issuedateTimePicker1.ResetText();
            ExpiredateTimePicker2.ResetText();

        }
    }
}
