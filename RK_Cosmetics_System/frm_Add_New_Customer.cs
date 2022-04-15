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
            tb_Quantity.Text = "0";
            tb_GST_Applied.Clear();
            tb_Final_Bill.Text = "0";
            tb_Discount.Text = "0";
            tb_Bill.Text = "0"; 
            dgv_Add_Customer.Rows.Clear();

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
              // TODO: This line of code loads data into the 'dB_RK_Cosmetics_SystemDataSet5.Customer_Details' table. You can move, or remove it, as needed.
            this.customer_DetailsTableAdapter.Fill(this.dB_RK_Cosmetics_SystemDataSet5.Customer_Details);
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
            int flag = -1 ,  Qty = Convert.ToInt32(tb_Quantity.Text);
            double Bill = 0.0;

            for (int i = 0; i <= dgv_Add_Customer.Rows.Count - 1; i++)
            {
                if (Convert.ToString(dgv_Add_Customer.Rows[i].Cells[2].Value) == cmb_Product_Name.Text)
                {
                    flag = 0;

                    Qty += Convert.ToInt32(dgv_Add_Customer.Rows[i].Cells[4].Value);

                    if (C_Stock >= Qty)
                    {
                        double Tot_Price = Convert.ToDouble(Qty) * Convert.ToDouble(tb_Price);

                        dgv_Add_Customer.Rows[i].Cells[4].Value = Qty;
                        dgv_Add_Customer.Rows[i].Cells[6].Value = Tot_Price;
                    }
                    else
                    {
                        MessageBox.Show("Can't Add More Quantity", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        flag = 1;
                    }
                }
            }

            if (flag == -1)
            {
               if (C_Stock >= Qty)
                {
                    dgv_Add_Customer.Rows.Add(pCnt, cmb_Brand_Name.Text, cmb_Product_Name.Text, tb_Per_Price.Text, tb_Quantity.Text,tb_GST_Applied.Text, tb_Price.Text);

                    pCnt++;
                }
                else
                {
                    MessageBox.Show("No Enough Stock Available", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = 1;
                    tb_Quantity.Clear();
                } 
            }

            if (flag < 1)
            {
                Bill = Convert.ToDouble(tb_Bill.Text) + Convert.ToDouble(tb_Price.Text);

                tb_Bill.Text = Convert.ToString(Bill);
                tb_Final_Bill.Text = Convert.ToString(Bill);
            }

            cmb_Brand_Name.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            tb_Per_Price.Clear();
            tb_Price.Clear();
            tb_Quantity.Text = "0";
            tb_GST_Applied.Clear();
            btn_Add.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Customer_Name.Text != "" && tb_Mobile_No.Text != "" && pCnt > 1 && tb_Bill.Text != "" && tb_Customer_ID.Text != "" && tb_Discount.Text != "" && tb_Final_Bill.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand("Insert Into Customer_Basic_Details Values(@id, @CName, @Mob, @Date, @Bill, @Dis, @Finalb,)", Con);

                Cmd.Parameters.Add("id", SqlDbType.Int).Value = tb_Customer_ID.Text;
                Cmd.Parameters.Add("CName", SqlDbType.NVarChar).Value = tb_Customer_Name.Text;
                Cmd.Parameters.Add("Mob", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Value.Date;
                Cmd.Parameters.Add("Bill", SqlDbType.Money).Value = tb_Bill.Text;
                Cmd.Parameters.Add("Dis", SqlDbType.Float).Value = tb_Discount.Text;
                Cmd.Parameters.Add("Finalb", SqlDbType.Money).Value = tb_Final_Bill.Text;

                Cmd.ExecuteNonQuery();
                Cmd.Dispose();

                for (int i = 0; i <= dgv_Add_Customer.Rows.Count - 1 ; i++)
                {
                    SqlCommand Cmd1 = new SqlCommand("Insert Into Customer_Details Values(@cid, @bName, @pName, @pp, @Qty, @GST, @Price)", Con);

                    Cmd1.Parameters.Add("cid", SqlDbType.Int).Value = tb_Customer_ID.Text;
                    Cmd1.Parameters.Add("bName", SqlDbType.NVarChar).Value = dgv_Add_Customer.Rows[i].Cells[1].Value;
                    Cmd1.Parameters.Add("pName", SqlDbType.NVarChar).Value = dgv_Add_Customer.Rows[i].Cells[2].Value;
                    Cmd1.Parameters.Add("pp", SqlDbType.Money).Value = dgv_Add_Customer.Rows[i].Cells[3].Value;
                    Cmd1.Parameters.Add("Qty", SqlDbType.Int).Value = dgv_Add_Customer.Rows[i].Cells[4].Value;
                    Cmd1.Parameters.Add("GST", SqlDbType.Float).Value = dgv_Add_Customer.Rows[i].Cells[5].Value;
                    Cmd1.Parameters.Add("Price", SqlDbType.Money).Value = dgv_Add_Customer.Rows[i].Cells[6].Value;

                    Cmd1.ExecuteNonQuery();
             


                }
                Con_Close();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Customer_Name.Text != "" || tb_Mobile_No.Text != "" || pCnt > 1 || tb_Bill.Text != "" || tb_Final_Bill.Text != ""  || tb_Discount.Text != "")
            {
                Res = MessageBox.Show("Are You Sure Data Entered Will Be Lost?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                Clear_Control();
            }
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

        private void tb_Discount_TextChanged(object sender, EventArgs e)
        {
            if (tb_Discount.Text != "")
            {
                double Disc = Convert.ToDouble(tb_Bill.Text) * (Convert.ToDouble(tb_Discount.Text) / 100);

                double Tot_Bill = Convert.ToDouble(tb_Final_Bill.Text) - Disc;

                tb_Final_Bill.Text = Convert.ToString(Tot_Bill);
            }
        }


        
    }
}
