namespace RK_Cosmetics_System
{
    partial class frm_Add_Stock
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
            this.gb_Stock_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Expiry_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Expiry_Date = new System.Windows.Forms.Label();
            this.pnl_Stock_Details = new System.Windows.Forms.Panel();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.cmb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.dtp_Mfg_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Current_Stock_Quantity = new System.Windows.Forms.Label();
            this.lbl_Mfg_Date = new System.Windows.Forms.Label();
            this.lbl_New_Stock_Added = new System.Windows.Forms.Label();
            this.tb_Current_Stock_Quantity = new System.Windows.Forms.TextBox();
            this.tb_New_Stock_Added = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Stock_Details.SuspendLayout();
            this.pnl_Stock_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Stock_Details
            // 
            this.gb_Stock_Details.Controls.Add(this.dtp_Expiry_Date);
            this.gb_Stock_Details.Controls.Add(this.lbl_Expiry_Date);
            this.gb_Stock_Details.Controls.Add(this.pnl_Stock_Details);
            this.gb_Stock_Details.Controls.Add(this.dtp_Mfg_Date);
            this.gb_Stock_Details.Controls.Add(this.lbl_Current_Stock_Quantity);
            this.gb_Stock_Details.Controls.Add(this.lbl_Mfg_Date);
            this.gb_Stock_Details.Controls.Add(this.lbl_New_Stock_Added);
            this.gb_Stock_Details.Controls.Add(this.tb_Current_Stock_Quantity);
            this.gb_Stock_Details.Controls.Add(this.tb_New_Stock_Added);
            this.gb_Stock_Details.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.gb_Stock_Details.Location = new System.Drawing.Point(177, 202);
            this.gb_Stock_Details.Name = "gb_Stock_Details";
            this.gb_Stock_Details.Size = new System.Drawing.Size(1721, 622);
            this.gb_Stock_Details.TabIndex = 0;
            this.gb_Stock_Details.TabStop = false;
            this.gb_Stock_Details.Text = "Stock Details";
            // 
            // dtp_Expiry_Date
            // 
            this.dtp_Expiry_Date.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Expiry_Date.Location = new System.Drawing.Point(932, 531);
            this.dtp_Expiry_Date.Name = "dtp_Expiry_Date";
            this.dtp_Expiry_Date.Size = new System.Drawing.Size(320, 43);
            this.dtp_Expiry_Date.TabIndex = 6;
            // 
            // lbl_Expiry_Date
            // 
            this.lbl_Expiry_Date.AutoSize = true;
            this.lbl_Expiry_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_Expiry_Date.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expiry_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Expiry_Date.Location = new System.Drawing.Point(376, 535);
            this.lbl_Expiry_Date.Name = "lbl_Expiry_Date";
            this.lbl_Expiry_Date.Size = new System.Drawing.Size(180, 39);
            this.lbl_Expiry_Date.TabIndex = 46;
            this.lbl_Expiry_Date.Text = "Expiry Date";
            // 
            // pnl_Stock_Details
            // 
            this.pnl_Stock_Details.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Stock_Details.Controls.Add(this.tb_Product_ID);
            this.pnl_Stock_Details.Controls.Add(this.dtp_Date);
            this.pnl_Stock_Details.Controls.Add(this.lbl_Date);
            this.pnl_Stock_Details.Controls.Add(this.cmb_Brand_Name);
            this.pnl_Stock_Details.Controls.Add(this.lbl_Product_ID);
            this.pnl_Stock_Details.Controls.Add(this.cmb_Product_Name);
            this.pnl_Stock_Details.Controls.Add(this.lbl_Brand_Name);
            this.pnl_Stock_Details.Controls.Add(this.lbl_Product_Name);
            this.pnl_Stock_Details.Location = new System.Drawing.Point(167, 71);
            this.pnl_Stock_Details.Name = "pnl_Stock_Details";
            this.pnl_Stock_Details.Size = new System.Drawing.Size(1455, 203);
            this.pnl_Stock_Details.TabIndex = 0;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Enabled = false;
            this.tb_Product_ID.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(1069, 121);
            this.tb_Product_ID.MaxLength = 5;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(320, 41);
            this.tb_Product_ID.TabIndex = 5;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1069, 28);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(320, 43);
            this.dtp_Date.TabIndex = 4;
            this.dtp_Date.ValueChanged += new System.EventHandler(this.dtp_Date_ValueChanged);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Date.Location = new System.Drawing.Point(841, 31);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(85, 39);
            this.lbl_Date.TabIndex = 40;
            this.lbl_Date.Text = "Date";
            // 
            // cmb_Brand_Name
            // 
            this.cmb_Brand_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Brand_Name.FormattingEnabled = true;
            this.cmb_Brand_Name.Location = new System.Drawing.Point(344, 34);
            this.cmb_Brand_Name.Name = "cmb_Brand_Name";
            this.cmb_Brand_Name.Size = new System.Drawing.Size(320, 42);
            this.cmb_Brand_Name.TabIndex = 1;
            this.cmb_Brand_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Brand_Name_SelectedIndexChanged);
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Product_ID.Location = new System.Drawing.Point(841, 120);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(169, 39);
            this.lbl_Product_ID.TabIndex = 34;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(344, 121);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(320, 42);
            this.cmb_Product_Name.TabIndex = 2;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // lbl_Brand_Name
            // 
            this.lbl_Brand_Name.AutoSize = true;
            this.lbl_Brand_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Brand_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Brand_Name.Location = new System.Drawing.Point(57, 32);
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
            this.lbl_Product_Name.Location = new System.Drawing.Point(57, 123);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(223, 39);
            this.lbl_Product_Name.TabIndex = 36;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // dtp_Mfg_Date
            // 
            this.dtp_Mfg_Date.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Mfg_Date.Location = new System.Drawing.Point(932, 461);
            this.dtp_Mfg_Date.Name = "dtp_Mfg_Date";
            this.dtp_Mfg_Date.Size = new System.Drawing.Size(320, 43);
            this.dtp_Mfg_Date.TabIndex = 3;
            // 
            // lbl_Current_Stock_Quantity
            // 
            this.lbl_Current_Stock_Quantity.AutoSize = true;
            this.lbl_Current_Stock_Quantity.BackColor = System.Drawing.Color.Pink;
            this.lbl_Current_Stock_Quantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_Stock_Quantity.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Current_Stock_Quantity.Location = new System.Drawing.Point(376, 317);
            this.lbl_Current_Stock_Quantity.Name = "lbl_Current_Stock_Quantity";
            this.lbl_Current_Stock_Quantity.Size = new System.Drawing.Size(342, 39);
            this.lbl_Current_Stock_Quantity.TabIndex = 36;
            this.lbl_Current_Stock_Quantity.Text = "Current Stock Quantity";
            // 
            // lbl_Mfg_Date
            // 
            this.lbl_Mfg_Date.AutoSize = true;
            this.lbl_Mfg_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_Mfg_Date.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mfg_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Mfg_Date.Location = new System.Drawing.Point(375, 465);
            this.lbl_Mfg_Date.Name = "lbl_Mfg_Date";
            this.lbl_Mfg_Date.Size = new System.Drawing.Size(303, 39);
            this.lbl_Mfg_Date.TabIndex = 45;
            this.lbl_Mfg_Date.Text = "Manufacturing Date";
            // 
            // lbl_New_Stock_Added
            // 
            this.lbl_New_Stock_Added.AutoSize = true;
            this.lbl_New_Stock_Added.BackColor = System.Drawing.Color.Pink;
            this.lbl_New_Stock_Added.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New_Stock_Added.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_New_Stock_Added.Location = new System.Drawing.Point(376, 392);
            this.lbl_New_Stock_Added.Name = "lbl_New_Stock_Added";
            this.lbl_New_Stock_Added.Size = new System.Drawing.Size(273, 39);
            this.lbl_New_Stock_Added.TabIndex = 34;
            this.lbl_New_Stock_Added.Text = "New Stock Added";
            // 
            // tb_Current_Stock_Quantity
            // 
            this.tb_Current_Stock_Quantity.Enabled = false;
            this.tb_Current_Stock_Quantity.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Stock_Quantity.Location = new System.Drawing.Point(932, 313);
            this.tb_Current_Stock_Quantity.MaxLength = 5;
            this.tb_Current_Stock_Quantity.Name = "tb_Current_Stock_Quantity";
            this.tb_Current_Stock_Quantity.Size = new System.Drawing.Size(320, 41);
            this.tb_Current_Stock_Quantity.TabIndex = 7;
            // 
            // tb_New_Stock_Added
            // 
            this.tb_New_Stock_Added.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_New_Stock_Added.Location = new System.Drawing.Point(932, 392);
            this.tb_New_Stock_Added.MaxLength = 5;
            this.tb_New_Stock_Added.Name = "tb_New_Stock_Added";
            this.tb_New_Stock_Added.Size = new System.Drawing.Size(320, 41);
            this.tb_New_Stock_Added.TabIndex = 8;
            this.tb_New_Stock_Added.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Yellow;
            this.btn_Submit.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(685, 857);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(157, 52);
            this.btn_Submit.TabIndex = 9;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1288, 857);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(141, 52);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Add_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 984);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Stock_Details);
            this.Name = "frm_Add_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Stock";
            this.Load += new System.EventHandler(this.frm_Add_Stock_Load);
            this.gb_Stock_Details.ResumeLayout(false);
            this.gb_Stock_Details.PerformLayout();
            this.pnl_Stock_Details.ResumeLayout(false);
            this.pnl_Stock_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Stock_Details;
        private System.Windows.Forms.Panel pnl_Stock_Details;
        private System.Windows.Forms.ComboBox cmb_Brand_Name;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.TextBox tb_New_Stock_Added;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Current_Stock_Quantity;
        private System.Windows.Forms.Label lbl_New_Stock_Added;
        private System.Windows.Forms.TextBox tb_Current_Stock_Quantity;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.DateTimePicker dtp_Expiry_Date;
        private System.Windows.Forms.DateTimePicker dtp_Mfg_Date;
        private System.Windows.Forms.Label lbl_Expiry_Date;
        private System.Windows.Forms.Label lbl_Mfg_Date;
    }
}