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
    public partial class frm_MDI_Customer_Details : Form
    {
        public frm_MDI_Customer_Details()
        {
            InitializeComponent();
        }

        private void pnl_Login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_MDI_Customer_Details_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_View_Customer_Details VCD = new frm_View_Customer_Details();

            VCD.MdiParent = this;

            VCD.WindowState = FormWindowState.Maximized;

            VCD.Show();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Customer ANS = new frm_Add_New_Customer();

            ANS.MdiParent = this;

            ANS.WindowState = FormWindowState.Maximized;

            ANS.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Admin_Entry_Form AEF = new frm_Admin_Entry_Form();

            AEF.Show();

            this.Hide();
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
