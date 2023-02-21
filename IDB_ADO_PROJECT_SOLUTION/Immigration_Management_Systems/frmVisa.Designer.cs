
namespace Immigration_Management_Systems
{
    partial class frmVisa
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
            this.issuedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVisaNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExpiredateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.visainfodataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbvisaType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.visainfodataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visa Type :";
            // 
            // issuedateTimePicker1
            // 
            this.issuedateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.issuedateTimePicker1.Location = new System.Drawing.Point(315, 224);
            this.issuedateTimePicker1.Name = "issuedateTimePicker1";
            this.issuedateTimePicker1.Size = new System.Drawing.Size(291, 37);
            this.issuedateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Visa Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Visa Number :";
            // 
            // txtVisaNumber
            // 
            this.txtVisaNumber.Location = new System.Drawing.Point(315, 156);
            this.txtVisaNumber.Name = "txtVisaNumber";
            this.txtVisaNumber.Size = new System.Drawing.Size(291, 37);
            this.txtVisaNumber.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Issue Date :";
            // 
            // ExpiredateTimePicker2
            // 
            this.ExpiredateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpiredateTimePicker2.Location = new System.Drawing.Point(315, 291);
            this.ExpiredateTimePicker2.Name = "ExpiredateTimePicker2";
            this.ExpiredateTimePicker2.Size = new System.Drawing.Size(291, 37);
            this.ExpiredateTimePicker2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Expire Date :";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(761, 78);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(123, 52);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(761, 156);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 52);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(761, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 52);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Delete";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // visainfodataGridView1
            // 
            this.visainfodataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.visainfodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visainfodataGridView1.Location = new System.Drawing.Point(78, 373);
            this.visainfodataGridView1.Name = "visainfodataGridView1";
            this.visainfodataGridView1.RowHeadersWidth = 62;
            this.visainfodataGridView1.RowTemplate.Height = 28;
            this.visainfodataGridView1.Size = new System.Drawing.Size(806, 219);
            this.visainfodataGridView1.TabIndex = 10;
            this.visainfodataGridView1.SelectionChanged += new System.EventHandler(this.visainfodataGridView1_SelectionChanged);
            // 
            // cmbvisaType
            // 
            this.cmbvisaType.FormattingEnabled = true;
            this.cmbvisaType.Items.AddRange(new object[] {
            "Student Visa",
            "Worker Visa",
            "Family  Visa",
            "Business Visa",
            "Political Visa",
            ""});
            this.cmbvisaType.Location = new System.Drawing.Point(315, 84);
            this.cmbvisaType.Name = "cmbvisaType";
            this.cmbvisaType.Size = new System.Drawing.Size(291, 38);
            this.cmbvisaType.TabIndex = 11;
            // 
            // frmVisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 650);
            this.Controls.Add(this.cmbvisaType);
            this.Controls.Add(this.visainfodataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVisaNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExpiredateTimePicker2);
            this.Controls.Add(this.issuedateTimePicker1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmVisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisa";
            this.Load += new System.EventHandler(this.frmVisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visainfodataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker issuedateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVisaNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ExpiredateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView visainfodataGridView1;
        private System.Windows.Forms.ComboBox cmbvisaType;
    }
}