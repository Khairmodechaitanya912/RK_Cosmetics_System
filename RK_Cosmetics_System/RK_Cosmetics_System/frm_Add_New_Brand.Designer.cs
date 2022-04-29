namespace RK_Cosmetics_System
{
    partial class frm_Add_New_Brand
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
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rbtn_Not_In_Use = new System.Windows.Forms.RadioButton();
            this.rbtn_In_Use = new System.Windows.Forms.RadioButton();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.tb_Brand_Name = new System.Windows.Forms.TextBox();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.tb_Brand_ID = new System.Windows.Forms.TextBox();
            this.lbl_Brand_ID = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Brand_Details.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Brand_Details
            // 
            this.gb_Brand_Details.Controls.Add(this.gb_Gender);
            this.gb_Brand_Details.Controls.Add(this.lbl_Status);
            this.gb_Brand_Details.Controls.Add(this.tb_Brand_Name);
            this.gb_Brand_Details.Controls.Add(this.lbl_Brand_Name);
            this.gb_Brand_Details.Controls.Add(this.tb_Brand_ID);
            this.gb_Brand_Details.Controls.Add(this.lbl_Brand_ID);
            this.gb_Brand_Details.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.gb_Brand_Details.Location = new System.Drawing.Point(448, 331);
            this.gb_Brand_Details.Name = "gb_Brand_Details";
            this.gb_Brand_Details.Size = new System.Drawing.Size(1062, 415);
            this.gb_Brand_Details.TabIndex = 1;
            this.gb_Brand_Details.TabStop = false;
            this.gb_Brand_Details.Text = "Brand Details";
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rbtn_Not_In_Use);
            this.gb_Gender.Controls.Add(this.rbtn_In_Use);
            this.gb_Gender.Location = new System.Drawing.Point(558, 300);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(320, 60);
            this.gb_Gender.TabIndex = 3;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Enter += new System.EventHandler(this.gb_Gender_Enter);
            // 
            // rbtn_Not_In_Use
            // 
            this.rbtn_Not_In_Use.AutoSize = true;
            this.rbtn_Not_In_Use.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Bold);
            this.rbtn_Not_In_Use.Location = new System.Drawing.Point(174, 23);
            this.rbtn_Not_In_Use.Name = "rbtn_Not_In_Use";
            this.rbtn_Not_In_Use.Size = new System.Drawing.Size(145, 32);
            this.rbtn_Not_In_Use.TabIndex = 5;
            this.rbtn_Not_In_Use.TabStop = true;
            this.rbtn_Not_In_Use.Text = "Not In Use ";
            this.rbtn_Not_In_Use.UseVisualStyleBackColor = true;
            // 
            // rbtn_In_Use
            // 
            this.rbtn_In_Use.AutoSize = true;
            this.rbtn_In_Use.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Bold);
            this.rbtn_In_Use.Location = new System.Drawing.Point(44, 23);
            this.rbtn_In_Use.Name = "rbtn_In_Use";
            this.rbtn_In_Use.Size = new System.Drawing.Size(102, 32);
            this.rbtn_In_Use.TabIndex = 4;
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
            this.tb_Brand_Name.TextChanged += new System.EventHandler(this.tb_Brand_Name_TextChanged);
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
            this.tb_Brand_ID.Enabled = false;
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
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Yellow;
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(967, 763);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(97, 52);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_New_Brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1619, 840);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Brand_Details);
            this.Name = "frm_Add_New_Brand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Brand";
            this.Load += new System.EventHandler(this.frm_Add_New_Brand_Load);
            this.gb_Brand_Details.ResumeLayout(false);
            this.gb_Brand_Details.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Brand_Details;
        private System.Windows.Forms.TextBox tb_Brand_Name;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.TextBox tb_Brand_ID;
        private System.Windows.Forms.Label lbl_Brand_ID;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rbtn_Not_In_Use;
        private System.Windows.Forms.RadioButton rbtn_In_Use;
        private System.Windows.Forms.Button btn_Save;

    }
}