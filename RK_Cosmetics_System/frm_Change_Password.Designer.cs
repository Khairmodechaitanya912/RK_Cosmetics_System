namespace RK_Cosmetics_System
{
    partial class frm_Change_Password
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.tb_New_Password = new System.Windows.Forms.TextBox();
            this.tb_Current_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_New_Password = new System.Windows.Forms.Label();
            this.lbl_Current_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Change_Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Update.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(716, 841);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(154, 53);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Close.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(1246, 841);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(154, 53);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // tb_New_Password
            // 
            this.tb_New_Password.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_New_Password.Location = new System.Drawing.Point(1037, 676);
            this.tb_New_Password.MaxLength = 10;
            this.tb_New_Password.Name = "tb_New_Password";
            this.tb_New_Password.PasswordChar = '*';
            this.tb_New_Password.Size = new System.Drawing.Size(426, 50);
            this.tb_New_Password.TabIndex = 3;
            // 
            // tb_Current_Password
            // 
            this.tb_Current_Password.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Password.Location = new System.Drawing.Point(1037, 557);
            this.tb_Current_Password.MaxLength = 10;
            this.tb_Current_Password.Name = "tb_Current_Password";
            this.tb_Current_Password.PasswordChar = '*';
            this.tb_Current_Password.Size = new System.Drawing.Size(426, 50);
            this.tb_Current_Password.TabIndex = 2;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(1037, 450);
            this.tb_Username.MaxLength = 20;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(426, 50);
            this.tb_Username.TabIndex = 1;
            // 
            // lbl_New_Password
            // 
            this.lbl_New_Password.AutoSize = true;
            this.lbl_New_Password.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New_Password.ForeColor = System.Drawing.Color.Red;
            this.lbl_New_Password.Location = new System.Drawing.Point(523, 676);
            this.lbl_New_Password.Name = "lbl_New_Password";
            this.lbl_New_Password.Size = new System.Drawing.Size(296, 50);
            this.lbl_New_Password.TabIndex = 12;
            this.lbl_New_Password.Text = "New Password";
            // 
            // lbl_Current_Password
            // 
            this.lbl_Current_Password.AutoSize = true;
            this.lbl_Current_Password.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_Password.ForeColor = System.Drawing.Color.Red;
            this.lbl_Current_Password.Location = new System.Drawing.Point(523, 557);
            this.lbl_Current_Password.Name = "lbl_Current_Password";
            this.lbl_Current_Password.Size = new System.Drawing.Size(353, 50);
            this.lbl_Current_Password.TabIndex = 11;
            this.lbl_Current_Password.Text = "Current Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Red;
            this.lbl_Username.Location = new System.Drawing.Point(523, 450);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(210, 50);
            this.lbl_Username.TabIndex = 10;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Change_Password
            // 
            this.lbl_Change_Password.AutoSize = true;
            this.lbl_Change_Password.Font = new System.Drawing.Font("Microsoft Uighur", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Change_Password.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Change_Password.Location = new System.Drawing.Point(722, 269);
            this.lbl_Change_Password.Name = "lbl_Change_Password";
            this.lbl_Change_Password.Size = new System.Drawing.Size(536, 109);
            this.lbl_Change_Password.TabIndex = 9;
            this.lbl_Change_Password.Text = "Change Password";
            // 
            // frm_Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 984);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.tb_New_Password);
            this.Controls.Add(this.tb_Current_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_New_Password);
            this.Controls.Add(this.lbl_Current_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Change_Password);
            this.Name = "frm_Change_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frm_Change_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox tb_New_Password;
        private System.Windows.Forms.TextBox tb_Current_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_New_Password;
        private System.Windows.Forms.Label lbl_Current_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Change_Password;
    }
}