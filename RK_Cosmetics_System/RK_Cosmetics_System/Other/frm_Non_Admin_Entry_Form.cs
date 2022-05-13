using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RK_Cosmetics_System.Other;

namespace RK_Cosmetics_System
{
    public partial class frm_Non_Admin_Entry_Form : Form
    {
        public frm_Non_Admin_Entry_Form()
        {
            InitializeComponent();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show(" Are You Sure....!!!", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                frm_Login_Form LF = new frm_Login_Form();

                LF.Show();

                this.Hide();
            }
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            frm_Main_Report MR = new frm_Main_Report();

            MR.Show();

            this.Hide();
        }

        private void frm_Non_Admin_Entry_Form_Load(object sender, EventArgs e)
        {
            lbl_Non_Admin.Text = Global_Var.Uname;
        }
    }
}
