using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace RK_Cosmetics_System
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            //Thread Td = new Thread(new ThreadStart(StartForm));
            //Td.Start();
            //Thread.Sleep(8000);
            InitializeComponent();
        }

        public void StartForm()
        {

            //Application.Run(new Frm_Splash_Screen());
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

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Sign_In.Enabled = true;
        }

        private void btn_Sign_In_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select * From Login_Details Where Username = @UName And Password = @Pass";

            Cmd.Parameters.Add("UName", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pass", SqlDbType.NVarChar).Value = tb_Password.Text;

            string Ret = Convert.ToString(Cmd.ExecuteScalar());

            if (Ret == tb_Username.Text && tb_Username.Text != "")
            {
                Global_Var.Uname = tb_Username.Text;

                MessageBox.Show(" Login Successful...!! ", "Opening", MessageBoxButtons.OK, MessageBoxIcon.Information);


                frm_Admin_Entry_Form AEF = new frm_Admin_Entry_Form();

                AEF.Show();

                this.Hide();

            }

            else
            {

                MessageBox.Show(" Please Check Username or Password ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            tb_Username.Clear();
            tb_Password.Clear();
            tb_Username.Focus();

            btn_Sign_In.Enabled = false;
            tb_Password.Enabled = false;

        }

    }
}
