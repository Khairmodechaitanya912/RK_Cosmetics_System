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

namespace RK_Cosmetics_System.Report
{
    public partial class Stock_Details_Report : Form
    {
        ReportDocument rd = new ReportDocument();

        public Stock_Details_Report()
        {
            InitializeComponent();
        }

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

        private void Stock_Details_Report_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Report_Click(object sender, EventArgs e)
        {
            Con_Open();

            //rd.Load(@"E:\C# Project\Project\RK_Cosmetics_System\RK_Cosmetics_System\RPT Files\Stock_Report.rpt");
            crv_Stock_Details.ReportSource = rd;
            crv_Stock_Details.Refresh();

            Con_Close();
        }
    }
}
