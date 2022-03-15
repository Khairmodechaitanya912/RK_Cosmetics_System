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
    public partial class frm_Delete_User : Form
    {
        public frm_Delete_User()
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

        void Clear_Controls()
        {
            tb_Username.Clear();
            tb_Password.Clear();

            tb_Username.Focus();
        }

        private void frm_Delete_User_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Username.Text != "" && tb_Password.Text != "")
            {
                DialogResult Res = MessageBox.Show(" Are You Sure To Delete The User....!!!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Res == DialogResult.Yes)
                {
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.Connection = Con;

                    Cmd.CommandText = "Delete from Login_Details where Username = '" + tb_Username.Text + "'";

                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("User Deleted Successfully...!!", "Deleting", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear_Controls();
                }

                else
                {
                    Clear_Controls();
                }

            }

            else
            {
                MessageBox.Show("Fill All Information...!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_Controls();
            }

            Con_Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
