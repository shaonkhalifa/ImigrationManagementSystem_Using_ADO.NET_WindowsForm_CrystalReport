
namespace Immigration_Management_Systems
{
    partial class frmOfficerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OfficerinfodataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OfficerinfodataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // OfficerinfodataGridView1
            // 
            this.OfficerinfodataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OfficerinfodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OfficerinfodataGridView1.Location = new System.Drawing.Point(28, 110);
            this.OfficerinfodataGridView1.Name = "OfficerinfodataGridView1";
            this.OfficerinfodataGridView1.RowHeadersWidth = 62;
            this.OfficerinfodataGridView1.RowTemplate.Height = 28;
            this.OfficerinfodataGridView1.Size = new System.Drawing.Size(1077, 461);
            this.OfficerinfodataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 34);
            this.label2.TabIndex = 27;
            this.label2.Text = " Immigrant Officer Information";
            // 
            // frmOfficerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 675);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OfficerinfodataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmOfficerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOfficerView";
            this.Load += new System.EventHandler(this.frmOfficerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OfficerinfodataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OfficerinfodataGridView1;
        private System.Windows.Forms.Label label2;
    }
}