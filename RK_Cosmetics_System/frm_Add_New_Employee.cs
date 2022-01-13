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
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
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

            Cmd.CommandText = "Select Count(*) from Employee_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Employee_ID) from Employee_Details";

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
            tb_Employee_ID.Text = Convert.ToString(Auto_Increament_ID());

            tb_First_Name.Clear();
            tb_Middle_Name.Clear();
            tb_Last_Name.Clear();
            dtp_Date_Of_Birth.ResetText();
            rbtn_Female.Checked = false;
            rbtn_Male.Checked = false;
            dtp_Joining_Date.ResetText();
            tb_Mobile_No.Clear();
            tb_Alternate_Mobile_No.Clear();
            tb_Aadhar_No.Clear();
            tb_PAN_No.Clear();
            tb_Address.Clear();

            tb_First_Name.Focus();

        }

        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            string Gender = " ";

            if (rbtn_Male.Checked)
            {
                Gender = rbtn_Male.Text;
            }

            else if (rbtn_Female.Checked)
            {
                Gender = rbtn_Female.Text;
            }

            if (tb_Mobile_No.TextLength < 10)
            {
                MessageBox.Show("Invalid Mobile Number... Please Enter Valid Mobile Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Mobile_No.Focus();

                goto DWN;
            }

            if (tb_Alternate_Mobile_No.TextLength < 10)
            {
                MessageBox.Show("Invalid Mobile Number... Please Enter Valid Mobile Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Alternate_Mobile_No.Focus();

                goto DWN;
            }

            if (tb_Aadhar_No.TextLength < 12)
            {
                MessageBox.Show("Invalid Aadhar Number... Please Enter Valid Aadhar Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Aadhar_No.Focus();

                goto DWN;
            }

            if (tb_Employee_ID.Text != "" && tb_First_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Last_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Aadhar_No.Text != "" && tb_PAN_No.Text != "" && tb_Address.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Employee_Details (Employee_ID,First_Name,Middle_Name,Last_Name,Date_Of_Birth,Gender,Joining_Date,Mobile_No,Alternate_Mobile_No,Aadhar_No,PAN_No,Address) Values (@E_Id,@F_Name,@M_Name,@L_Name,@DOB,'" + Gender + "',@JDate,@Mob,@AMob,@Aadhar,@Pan,@Add)";

                Cmd.Parameters.Add("E_ID", SqlDbType.Int).Value = tb_Employee_ID.Text;
                Cmd.Parameters.Add("F_Name", SqlDbType.VarChar).Value = tb_First_Name.Text;
                Cmd.Parameters.Add("M_Name", SqlDbType.VarChar).Value = tb_Middle_Name.Text;
                Cmd.Parameters.Add("L_Name", SqlDbType.VarChar).Value = tb_Last_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_Date_Of_Birth.Text;
                Cmd.Parameters.Add("JDate", SqlDbType.Date).Value = dtp_Joining_Date.Text;
                Cmd.Parameters.Add("Mob", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("AMob", SqlDbType.Decimal).Value = tb_Alternate_Mobile_No.Text;
                Cmd.Parameters.Add("Aadhar", SqlDbType.NVarChar).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("Pan", SqlDbType.NVarChar).Value = tb_PAN_No.Text;
                Cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Address.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Employee Details Saved Successfully !!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Control();

                Con_Close();
            }
            else
            {
                MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DWN:
            Clear_Control(); 

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
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
