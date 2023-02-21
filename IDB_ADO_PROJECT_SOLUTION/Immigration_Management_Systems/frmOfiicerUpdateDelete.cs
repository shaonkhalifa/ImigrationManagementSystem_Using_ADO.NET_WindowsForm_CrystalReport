using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Immigration_Management_Systems
{
    public partial class frmOfiicerUpdateDelete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9VEOBD4;Initial Catalog=ImmigarationManagementDB;Integrated Security=True");
        public frmOfiicerUpdateDelete()
        {
            InitializeComponent();
        }

        private void frmOfiicerUpdateDelete_Load(object sender, EventArgs e)
        {
            LoadCombo();
          
        }
        private void LoadCombo()
        {
          
      
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT immigrationOfficerId From ImmigrationOfficer", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            cmbId.DisplayMember = "immigrationOfficerId";
            cmbId.ValueMember = "immigrationOfficerId";
            cmbId.DataSource = dt2;
            con.Close();

        }

        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT immigrationOfficerId,officerName,dateOfBirth,gender,nidNumber,email,phone,address,maritalStatus,joinDate,Designation,image,imagePath FROM ImmigrationOfficer WHERE immigrationOfficerId=@i";
            cmd.Parameters.AddWithValue("@i", cmbId.SelectedValue);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtName.Text = dr.GetString(1);
                immigrantDOBdateTimePicker1.Value = dr.GetDateTime(2).Date;
                cmbGender.SelectedItem = dr.GetString(3);
                txtNid.Text = dr.GetString(4);
                txtEmail.Text= dr.GetString(5);
                txtPhone.Text= dr.GetString(6);
                txtAddress.Text= dr.GetString(7);
                rbtnMarrid.Checked = dr.GetBoolean(8) == true;
                rbtnUnmarried.Checked = dr.GetBoolean(8) == false;
                JoindateTimePicker1.Value= dr.GetDateTime(9).Date;
                txtDesignation.Text= dr.GetString(10);
                MemoryStream ms = new MemoryStream((byte[])dr[11]);
                Image img = Image.FromStream(ms);
                txtImagePath.Text= dr.GetString(12);
                pictureBox1.Image = img;

            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtImagePath.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);

            con.Open();
            using (SqlCommand cmd = new SqlCommand("UPDATE  ImmigrationOfficer SET officerName=@n,dateOfBirth=@dob,gender=@g,nidNumber=@nid,email=@e,phone=@p,address=@a,maritalStatus=@m,joinDate=@j,Designation=@d,image=@pic,imagePath=@ip WHERE immigrationOfficerId =@i", con))
            {
                cmd.Parameters.AddWithValue("@i", cmbId.SelectedValue);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@dob", immigrantDOBdateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@g", cmbGender.SelectedItem);
                cmd.Parameters.AddWithValue("@nid", txtNid.Text);
                cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                cmd.Parameters.AddWithValue("@p", txtPhone.Text);
                cmd.Parameters.AddWithValue("@a", txtAddress.Text);
                if (rbtnMarrid.Checked)
                    cmd.Parameters.AddWithValue("@m", true);
                else
                    cmd.Parameters.AddWithValue("@m", false);
                cmd.Parameters.AddWithValue("@j", JoindateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@d", txtDesignation.Text);
                cmd.Parameters.Add(new SqlParameter("@pic", SqlDbType.VarBinary) { Value = ms.ToArray() });
                cmd.Parameters.AddWithValue("@ip", txtImagePath.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated successfully!!!");
                RemoveAll();
                con.Close();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtImagePath.Text = openFileDialog1.FileName;
            }
        }
        private void RemoveAll()
        {
            txtName.Clear();
            cmbId.SelectedIndex = -1;
            immigrantDOBdateTimePicker1.ResetText();
            txtNid.Clear();
            
            cmbGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtPhone.Clear();
            txtImagePath.Clear();
            pictureBox1.Image = null;
            rbtnMarrid.Checked = true;
            JoindateTimePicker1.ResetText();
            txtAddress.Clear();
            txtDesignation.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE  FROM  ImmigrationOfficer  WHERE immigrationOfficerId = " + cmbId.SelectedValue + "";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Deleted successfully!!!");
            //LoadGrid();
            //RemoveAll();
            frmOfiicerUpdateDelete view = new frmOfiicerUpdateDelete();
            view.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
