using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace Immigration_Management_Systems
{
    public partial class frmImmigrantInsert : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9VEOBD4;Initial Catalog=ImmigarationManagementDB;Integrated Security=True");
        public frmImmigrantInsert()
        {
            InitializeComponent();
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPicturePath.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);

            con.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Immigrant VALUES(@n,@dob,@g,@pn,@nid,@c,@e,@p,@m,@pic,@ip)", con))
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
                    cmd.Parameters.AddWithValue("@m",true);
                else
                    cmd.Parameters.AddWithValue("@m", false);
                cmd.Parameters.Add(new SqlParameter("@pic", SqlDbType.VarBinary) { Value = ms.ToArray() });
               
                cmd.Parameters.AddWithValue("@ip", txtPicturePath.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully!!!");
                RemoveAll();
                con.Close();
            }
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

       

        private void frmImmigrantInsert_Load(object sender, EventArgs e)
        {
            LoadCombo();
           
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
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            frmImmigrantView frmv = new frmImmigrantView();
            frmv.Show();
            this.Close();
        }
    }
}
