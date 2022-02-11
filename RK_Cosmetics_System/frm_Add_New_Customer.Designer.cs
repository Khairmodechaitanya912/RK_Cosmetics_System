﻿namespace RK_Cosmetics_System
{
    partial class frm_Add_New_Customer
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
            this.gb_Customer_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.gb_Purchase_Details = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Add_Customer = new System.Windows.Forms.DataGridView();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.tb_GST_Applied = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_GST_Applied = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.tb_Net_Weight = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Net_Weight = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.tb_Final_Bill = new System.Windows.Forms.TextBox();
            this.tb_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Final_Bill = new System.Windows.Forms.Label();
            this.lbl_Bill = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Customer_Details.SuspendLayout();
            this.gb_Purchase_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Add_Customer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Customer_Details
            // 
            this.gb_Customer_Details.Controls.Add(this.dtp_Date);
            this.gb_Customer_Details.Controls.Add(this.tb_Customer_Name);
            this.gb_Customer_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Customer_Details.Controls.Add(this.tb_Customer_ID);
            this.gb_Customer_Details.Controls.Add(this.lbl_Customer_Name);
            this.gb_Customer_Details.Controls.Add(this.lbl_Date);
            this.gb_Customer_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Customer_Details.Controls.Add(this.lbl_Customer_ID);
            this.gb_Customer_Details.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Customer_Details.Location = new System.Drawing.Point(59, 174);
            this.gb_Customer_Details.Name = "gb_Customer_Details";
            this.gb_Customer_Details.Size = new System.Drawing.Size(1900, 200);
            this.gb_Customer_Details.TabIndex = 0;
            this.gb_Customer_Details.TabStop = false;
            this.gb_Customer_Details.Text = "Customer Details";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1381, 56);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(320, 43);
            this.dtp_Date.TabIndex = 3;
            this.dtp_Date.ValueChanged += new System.EventHandler(this.dtp_Date_ValueChanged);
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Name.Location = new System.Drawing.Point(466, 124);
            this.tb_Customer_Name.MaxLength = 50;
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(320, 41);
            this.tb_Customer_Name.TabIndex = 2;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(1381, 124);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(320, 41);
            this.tb_Mobile_No.TabIndex = 4;
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Enabled = false;
            this.tb_Customer_ID.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(466, 56);
            this.tb_Customer_ID.MaxLength = 5;
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(320, 41);
            this.tb_Customer_ID.TabIndex = 1;
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Customer_Name.Location = new System.Drawing.Point(137, 124);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(250, 39);
            this.lbl_Customer_Name.TabIndex = 3;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Date.Location = new System.Drawing.Point(1140, 56);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(85, 39);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.Pink;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(1140, 124);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(169, 39);
            this.lbl_Mobile_No.TabIndex = 1;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Customer_ID.Location = new System.Drawing.Point(137, 56);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(196, 39);
            this.lbl_Customer_ID.TabIndex = 0;
            this.lbl_Customer_ID.Text = "Customer ID";
            // 
            // gb_Purchase_Details
            // 
            this.gb_Purchase_Details.Controls.Add(this.btn_Add);
            this.gb_Purchase_Details.Controls.Add(this.dgv_Add_Customer);
            this.gb_Purchase_Details.Controls.Add(this.cmb_Product_Name);
            this.gb_Purchase_Details.Controls.Add(this.cmb_Brand_Name);
            this.gb_Purchase_Details.Controls.Add(this.tb_GST_Applied);
            this.gb_Purchase_Details.Controls.Add(this.tb_Price);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Price);
            this.gb_Purchase_Details.Controls.Add(this.lbl_GST_Applied);
            this.gb_Purchase_Details.Controls.Add(this.tb_Quantity);
            this.gb_Purchase_Details.Controls.Add(this.tb_Net_Weight);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Quantity);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Net_Weight);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Brand_Name);
            this.gb_Purchase_Details.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Purchase_Details.Location = new System.Drawing.Point(59, 380);
            this.gb_Purchase_Details.Name = "gb_Purchase_Details";
            this.gb_Purchase_Details.Size = new System.Drawing.Size(1900, 392);
            this.gb_Purchase_Details.TabIndex = 1;
            this.gb_Purchase_Details.TabStop = false;
            this.gb_Purchase_Details.Text = "Purchase Details";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Yellow;
            this.btn_Add.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(792, 317);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(97, 52);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_Add_Customer
            // 
            this.dgv_Add_Customer.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgv_Add_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Add_Customer.Location = new System.Drawing.Point(941, 51);
            this.dgv_Add_Customer.Name = "dgv_Add_Customer";
            this.dgv_Add_Customer.RowTemplate.Height = 24;
            this.dgv_Add_Customer.Size = new System.Drawing.Size(912, 317);
            this.dgv_Add_Customer.TabIndex = 17;
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(427, 107);
            this.cmb_Product_Name.MaxLength = 50;
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(320, 42);
            this.cmb_Product_Name.TabIndex = 6;
            // 
            // cmb_Brand_Name
            // 
            this.cmb_Brand_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Brand_Name.FormattingEnabled = true;
            this.cmb_Brand_Name.Location = new System.Drawing.Point(428, 51);
            this.cmb_Brand_Name.MaxLength = 20;
            this.cmb_Brand_Name.Name = "cmb_Brand_Name";
            this.cmb_Brand_Name.Size = new System.Drawing.Size(320, 42);
            this.cmb_Brand_Name.TabIndex = 5;
            this.cmb_Brand_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Brand_Name_SelectedIndexChanged);
            // 
            // tb_GST_Applied
            // 
            this.tb_GST_Applied.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST_Applied.Location = new System.Drawing.Point(427, 275);
            this.tb_GST_Applied.MaxLength = 5;
            this.tb_GST_Applied.Name = "tb_GST_Applied";
            this.tb_GST_Applied.Size = new System.Drawing.Size(320, 41);
            this.tb_GST_Applied.TabIndex = 9;
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(427, 330);
            this.tb_Price.MaxLength = 5;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(320, 41);
            this.tb_Price.TabIndex = 10;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.Pink;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Price.Location = new System.Drawing.Point(137, 330);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(86, 39);
            this.lbl_Price.TabIndex = 12;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_GST_Applied
            // 
            this.lbl_GST_Applied.AutoSize = true;
            this.lbl_GST_Applied.BackColor = System.Drawing.Color.Pink;
            this.lbl_GST_Applied.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST_Applied.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_GST_Applied.Location = new System.Drawing.Point(138, 275);
            this.lbl_GST_Applied.Name = "lbl_GST_Applied";
            this.lbl_GST_Applied.Size = new System.Drawing.Size(193, 39);
            this.lbl_GST_Applied.TabIndex = 11;
            this.lbl_GST_Applied.Text = "GST Applied";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(428, 218);
            this.tb_Quantity.MaxLength = 5;
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(320, 41);
            this.tb_Quantity.TabIndex = 8;
            // 
            // tb_Net_Weight
            // 
            this.tb_Net_Weight.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Net_Weight.Location = new System.Drawing.Point(427, 163);
            this.tb_Net_Weight.MaxLength = 20;
            this.tb_Net_Weight.Name = "tb_Net_Weight";
            this.tb_Net_Weight.Size = new System.Drawing.Size(320, 41);
            this.tb_Net_Weight.TabIndex = 7;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.BackColor = System.Drawing.Color.Pink;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Quantity.Location = new System.Drawing.Point(138, 218);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(140, 39);
            this.lbl_Quantity.TabIndex = 8;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Net_Weight
            // 
            this.lbl_Net_Weight.AutoSize = true;
            this.lbl_Net_Weight.BackColor = System.Drawing.Color.Pink;
            this.lbl_Net_Weight.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Net_Weight.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Net_Weight.Location = new System.Drawing.Point(137, 163);
            this.lbl_Net_Weight.Name = "lbl_Net_Weight";
            this.lbl_Net_Weight.Size = new System.Drawing.Size(182, 39);
            this.lbl_Net_Weight.TabIndex = 7;
            this.lbl_Net_Weight.Text = "Net Weight";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Product_Name.Location = new System.Drawing.Point(137, 106);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(223, 39);
            this.lbl_Product_Name.TabIndex = 3;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Brand_Name
            // 
            this.lbl_Brand_Name.AutoSize = true;
            this.lbl_Brand_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Brand_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Brand_Name.Location = new System.Drawing.Point(137, 50);
            this.lbl_Brand_Name.Name = "lbl_Brand_Name";
            this.lbl_Brand_Name.Size = new System.Drawing.Size(196, 39);
            this.lbl_Brand_Name.TabIndex = 0;
            this.lbl_Brand_Name.Text = "Brand Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Discount);
            this.groupBox1.Controls.Add(this.lbl_Discount);
            this.groupBox1.Controls.Add(this.tb_Final_Bill);
            this.groupBox1.Controls.Add(this.tb_Bill);
            this.groupBox1.Controls.Add(this.lbl_Final_Bill);
            this.groupBox1.Controls.Add(this.lbl_Bill);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 778);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1900, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // tb_Discount
            // 
            this.tb_Discount.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Discount.Location = new System.Drawing.Point(917, 36);
            this.tb_Discount.MaxLength = 5;
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(320, 41);
            this.tb_Discount.TabIndex = 13;
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.BackColor = System.Drawing.Color.Pink;
            this.lbl_Discount.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Discount.Location = new System.Drawing.Point(737, 37);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(143, 39);
            this.lbl_Discount.TabIndex = 6;
            this.lbl_Discount.Text = "Discount";
            // 
            // tb_Final_Bill
            // 
            this.tb_Final_Bill.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Final_Bill.Location = new System.Drawing.Point(1533, 35);
            this.tb_Final_Bill.MaxLength = 10;
            this.tb_Final_Bill.Name = "tb_Final_Bill";
            this.tb_Final_Bill.Size = new System.Drawing.Size(320, 41);
            this.tb_Final_Bill.TabIndex = 14;
            // 
            // tb_Bill
            // 
            this.tb_Bill.Enabled = false;
            this.tb_Bill.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bill.Location = new System.Drawing.Point(245, 36);
            this.tb_Bill.MaxLength = 10;
            this.tb_Bill.Name = "tb_Bill";
            this.tb_Bill.Size = new System.Drawing.Size(320, 41);
            this.tb_Bill.TabIndex = 12;
            // 
            // lbl_Final_Bill
            // 
            this.lbl_Final_Bill.AutoSize = true;
            this.lbl_Final_Bill.BackColor = System.Drawing.Color.Pink;
            this.lbl_Final_Bill.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Final_Bill.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Final_Bill.Location = new System.Drawing.Point(1343, 37);
            this.lbl_Final_Bill.Name = "lbl_Final_Bill";
            this.lbl_Final_Bill.Size = new System.Drawing.Size(136, 39);
            this.lbl_Final_Bill.TabIndex = 2;
            this.lbl_Final_Bill.Text = "Final Bill";
            // 
            // lbl_Bill
            // 
            this.lbl_Bill.AutoSize = true;
            this.lbl_Bill.BackColor = System.Drawing.Color.Pink;
            this.lbl_Bill.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Bill.Location = new System.Drawing.Point(129, 38);
            this.lbl_Bill.Name = "lbl_Bill";
            this.lbl_Bill.Size = new System.Drawing.Size(60, 39);
            this.lbl_Bill.TabIndex = 0;
            this.lbl_Bill.Text = "Bill";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Yellow;
            this.btn_Save.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(525, 900);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(97, 52);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1424, 900);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(140, 52);
            this.btn_Refresh.TabIndex = 16;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Add_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 973);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Purchase_Details);
            this.Controls.Add(this.gb_Customer_Details);
            this.Name = "frm_Add_New_Customer";
            this.Text = "Add New Customer";
            this.Load += new System.EventHandler(this.frm_Add_New_Customer_Load);
            this.gb_Customer_Details.ResumeLayout(false);
            this.gb_Customer_Details.PerformLayout();
            this.gb_Purchase_Details.ResumeLayout(false);
            this.gb_Purchase_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Add_Customer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Customer_Details;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_Customer_Name;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.GroupBox gb_Purchase_Details;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Brand_Name;
        private System.Windows.Forms.TextBox tb_GST_Applied;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_GST_Applied;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.TextBox tb_Net_Weight;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Net_Weight;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.DataGridView dgv_Add_Customer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Bill;
        private System.Windows.Forms.Label lbl_Final_Bill;
        private System.Windows.Forms.Label lbl_Bill;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.TextBox tb_Final_Bill;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
    }
}