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
    public partial class Form_Account : Form
    {
        public Form_Account()
        {
            InitializeComponent();
            BL.All_Orders ord = new BL.All_Orders();
            dataGridView1.DataSource = ord.get_done_orders();
            textBox1.Text = ord.get_account().Rows[0][0].ToString()+" دينار";
        }
    }
}
