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
    public partial class frm_Add_New_Customer : Form
    {
        public frm_Add_New_Customer()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_RK_Cosmetics_System;Integrated Security=True");

        int pCnt = 1 , C_Stock = 0;

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

        int Auto_Increament_ID()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(*) from Customer_Basic_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Customer_ID) from Customer_Basic_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }

            else
            {
                Cnt =  1;
            }

            Con_Close();

            return Cnt;

        }

        void Clear_Control()
        {
            tb_Customer_ID.Text = Convert.ToString(Auto_Increament_ID());

            tb_Customer_Name.Clear();
            dtp_Date.ResetText();
            tb_Mobile_No.Clear();
            cmb_Brand_Name.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            tb_Per_Price.Clear();
            tb_Price.Clear();
            tb_Quantity.Clear();
            tb_GST_Applied.Clear();
            tb_Final_Bill.Clear();
            tb_Discount.Clear();
            tb_Bill.Clear();
            //dgv_Add_Customer.Rows.Clear();

            C_Stock = 0;
            pCnt = 1;

            tb_Customer_Name.Focus();
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

        private void frm_Add_New_Customer_Load(object sender, EventArgs e)
        { 
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
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Selling_Price , GST , Stock from Product_Details where Product_Name = '" + cmb_Product_Name.Text + "'";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                tb_Per_Price.Text = (Obj["Selling_Price"].ToString());
                tb_GST_Applied.Text = (Obj["GST"].ToString());
                C_Stock = Convert.ToInt32(Obj["Stock"]);
            }

            Obj.Dispose();
            Con_Close();
        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            double GST = 0;

            if (tb_Quantity.Text != "" && Convert.ToInt32(tb_Quantity.Text) > 0)
            {
                GST = (Convert.ToDouble(tb_Per_Price.Text) * Convert.ToDouble(tb_GST_Applied.Text))/ 100;
                tb_Price.Text = Convert.ToString( (Convert.ToDouble(tb_Per_Price.Text) + GST  ) * ( Convert.ToDouble(tb_Quantity.Text))) ;

                btn_Add.Enabled = true;
            }

            if (tb_Quantity.Text == "")
            {
                tb_Price.Text = "0";
            }
        }

        private void tb_Quantity_Leave(object sender, EventArgs e)
        {
            if (tb_Quantity.Text == "" || tb_Quantity.Text == "0")
            {
                MessageBox.Show("Invalid Quantity!!!");
                tb_Quantity.Text = "0";
                tb_Quantity.Focus();
                btn_Add.Enabled = false;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            dtp_Date.MinDate = dtp_Date.MaxDate = DateTime.Now;
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void Only_Number(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }


        
    }
}
