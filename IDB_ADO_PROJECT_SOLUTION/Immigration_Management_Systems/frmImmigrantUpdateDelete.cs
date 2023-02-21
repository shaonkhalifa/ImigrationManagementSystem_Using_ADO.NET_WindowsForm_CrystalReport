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
using System.IO;
using System.Drawing.Imaging;

namespace Immigration_Management_Systems
{
    public partial class frmImmigrantUpdateDelete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9VEOBD4;Initial Catalog=ImmigarationManagementDB;Integrated Security=True");
        public frmImmigrantUpdateDelete()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Immigrant where immigrantId=" + txtsearch.Text + "", con);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);

            //if (dt.Rows.Count > 0)
            //{
            //    txtName.Text = dt.Rows[0]["immigrantName"].ToString();
            //    immigrantDOBdateTimePicker1.Text = dt.Rows[0]["dateOfBirth"].ToString();
            //    cmbGender.SelectedItem = dt.Rows[0]["gender"].ToString();
            //    cmbPassportNumber.SelectedValue = dt.Rows[0]["passportId"].ToString();
            //    txtNid.Text = dt.Rows[0]["nidNumber"].ToString();
            //    cmbCountry.SelectedValue = dt.Rows[0]["countryId"].ToString();
            //    txtEmail.Text = dt.Rows[0]["email"].ToString();
            //    txtPhone.Text = dt.Rows[0]["phone"].ToString();
            //    rbtnMarrid.Checked =(bool.Parse(dt.Rows[0]["maritalStatus"].ToString()));
            //    rbtnunmarried.Checked = bool.Parse(dt.Rows[0]["maritalStatus"].ToString());


            //    pictureBox1.Image = Image.FromStream(dt.Rows[0]["image"].);

            //}
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                txtName.Text = dr.GetString(1);
                immigrantDOBdateTimePicker1.Value = dr.GetDateTime(2).Date;
                cmbGender.SelectedItem = dr.GetSqlValue(3).ToString();
                cmbPassportNumber.SelectedValue = dr.GetInt32(4).ToString();
                txtNid.Text = dr.GetString(5);
                cmbCountry.SelectedValue = dr.GetInt32(6).ToString();
                txtEmail.Text = dr.GetString(7);
                txtPhone.Text = dr.GetString(8);
                rbtnMarrid.Checked = dr.GetBoolean(9) == true;
                rbtnunmarried.Checked = dr.GetBoolean(9) == false;
                MemoryStream ms = new MemoryStream((byte[])dr[10]);
                Image img = Image.FromStream(ms);
                //txtPicturePath.Text=
                pictureBox1.Image = img;
                txtPicturePath.Text = dr.GetString(11);
            }
            con.Close();
        }

        private void frmImmigrantUpdateDelete_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }
        private void LoadCombo()
        {


            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT passportID,passportNumber FROM Passport", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbPassportNumber.DataSource = dt;
            cmbPassportNumber.DisplayMember = "passportNumber";
            cmbPassportNumber.ValueMember = "passportID";

            SqlDataAdapter kda = new SqlDataAdapter("SELECT countryId, countryName  From Country", con);
            DataTable ct = new DataTable();
            kda.Fill(ct);
            cmbCountry.DataSource = ct;
            cmbCountry.DisplayMember = "countryName";
            cmbCountry.ValueMember = "countryId";
            con.Close();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPicturePath.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);

            con.Open();
            using (SqlCommand cmd = new SqlCommand("UPDATE  Immigrant SET immigrantName=@n,dateOfBirth=@dob,gender=@g,passportId=@pn,nidNumber=@nid,countryId=@c,email=@e,phone=@p,maritalStatus=@m,image=@pic,imagePath=@ip WHERE immigrantId=" + txtsearch.Text + "", con))
            {

                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@dob", immigrantDOBdateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@g", cmbGender.SelectedItem);
                cmd.Parameters.AddWithValue("@pn", cmbPassportNumber.SelectedValue);
                cmd.Parameters.AddWithValue("@nid", txtNid.Text);
                cmd.Parameters.AddWithValue("@c", cmbCountry.SelectedValue);
                cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                cmd.Parameters.AddWithValue("@p", txtPhone.Text);
                if (rbtnMarrid.Checked)
                    cmd.Parameters.AddWithValue("@m", true);
                else
                    cmd.Parameters.AddWithValue("@m", false);
                cmd.Parameters.Add(new SqlParameter("@pic", SqlDbType.VarBinary) { Value = ms.ToArray() });
                cmd.Parameters.AddWithValue("@ip", txtPicturePath.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated successfully!!!");
                RemoveAll();
                con.Close();
                frmImmigrantView view = new frmImmigrantView();
                view.Show();
                this.Close();
            }


        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPicturePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Immigrant WHERE immigrantId=" + txtsearch.Text + "";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            
            MessageBox.Show("Data Deleted successfully!!!");
            //LoadGrid();
            RemoveAll();
            //frmImmigrantView view = new frmImmigrantView();
            //view.Show();
            //this.Close();
        }
        private void RemoveAll()
        {
            txtName.Clear();
            cmbPassportNumber.SelectedIndex = -1;
            immigrantDOBdateTimePicker1.ResetText();
            txtNid.Clear();
            cmbCountry.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtPhone.Clear();
            txtPicturePath.Clear();
            pictureBox1.Image = null;
            rbtnMarrid.Checked = true;
            txtsearch.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

