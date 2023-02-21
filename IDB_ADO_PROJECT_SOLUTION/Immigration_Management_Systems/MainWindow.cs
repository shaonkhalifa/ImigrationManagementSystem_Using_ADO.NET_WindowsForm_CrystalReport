using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Immigration_Management_Systems
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void immigrantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logInFrm logIn = new logInFrm();
            logIn.Show();
            this.Close();
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCountry frmc = new frmCountry();
            frmc.Show();
            frmc.MdiParent = this;
        }

        private void transportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransport frmt = new frmTransport();
            frmt.Show();
            frmt.MdiParent = this;
        }

        private void userSginUpFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void immigrationOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImmigrationInformationReport fio = new ImmigrationInformationReport();
            fio.Show();
            fio.MdiParent = this;
        }

        private void immigrantsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImmigrationDetails id = new ImmigrationDetails();
            id.Show();
            id.MdiParent = this;
        }

        private void softwerUserSignUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserSignUp fus = new frmUserSignUp();
            fus.Show();
            fus.MdiParent = this;
        }

        private void passportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPassport fp = new frmPassport();
            fp.Show();
            fp.MdiParent = this;
        }

        private void visaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisa fv = new frmVisa();
            fv.Show();
            fv.MdiParent = this;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmImmigrantInsert fII = new frmImmigrantInsert();
            fII.Show();
            fII.MdiParent = this;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmImmigrantView fIv = new frmImmigrantView();
            fIv.Show();
            fIv.MdiParent = this;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmImmigrantUpdateDelete fiud = new frmImmigrantUpdateDelete();
            fiud.Show();
            fiud.MdiParent = this;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmOfficerInsert fOI = new frmOfficerInsert();
            fOI.Show();
            fOI.MdiParent = this;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmOfiicerUpdateDelete ffUD = new frmOfiicerUpdateDelete();
            ffUD.Show();
            ffUD.MdiParent = this;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmOfficerView fov = new frmOfficerView();
            fov.Show();
            fov.MdiParent = this;
        }

        private void immigrantDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             immigrantDetaile im = new immigrantDetaile();
            im.Show();
            im.MdiParent = this;
        }
    }
}
