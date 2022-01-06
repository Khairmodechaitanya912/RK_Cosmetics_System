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
    public partial class frm_Update_Employee_Details : Form
    {
        public frm_Update_Employee_Details()
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
            tb_Employee_ID.Clear();

            tb_First_Name.Clear();
            tb_Middle_Name.Clear();
            tb_Last_Name.Clear();
            tb_Mobile_No.Clear();
            tb_Alternate_Mobile_No.Clear();
            tb_Address.Clear();

            tb_First_Name.Focus();

        }

        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            Clear_Control();
        }
            
        private void btn_Search_Click(object sender, EventArgs e)
        {
            tb_Employee_ID.Enabled = false;
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select * from Employee_Details where Employee_ID = " + tb_Employee_ID.Text + " ";

            var Obj = Cmd.ExecuteReader();

            if (Obj.Read())
            {
                tb_First_Name.Text = Obj.GetString(Obj.GetOrdinal("First_Name"));
                tb_Middle_Name.Text = Obj.GetString(Obj.GetOrdinal("Middle_Name"));
                tb_Last_Name.Text = Obj.GetString(Obj.GetOrdinal("Last_Name"));
                tb_Address.Text = Obj.GetString(Obj.GetOrdinal("Address"));
                tb_Mobile_No.Text = (Obj["Mobile_No"].ToString());
                tb_Alternate_Mobile_No.Text = (Obj["Alternate_Mobile_No"].ToString());

                btn_Update.Enabled = true;
            }
            else
            {
                MessageBox.Show("Information is not Available...", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Clear_Control();
            }

            btn_Update.Enabled = true;
            Con_Close();
        }

        private void tb_Employee_ID_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

        private void frm_Update_Employee_Details_Load(object sender, EventArgs e)
        {
            tb_Employee_ID.Focus();
            Clear_Control();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_Mobile_No.TextLength < 10)
            {
                MessageBox.Show("Invalid Mobile Number!!! Please Enter Valid Mobile Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Mobile_No.Focus();

                goto DWN;
            }

            if (tb_Alternate_Mobile_No.TextLength < 10)
            {
                MessageBox.Show("Invalid Mobile Number!!! Please Enter Valid Mobile Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Alternate_Mobile_No.Focus();

                goto DWN;
            }

            Con_Open();

            if (tb_Employee_ID.Text != "" && tb_First_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Last_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Address.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Employee_Details Set First_Name = @F_Name, Middle_Name = @M_Name, Last_Name = @L_Name, Mobile_No = @Mob1, Alternate_Mobile_No = @Mob2, Address = @Add Where Employee_ID = @Emp_ID";

                Cmd.Parameters.Add("Emp_ID", SqlDbType.Int).Value = tb_Employee_ID.Text;
                Cmd.Parameters.Add("F_Name", SqlDbType.VarChar).Value = tb_First_Name.Text;
                Cmd.Parameters.Add("M_Name", SqlDbType.VarChar).Value = tb_Middle_Name.Text;
                Cmd.Parameters.Add("L_Name", SqlDbType.VarChar).Value = tb_Last_Name.Text;
                Cmd.Parameters.Add("Mob1", SqlDbType.Money).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Mob2", SqlDbType.Money).Value = tb_Alternate_Mobile_No.Text;
                Cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Address.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Employee Details Updated Successfully !!!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Control();

            }
            else
            {
                MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            btn_Search.Enabled = false;
            DWN:
            Con_Close();
        
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
            tb_Employee_ID.Enabled = true;
            btn_Search.Enabled = false;
            btn_Update.Enabled = false;
            tb_Employee_ID.Focus();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;

            }
        }
    }
}
