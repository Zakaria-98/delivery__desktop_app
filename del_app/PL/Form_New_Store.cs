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
    public partial class Form_New_Store : Form
    {
        BL.New_Store st = new BL.New_Store();
        public Form_New_Store()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            st.add_new_store(storeid.Text, storename.Text,storetel.Text);
            MessageBox.Show("تمت إضافة متجر جديد");

        }
    }
}
