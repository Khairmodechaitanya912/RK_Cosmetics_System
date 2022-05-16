using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RK_Cosmetics_System.Other;

namespace RK_Cosmetics_System.MDI_Form
{
    public partial class Frm_MDI_Customer_Report : Form
    {
        public Frm_MDI_Customer_Report()
        {
            InitializeComponent();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show(" Are You Sure....!!!", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                frm_Login_Form LF = new frm_Login_Form();

                LF.Show();

                this.Hide();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Main_Report MR = new frm_Main_Report();

            MR.Show();

            this.Hide();
        }
    }
}
