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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Report));
            this.lbl_Stock_Details = new System.Windows.Forms.Label();
            this.Stock_crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Stock_Details
            // 
            this.lbl_Stock_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Stock_Details.AutoSize = true;
            this.lbl_Stock_Details.Font = new System.Drawing.Font("Comic Sans MS", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_Details.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Stock_Details.Location = new System.Drawing.Point(694, 9);
            this.lbl_Stock_Details.Name = "lbl_Stock_Details";
            this.lbl_Stock_Details.Size = new System.Drawing.Size(698, 140);
            this.lbl_Stock_Details.TabIndex = 52;
            this.lbl_Stock_Details.Text = "Stock Report";
            // 
            // Stock_crystalReportViewer
            // 
            this.Stock_crystalReportViewer.ActiveViewIndex = -1;
            this.Stock_crystalReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Stock_crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Stock_crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.Stock_crystalReportViewer.Location = new System.Drawing.Point(0, 199);
            this.Stock_crystalReportViewer.Name = "Stock_crystalReportViewer";
            this.Stock_crystalReportViewer.Size = new System.Drawing.Size(1924, 856);
            this.Stock_crystalReportViewer.TabIndex = 53;
            this.Stock_crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(12, 30);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(153, 53);
            this.btn_Back.TabIndex = 54;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Stock_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.Stock_crystalReportViewer);
            this.Controls.Add(this.lbl_Stock_Details);
            this.Name = "Stock_Report";
            this.Text = "Stock_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Stock_Details;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer Stock_crystalReportViewer;
        private System.Windows.Forms.Button btn_Back;
    }
}