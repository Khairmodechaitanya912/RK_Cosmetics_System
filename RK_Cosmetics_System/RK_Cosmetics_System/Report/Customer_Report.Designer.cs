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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Report));
            this.Customer_crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lbl_Product_Details = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customer_crystalReportViewer
            // 
            this.Customer_crystalReportViewer.ActiveViewIndex = -1;
            this.Customer_crystalReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Customer_crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Customer_crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.Customer_crystalReportViewer.Location = new System.Drawing.Point(0, 188);
            this.Customer_crystalReportViewer.Name = "Customer_crystalReportViewer";
            this.Customer_crystalReportViewer.Size = new System.Drawing.Size(1926, 867);
            this.Customer_crystalReportViewer.TabIndex = 0;
            this.Customer_crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lbl_Product_Details
            // 
            this.lbl_Product_Details.AutoSize = true;
            this.lbl_Product_Details.Font = new System.Drawing.Font("Comic Sans MS", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Details.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Product_Details.Location = new System.Drawing.Point(502, -22);
            this.lbl_Product_Details.Name = "lbl_Product_Details";
            this.lbl_Product_Details.Size = new System.Drawing.Size(869, 140);
            this.lbl_Product_Details.TabIndex = 59;
            this.lbl_Product_Details.Text = "Customer Report";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(12, 24);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(153, 53);
            this.btn_Back.TabIndex = 60;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Customer_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_Product_Details);
            this.Controls.Add(this.Customer_crystalReportViewer);
            this.Name = "Customer_Report";
            this.Text = "Customer_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Customer_crystalReportViewer;
        private System.Windows.Forms.Label lbl_Product_Details;
        private System.Windows.Forms.Button btn_Back;
    }
}