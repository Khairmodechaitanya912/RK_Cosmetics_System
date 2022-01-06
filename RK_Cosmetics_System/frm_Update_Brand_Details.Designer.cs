namespace RK_Cosmetics_System
{
    partial class frm_Update_Brand_Details
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
            this.gb_Brand_Details = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rbtn_In_Not_In_Use = new System.Windows.Forms.RadioButton();
            this.rbtn_In_Use = new System.Windows.Forms.RadioButton();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.tb_Brand_Name = new System.Windows.Forms.TextBox();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.tb_Brand_ID = new System.Windows.Forms.TextBox();
            this.lbl_Brand_ID = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.gb_Brand_Details.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Brand_Details
            // 
            this.gb_Brand_Details.Controls.Add(this.btn_Search);
            this.gb_Brand_Details.Controls.Add(this.gb_Gender);
            this.gb_Brand_Details.Controls.Add(this.lbl_Status);
            this.gb_Brand_Details.Controls.Add(this.tb_Brand_Name);
            this.gb_Brand_Details.Controls.Add(this.lbl_Brand_Name);
            this.gb_Brand_Details.Controls.Add(this.tb_Brand_ID);
            this.gb_Brand_Details.Controls.Add(this.lbl_Brand_ID);
            this.gb_Brand_Details.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.gb_Brand_Details.Location = new System.Drawing.Point(368, 322);
            this.gb_Brand_Details.Name = "gb_Brand_Details";
            this.gb_Brand_Details.Size = new System.Drawing.Size(1223, 415);
            this.gb_Brand_Details.TabIndex = 2;
            this.gb_Brand_Details.TabStop = false;
            this.gb_Brand_Details.Text = "Brand Details";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1001, 90);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(159, 52);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rbtn_In_Not_In_Use);
            this.gb_Gender.Controls.Add(this.rbtn_In_Use);
            this.gb_Gender.Location = new System.Drawing.Point(558, 300);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(320, 60);
            this.gb_Gender.TabIndex = 3;
            this.gb_Gender.TabStop = false;
            // 
            // rbtn_In_Not_In_Use
            // 
            this.rbtn_In_Not_In_Use.AutoSize = true;
            this.rbtn_In_Not_In_Use.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Bold);
            this.rbtn_In_Not_In_Use.Location = new System.Drawing.Point(174, 23);
            this.rbtn_In_Not_In_Use.Name = "rbtn_In_Not_In_Use";
            this.rbtn_In_Not_In_Use.Size = new System.Drawing.Size(145, 32);
            this.rbtn_In_Not_In_Use.TabIndex = 1;
            this.rbtn_In_Not_In_Use.TabStop = true;
            this.rbtn_In_Not_In_Use.Text = "Not In Use ";
            this.rbtn_In_Not_In_Use.UseVisualStyleBackColor = true;
            // 
            // rbtn_In_Use
            // 
            this.rbtn_In_Use.AutoSize = true;
            this.rbtn_In_Use.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Bold);
            this.rbtn_In_Use.Location = new System.Drawing.Point(44, 23);
            this.rbtn_In_Use.Name = "rbtn_In_Use";
            this.rbtn_In_Use.Size = new System.Drawing.Size(102, 32);
            this.rbtn_In_Use.TabIndex = 0;
            this.rbtn_In_Use.TabStop = true;
            this.rbtn_In_Use.Text = "In Use ";
            this.rbtn_In_Use.UseVisualStyleBackColor = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.Pink;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Status.Location = new System.Drawing.Point(245, 321);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(105, 39);
            this.lbl_Status.TabIndex = 29;
            this.lbl_Status.Text = "Status";
            // 
            // tb_Brand_Name
            // 
            this.tb_Brand_Name.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Brand_Name.Location = new System.Drawing.Point(558, 205);
            this.tb_Brand_Name.MaxLength = 20;
            this.tb_Brand_Name.Name = "tb_Brand_Name";
            this.tb_Brand_Name.Size = new System.Drawing.Size(320, 41);
            this.tb_Brand_Name.TabIndex = 2;
            // 
            // lbl_Brand_Name
            // 
            this.lbl_Brand_Name.AutoSize = true;
            this.lbl_Brand_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Brand_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Brand_Name.Location = new System.Drawing.Point(245, 207);
            this.lbl_Brand_Name.Name = "lbl_Brand_Name";
            this.lbl_Brand_Name.Size = new System.Drawing.Size(196, 39);
            this.lbl_Brand_Name.TabIndex = 27;
            this.lbl_Brand_Name.Text = "Brand Name";
            // 
            // tb_Brand_ID
            // 
            this.tb_Brand_ID.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Brand_ID.Location = new System.Drawing.Point(558, 101);
            this.tb_Brand_ID.MaxLength = 5;
            this.tb_Brand_ID.Name = "tb_Brand_ID";
            this.tb_Brand_ID.Size = new System.Drawing.Size(320, 41);
            this.tb_Brand_ID.TabIndex = 1;
            // 
            // lbl_Brand_ID
            // 
            this.lbl_Brand_ID.AutoSize = true;
            this.lbl_Brand_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Brand_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Brand_ID.Location = new System.Drawing.Point(245, 103);
            this.lbl_Brand_ID.Name = "lbl_Brand_ID";
            this.lbl_Brand_ID.Size = new System.Drawing.Size(142, 39);
            this.lbl_Brand_ID.TabIndex = 25;
            this.lbl_Brand_ID.Text = "Brand ID";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1280, 778);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(140, 52);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Yellow;
            this.btn_Update.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(651, 778);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(140, 52);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // frm_Update_Brand_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1619, 840);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Brand_Details);
            this.Name = "frm_Update_Brand_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Update_Brand_Details";
            this.Load += new System.EventHandler(this.frm_Update_Brand_Details_Load);
            this.gb_Brand_Details.ResumeLayout(false);
            this.gb_Brand_Details.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Brand_Details;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rbtn_In_Not_In_Use;
        private System.Windows.Forms.RadioButton rbtn_In_Use;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TextBox tb_Brand_Name;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.TextBox tb_Brand_ID;
        private System.Windows.Forms.Label lbl_Brand_ID;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
    }
}