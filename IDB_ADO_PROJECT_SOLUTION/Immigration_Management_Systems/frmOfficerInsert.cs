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
    public partial class frmOfficerInsert : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9VEOBD4;Initial Catalog=ImmigarationManagementDB;Integrated Security=True");
        public frmOfficerInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtImagePath.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);

            con.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO ImmigrationOfficer VALUES(@n,@dob,@g,@nid,@e,@p,@a,@m,@j,@d,@pic,@ip)", con))
            {
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
                MessageBox.Show("Data inserted successfully!!!");
                RemoveAll();
                con.Close();
            }
        }
        private void RemoveAll()
        {
            txtName.Clear();
            
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtImagePath.Text = openFileDialog1.FileName;
            }
        }
    }
}
