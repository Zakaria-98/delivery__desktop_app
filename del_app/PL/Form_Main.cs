using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace del_app.PL
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Add frm= new Form_Add();
             
            frm.ShowDialog();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_New_Store frm= new Form_New_Store();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PL.Form_cities frm = new PL.Form_cities();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.Form_All_Orders frm = new PL.Form_All_Orders();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Form_Stores form = new Form_Stores();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BL.All_Orders ord = new BL.All_Orders();
            PL.Form_Account frm = new PL.Form_Account();
            frm.ShowDialog();
        }
    }
}
