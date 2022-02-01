namespace RK_Cosmetics_System
{
    partial class frm_View_Stock_Details
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
            this.components = new System.ComponentModel.Container();
            this.pnl_View_Stock_DEtails = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.gb_Stock_Details = new System.Windows.Forms.GroupBox();
            this.dgv_View_Stock_Details = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dB_RK_Cosmetics_SystemDataSet4 = new RK_Cosmetics_System.DB_RK_Cosmetics_SystemDataSet4();
            this.productStockDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_Stock_DetailsTableAdapter = new RK_Cosmetics_System.DB_RK_Cosmetics_SystemDataSet4TableAdapters.Product_Stock_DetailsTableAdapter();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfgDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_View_Stock_DEtails.SuspendLayout();
            this.gb_Stock_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Stock_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RK_Cosmetics_SystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStockDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_View_Stock_DEtails
            // 
            this.pnl_View_Stock_DEtails.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_View_Stock_DEtails.Controls.Add(this.btn_Search);
            this.pnl_View_Stock_DEtails.Controls.Add(this.cmb_Brand_Name);
            this.pnl_View_Stock_DEtails.Controls.Add(this.cmb_Product_Name);
            this.pnl_View_Stock_DEtails.Controls.Add(this.lbl_Brand_Name);
            this.pnl_View_Stock_DEtails.Controls.Add(this.lbl_Product_Name);
            this.pnl_View_Stock_DEtails.Location = new System.Drawing.Point(263, 217);
            this.pnl_View_Stock_DEtails.Name = "pnl_View_Stock_DEtails";
            this.pnl_View_Stock_DEtails.Size = new System.Drawing.Size(1455, 198);
            this.pnl_View_Stock_DEtails.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search.Enabled = false;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1173, 55);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(157, 52);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_Brand_Name
            // 
            this.cmb_Brand_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Brand_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Brand_Name.FormattingEnabled = true;
            this.cmb_Brand_Name.Location = new System.Drawing.Point(685, 27);
            this.cmb_Brand_Name.Name = "cmb_Brand_Name";
            this.cmb_Brand_Name.Size = new System.Drawing.Size(320, 39);
            this.cmb_Brand_Name.TabIndex = 1;
            this.cmb_Brand_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Brand_Name_SelectedIndexChanged);
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(685, 106);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(320, 39);
            this.cmb_Product_Name.TabIndex = 2;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // lbl_Brand_Name
            // 
            this.lbl_Brand_Name.AutoSize = true;
            this.lbl_Brand_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Brand_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Brand_Name.Location = new System.Drawing.Point(398, 25);
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
            this.lbl_Product_Name.Location = new System.Drawing.Point(398, 108);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(223, 39);
            this.lbl_Product_Name.TabIndex = 36;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // gb_Stock_Details
            // 
            this.gb_Stock_Details.Controls.Add(this.dgv_View_Stock_Details);
            this.gb_Stock_Details.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.gb_Stock_Details.Location = new System.Drawing.Point(177, 421);
            this.gb_Stock_Details.Name = "gb_Stock_Details";
            this.gb_Stock_Details.Size = new System.Drawing.Size(1750, 463);
            this.gb_Stock_Details.TabIndex = 2;
            this.gb_Stock_Details.TabStop = false;
            this.gb_Stock_Details.Text = "Stock Details";
            // 
            // dgv_View_Stock_Details
            // 
            this.dgv_View_Stock_Details.AllowUserToAddRows = false;
            this.dgv_View_Stock_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Stock_Details.AutoGenerateColumns = false;
            this.dgv_View_Stock_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Stock_Details.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgv_View_Stock_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Stock_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.mfgDateDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.currentStockDataGridViewTextBoxColumn,
            this.newStockDataGridViewTextBoxColumn});
            this.dgv_View_Stock_Details.DataSource = this.productStockDetailsBindingSource;
            this.dgv_View_Stock_Details.Location = new System.Drawing.Point(39, 67);
            this.dgv_View_Stock_Details.Name = "dgv_View_Stock_Details";
            this.dgv_View_Stock_Details.ReadOnly = true;
            this.dgv_View_Stock_Details.RowTemplate.Height = 24;
            this.dgv_View_Stock_Details.Size = new System.Drawing.Size(1609, 379);
            this.dgv_View_Stock_Details.TabIndex = 21;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(965, 906);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(157, 52);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dB_RK_Cosmetics_SystemDataSet4
            // 
            this.dB_RK_Cosmetics_SystemDataSet4.DataSetName = "DB_RK_Cosmetics_SystemDataSet4";
            this.dB_RK_Cosmetics_SystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productStockDetailsBindingSource
            // 
            this.productStockDetailsBindingSource.DataMember = "Product_Stock_Details";
            this.productStockDetailsBindingSource.DataSource = this.dB_RK_Cosmetics_SystemDataSet4;
            // 
            // product_Stock_DetailsTableAdapter
            // 
            this.product_Stock_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "Product_Id";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Product_Id";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mfgDateDataGridViewTextBoxColumn
            // 
            this.mfgDateDataGridViewTextBoxColumn.DataPropertyName = "Mfg_Date";
            this.mfgDateDataGridViewTextBoxColumn.HeaderText = "Mfg_Date";
            this.mfgDateDataGridViewTextBoxColumn.Name = "mfgDateDataGridViewTextBoxColumn";
            this.mfgDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "Expiry_Date";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "Expiry_Date";
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            this.expiryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentStockDataGridViewTextBoxColumn
            // 
            this.currentStockDataGridViewTextBoxColumn.DataPropertyName = "Current_Stock";
            this.currentStockDataGridViewTextBoxColumn.HeaderText = "Current_Stock";
            this.currentStockDataGridViewTextBoxColumn.Name = "currentStockDataGridViewTextBoxColumn";
            this.currentStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newStockDataGridViewTextBoxColumn
            // 
            this.newStockDataGridViewTextBoxColumn.DataPropertyName = "New_Stock";
            this.newStockDataGridViewTextBoxColumn.HeaderText = "New_Stock";
            this.newStockDataGridViewTextBoxColumn.Name = "newStockDataGridViewTextBoxColumn";
            this.newStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_View_Stock_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Stock_Details);
            this.Controls.Add(this.pnl_View_Stock_DEtails);
            this.Name = "frm_View_Stock_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Stock Details";
            this.Load += new System.EventHandler(this.frm_View_Stock_Details_Load);
            this.pnl_View_Stock_DEtails.ResumeLayout(false);
            this.pnl_View_Stock_DEtails.PerformLayout();
            this.gb_Stock_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Stock_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RK_Cosmetics_SystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStockDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_View_Stock_DEtails;
        private System.Windows.Forms.ComboBox cmb_Brand_Name;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox gb_Stock_Details;
        private System.Windows.Forms.DataGridView dgv_View_Stock_Details;
        private System.Windows.Forms.Button btn_Refresh;
        private DB_RK_Cosmetics_SystemDataSet4 dB_RK_Cosmetics_SystemDataSet4;
        private System.Windows.Forms.BindingSource productStockDetailsBindingSource;
        private DB_RK_Cosmetics_SystemDataSet4TableAdapters.Product_Stock_DetailsTableAdapter product_Stock_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfgDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newStockDataGridViewTextBoxColumn;
    }
}