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
    public partial class frm_Add_Stock : Form
    {
        public frm_Add_Stock()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_RK_Cosmetics_System;Integrated Security=True");

        int A_Stocks;

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
            dtp_Date.ResetText();
            tb_Product_ID.Clear();
            dtp_Mfg_Date.ResetText();
            dtp_Expiry_Date.ResetText();
            tb_Current_Stock_Quantity.Clear();
            tb_New_Stock_Added.Clear();

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

            tb_Product_ID.Clear();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Product_ID from Product_Details where Product_Name = '" + cmb_Product_Name.Text + "'";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                tb_Product_ID.Text = (Obj["Product_ID"].ToString());
            }

            Obj.Dispose();

            tb_Current_Stock_Quantity.Clear();

            SqlCommand Cmd1 = new SqlCommand();

            Cmd1.Connection = Con;

            Cmd1.CommandText = "Select Stock From Product_Details where Product_Name = '" + cmb_Product_Name.Text + "'";

            var Obj1 = Cmd1.ExecuteReader();

            while (Obj1.Read())
            {
                tb_Current_Stock_Quantity.Text = (Obj1["Stock"].ToString());
            }

            Obj1.Dispose();
            Con_Close();
        }

        private void frm_Add_Stock_Load(object sender, EventArgs e)
        {
            Clear_Control();
            Bind_Brand_Name_To_Combobox();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            A_Stocks = Convert.ToInt32(tb_Current_Stock_Quantity.Text) + Convert.ToInt32(tb_New_Stock_Added.Text);

            if (cmb_Brand_Name.Text != "" && cmb_Product_Name.Text != "" && tb_Product_ID.Text != "" && tb_Current_Stock_Quantity.Text != "" && tb_New_Stock_Added.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Product_Stock_Details (Product_Id, Mfg_Date, Expiry_Date, Date, Stock, Current_Stock, New_Stock) Values (@PID, @MFG, @EXPIRY, @DATE, " + A_Stocks + ", @CS, @NS)";

                Cmd.Parameters.Add("PID", SqlDbType.Int).Value = tb_Product_ID.Text;
                Cmd.Parameters.Add("MFG", SqlDbType.Date).Value = dtp_Mfg_Date.Value.Date;
                Cmd.Parameters.Add("EXPIRY", SqlDbType.Date).Value = dtp_Expiry_Date.Value.Date;
                Cmd.Parameters.Add("DATE", SqlDbType.Date).Value = dtp_Date.Value.Date;
                //Cmd.Parameters.Add("STOCK", SqlDbType.Int).Value = 
                Cmd.Parameters.Add("CS", SqlDbType.Int).Value = tb_Current_Stock_Quantity.Text;
                Cmd.Parameters.Add("NS", SqlDbType.Int).Value = tb_New_Stock_Added.Text;

                Cmd.ExecuteNonQuery();
                Cmd.Dispose();

                Cmd.CommandText = "Update Product_Details Set Stock = " + A_Stocks + " where Product_ID = " + tb_Product_ID.Text +"";

                Cmd.ExecuteNonQuery();
                Cmd.Dispose();

                MessageBox.Show("Stock Added Saved Successfully...!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Control();
            }

            else
            {
                MessageBox.Show("Incomplete Information....!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            dtp_Date.MinDate = dtp_Date.MaxDate = DateTime.Now;
        }
        
    }
}
