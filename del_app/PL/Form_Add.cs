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
    public partial class Form_Add : Form
    {
        BL.New_Order neworder = new BL.New_Order();
        public Form_Add()
        {
            InitializeComponent();
            
            comboBox1.DisplayMember = "store_name";
            comboBox1.ValueMember = "store_id";
            comboBox1.DataSource = neworder.get_stores();
            comboBox2.DataSource = neworder.get_cities();
            comboBox2.DisplayMember = "city";
            comboBox2.ValueMember = "city";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تم إضافة الطلبية");
             neworder.add_new_order(comboBox1.SelectedValue.ToString(),Convert.ToInt32( prodprice.Text) ,Convert.ToInt32( city_price.Text), comboBox2.SelectedValue.ToString(), custname.Text, custtel.Text);
        }

        private void Form_Add_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            city_price.Text= neworder.get_city_price(comboBox2.Text);
           
        }
    }
}
