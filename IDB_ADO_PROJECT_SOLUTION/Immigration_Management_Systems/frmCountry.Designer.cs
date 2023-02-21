
namespace Immigration_Management_Systems
{
    partial class frmCountry
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcountryName = new System.Windows.Forms.TextBox();
            this.btnCountryInsert = new System.Windows.Forms.Button();
            this.countryDatagridView = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countryDatagridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country Name:";
            // 
            // txtcountryName
            // 
            this.txtcountryName.Location = new System.Drawing.Point(275, 463);
            this.txtcountryName.Name = "txtcountryName";
            this.txtcountryName.Size = new System.Drawing.Size(330, 42);
            this.txtcountryName.TabIndex = 1;
            // 
            // btnCountryInsert
            // 
            this.btnCountryInsert.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountryInsert.Location = new System.Drawing.Point(671, 415);
            this.btnCountryInsert.Name = "btnCountryInsert";
            this.btnCountryInsert.Size = new System.Drawing.Size(192, 42);
            this.btnCountryInsert.TabIndex = 2;
            this.btnCountryInsert.Text = "Insert";
            this.btnCountryInsert.UseVisualStyleBackColor = true;
            this.btnCountryInsert.Click += new System.EventHandler(this.btnCountryInsert_Click);
            // 
            // countryDatagridView
            // 
            this.countryDatagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.countryDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryDatagridView.Location = new System.Drawing.Point(121, 81);
            this.countryDatagridView.Name = "countryDatagridView";
            this.countryDatagridView.RowHeadersWidth = 62;
            this.countryDatagridView.RowTemplate.Height = 28;
            this.countryDatagridView.Size = new System.Drawing.Size(656, 229);
            this.countryDatagridView.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(671, 515);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 664);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.countryDatagridView);
            this.Controls.Add(this.btnCountryInsert);
            this.Controls.Add(this.txtcountryName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmCountry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCountry";
            this.Load += new System.EventHandler(this.frmCountry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryDatagridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcountryName;
        private System.Windows.Forms.Button btnCountryInsert;
        private System.Windows.Forms.DataGridView countryDatagridView;
        private System.Windows.Forms.Button btnExit;
    }
}