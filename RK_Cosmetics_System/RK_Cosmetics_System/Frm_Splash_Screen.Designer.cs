namespace RK_Cosmetics_System
{
    partial class Frm_Splash_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Splash_Screen));
            this.prgb_Loading = new System.Windows.Forms.ProgressBar();
            this.pb_Splash_Img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Splash_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // prgb_Loading
            // 
            this.prgb_Loading.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prgb_Loading.Location = new System.Drawing.Point(17, 552);
            this.prgb_Loading.MarqueeAnimationSpeed = 60;
            this.prgb_Loading.Name = "prgb_Loading";
            this.prgb_Loading.Size = new System.Drawing.Size(1048, 41);
            this.prgb_Loading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgb_Loading.TabIndex = 0;
            // 
            // pb_Splash_Img
            // 
            this.pb_Splash_Img.Image = ((System.Drawing.Image)(resources.GetObject("pb_Splash_Img.Image")));
            this.pb_Splash_Img.Location = new System.Drawing.Point(-1, -59);
            this.pb_Splash_Img.Name = "pb_Splash_Img";
            this.pb_Splash_Img.Size = new System.Drawing.Size(1082, 686);
            this.pb_Splash_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Splash_Img.TabIndex = 1;
            this.pb_Splash_Img.TabStop = false;
            // 
            // Frm_Splash_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 629);
            this.ControlBox = false;
            this.Controls.Add(this.prgb_Loading);
            this.Controls.Add(this.pb_Splash_Img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Splash_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RK Varieties";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Splash_Img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgb_Loading;
        private System.Windows.Forms.PictureBox pb_Splash_Img;
    }
}