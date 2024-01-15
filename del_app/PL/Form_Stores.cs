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
    public partial class Form_Stores : Form
    {
        BL.All_Stores str = new BL.All_Stores();
        public Form_Stores()
        {
            BL.All_Stores str =new BL.All_Stores();
            InitializeComponent();
            comboBox1.DisplayMember = "store_name";
            comboBox1.ValueMember = "store_id";
            comboBox1.DataSource = str.get_stores();

            comboBox2.Items.Add("كل الطلبات");
            comboBox2.Items.Add("قيد الاجراء");
            comboBox2.Items.Add("تم التسليم");
            comboBox2.Items.Add("راجع");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text.ToString()=="كل الطلبات")
                dataGridView1.DataSource = str.get_orders(comboBox1.SelectedValue.ToString());
            else
            dataGridView1.DataSource= str.get_orders_state(comboBox1.SelectedValue.ToString(), comboBox2.Text.ToString());
            textBox1.Text = str.get_store_account(comboBox1.SelectedValue.ToString()).Rows[0][0].ToString() + " دينار";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = str.get_store_account(comboBox1.SelectedValue.ToString()).Rows[0][0].ToString() + " دينار";

        }
    }
}
