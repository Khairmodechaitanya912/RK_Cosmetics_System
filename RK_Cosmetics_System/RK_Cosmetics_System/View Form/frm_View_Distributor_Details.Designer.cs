namespace RK_Cosmetics_System
{
    partial class frm_View_Distributor_Details
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
            this.gb_Distributor_Details = new System.Windows.Forms.GroupBox();
            this.pnl_Distributor_Details = new System.Windows.Forms.Panel();
            this.tb_Distributor_Id = new System.Windows.Forms.TextBox();
            this.lbl_Distributor_Id = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_View_Distributor_Details = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Distributor_Details.SuspendLayout();
            this.pnl_Distributor_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Distributor_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Distributor_Details
            // 
            this.gb_Distributor_Details.Controls.Add(this.pnl_Distributor_Details);
            this.gb_Distributor_Details.Controls.Add(this.dgv_View_Distributor_Details);
            this.gb_Distributor_Details.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.gb_Distributor_Details.Location = new System.Drawing.Point(78, 231);
            this.gb_Distributor_Details.Name = "gb_Distributor_Details";
            this.gb_Distributor_Details.Size = new System.Drawing.Size(1861, 673);
            this.gb_Distributor_Details.TabIndex = 1;
            this.gb_Distributor_Details.TabStop = false;
            this.gb_Distributor_Details.Text = "Distributor Details";
            // 
            // pnl_Distributor_Details
            // 
            this.pnl_Distributor_Details.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Distributor_Details.Controls.Add(this.tb_Distributor_Id);
            this.pnl_Distributor_Details.Controls.Add(this.lbl_Distributor_Id);
            this.pnl_Distributor_Details.Controls.Add(this.btn_Search);
            this.pnl_Distributor_Details.Location = new System.Drawing.Point(266, 48);
            this.pnl_Distributor_Details.Name = "pnl_Distributor_Details";
            this.pnl_Distributor_Details.Size = new System.Drawing.Size(1298, 87);
            this.pnl_Distributor_Details.TabIndex = 22;
            // 
            // tb_Distributor_Id
            // 
            this.tb_Distributor_Id.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Distributor_Id.Location = new System.Drawing.Point(363, 21);
            this.tb_Distributor_Id.MaxLength = 5;
            this.tb_Distributor_Id.Name = "tb_Distributor_Id";
            this.tb_Distributor_Id.Size = new System.Drawing.Size(320, 41);
            this.tb_Distributor_Id.TabIndex = 1;
            this.tb_Distributor_Id.TextChanged += new System.EventHandler(this.tb_Distributor_Id_TextChanged);
            this.tb_Distributor_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numerics);
            // 
            // lbl_Distributor_Id
            // 
            this.lbl_Distributor_Id.AutoSize = true;
            this.lbl_Distributor_Id.BackColor = System.Drawing.Color.Pink;
            this.lbl_Distributor_Id.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.lbl_Distributor_Id.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Distributor_Id.Location = new System.Drawing.Point(56, 23);
            this.lbl_Distributor_Id.Name = "lbl_Distributor_Id";
            this.lbl_Distributor_Id.Size = new System.Drawing.Size(207, 39);
            this.lbl_Distributor_Id.TabIndex = 20;
            this.lbl_Distributor_Id.Text = "Distributor Id";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(983, 20);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(142, 52);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_View_Distributor_Details
            // 
            this.dgv_View_Distributor_Details.AllowUserToAddRows = false;
            this.dgv_View_Distributor_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Distributor_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Distributor_Details.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgv_View_Distributor_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Distributor_Details.Location = new System.Drawing.Point(22, 158);
            this.dgv_View_Distributor_Details.Name = "dgv_View_Distributor_Details";
            this.dgv_View_Distributor_Details.ReadOnly = true;
            this.dgv_View_Distributor_Details.RowTemplate.Height = 24;
            this.dgv_View_Distributor_Details.Size = new System.Drawing.Size(1823, 476);
            this.dgv_View_Distributor_Details.TabIndex = 21;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(886, 921);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(141, 52);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_View_Distributor_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 1007);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Distributor_Details);
            this.Name = "frm_View_Distributor_Details";
            this.Text = "View Distributor Details";
            this.Load += new System.EventHandler(this.frm_View_Distributor_Details_Load);
            this.gb_Distributor_Details.ResumeLayout(false);
            this.pnl_Distributor_Details.ResumeLayout(false);
            this.pnl_Distributor_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Distributor_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Distributor_Details;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_View_Distributor_Details;
        private System.Windows.Forms.Panel pnl_Distributor_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Distributor_Id;
        private System.Windows.Forms.Label lbl_Distributor_Id;
    }
}