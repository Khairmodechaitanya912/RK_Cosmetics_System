namespace RK_Cosmetics_System.Report
{
    partial class Customer_Report
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
            this.Customer_crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Customer_crystalReportViewer
            // 
            this.Customer_crystalReportViewer.ActiveViewIndex = -1;
            this.Customer_crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Customer_crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.Customer_crystalReportViewer.Location = new System.Drawing.Point(-1, 231);
            this.Customer_crystalReportViewer.Name = "Customer_crystalReportViewer";
            this.Customer_crystalReportViewer.Size = new System.Drawing.Size(1485, 567);
            this.Customer_crystalReportViewer.TabIndex = 0;
            this.Customer_crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Customer_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1479, 797);
            this.Controls.Add(this.Customer_crystalReportViewer);
            this.Name = "Customer_Report";
            this.Text = "Customer_Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Customer_crystalReportViewer;
    }
}