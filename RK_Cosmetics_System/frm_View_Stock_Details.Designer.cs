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
            this.pnl_View_Stock_DEtails = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.gb_Stock_Details = new System.Windows.Forms.GroupBox();
            this.dgv_View_Stock_Details = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_View_Stock_DEtails.SuspendLayout();
            this.gb_Stock_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Stock_Details)).BeginInit();
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
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1173, 55);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(157, 52);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // cmb_Brand_Name
            // 
            this.cmb_Brand_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Brand_Name.FormattingEnabled = true;
            this.cmb_Brand_Name.Location = new System.Drawing.Point(685, 27);
            this.cmb_Brand_Name.Name = "cmb_Brand_Name";
            this.cmb_Brand_Name.Size = new System.Drawing.Size(320, 39);
            this.cmb_Brand_Name.TabIndex = 1;
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(685, 106);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(320, 39);
            this.cmb_Product_Name.TabIndex = 2;
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
            this.dgv_View_Stock_Details.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgv_View_Stock_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.pnl_View_Stock_DEtails.ResumeLayout(false);
            this.pnl_View_Stock_DEtails.PerformLayout();
            this.gb_Stock_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Stock_Details)).EndInit();
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
    }
}