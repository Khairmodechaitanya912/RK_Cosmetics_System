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
    public partial class frm_Admin_Entry_Form : Form
    {
        public frm_Admin_Entry_Form()
        {
            InitializeComponent();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            frm_MDI_Customer_Details MCD = new frm_MDI_Customer_Details();

            MCD.Show();

            this.Hide();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            frm_MDI_Employee_Details MED = new frm_MDI_Employee_Details();

            MED.Show();

            this.Hide();
        }

        private void btn_Distributor_Click(object sender, EventArgs e)
        {
            frm_MDI_Distributor_Details MDD = new frm_MDI_Distributor_Details();

            MDD.Show();

            this.Hide();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            frm_MDI_Product_Details MPD = new frm_MDI_Product_Details();

            MPD.Show();

            this.Hide();
        }

        private void btn_User_Management_Click(object sender, EventArgs e)
        {
            frm_MDI_User_Management MUM = new frm_MDI_User_Management();

            MUM.Show();

            this.Hide();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            frm_MDI_Stock_Details MSD = new frm_MDI_Stock_Details();

            MSD.Show();

            this.Hide();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show(" Are You Sure....!!!", "LogOut",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                frm_Login_Form LF = new frm_Login_Form();

                LF.Show();

                this.Hide();
            }
        }

        private void btn_Brand_Click(object sender, EventArgs e)
        {
            frm_MDI_Brand_Details MBD = new frm_MDI_Brand_Details();

            MBD.Show();

            this.Hide();
        }

        private void frm_Admin_Entry_Form_Load(object sender, EventArgs e)
        {
            lbl_Admin.Text = Global_Var.Uname;
        }

        private void btn_Expenses_Click(object sender, EventArgs e)
        {
            frm_MDI_Expences_Details MED = new frm_MDI_Expences_Details();

            MED.Show();

            this.Hide();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            frm_Main_Report MR = new frm_Main_Report();

            MR.Show();

            this.Hide();
        }

    }
}
