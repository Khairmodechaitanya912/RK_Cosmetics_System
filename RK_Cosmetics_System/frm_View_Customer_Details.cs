using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RK_Cosmetics_System
{
    public partial class frm_View_Customer_Details : Form
    {
        public frm_View_Customer_Details()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_View_Customer_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_RK_Cosmetics_SystemDataSet7.Customer_Basic_Details' table. You can move, or remove it, as needed.
            this.customer_Basic_DetailsTableAdapter.Fill(this.dB_RK_Cosmetics_SystemDataSet7.Customer_Basic_Details);

        }
    }
}
