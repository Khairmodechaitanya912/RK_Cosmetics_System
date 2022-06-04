using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using RK_Cosmetics_System.Other;

namespace RK_Cosmetics_System.Report
{
    public partial class Employee_Details : Form
    {
        public Employee_Details()
        {
            InitializeComponent();
        }

        ReportDocument rd = new ReportDocument();

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_RK_Cosmetics_System;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Main_Report mr = new frm_Main_Report();
            mr.Show();
            this.Hide();
        }

        private void Employee_Details_Load(object sender, EventArgs e)
        {
            Con_Open();

            string Query = "Select * from Employee_Details";

            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);

            DataSet ds = new DataSet();
            sda.Fill(ds, "Employee_Details");

            Employee_CrystalReport sdr = new Employee_CrystalReport();
            sdr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = sdr;


            Con_Close();
        }
    }
}
