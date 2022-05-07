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
    public partial class frm_Update_Distributor_Details : Form
    {
        public frm_Update_Distributor_Details()
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
            tb_Distributor_Id.Enabled = true;

            tb_Distributor_Id.Focus();

            btn_Search.Enabled = false;
            btn_Update.Enabled = false;

            tb_Distributor_Id.Clear();
            tb_Name.Clear();
            tb_Address.Clear();
            tb_Mobile_No.Clear();
            tb_Alternate_Mobile_No.Clear();
            tb_Email_ID.Clear();

           

        }

        private void frm_Update_Distributor_Details_Load(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            tb_Distributor_Id.Enabled = false;
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select * from Distributor_Details where Distributor_Id = " + tb_Distributor_Id.Text + "";

            var Obj = Cmd.ExecuteReader();

            if (Obj.Read())
            {
                tb_Name.Text = Obj.GetString(Obj.GetOrdinal("Name"));
                tb_Address.Text = Obj.GetString(Obj.GetOrdinal("Address"));
                tb_Mobile_No.Text = (Obj["Mobile_No"].ToString());
                tb_Alternate_Mobile_No.Text = (Obj["Alternate_Mobile_No"].ToString());
                tb_Email_ID.Text = Obj.GetString(Obj.GetOrdinal("Email_ID"));

                btn_Update.Enabled = true;
            }
            else
            {
                MessageBox.Show("Information is Not Available...","No Record Found",MessageBoxButtons.OK,MessageBoxIcon.Question);
                Clear_Control();
            }

            Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_Mobile_No.TextLength < 10)
            {
                MessageBox.Show("Invalid Mobile No... Please Enter Valid Mobile Number . ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tb_Mobile_No.Focus();

                goto DWN;
            }

            if (tb_Alternate_Mobile_No.TextLength < 10)
            {
                MessageBox.Show("Invalid Mobile No... Please Enter Valid Mobile Number . ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Alternate_Mobile_No.Focus();

                goto DWN;
            }

            Con_Open();

            if (tb_Distributor_Id.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Address.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Distributor_Details Set Name = @Name, Mobile_No = @Mob, Alternate_Mobile_No = @AMob, Address = @Add, Email_ID = @Eid Where Distributor_ID = @D_Id";

                Cmd.Parameters.Add("D_Id", SqlDbType.Int).Value = tb_Distributor_Id.Text;
                Cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Mob", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("AMob", SqlDbType.Decimal).Value = tb_Alternate_Mobile_No.Text;
                Cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("Eid", SqlDbType.NVarChar).Value = tb_Email_ID.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Distributor Details Updated Successfully...!!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Control();

            }

            else
            {
                MessageBox.Show("Incomplete Information...!!", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }

        DWN:
            Clear_Control();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
            btn_Search.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void tb_Distributor_Id_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

        private void Only_Numerics(object sender, KeyPressEventArgs e)
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

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

      
    }
}
