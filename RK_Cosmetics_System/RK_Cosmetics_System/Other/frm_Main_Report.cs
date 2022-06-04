using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RK_Cosmetics_System.MDI_Form;
using RK_Cosmetics_System.Report;

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

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Customer_Report cr = new Customer_Report();
            cr.Show();
            this.Hide();
            //Frm_MDI_Customer_Report MCR = new Frm_MDI_Customer_Report();

            //MCR.Show();

            //this.Hide();
        }

        private void btn_Distributor_Click(object sender, EventArgs e)
        {

            Distributor_Report dr = new Distributor_Report();

            dr.Show();
            this.Hide();
            //Frm_MDI_Distributor_Report MDR = new Frm_MDI_Distributor_Report();

            //MDR.Show();

            //this.Hide();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            Employee_Details ed = new Employee_Details();
            ed.Show();
            this.Hide();
            //Frm_MDI_Employee_Report MER = new Frm_MDI_Employee_Report();

            //MER.Show();

            //this.Hide();
        }

        private void btn_Expenses_Click(object sender, EventArgs e)
        {
            Expences_Report er = new Expences_Report();
            er.Show();
            this.Hide();
            //Frm_MDI_Expences_Report MER = new Frm_MDI_Expences_Report();

            //MER.Show();

            //this.Hide();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            Stock_Report sr = new Stock_Report();
            sr.Show();
            this.Hide();

            //Frm_MDI_Stock_Report MSR = new Frm_MDI_Stock_Report();

            //MSR.Show();

            //this.Hide();
        }


    }
}
