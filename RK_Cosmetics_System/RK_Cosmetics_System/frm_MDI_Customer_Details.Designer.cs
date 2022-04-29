namespace RK_Cosmetics_System
{
    partial class frm_MDI_Customer_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MDI_Customer_Details));
            this.pnl_Customer_Details = new System.Windows.Forms.Panel();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_Customer_Details = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ViewCustomerDetailstoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_Customer_Details.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Customer_Details
            // 
            this.pnl_Customer_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Customer_Details.BackColor = System.Drawing.Color.DeepPink;
            this.pnl_Customer_Details.Controls.Add(this.btn_Log_Out);
            this.pnl_Customer_Details.Controls.Add(this.btn_Back);
            this.pnl_Customer_Details.Controls.Add(this.btn_LogOut);
            this.pnl_Customer_Details.Controls.Add(this.lbl_Customer_Details);
            this.pnl_Customer_Details.Location = new System.Drawing.Point(-8, 3);
            this.pnl_Customer_Details.Name = "pnl_Customer_Details";
            this.pnl_Customer_Details.Size = new System.Drawing.Size(2822, 117);
            this.pnl_Customer_Details.TabIndex = 2;
            this.pnl_Customer_Details.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Login_Paint);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Log_Out.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Log_Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Log_Out.BackgroundImage")));
            this.btn_Log_Out.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.Location = new System.Drawing.Point(1693, 36);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(153, 53);
            this.btn_Log_Out.TabIndex = 2;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(20, 36);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(153, 53);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LogOut.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_LogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LogOut.BackgroundImage")));
            this.btn_LogOut.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.Location = new System.Drawing.Point(2648, 36);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(153, 53);
            this.btn_LogOut.TabIndex = 9;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            // 
            // lbl_Customer_Details
            // 
            this.lbl_Customer_Details.AutoSize = true;
            this.lbl_Customer_Details.Font = new System.Drawing.Font("Comic Sans MS", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Details.ForeColor = System.Drawing.Color.White;
            this.lbl_Customer_Details.Location = new System.Drawing.Point(553, -21);
            this.lbl_Customer_Details.Name = "lbl_Customer_Details";
            this.lbl_Customer_Details.Size = new System.Drawing.Size(883, 140);
            this.lbl_Customer_Details.TabIndex = 0;
            this.lbl_Customer_Details.Text = "Customer Details";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(447, 122);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(311, 49);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "Add New Customer";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(303, 45);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewCustomerDetailstoolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(1337, 121);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(353, 49);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "Add New Customer";
            // 
            // ViewCustomerDetailstoolStripMenuItem1
            // 
            this.ViewCustomerDetailstoolStripMenuItem1.Name = "ViewCustomerDetailstoolStripMenuItem1";
            this.ViewCustomerDetailstoolStripMenuItem1.Size = new System.Drawing.Size(345, 45);
            this.ViewCustomerDetailstoolStripMenuItem1.Text = "View Customer Details";
            this.ViewCustomerDetailstoolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1271, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // frm_MDI_Customer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1850, 739);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.pnl_Customer_Details);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_MDI_Customer_Details";
            this.Text = "Customer Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_MDI_Customer_Details_Load);
            this.pnl_Customer_Details.ResumeLayout(false);
            this.pnl_Customer_Details.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Customer_Details;
        private System.Windows.Forms.Label lbl_Customer_Details;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ViewCustomerDetailstoolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}