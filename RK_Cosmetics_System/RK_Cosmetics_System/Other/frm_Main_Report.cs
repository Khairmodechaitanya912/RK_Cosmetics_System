using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RK_Cosmetics_System.Other
{
    public partial class frm_Main_Report : Form
    {
        public frm_Main_Report()
        {
            InitializeComponent();
        }

        private void frm_Main_Report_Load(object sender, EventArgs e)
        {
            lbl_Admin.Text = Global_Var.Uname;
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {

            DialogResult Res = MessageBox.Show(" Are You Sure....!!!", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                frm_Admin_Entry_Form AEF = new frm_Admin_Entry_Form();

                AEF.Show();

                this.Hide();
            }
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


    }
}
