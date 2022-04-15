namespace RK_Cosmetics_System
{
    partial class frm_Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login_Form));
            this.pb_Login_Form = new System.Windows.Forms.PictureBox();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_Ready_To_Login = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.pb_Login_Icon = new System.Windows.Forms.PictureBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Sign_In = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_Form)).BeginInit();
            this.pnl_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Login_Form
            // 
            this.pb_Login_Form.Image = ((System.Drawing.Image)(resources.GetObject("pb_Login_Form.Image")));
            this.pb_Login_Form.Location = new System.Drawing.Point(1, 1);
            this.pb_Login_Form.Name = "pb_Login_Form";
            this.pb_Login_Form.Size = new System.Drawing.Size(617, 725);
            this.pb_Login_Form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Login_Form.TabIndex = 0;
            this.pb_Login_Form.TabStop = false;
            // 
            // pnl_Login
            // 
            this.pnl_Login.BackColor = System.Drawing.Color.DeepPink;
            this.pnl_Login.Controls.Add(this.lbl_Welcome);
            this.pnl_Login.Location = new System.Drawing.Point(615, 1);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(594, 100);
            this.pnl_Login.TabIndex = 1;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Monotype Corsiva", 60F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Welcome.Location = new System.Drawing.Point(93, -9);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(414, 122);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "Wel-Come";
            // 
            // lbl_Ready_To_Login
            // 
            this.lbl_Ready_To_Login.AutoSize = true;
            this.lbl_Ready_To_Login.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ready_To_Login.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Ready_To_Login.Location = new System.Drawing.Point(727, 280);
            this.lbl_Ready_To_Login.Name = "lbl_Ready_To_Login";
            this.lbl_Ready_To_Login.Size = new System.Drawing.Size(377, 65);
            this.lbl_Ready_To_Login.TabIndex = 2;
            this.lbl_Ready_To_Login.Text = "Ready To Login";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Username.Location = new System.Drawing.Point(660, 383);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(186, 44);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Password.Location = new System.Drawing.Point(660, 496);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(179, 44);
            this.lbl_Password.TabIndex = 4;
            this.lbl_Password.Text = "Password";
            // 
            // pb_Login_Icon
            // 
            this.pb_Login_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pb_Login_Icon.Image")));
            this.pb_Login_Icon.Location = new System.Drawing.Point(835, 117);
            this.pb_Login_Icon.Name = "pb_Login_Icon";
            this.pb_Login_Icon.Size = new System.Drawing.Size(153, 150);
            this.pb_Login_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Login_Icon.TabIndex = 5;
            this.pb_Login_Icon.TabStop = false;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(897, 384);
            this.tb_Username.MaxLength = 20;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(289, 41);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.TextChanged += new System.EventHandler(this.tb_Username_TextChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.Enabled = false;
            this.tb_Password.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(897, 500);
            this.tb_Password.MaxLength = 10;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(289, 41);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // btn_Sign_In
            // 
            this.btn_Sign_In.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Sign_In.Enabled = false;
            this.btn_Sign_In.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sign_In.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Sign_In.Location = new System.Drawing.Point(835, 606);
            this.btn_Sign_In.Name = "btn_Sign_In";
            this.btn_Sign_In.Size = new System.Drawing.Size(147, 51);
            this.btn_Sign_In.TabIndex = 3;
            this.btn_Sign_In.Text = "Sign In";
            this.btn_Sign_In.UseVisualStyleBackColor = false;
            this.btn_Sign_In.Click += new System.EventHandler(this.btn_Sign_In_Click);
            // 
            // frm_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1212, 723);
            this.Controls.Add(this.btn_Sign_In);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.pb_Login_Icon);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Ready_To_Login);
            this.Controls.Add(this.pnl_Login);
            this.Controls.Add(this.pb_Login_Form);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_Form)).EndInit();
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Login_Form;
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_Ready_To_Login;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.PictureBox pb_Login_Icon;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Sign_In;
    }
}

