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
    public partial class frm_View_Brand_Details : Form
    {
        public frm_View_Brand_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Brand_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_RK_Cosmetics_SystemDataSet2.Brand_Details' table. You can move, or remove it, as needed.
            this.brand_DetailsTableAdapter.Fill(this.dB_RK_Cosmetics_SystemDataSet2.Brand_Details);

        }

       
    }
}
