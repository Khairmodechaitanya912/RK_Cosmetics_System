
namespace RK_Cosmetics_System
{
    partial class frm_View_Brand_Details
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Brand_Details = new System.Windows.Forms.GroupBox();
            this.dgv_View_Brand_Details = new System.Windows.Forms.DataGridView();
            this.pnl_Customer_Details = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Brand_ID = new System.Windows.Forms.TextBox();
            this.lbl_Brand_ID = new System.Windows.Forms.Label();
            this.gb_Brand_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Brand_Details)).BeginInit();
            this.pnl_Customer_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(854, 889);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(140, 54);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // gb_Brand_Details
            // 
            this.gb_Brand_Details.Controls.Add(this.dgv_View_Brand_Details);
            this.gb_Brand_Details.Controls.Add(this.pnl_Customer_Details);
            this.gb_Brand_Details.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.gb_Brand_Details.Location = new System.Drawing.Point(185, 247);
            this.gb_Brand_Details.Name = "gb_Brand_Details";
            this.gb_Brand_Details.Size = new System.Drawing.Size(1520, 621);
            this.gb_Brand_Details.TabIndex = 39;
            this.gb_Brand_Details.TabStop = false;
            this.gb_Brand_Details.Text = "Brand Details";
            // 
            // dgv_View_Brand_Details
            // 
            this.dgv_View_Brand_Details.AllowUserToAddRows = false;
            this.dgv_View_Brand_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Brand_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Brand_Details.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgv_View_Brand_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Brand_Details.Location = new System.Drawing.Point(30, 153);
            this.dgv_View_Brand_Details.Name = "dgv_View_Brand_Details";
            this.dgv_View_Brand_Details.ReadOnly = true;
            this.dgv_View_Brand_Details.RowTemplate.Height = 24;
            this.dgv_View_Brand_Details.Size = new System.Drawing.Size(1449, 450);
            this.dgv_View_Brand_Details.TabIndex = 43;
            // 
            // pnl_Customer_Details
            // 
            this.pnl_Customer_Details.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Customer_Details.Controls.Add(this.btn_Search);
            this.pnl_Customer_Details.Controls.Add(this.tb_Brand_ID);
            this.pnl_Customer_Details.Controls.Add(this.lbl_Brand_ID);
            this.pnl_Customer_Details.Location = new System.Drawing.Point(45, 46);
            this.pnl_Customer_Details.Name = "pnl_Customer_Details";
            this.pnl_Customer_Details.Size = new System.Drawing.Size(1411, 91);
            this.pnl_Customer_Details.TabIndex = 42;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search.Enabled = false;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1187, 18);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(159, 52);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Brand_ID
            // 
            this.tb_Brand_ID.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Brand_ID.Location = new System.Drawing.Point(425, 29);
            this.tb_Brand_ID.MaxLength = 5;
            this.tb_Brand_ID.Name = "tb_Brand_ID";
            this.tb_Brand_ID.Size = new System.Drawing.Size(320, 41);
            this.tb_Brand_ID.TabIndex = 1;
            this.tb_Brand_ID.TextChanged += new System.EventHandler(this.tb_Brand_ID_TextChanged);
            this.tb_Brand_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Brand_ID
            // 
            this.lbl_Brand_ID.AutoSize = true;
            this.lbl_Brand_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Brand_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Brand_ID.Location = new System.Drawing.Point(174, 31);
            this.lbl_Brand_ID.Name = "lbl_Brand_ID";
            this.lbl_Brand_ID.Size = new System.Drawing.Size(142, 39);
            this.lbl_Brand_ID.TabIndex = 25;
            this.lbl_Brand_ID.Text = "Brand ID";
            // 
            // frm_View_Brand_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1742, 975);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Brand_Details);
            this.Name = "frm_View_Brand_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_Brand_Details";
            this.Load += new System.EventHandler(this.frm_View_Brand_Details_Load);
            this.gb_Brand_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Brand_Details)).EndInit();
            this.pnl_Customer_Details.ResumeLayout(false);
            this.pnl_Customer_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.GroupBox gb_Brand_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Brand_ID;
        private System.Windows.Forms.Label lbl_Brand_ID;
        private System.Windows.Forms.Panel pnl_Customer_Details;
        private System.Windows.Forms.DataGridView dgv_View_Brand_Details;
    }
}