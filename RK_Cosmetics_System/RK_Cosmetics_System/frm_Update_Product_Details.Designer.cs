namespace RK_Cosmetics_System
{
    partial class frm_Update_Product_Details
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.cmb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.tb_Selling_Price = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_Selling_Price = new System.Windows.Forms.Label();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.tb_Product_ID);
            this.panel1.Controls.Add(this.lbl_Product_ID);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Location = new System.Drawing.Point(168, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1441, 85);
            this.panel1.TabIndex = 25;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(366, 20);
            this.tb_Product_ID.MaxLength = 5;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(320, 41);
            this.tb_Product_ID.TabIndex = 1;
            this.tb_Product_ID.TextChanged += new System.EventHandler(this.tb_Product_ID_TextChanged);
            this.tb_Product_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numerics);
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Product_ID.Location = new System.Drawing.Point(64, 20);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(169, 39);
            this.lbl_Product_ID.TabIndex = 38;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Yellow;
            this.btn_Update.Enabled = false;
            this.btn_Update.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(1192, 20);
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
            this.btn_Search.Enabled = false;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(848, 15);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(159, 52);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Product_Name);
            this.groupBox1.Controls.Add(this.tb_Description);
            this.groupBox1.Controls.Add(this.lbl_Description);
            this.groupBox1.Controls.Add(this.cmb_Brand_Name);
            this.groupBox1.Controls.Add(this.tb_Purchase_Price);
            this.groupBox1.Controls.Add(this.tb_Selling_Price);
            this.groupBox1.Controls.Add(this.lbl_Purchase_Price);
            this.groupBox1.Controls.Add(this.lbl_Selling_Price);
            this.groupBox1.Controls.Add(this.lbl_Brand_Name);
            this.groupBox1.Controls.Add(this.lbl_Product_Name);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(75, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1817, 650);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Or Search Product";
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(465, 348);
            this.tb_Product_Name.MaxLength = 50;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(320, 41);
            this.tb_Product_Name.TabIndex = 5;
            // 
            // tb_Description
            // 
            this.tb_Description.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(1336, 364);
            this.tb_Description.MaxLength = 50;
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(320, 208);
            this.tb_Description.TabIndex = 9;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.BackColor = System.Drawing.Color.Pink;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Description.Location = new System.Drawing.Point(1034, 368);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(180, 39);
            this.lbl_Description.TabIndex = 42;
            this.lbl_Description.Text = "Description";
            // 
            // cmb_Brand_Name
            // 
            this.cmb_Brand_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Brand_Name.FormattingEnabled = true;
            this.cmb_Brand_Name.Location = new System.Drawing.Point(465, 236);
            this.cmb_Brand_Name.Name = "cmb_Brand_Name";
            this.cmb_Brand_Name.Size = new System.Drawing.Size(320, 42);
            this.cmb_Brand_Name.TabIndex = 4;
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(465, 466);
            this.tb_Purchase_Price.MaxLength = 5;
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(320, 41);
            this.tb_Purchase_Price.TabIndex = 6;
            this.tb_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numerics);
            // 
            // tb_Selling_Price
            // 
            this.tb_Selling_Price.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Selling_Price.Location = new System.Drawing.Point(1336, 235);
            this.tb_Selling_Price.MaxLength = 5;
            this.tb_Selling_Price.Name = "tb_Selling_Price";
            this.tb_Selling_Price.Size = new System.Drawing.Size(320, 41);
            this.tb_Selling_Price.TabIndex = 7;
            this.tb_Selling_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numerics);
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.BackColor = System.Drawing.Color.Pink;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(144, 466);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(223, 39);
            this.lbl_Purchase_Price.TabIndex = 35;
            this.lbl_Purchase_Price.Text = "Purchase Price";
            // 
            // lbl_Selling_Price
            // 
            this.lbl_Selling_Price.AutoSize = true;
            this.lbl_Selling_Price.BackColor = System.Drawing.Color.Pink;
            this.lbl_Selling_Price.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Selling_Price.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Selling_Price.Location = new System.Drawing.Point(1034, 235);
            this.lbl_Selling_Price.Name = "lbl_Selling_Price";
            this.lbl_Selling_Price.Size = new System.Drawing.Size(190, 39);
            this.lbl_Selling_Price.TabIndex = 34;
            this.lbl_Selling_Price.Text = "Selling Price";
            // 
            // lbl_Brand_Name
            // 
            this.lbl_Brand_Name.AutoSize = true;
            this.lbl_Brand_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Brand_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Brand_Name.Location = new System.Drawing.Point(144, 235);
            this.lbl_Brand_Name.Name = "lbl_Brand_Name";
            this.lbl_Brand_Name.Size = new System.Drawing.Size(196, 39);
            this.lbl_Brand_Name.TabIndex = 37;
            this.lbl_Brand_Name.Text = "Brand Name";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Product_Name.Location = new System.Drawing.Point(144, 348);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(223, 39);
            this.lbl_Product_Name.TabIndex = 36;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(884, 899);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(140, 52);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Update_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 984);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Update_Product_Details";
            this.Text = "Update Product Details";
            this.Load += new System.EventHandler(this.frm_Update_Product_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.ComboBox cmb_Brand_Name;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Selling_Price;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.Label lbl_Selling_Price;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox tb_Product_Name;
    }
}