namespace RK_Cosmetics_System
{
    partial class frm_View_Employee_Details
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
            this.gb_Employee_Details = new System.Windows.Forms.GroupBox();
            this.dgv_View_Employee_Details = new System.Windows.Forms.DataGridView();
            this.pnl_Customer_Details = new System.Windows.Forms.Panel();
            this.tb_Employee_ID = new System.Windows.Forms.TextBox();
            this.lbl_Employee_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Employee_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Employee_Details)).BeginInit();
            this.pnl_Customer_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Employee_Details
            // 
            this.gb_Employee_Details.Controls.Add(this.dgv_View_Employee_Details);
            this.gb_Employee_Details.Controls.Add(this.pnl_Customer_Details);
            this.gb_Employee_Details.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.gb_Employee_Details.Location = new System.Drawing.Point(120, 189);
            this.gb_Employee_Details.Name = "gb_Employee_Details";
            this.gb_Employee_Details.Size = new System.Drawing.Size(1870, 695);
            this.gb_Employee_Details.TabIndex = 0;
            this.gb_Employee_Details.TabStop = false;
            this.gb_Employee_Details.Text = "Employee Details";
            // 
            // dgv_View_Employee_Details
            // 
            this.dgv_View_Employee_Details.AllowUserToAddRows = false;
            this.dgv_View_Employee_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Employee_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Employee_Details.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgv_View_Employee_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Employee_Details.Location = new System.Drawing.Point(58, 199);
            this.dgv_View_Employee_Details.Name = "dgv_View_Employee_Details";
            this.dgv_View_Employee_Details.ReadOnly = true;
            this.dgv_View_Employee_Details.RowTemplate.Height = 24;
            this.dgv_View_Employee_Details.Size = new System.Drawing.Size(1721, 441);
            this.dgv_View_Employee_Details.TabIndex = 19;
            // 
            // pnl_Customer_Details
            // 
            this.pnl_Customer_Details.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Customer_Details.Controls.Add(this.tb_Employee_ID);
            this.pnl_Customer_Details.Controls.Add(this.lbl_Employee_ID);
            this.pnl_Customer_Details.Controls.Add(this.btn_Search);
            this.pnl_Customer_Details.Location = new System.Drawing.Point(247, 65);
            this.pnl_Customer_Details.Name = "pnl_Customer_Details";
            this.pnl_Customer_Details.Size = new System.Drawing.Size(1269, 91);
            this.pnl_Customer_Details.TabIndex = 1;
            // 
            // tb_Employee_ID
            // 
            this.tb_Employee_ID.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_ID.Location = new System.Drawing.Point(358, 28);
            this.tb_Employee_ID.MaxLength = 5;
            this.tb_Employee_ID.Name = "tb_Employee_ID";
            this.tb_Employee_ID.Size = new System.Drawing.Size(320, 41);
            this.tb_Employee_ID.TabIndex = 1;
            this.tb_Employee_ID.TextChanged += new System.EventHandler(this.tb_Employee_ID_TextChanged);
            this.tb_Employee_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Employee_ID
            // 
            this.lbl_Employee_ID.AutoSize = true;
            this.lbl_Employee_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Employee_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Employee_ID.Location = new System.Drawing.Point(56, 28);
            this.lbl_Employee_ID.Name = "lbl_Employee_ID";
            this.lbl_Employee_ID.Size = new System.Drawing.Size(199, 39);
            this.lbl_Employee_ID.TabIndex = 11;
            this.lbl_Employee_ID.Text = "Employee ID";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search.Enabled = false;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1071, 23);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(142, 52);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(940, 910);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(142, 52);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_View_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1911, 991);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Employee_Details);
            this.Name = "frm_View_Employee_Details";
            this.Text = "View Employee Details";
            this.Load += new System.EventHandler(this.frm_View_Employee_Details_Load);
            this.gb_Employee_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Employee_Details)).EndInit();
            this.pnl_Customer_Details.ResumeLayout(false);
            this.pnl_Customer_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Employee_Details;
        private System.Windows.Forms.Panel pnl_Customer_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_View_Employee_Details;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Employee_ID;
        private System.Windows.Forms.Label lbl_Employee_ID;
    }
}