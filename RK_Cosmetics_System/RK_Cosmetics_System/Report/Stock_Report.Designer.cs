namespace RK_Cosmetics_System.Report
{
    partial class Stock_Report
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
            this.lbl_Stock_Details = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_To = new System.Windows.Forms.Label();
            this.btn_Search_Report = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.Stock_crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // lbl_Stock_Details
            // 
            this.lbl_Stock_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Stock_Details.AutoSize = true;
            this.lbl_Stock_Details.Font = new System.Drawing.Font("Comic Sans MS", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_Details.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Stock_Details.Location = new System.Drawing.Point(523, 9);
            this.lbl_Stock_Details.Name = "lbl_Stock_Details";
            this.lbl_Stock_Details.Size = new System.Drawing.Size(712, 140);
            this.lbl_Stock_Details.TabIndex = 52;
            this.lbl_Stock_Details.Text = "Stock Details";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(874, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(320, 43);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.BackColor = System.Drawing.Color.Pink;
            this.lbl_To.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_To.Location = new System.Drawing.Point(726, 187);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(130, 39);
            this.lbl_To.TabIndex = 51;
            this.lbl_To.Text = "To Date";
            // 
            // btn_Search_Report
            // 
            this.btn_Search_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search_Report.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search_Report.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Report.Location = new System.Drawing.Point(1303, 175);
            this.btn_Search_Report.Name = "btn_Search_Report";
            this.btn_Search_Report.Size = new System.Drawing.Size(254, 52);
            this.btn_Search_Report.TabIndex = 49;
            this.btn_Search_Report.Text = "Search Report";
            this.btn_Search_Report.UseVisualStyleBackColor = false;
            this.btn_Search_Report.Click += new System.EventHandler(this.btn_Search_Report_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(222, 184);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(320, 43);
            this.dtp_Date.TabIndex = 47;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Date.Location = new System.Drawing.Point(31, 187);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(168, 39);
            this.lbl_Date.TabIndex = 48;
            this.lbl_Date.Text = "From Date";
            // 
            // Stock_crystalReportViewer
            // 
            this.Stock_crystalReportViewer.ActiveViewIndex = -1;
            this.Stock_crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Stock_crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.Stock_crystalReportViewer.Location = new System.Drawing.Point(0, 261);
            this.Stock_crystalReportViewer.Name = "Stock_crystalReportViewer";
            this.Stock_crystalReportViewer.Size = new System.Drawing.Size(1621, 578);
            this.Stock_crystalReportViewer.TabIndex = 53;
            this.Stock_crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Stock_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1619, 840);
            this.Controls.Add(this.Stock_crystalReportViewer);
            this.Controls.Add(this.lbl_Stock_Details);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.btn_Search_Report);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbl_Date);
            this.Name = "Stock_Report";
            this.Text = "Stock_Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Stock_Details;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Button btn_Search_Report;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer Stock_crystalReportViewer;
    }
}