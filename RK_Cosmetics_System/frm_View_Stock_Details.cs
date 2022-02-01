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
    public partial class frm_View_Stock_Details : Form
    {
        public frm_View_Stock_Details()
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

        void Clear_Control()
        {
            cmb_Brand_Name.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            btn_Search.Enabled = false;
            cmb_Brand_Name.Focus();

        }

        void Bind_Brand_Name_To_Combobox()
        {
            string Stat = "In Use";

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Brand_Name) from Brand_Details where Status = '" + Stat + "'";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cmb_Brand_Name.Items.Add(Obj.GetString(Obj.GetOrdinal("Brand_Name")));
            }

            Obj.Dispose();
            Con_Close();
        }

        private void frm_View_Stock_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_RK_Cosmetics_SystemDataSet4.Product_Stock_Details' table. You can move, or remove it, as needed.
            this.product_Stock_DetailsTableAdapter.Fill(this.dB_RK_Cosmetics_SystemDataSet4.Product_Stock_Details);
            Clear_Control();
            Bind_Brand_Name_To_Combobox();
        }

        private void cmb_Brand_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            cmb_Product_Name.Items.Clear();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Product_Name) from Product_Details where Brand_Name = '" + cmb_Brand_Name.Text + "'";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cmb_Product_Name.Items.Add(Obj.GetString(Obj.GetOrdinal("Product_Name")));
            }

            Obj.Dispose();
            Con_Close();
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Product_Stock_Details where Product_Name = '" + cmb_Product_Name.Text + "' ", Con);

            DataTable dt = new DataTable();

              SDA.Fill(dt);

            dgv_View_Stock_Details.DataSource = dt;
            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Product_Stock_Details", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Stock_Details.DataSource = dt;

        }
    }
}
