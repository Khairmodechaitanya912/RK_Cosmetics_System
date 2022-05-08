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
            this.SuspendLayout();
            // 
            // crv_Stock_Details
            // 
            this.crv_Stock_Details.ActiveViewIndex = -1;
            this.crv_Stock_Details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Stock_Details.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Stock_Details.Location = new System.Drawing.Point(-1, 151);
            this.crv_Stock_Details.Name = "crv_Stock_Details";
            this.crv_Stock_Details.Size = new System.Drawing.Size(1241, 588);
            this.crv_Stock_Details.TabIndex = 0;
            // 
            // Stock_Details_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 738);
            this.Controls.Add(this.crv_Stock_Details);
            this.Name = "Stock_Details_Report";
            this.Text = "Stock_Details_Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Stock_Details;
    }
}