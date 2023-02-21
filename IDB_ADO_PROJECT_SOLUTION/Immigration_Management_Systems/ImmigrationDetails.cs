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
    public partial class ImmigrationDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9VEOBD4;Initial Catalog=ImmigarationManagementDB;Integrated Security=True");
        public ImmigrationDetails()
        {
            InitializeComponent();
        }

        private void ImmigrationDetails_Load(object sender, EventArgs e)
        {
            LoadCombo();
            unselect();
        }

        private void LoadCombo()
        {


            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT passportID,passportNumber FROM Passport", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbPassport.DataSource = dt;
            cmbPassport.DisplayMember = "passportNumber";
            cmbPassport.ValueMember = "passportID";

            SqlDataAdapter kda = new SqlDataAdapter("SELECT visaId, visaType  From Visa", con);
            DataTable ct = new DataTable();
            kda.Fill(ct);
            cmbVisaType.DataSource = ct;
            cmbVisaType.DisplayMember = "visaType";
            cmbVisaType.ValueMember = "visaId";

            SqlDataAdapter ida = new SqlDataAdapter("SELECT immigrantId, immigrantName  From Immigrant", con);
            DataTable it = new DataTable();
            ida.Fill(it);
            cmbImmigrantName.DataSource = it;
            cmbImmigrantName.DisplayMember = "immigrantName";
            cmbImmigrantName.ValueMember = "immigrantId";

            SqlDataAdapter tda = new SqlDataAdapter("SELECT transportId,transportType FROM Transports", con);
            DataTable tt = new DataTable();
            tda.Fill(tt);
            cmbTransportType.DataSource = tt;
            cmbTransportType.DisplayMember = "transportType";
            cmbTransportType.ValueMember = "transportId";

            SqlDataAdapter zda = new SqlDataAdapter("SELECT transportId,TransportNumber FROM TransportsDetails", con);
            DataTable zt = new DataTable();
            zda.Fill(zt);
            cmbTransportnumber.DataSource = zt;
            cmbTransportnumber.DisplayMember = "TransportNumber";
            cmbTransportnumber.ValueMember = "transportId";

            SqlDataAdapter tifda = new SqlDataAdapter("SELECT immigrationOfficerId, officerName  From ImmigrationOfficer", con);
            DataTable ift = new DataTable();
            tifda.Fill(ift);
            cmbofficerName.DataSource = ift;
            cmbofficerName.DisplayMember = "officerName";
            cmbofficerName.ValueMember = "immigrationOfficerId";
            con.Close();


        }
        private void unselect()
        {
            cmbImmigrantName.SelectedIndex = -1;
            cmbofficerName.SelectedIndex = -1;
            cmbPassport.SelectedIndex = -1;
            cmbTransportnumber.SelectedIndex = -1;
            cmbTransportType.SelectedIndex = -1;
            cmbVisaType.SelectedIndex = -1;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO ImmigrationDetails VALUES(@IM,@PN,@VT,@TT,@TN,@ON,@OFFICN,@DD,@AD,@DP,@AP)", con))
            {
                cmd.Parameters.AddWithValue("@IM", cmbImmigrantName.SelectedValue);
                cmd.Parameters.AddWithValue("@PN", cmbPassport.SelectedValue);
                cmd.Parameters.AddWithValue("@VT", cmbVisaType.SelectedValue);
                cmd.Parameters.AddWithValue("@TT", cmbTransportType.SelectedValue);
                cmd.Parameters.AddWithValue("@TN", cmbTransportnumber.SelectedValue);
                cmd.Parameters.AddWithValue("@ON", cmbofficerName.SelectedValue);
                cmd.Parameters.AddWithValue("@OFFICN", cmbOffice.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DD", DepaturedateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@AD", ArrivaldateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@DP", txtDepaturePlace.Text);
                cmd.Parameters.AddWithValue("@AP", txtArivalPlace.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully!!!");

                con.Close();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}


    












































    
