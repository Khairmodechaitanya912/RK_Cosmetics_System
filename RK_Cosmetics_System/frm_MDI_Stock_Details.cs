﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RK_Cosmetics_System
{
    public partial class frm_MDI_Stock_Details : Form
    {
        public frm_MDI_Stock_Details()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Admin_Entry_Form AEF = new frm_Admin_Entry_Form();

            AEF.Show();

            this.Hide();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Stock AS = new frm_Add_Stock();

            AS.MdiParent = this;

            AS.WindowState = FormWindowState.Maximized;

            AS.Show();
        }

        private void ViewOrSearchStockDetailstoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_View_Stock_Details VSD = new frm_View_Stock_Details();

            VSD.MdiParent = this;

            VSD.WindowState = FormWindowState.Maximized;

            VSD.Show();
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
    }
}
