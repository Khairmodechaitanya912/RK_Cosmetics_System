namespace RK_Cosmetics_System.Report
{
    partial class Stock_Details_Report
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
            this.crv_Stock_Details = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.btn_Search_Report = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_Stock_Details = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crv_Stock_Details
            // 
            this.crv_Stock_Details.ActiveViewIndex = -1;
            this.crv_Stock_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crv_Stock_Details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Stock_Details.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Stock_Details.Location = new System.Drawing.Point(-1, 244);
            this.crv_Stock_Details.Name = "crv_Stock_Details";
            this.crv_Stock_Details.Size = new System.Drawing.Size(1622, 597);
            this.crv_Stock_Details.TabIndex = 0;
            this.crv_Stock_Details.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(331, 171);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(320, 43);
            this.dtp_Date.TabIndex = 41;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Date.Location = new System.Drawing.Point(140, 174);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(168, 39);
            this.lbl_Date.TabIndex = 42;
            this.lbl_Date.Text = "From Date";
            // 
            // btn_Search_Report
            // 
            this.btn_Search_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search_Report.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search_Report.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Report.Location = new System.Drawing.Point(1353, 169);
            this.btn_Search_Report.Name = "btn_Search_Report";
            this.btn_Search_Report.Size = new System.Drawing.Size(254, 52);
            this.btn_Search_Report.TabIndex = 43;
            this.btn_Search_Report.Text = "Search Report";
            this.btn_Search_Report.UseVisualStyleBackColor = false;
            this.btn_Search_Report.Click += new System.EventHandler(this.btn_Search_Report_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(983, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(320, 43);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.BackColor = System.Drawing.Color.Pink;
            this.lbl_To.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_To.Location = new System.Drawing.Point(835, 174);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(130, 39);
            this.lbl_To.TabIndex = 45;
            this.lbl_To.Text = "To Date";
            // 
            // lbl_Stock_Details
            // 
            this.lbl_Stock_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Stock_Details.AutoSize = true;
            this.lbl_Stock_Details.Font = new System.Drawing.Font("Comic Sans MS", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_Details.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Stock_Details.Location = new System.Drawing.Point(632, -4);
            this.lbl_Stock_Details.Name = "lbl_Stock_Details";
            this.lbl_Stock_Details.Size = new System.Drawing.Size(712, 140);
            this.lbl_Stock_Details.TabIndex = 46;
            this.lbl_Stock_Details.Text = "Stock Details";
            // 
            // Stock_Details_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1619, 840);
            this.Controls.Add(this.lbl_Stock_Details);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.btn_Search_Report);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.crv_Stock_Details);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stock_Details_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock_Details_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_Details_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Stock_Details;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Button btn_Search_Report;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_Stock_Details;
    }
}