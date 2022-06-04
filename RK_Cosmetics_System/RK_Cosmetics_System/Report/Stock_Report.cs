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
    public partial class Stock_Report : Form
    {
        ReportDocument rd = new ReportDocument();

        public Stock_Report()
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

        private void btn_Search_Report_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Main_Report mr = new frm_Main_Report();
            mr.Show();
            this.Hide();
        }

        private void Stock_Report_Load(object sender, EventArgs e)
        {
            Con_Open();

            string Query = "Select * from Product_Stock_Details";

            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);

            DataSet ds = new DataSet();
            sda.Fill(ds, "Product_Stock_Details");

            Stock_CrystalReport sdr = new Stock_CrystalReport();
            sdr.SetDataSource(ds);
            Stock_crystalReportViewer.ReportSource = sdr;


            Con_Close();
        }

    }
}
