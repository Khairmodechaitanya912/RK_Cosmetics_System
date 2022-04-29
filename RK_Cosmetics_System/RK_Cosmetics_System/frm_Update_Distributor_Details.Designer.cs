namespace RK_Cosmetics_System
{
    partial class frm_Update_Distributor_Details
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Distributor_Id = new System.Windows.Forms.TextBox();
            this.lbl_Distributor_Id = new System.Windows.Forms.Label();
            this.tb_Alternate_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Email_ID = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Alternate_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Email_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Distributor_Details.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Distributor_Details
            // 
            this.gb_Distributor_Details.Controls.Add(this.panel1);
            this.gb_Distributor_Details.Controls.Add(this.tb_Alternate_Mobile_No);
            this.gb_Distributor_Details.Controls.Add(this.tb_Address);
            this.gb_Distributor_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Distributor_Details.Controls.Add(this.tb_Name);
            this.gb_Distributor_Details.Controls.Add(this.tb_Email_ID);
            this.gb_Distributor_Details.Controls.Add(this.lbl_Address);
            this.gb_Distributor_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Distributor_Details.Controls.Add(this.lbl_Alternate_Mobile_No);
            this.gb_Distributor_Details.Controls.Add(this.lbl_Email_ID);
            this.gb_Distributor_Details.Controls.Add(this.lbl_Name);
            this.gb_Distributor_Details.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.gb_Distributor_Details.Location = new System.Drawing.Point(77, 223);
            this.gb_Distributor_Details.Name = "gb_Distributor_Details";
            this.gb_Distributor_Details.Size = new System.Drawing.Size(1735, 624);
            this.gb_Distributor_Details.TabIndex = 1;
            this.gb_Distributor_Details.TabStop = false;
            this.gb_Distributor_Details.Text = "Update Or Search Distributor ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.tb_Distributor_Id);
            this.panel1.Controls.Add(this.lbl_Distributor_Id);
            this.panel1.Location = new System.Drawing.Point(43, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1625, 85);
            this.panel1.TabIndex = 24;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Yellow;
            this.btn_Update.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(1358, 19);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(140, 52);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(895, 19);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(159, 52);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Distributor_Id
            // 
            this.tb_Distributor_Id.Enabled = false;
            this.tb_Distributor_Id.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Distributor_Id.Location = new System.Drawing.Point(348, 20);
            this.tb_Distributor_Id.MaxLength = 5;
            this.tb_Distributor_Id.Name = "tb_Distributor_Id";
            this.tb_Distributor_Id.Size = new System.Drawing.Size(320, 41);
            this.tb_Distributor_Id.TabIndex = 1;
            this.tb_Distributor_Id.TextChanged += new System.EventHandler(this.tb_Distributor_Id_TextChanged);
            this.tb_Distributor_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numerics);
            // 
            // lbl_Distributor_Id
            // 
            this.lbl_Distributor_Id.AutoSize = true;
            this.lbl_Distributor_Id.BackColor = System.Drawing.Color.Pink;
            this.lbl_Distributor_Id.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_Distributor_Id.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Distributor_Id.Location = new System.Drawing.Point(78, 24);
            this.lbl_Distributor_Id.Name = "lbl_Distributor_Id";
            this.lbl_Distributor_Id.Size = new System.Drawing.Size(207, 39);
            this.lbl_Distributor_Id.TabIndex = 0;
            this.lbl_Distributor_Id.Text = "Distributor Id";
            // 
            // tb_Alternate_Mobile_No
            // 
            this.tb_Alternate_Mobile_No.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alternate_Mobile_No.Location = new System.Drawing.Point(1375, 348);
            this.tb_Alternate_Mobile_No.MaxLength = 10;
            this.tb_Alternate_Mobile_No.Name = "tb_Alternate_Mobile_No";
            this.tb_Alternate_Mobile_No.Size = new System.Drawing.Size(320, 41);
            this.tb_Alternate_Mobile_No.TabIndex = 7;
            this.tb_Alternate_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(391, 352);
            this.tb_Address.MaxLength = 50;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(320, 41);
            this.tb_Address.TabIndex = 5;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(1375, 210);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(320, 41);
            this.tb_Mobile_No.TabIndex = 6;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(391, 210);
            this.tb_Name.MaxLength = 50;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(320, 41);
            this.tb_Name.TabIndex = 4;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Email_ID
            // 
            this.tb_Email_ID.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_ID.Location = new System.Drawing.Point(910, 500);
            this.tb_Email_ID.MaxLength = 30;
            this.tb_Email_ID.Name = "tb_Email_ID";
            this.tb_Email_ID.Size = new System.Drawing.Size(320, 41);
            this.tb_Email_ID.TabIndex = 8;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.BackColor = System.Drawing.Color.Pink;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_Address.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Address.Location = new System.Drawing.Point(87, 352);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(132, 39);
            this.lbl_Address.TabIndex = 10;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.Pink;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(990, 210);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(178, 39);
            this.lbl_Mobile_No.TabIndex = 6;
            this.lbl_Mobile_No.Text = "Mobile No ";
            // 
            // lbl_Alternate_Mobile_No
            // 
            this.lbl_Alternate_Mobile_No.AutoSize = true;
            this.lbl_Alternate_Mobile_No.BackColor = System.Drawing.Color.Pink;
            this.lbl_Alternate_Mobile_No.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_Alternate_Mobile_No.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Alternate_Mobile_No.Location = new System.Drawing.Point(990, 352);
            this.lbl_Alternate_Mobile_No.Name = "lbl_Alternate_Mobile_No";
            this.lbl_Alternate_Mobile_No.Size = new System.Drawing.Size(318, 39);
            this.lbl_Alternate_Mobile_No.TabIndex = 4;
            this.lbl_Alternate_Mobile_No.Text = "Alternate Mobile No ";
            // 
            // lbl_Email_ID
            // 
            this.lbl_Email_ID.AutoSize = true;
            this.lbl_Email_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Email_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_Email_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Email_ID.Location = new System.Drawing.Point(609, 504);
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
            this.lbl_Name.Location = new System.Drawing.Point(93, 214);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(103, 39);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(838, 897);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(140, 52);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Update_Distributor_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 984);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Distributor_Details);
            this.Name = "frm_Update_Distributor_Details";
            this.Text = "Update Distributor Details";
            this.Load += new System.EventHandler(this.frm_Update_Distributor_Details_Load);
            this.gb_Distributor_Details.ResumeLayout(false);
            this.gb_Distributor_Details.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Distributor_Details;
        private System.Windows.Forms.TextBox tb_Alternate_Mobile_No;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Email_ID;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Alternate_Mobile_No;
        private System.Windows.Forms.Label lbl_Email_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Distributor_Id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
        public System.Windows.Forms.TextBox tb_Distributor_Id;
    }
}