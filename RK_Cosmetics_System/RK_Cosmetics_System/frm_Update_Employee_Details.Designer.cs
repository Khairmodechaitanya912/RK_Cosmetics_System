namespace RK_Cosmetics_System
{
    partial class frm_Update_Employee_Details
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
            this.gb_Update_Or_Search_Employee = new System.Windows.Forms.GroupBox();
            this.tb_Last_Name = new System.Windows.Forms.TextBox();
            this.lbl_Last_Name = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_Employee_ID = new System.Windows.Forms.TextBox();
            this.lbl_Employee_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Alternate_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Middle_Name = new System.Windows.Forms.Label();
            this.tb_Middle_Name = new System.Windows.Forms.TextBox();
            this.lbl_First_Name = new System.Windows.Forms.Label();
            this.tb_First_Name = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No_2 = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.Warn_First_Name = new System.Windows.Forms.Label();
            this.Warn_Middle_Name = new System.Windows.Forms.Label();
            this.Warn_Last_Name = new System.Windows.Forms.Label();
            this.Warn_Address = new System.Windows.Forms.Label();
            this.Warn_Mobile_Number = new System.Windows.Forms.Label();
            this.Warn_Alternate_Mobile_Number = new System.Windows.Forms.Label();
            this.tb_Email_ID = new System.Windows.Forms.TextBox();
            this.lbl_Email_ID = new System.Windows.Forms.Label();
            this.gb_Update_Or_Search_Employee.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Update_Or_Search_Employee
            // 
            this.gb_Update_Or_Search_Employee.Controls.Add(this.tb_Email_ID);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.lbl_Email_ID);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.Warn_Alternate_Mobile_Number);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.Warn_Mobile_Number);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.Warn_Address);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.Warn_Last_Name);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.Warn_Middle_Name);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.Warn_First_Name);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.tb_Last_Name);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.lbl_Last_Name);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.tb_Address);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.lbl_Address);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.tb_Mobile_No);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.panel1);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.tb_Alternate_Mobile_No);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.lbl_Middle_Name);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.tb_Middle_Name);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.lbl_First_Name);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.tb_First_Name);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.lbl_Mobile_No_2);
            this.gb_Update_Or_Search_Employee.Controls.Add(this.lbl_Mobile_No);
            this.gb_Update_Or_Search_Employee.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Update_Or_Search_Employee.Location = new System.Drawing.Point(87, 224);
            this.gb_Update_Or_Search_Employee.Name = "gb_Update_Or_Search_Employee";
            this.gb_Update_Or_Search_Employee.Size = new System.Drawing.Size(1833, 593);
            this.gb_Update_Or_Search_Employee.TabIndex = 0;
            this.gb_Update_Or_Search_Employee.TabStop = false;
            this.gb_Update_Or_Search_Employee.Text = "Update Or Search Employee";
            // 
            // tb_Last_Name
            // 
            this.tb_Last_Name.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Last_Name.Location = new System.Drawing.Point(453, 441);
            this.tb_Last_Name.MaxLength = 20;
            this.tb_Last_Name.Name = "tb_Last_Name";
            this.tb_Last_Name.Size = new System.Drawing.Size(320, 41);
            this.tb_Last_Name.TabIndex = 6;
            this.tb_Last_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // lbl_Last_Name
            // 
            this.lbl_Last_Name.AutoSize = true;
            this.lbl_Last_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Last_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Last_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Last_Name.Location = new System.Drawing.Point(151, 437);
            this.lbl_Last_Name.Name = "lbl_Last_Name";
            this.lbl_Last_Name.Size = new System.Drawing.Size(169, 39);
            this.lbl_Last_Name.TabIndex = 48;
            this.lbl_Last_Name.Text = "Last Name";
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(1379, 268);
            this.tb_Address.MaxLength = 50;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(320, 41);
            this.tb_Address.TabIndex = 7;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.BackColor = System.Drawing.Color.Pink;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Address.Location = new System.Drawing.Point(1043, 272);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(132, 39);
            this.lbl_Address.TabIndex = 46;
            this.lbl_Address.Text = "Address";
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(1379, 351);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(320, 41);
            this.tb_Mobile_No.TabIndex = 8;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.tb_Employee_ID);
            this.panel1.Controls.Add(this.lbl_Employee_ID);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Location = new System.Drawing.Point(119, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1580, 85);
            this.panel1.TabIndex = 0;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Yellow;
            this.btn_Update.Enabled = false;
            this.btn_Update.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(1291, 19);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(140, 52);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_Employee_ID
            // 
            this.tb_Employee_ID.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_ID.Location = new System.Drawing.Point(364, 24);
            this.tb_Employee_ID.Name = "tb_Employee_ID";
            this.tb_Employee_ID.Size = new System.Drawing.Size(320, 41);
            this.tb_Employee_ID.TabIndex = 1;
            this.tb_Employee_ID.TextChanged += new System.EventHandler(this.tb_Employee_ID_TextChanged);
            // 
            // lbl_Employee_ID
            // 
            this.lbl_Employee_ID.AutoSize = true;
            this.lbl_Employee_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Employee_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Employee_ID.Location = new System.Drawing.Point(62, 24);
            this.lbl_Employee_ID.Name = "lbl_Employee_ID";
            this.lbl_Employee_ID.Size = new System.Drawing.Size(199, 39);
            this.lbl_Employee_ID.TabIndex = 25;
            this.lbl_Employee_ID.Text = "Employee ID";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search.Enabled = false;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(931, 19);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(159, 52);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Alternate_Mobile_No
            // 
            this.tb_Alternate_Mobile_No.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alternate_Mobile_No.Location = new System.Drawing.Point(1379, 437);
            this.tb_Alternate_Mobile_No.MaxLength = 10;
            this.tb_Alternate_Mobile_No.Name = "tb_Alternate_Mobile_No";
            this.tb_Alternate_Mobile_No.Size = new System.Drawing.Size(320, 41);
            this.tb_Alternate_Mobile_No.TabIndex = 9;
            this.tb_Alternate_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Middle_Name
            // 
            this.lbl_Middle_Name.AutoSize = true;
            this.lbl_Middle_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Middle_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Middle_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Middle_Name.Location = new System.Drawing.Point(151, 355);
            this.lbl_Middle_Name.Name = "lbl_Middle_Name";
            this.lbl_Middle_Name.Size = new System.Drawing.Size(212, 39);
            this.lbl_Middle_Name.TabIndex = 38;
            this.lbl_Middle_Name.Text = "Middle Name";
            // 
            // tb_Middle_Name
            // 
            this.tb_Middle_Name.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Middle_Name.Location = new System.Drawing.Point(453, 351);
            this.tb_Middle_Name.MaxLength = 20;
            this.tb_Middle_Name.Name = "tb_Middle_Name";
            this.tb_Middle_Name.Size = new System.Drawing.Size(320, 41);
            this.tb_Middle_Name.TabIndex = 5;
            this.tb_Middle_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // lbl_First_Name
            // 
            this.lbl_First_Name.AutoSize = true;
            this.lbl_First_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_First_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_First_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_First_Name.Location = new System.Drawing.Point(151, 268);
            this.lbl_First_Name.Name = "lbl_First_Name";
            this.lbl_First_Name.Size = new System.Drawing.Size(172, 39);
            this.lbl_First_Name.TabIndex = 39;
            this.lbl_First_Name.Text = "First Name";
            // 
            // tb_First_Name
            // 
            this.tb_First_Name.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_First_Name.Location = new System.Drawing.Point(453, 268);
            this.tb_First_Name.MaxLength = 20;
            this.tb_First_Name.Name = "tb_First_Name";
            this.tb_First_Name.Size = new System.Drawing.Size(320, 41);
            this.tb_First_Name.TabIndex = 4;
            this.tb_First_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // lbl_Mobile_No_2
            // 
            this.lbl_Mobile_No_2.AutoSize = true;
            this.lbl_Mobile_No_2.BackColor = System.Drawing.Color.Pink;
            this.lbl_Mobile_No_2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No_2.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Mobile_No_2.Location = new System.Drawing.Point(1040, 437);
            this.lbl_Mobile_No_2.Name = "lbl_Mobile_No_2";
            this.lbl_Mobile_No_2.Size = new System.Drawing.Size(309, 39);
            this.lbl_Mobile_No_2.TabIndex = 40;
            this.lbl_Mobile_No_2.Text = "Alternate Mobile No";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.Pink;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(1043, 355);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(178, 39);
            this.lbl_Mobile_No.TabIndex = 41;
            this.lbl_Mobile_No.Text = "Mobile No ";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(923, 847);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(140, 52);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Warn_First_Name
            // 
            this.Warn_First_Name.AutoSize = true;
            this.Warn_First_Name.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.Warn_First_Name.ForeColor = System.Drawing.Color.Red;
            this.Warn_First_Name.Location = new System.Drawing.Point(722, 312);
            this.Warn_First_Name.Name = "Warn_First_Name";
            this.Warn_First_Name.Size = new System.Drawing.Size(118, 25);
            this.Warn_First_Name.TabIndex = 49;
            this.Warn_First_Name.Text = "First Name ";
            this.Warn_First_Name.Visible = false;
            // 
            // Warn_Middle_Name
            // 
            this.Warn_Middle_Name.AutoSize = true;
            this.Warn_Middle_Name.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.Warn_Middle_Name.ForeColor = System.Drawing.Color.Red;
            this.Warn_Middle_Name.Location = new System.Drawing.Point(722, 395);
            this.Warn_Middle_Name.Name = "Warn_Middle_Name";
            this.Warn_Middle_Name.Size = new System.Drawing.Size(136, 25);
            this.Warn_Middle_Name.TabIndex = 50;
            this.Warn_Middle_Name.Text = "Middle Name ";
            this.Warn_Middle_Name.Visible = false;
            // 
            // Warn_Last_Name
            // 
            this.Warn_Last_Name.AutoSize = true;
            this.Warn_Last_Name.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.Warn_Last_Name.ForeColor = System.Drawing.Color.Red;
            this.Warn_Last_Name.Location = new System.Drawing.Point(722, 485);
            this.Warn_Last_Name.Name = "Warn_Last_Name";
            this.Warn_Last_Name.Size = new System.Drawing.Size(113, 25);
            this.Warn_Last_Name.TabIndex = 51;
            this.Warn_Last_Name.Text = "Last Name ";
            this.Warn_Last_Name.Visible = false;
            // 
            // Warn_Address
            // 
            this.Warn_Address.AutoSize = true;
            this.Warn_Address.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.Warn_Address.ForeColor = System.Drawing.Color.Red;
            this.Warn_Address.Location = new System.Drawing.Point(1639, 312);
            this.Warn_Address.Name = "Warn_Address";
            this.Warn_Address.Size = new System.Drawing.Size(83, 25);
            this.Warn_Address.TabIndex = 52;
            this.Warn_Address.Text = "Address";
            this.Warn_Address.Visible = false;
            // 
            // Warn_Mobile_Number
            // 
            this.Warn_Mobile_Number.AutoSize = true;
            this.Warn_Mobile_Number.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.Warn_Mobile_Number.ForeColor = System.Drawing.Color.Red;
            this.Warn_Mobile_Number.Location = new System.Drawing.Point(1639, 395);
            this.Warn_Mobile_Number.Name = "Warn_Mobile_Number";
            this.Warn_Mobile_Number.Size = new System.Drawing.Size(152, 25);
            this.Warn_Mobile_Number.TabIndex = 53;
            this.Warn_Mobile_Number.Text = "Mobile Number";
            this.Warn_Mobile_Number.Visible = false;
            // 
            // Warn_Alternate_Mobile_Number
            // 
            this.Warn_Alternate_Mobile_Number.AutoSize = true;
            this.Warn_Alternate_Mobile_Number.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.Warn_Alternate_Mobile_Number.ForeColor = System.Drawing.Color.Red;
            this.Warn_Alternate_Mobile_Number.Location = new System.Drawing.Point(1639, 481);
            this.Warn_Alternate_Mobile_Number.Name = "Warn_Alternate_Mobile_Number";
            this.Warn_Alternate_Mobile_Number.Size = new System.Drawing.Size(243, 25);
            this.Warn_Alternate_Mobile_Number.TabIndex = 54;
            this.Warn_Alternate_Mobile_Number.Text = "Alternate Mobile Number";
            this.Warn_Alternate_Mobile_Number.Visible = false;
            // 
            // tb_Email_ID
            // 
            this.tb_Email_ID.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_ID.Location = new System.Drawing.Point(968, 536);
            this.tb_Email_ID.MaxLength = 10;
            this.tb_Email_ID.Name = "tb_Email_ID";
            this.tb_Email_ID.Size = new System.Drawing.Size(461, 41);
            this.tb_Email_ID.TabIndex = 55;
            // 
            // lbl_Email_ID
            // 
            this.lbl_Email_ID.AutoSize = true;
            this.lbl_Email_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Email_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Email_ID.Location = new System.Drawing.Point(720, 536);
            this.lbl_Email_ID.Name = "lbl_Email_ID";
            this.lbl_Email_ID.Size = new System.Drawing.Size(136, 39);
            this.lbl_Email_ID.TabIndex = 56;
            this.lbl_Email_ID.Text = "Email ID";
            // 
            // frm_Update_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 941);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Update_Or_Search_Employee);
            this.Name = "frm_Update_Employee_Details";
            this.Text = "Update Employee Details";
            this.Load += new System.EventHandler(this.frm_Update_Employee_Details_Load);
            this.gb_Update_Or_Search_Employee.ResumeLayout(false);
            this.gb_Update_Or_Search_Employee.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Update_Or_Search_Employee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_Employee_ID;
        private System.Windows.Forms.Label lbl_Employee_ID;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Alternate_Mobile_No;
        private System.Windows.Forms.Label lbl_Middle_Name;
        private System.Windows.Forms.TextBox tb_Middle_Name;
        private System.Windows.Forms.Label lbl_First_Name;
        private System.Windows.Forms.TextBox tb_First_Name;
        private System.Windows.Forms.Label lbl_Mobile_No_2;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_Last_Name;
        private System.Windows.Forms.Label lbl_Last_Name;
        private System.Windows.Forms.TextBox tb_Email_ID;
        private System.Windows.Forms.Label lbl_Email_ID;
        private System.Windows.Forms.Label Warn_Alternate_Mobile_Number;
        private System.Windows.Forms.Label Warn_Mobile_Number;
        private System.Windows.Forms.Label Warn_Address;
        private System.Windows.Forms.Label Warn_Last_Name;
        private System.Windows.Forms.Label Warn_Middle_Name;
        private System.Windows.Forms.Label Warn_First_Name;
    }
}