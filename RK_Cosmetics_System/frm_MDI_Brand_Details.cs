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
    public partial class frm_MDI_Brand_Details : Form
    {
        public frm_MDI_Brand_Details()
        {
            InitializeComponent();
        }

        private void AddNewBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Brand ANB = new frm_Add_New_Brand();

            ANB.MdiParent = this;

            ANB.WindowState = FormWindowState.Maximized;

            ANB.Show();
        }

        private void UpdateBrandDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Update_Brand_Details UBD = new frm_Update_Brand_Details();

            UBD.MdiParent = this;

            UBD.WindowState = FormWindowState.Maximized;

            UBD.Show();
        }

        private void ViewBrandDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_View_Brand_Details VBD = new frm_View_Brand_Details();

            VBD.MdiParent = this;

            VBD.WindowState = FormWindowState.Maximized;

            VBD.Show();

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Admin_Entry_Form AEF = new frm_Admin_Entry_Form();

            AEF.Show();

            this.Hide();
        }
    }
}
