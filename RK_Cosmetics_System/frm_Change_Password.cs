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
    public partial class frm_Change_Password : Form
    {
        public frm_Change_Password()
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
            tb_Current_Password.Clear();
            tb_New_Password.Clear();

            tb_Username.Focus();
        }

        private void frm_Change_Password_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Username.Text != "" && tb_Current_Password.Text != "" && tb_New_Password.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Login_Details set Password = '" + tb_New_Password.Text + "' Where Username = '" + tb_Username.Text + "'";

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Password Updated Successfully !!!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
