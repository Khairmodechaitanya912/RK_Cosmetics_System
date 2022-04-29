namespace RK_Cosmetics_System
{
    partial class frm_Add_New_Distributor
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
            this.gb_Distributor_Details = new System.Windows.Forms.GroupBox();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rbtn_Female = new System.Windows.Forms.RadioButton();
            this.rbtn_Male = new System.Windows.Forms.RadioButton();
            this.tb_PAN_No = new System.Windows.Forms.TextBox();
            this.tb_Aadhar_No = new System.Windows.Forms.TextBox();
            this.tb_Alternate_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Registation_No = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.dtp_TieUp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Email_ID = new System.Windows.Forms.TextBox();
            this.tb_Distributor_Id = new System.Windows.Forms.TextBox();
            this.lbl_Registation_No = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Aadhar_No = new System.Windows.Forms.Label();
            this.lbl_TieUp_Date = new System.Windows.Forms.Label();
            this.lbl_PAN_No = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Alternate_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Email_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Distributor_Id = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Distributor_Details.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Distributor_Details
            // 
            this.gb_Distributor_Details.Controls.Add(this.gb_Gender);
            this.gb_Distributor_Details.Controls.Add(this.tb_PAN_No);
            this.gb_Distributor_Details.Controls.Add(this.tb_Aadhar_No);
            this.gb_Distributor_Details.Controls.Add(this.tb_Alternate_Mobile_No);
            this.gb_Distributor_Details.Controls.Add(this.tb_Address);
            this.gb_Distributor_Details.Controls.Add(this.tb_Registation_No);
            this.gb_Distributor_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Distributor_Details.Controls.Add(this.dtp_TieUp_Date);
            this.gb_Distributor_Details.Controls.Add(this.tb_Name);
            this.gb_Distributor_Details.Controls.Add(this.tb_Email_ID);
            this.gb_Distributor_Details.Controls.Add(this.tb_Distributor_Id);
            this.gb_Distributor_Details.Controls.Add(this.lbl_Registation_No);
            this.gb_Distributor_Details.Controls.Add(this.lbl_Address);
            this.gb_Distributor_Details.Controls.Add(this.lbl_Aadhar_No);
            this.gb_Distributor_Details.Controls.Add(this.lbl_TieUp_Date);
            this.gb_Distributor_Details.Controls.Add(this.lbl_PAN_No);
            this.gb_Distributor_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Distributor_Details.Controls.Add(this.lbl_Alternate_Mobile_No);
            this.gb_Distributor_Details.Controls.Add(this.lbl_Gender);
            this.gb_Distributor_Details.Controls.Add(this.lbl_Email_ID);
            this.gb_Distributor_Details.Controls.Add(this.lbl_Name);
            this.gb_Distributor_Details.Controls.Add(this.lbl_Distributor_Id);
            this.gb_Distributor_Details.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.gb_Distributor_Details.Location = new System.Drawing.Point(90, 210);
            this.gb_Distributor_Details.Name = "gb_Distributor_Details";
            this.gb_Distributor_Details.Size = new System.Drawing.Size(1765, 617);
            this.gb_Distributor_Details.TabIndex = 0;
            this.gb_Distributor_Details.TabStop = false;
            this.gb_Distributor_Details.Text = "Distributor Details";
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rbtn_Female);
            this.gb_Gender.Controls.Add(this.rbtn_Male);
            this.gb_Gender.Location = new System.Drawing.Point(382, 305);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(320, 60);
            this.gb_Gender.TabIndex = 4;
            this.gb_Gender.TabStop = false;
            // 
            // rbtn_Female
            // 
            this.rbtn_Female.AutoSize = true;
            this.rbtn_Female.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Bold);
            this.rbtn_Female.Location = new System.Drawing.Point(174, 23);
            this.rbtn_Female.Name = "rbtn_Female";
            this.rbtn_Female.Size = new System.Drawing.Size(105, 32);
            this.rbtn_Female.TabIndex = 1;
            this.rbtn_Female.TabStop = true;
            this.rbtn_Female.Text = "Female";
            this.rbtn_Female.UseVisualStyleBackColor = true;
            // 
            // rbtn_Male
            // 
            this.rbtn_Male.AutoSize = true;
            this.rbtn_Male.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Bold);
            this.rbtn_Male.Location = new System.Drawing.Point(44, 23);
            this.rbtn_Male.Name = "rbtn_Male";
            this.rbtn_Male.Size = new System.Drawing.Size(82, 32);
            this.rbtn_Male.TabIndex = 0;
            this.rbtn_Male.TabStop = true;
            this.rbtn_Male.Text = "Male";
            this.rbtn_Male.UseVisualStyleBackColor = true;
            // 
            // tb_PAN_No
            // 
            this.tb_PAN_No.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PAN_No.Location = new System.Drawing.Point(1381, 394);
            this.tb_PAN_No.MaxLength = 14;
            this.tb_PAN_No.Name = "tb_PAN_No";
            this.tb_PAN_No.Size = new System.Drawing.Size(320, 41);
            this.tb_PAN_No.TabIndex = 10;
            // 
            // tb_Aadhar_No
            // 
            this.tb_Aadhar_No.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Aadhar_No.Location = new System.Drawing.Point(1381, 305);
            this.tb_Aadhar_No.MaxLength = 12;
            this.tb_Aadhar_No.Name = "tb_Aadhar_No";
            this.tb_Aadhar_No.Size = new System.Drawing.Size(320, 41);
            this.tb_Aadhar_No.TabIndex = 9;
            //this.tb_Aadhar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numerics);
            // 
            // tb_Alternate_Mobile_No
            // 
            this.tb_Alternate_Mobile_No.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alternate_Mobile_No.Location = new System.Drawing.Point(1381, 217);
            this.tb_Alternate_Mobile_No.MaxLength = 10;
            this.tb_Alternate_Mobile_No.Name = "tb_Alternate_Mobile_No";
            this.tb_Alternate_Mobile_No.Size = new System.Drawing.Size(320, 41);
            this.tb_Alternate_Mobile_No.TabIndex = 8;
            this.tb_Alternate_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(382, 221);
            this.tb_Address.MaxLength = 50;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(320, 41);
            this.tb_Address.TabIndex = 3;
            // 
            // tb_Registation_No
            // 
            this.tb_Registation_No.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Registation_No.Location = new System.Drawing.Point(376, 398);
            this.tb_Registation_No.MaxLength = 10;
            this.tb_Registation_No.Name = "tb_Registation_No";
            this.tb_Registation_No.Size = new System.Drawing.Size(320, 41);
            this.tb_Registation_No.TabIndex = 5;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(1381, 142);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(320, 41);
            this.tb_Mobile_No.TabIndex = 7;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // dtp_TieUp_Date
            // 
            this.dtp_TieUp_Date.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_TieUp_Date.Location = new System.Drawing.Point(1381, 51);
            this.dtp_TieUp_Date.Name = "dtp_TieUp_Date";
            this.dtp_TieUp_Date.Size = new System.Drawing.Size(320, 43);
            this.dtp_TieUp_Date.TabIndex = 6;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(376, 142);
            this.tb_Name.MaxLength = 50;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(320, 41);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Email_ID
            // 
            this.tb_Email_ID.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_ID.Location = new System.Drawing.Point(867, 525);
            this.tb_Email_ID.MaxLength = 30;
            this.tb_Email_ID.Name = "tb_Email_ID";
            this.tb_Email_ID.Size = new System.Drawing.Size(320, 41);
            this.tb_Email_ID.TabIndex = 11;
            // 
            // tb_Distributor_Id
            // 
            this.tb_Distributor_Id.Enabled = false;
            this.tb_Distributor_Id.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Distributor_Id.Location = new System.Drawing.Point(376, 55);
            this.tb_Distributor_Id.MaxLength = 5;
            this.tb_Distributor_Id.Name = "tb_Distributor_Id";
            this.tb_Distributor_Id.Size = new System.Drawing.Size(320, 41);
            this.tb_Distributor_Id.TabIndex = 1;
            // 
            // lbl_Registation_No
            // 
            this.lbl_Registation_No.AutoSize = true;
            this.lbl_Registation_No.BackColor = System.Drawing.Color.Pink;
            this.lbl_Registation_No.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_Registation_No.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Registation_No.Location = new System.Drawing.Point(75, 402);
            this.lbl_Registation_No.Name = "lbl_Registation_No";
            this.lbl_Registation_No.Size = new System.Drawing.Size(231, 39);
            this.lbl_Registation_No.TabIndex = 11;
            this.lbl_Registation_No.Text = "Registation No";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.BackColor = System.Drawing.Color.Pink;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_Address.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Address.Location = new System.Drawing.Point(84, 221);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(132, 39);
            this.lbl_Address.TabIndex = 10;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Aadhar_No
            // 
            this.lbl_Aadhar_No.AutoSize = true;
            this.lbl_Aadhar_No.BackColor = System.Drawing.Color.Pink;
            this.lbl_Aadhar_No.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_Aadhar_No.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Aadhar_No.Location = new System.Drawing.Point(1018, 309);
            this.lbl_Aadhar_No.Name = "lbl_Aadhar_No";
            this.lbl_Aadhar_No.Size = new System.Drawing.Size(172, 39);
            this.lbl_Aadhar_No.TabIndex = 9;
            this.lbl_Aadhar_No.Text = "Aadhar No";
            // 
            // lbl_TieUp_Date
            // 
            this.lbl_TieUp_Date.AutoSize = true;
            this.lbl_TieUp_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_TieUp_Date.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_TieUp_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_TieUp_Date.Location = new System.Drawing.Point(1018, 55);
            this.lbl_TieUp_Date.Name = "lbl_TieUp_Date";
            this.lbl_TieUp_Date.Size = new System.Drawing.Size(190, 39);
            this.lbl_TieUp_Date.TabIndex = 8;
            this.lbl_TieUp_Date.Text = "Tie-Up Date";
            // 
            // lbl_PAN_No
            // 
            this.lbl_PAN_No.AutoSize = true;
            this.lbl_PAN_No.BackColor = System.Drawing.Color.Pink;
            this.lbl_PAN_No.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_PAN_No.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_PAN_No.Location = new System.Drawing.Point(1018, 398);
            this.lbl_PAN_No.Name = "lbl_PAN_No";
            this.lbl_PAN_No.Size = new System.Drawing.Size(132, 39);
            this.lbl_PAN_No.TabIndex = 7;
            this.lbl_PAN_No.Text = "PAN No";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.Pink;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(1018, 142);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(169, 39);
            this.lbl_Mobile_No.TabIndex = 6;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Alternate_Mobile_No
            // 
            this.lbl_Alternate_Mobile_No.AutoSize = true;
            this.lbl_Alternate_Mobile_No.BackColor = System.Drawing.Color.Pink;
            this.lbl_Alternate_Mobile_No.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_Alternate_Mobile_No.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Alternate_Mobile_No.Location = new System.Drawing.Point(1018, 221);
            this.lbl_Alternate_Mobile_No.Name = "lbl_Alternate_Mobile_No";
            this.lbl_Alternate_Mobile_No.Size = new System.Drawing.Size(309, 39);
            this.lbl_Alternate_Mobile_No.TabIndex = 4;
            this.lbl_Alternate_Mobile_No.Text = "Alternate Mobile No";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.Color.Pink;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_Gender.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Gender.Location = new System.Drawing.Point(78, 309);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(121, 39);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Email_ID
            // 
            this.lbl_Email_ID.AutoSize = true;
            this.lbl_Email_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Email_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_Email_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Email_ID.Location = new System.Drawing.Point(566, 529);
            this.lbl_Email_ID.Name = "lbl_Email_ID";
            this.lbl_Email_ID.Size = new System.Drawing.Size(136, 39);
            this.lbl_Email_ID.TabIndex = 2;
            this.lbl_Email_ID.Text = "Email ID";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Name.Location = new System.Drawing.Point(78, 146);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(112, 39);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = " Name";
            // 
            // lbl_Distributor_Id
            // 
            this.lbl_Distributor_Id.AutoSize = true;
            this.lbl_Distributor_Id.BackColor = System.Drawing.Color.Pink;
            this.lbl_Distributor_Id.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_Distributor_Id.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Distributor_Id.Location = new System.Drawing.Point(78, 55);
            this.lbl_Distributor_Id.Name = "lbl_Distributor_Id";
            this.lbl_Distributor_Id.Size = new System.Drawing.Size(207, 39);
            this.lbl_Distributor_Id.TabIndex = 0;
            this.lbl_Distributor_Id.Text = "Distributor Id";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1189, 865);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(141, 52);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Yellow;
            this.btn_Save.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(663, 865);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(97, 52);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_New_Distributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 984);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Distributor_Details);
            this.Name = "frm_Add_New_Distributor";
            this.Text = "Add New Distributor";
            this.Load += new System.EventHandler(this.frm_Add_New_Distributor_Load);
            this.gb_Distributor_Details.ResumeLayout(false);
            this.gb_Distributor_Details.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Distributor_Details;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Distributor_Id;
        private System.Windows.Forms.Label lbl_Registation_No;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Aadhar_No;
        private System.Windows.Forms.Label lbl_TieUp_Date;
        private System.Windows.Forms.Label lbl_PAN_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Alternate_Mobile_No;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Email_ID;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Email_ID;
        private System.Windows.Forms.TextBox tb_Distributor_Id;
        private System.Windows.Forms.TextBox tb_PAN_No;
        private System.Windows.Forms.TextBox tb_Aadhar_No;
        private System.Windows.Forms.TextBox tb_Alternate_Mobile_No;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Registation_No;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.DateTimePicker dtp_TieUp_Date;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rbtn_Female;
        private System.Windows.Forms.RadioButton rbtn_Male;
    }
}