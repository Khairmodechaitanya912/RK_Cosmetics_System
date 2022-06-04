using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RK_Cosmetics_System
{
    public partial class Frm_Splash_Screen : Form
    {
        public Frm_Splash_Screen()
        {
            InitializeComponent();
        }

        private void Frm_Splash_Screen_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.prgb_Loading.Increment(10);

            if (prgb_Loading.Value >= prgb_Loading.Maximum)
            {
                timer1.Stop();
                this.Hide();
                frm_Login_Form obj = new frm_Login_Form();
                obj.Show();
            }
        }
    }
}
