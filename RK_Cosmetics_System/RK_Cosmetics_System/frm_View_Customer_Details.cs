using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RK_Cosmetics_System
{
    public partial class frm_View_Customer_Details : Form
    {
        public frm_View_Customer_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_RK_Cosmetics_System;Integrated Security=True");

        int pCnt = 1, C_Stock = 0;

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

        void Clear_Control()
        {
            dtp_From_Date.ResetText();
            dtp_To_Date.ResetText();
            btn_Search.Enabled = false;
            dtp_From_Date.Focus();

        }
        private void frm_View_Customer_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_RK_Cosmetics_SystemDataSet7.Customer_Basic_Details' table. You can move, or remove it, as needed.
            this.customer_Basic_DetailsTableAdapter.Fill(this.dB_RK_Cosmetics_SystemDataSet7.Customer_Basic_Details);
            Clear_Control();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Customer_Basic_Details where Date Between '" + dtp_From_Date.Text + "' And '" + dtp_To_Date.Text + "'", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Customer_Details.DataSource = dt;

            btn_Search.Enabled = false;

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Customer_Basic_Details", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Customer_Details.DataSource = dt;

            btn_Search.Enabled = false;
        }

        private void dtp_To_Date_ValueChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

    }
}
