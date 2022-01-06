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
    public partial class frm_Add_New_Distributor : Form
    {
        public frm_Add_New_Distributor()
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

        int Auto_Increament_ID()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(*) from Distributor_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Distributor_ID) from Distributor_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }

            else
            {
                Cnt = 1;
            }

            Con_Close();

            return Cnt;
         
        }

        void Clear_Control()
        {
            tb_Distributor_Id.Text = Convert.ToString(Auto_Increament_ID());

            tb_Name.Clear();
            tb_Address.Clear();
            rbtn_Male.Checked = false;
            rbtn_Female.Checked = false;
            tb_Registation_No.Clear();
            dtp_TieUp_Date.ResetText();
            tb_Mobile_No.Clear();
            tb_Alternate_Mobile_No.Clear();
            tb_Aadhar_No.Clear();
            tb_PAN_No.Clear();
            tb_Email_ID.Clear();

        }
        private void frm_Add_New_Distributor_Load(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {

            Con_Open();

            string Gender = " ";

            if(rbtn_Male.Checked)
            {
                Gender = rbtn_Male.Text;
            }

            else if (rbtn_Female.Checked)
            {
                Gender = rbtn_Female.Text;
            }

            if(tb_Mobile_No.TextLength < 10)
            {
                MessageBox.Show("Invalid Mobile Number...!!  Please Enter Valid Mobile Number...", "Error",MessageBoxButtons.OK , MessageBoxIcon.Error);
                tb_Mobile_No.Focus();

                goto DWN;

            }
            
            if(tb_Alternate_Mobile_No.TextLength < 10)
            {
                MessageBox.Show("Invalid Mobile Number...!!  Please Enter Valid Mobile Number...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Alternate_Mobile_No.Focus();

                goto DWN;
            }

            if(tb_Aadhar_No.TextLength < 12)
            {
                MessageBox.Show("Invalid Aadhar Number...!!  Please Enter Valid Aadhar Number...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Aadhar_No.Focus();

                goto DWN;
            }

            if (tb_PAN_No.TextLength < 10)
            {
                MessageBox.Show("Invalid PAN Number...!!  Please Enter Valid PAN Number...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_PAN_No.Focus();

                goto DWN;
            }

            if (tb_Distributor_Id.Text != "" && tb_Name.Text != "" && tb_Address.Text != "" && tb_Registation_No.Text != "" && tb_Aadhar_No.Text != "" && tb_Alternate_Mobile_No.Text != "" && tb_Mobile_No.Text != "" && tb_PAN_No.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Distributor_Details (Distributor_ID,Name,Address,Gender,Registration_No,Tie_Up_Date,Mobile_No,Alternate_Mobile_No,Aadhar_No,PAN_No,Email_Id) Values (@D_ID,@NAME,@ADD,'" + Gender + "',@R_NO,@T_DATE,@MOB_NO,@A_MOB,@A_NO,@P_NO,@E_ID)";

                Cmd.Parameters.Add("D_ID", SqlDbType.Int).Value = tb_Distributor_Id.Text;
                Cmd.Parameters.Add("NAME", SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("ADD", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("R_NO", SqlDbType.Int).Value = tb_Registation_No.Text;
                Cmd.Parameters.Add("T_DATE", SqlDbType.Date).Value = dtp_TieUp_Date.Value.Date;
                Cmd.Parameters.Add("MOB_NO", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("A_MOB", SqlDbType.Decimal).Value = tb_Alternate_Mobile_No.Text;
                Cmd.Parameters.Add("A_NO", SqlDbType.NVarChar).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("P_NO", SqlDbType.NVarChar).Value = tb_PAN_No.Text;
                Cmd.Parameters.Add("E_ID", SqlDbType.NVarChar).Value = tb_Email_ID.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Distributor Details Saved Successfully...!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Clear_Control();

            }

            else
            {
                MessageBox.Show("Incomplete Information....!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DWN:
            Con_Close();

        }


        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }

        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

      
    }
}
