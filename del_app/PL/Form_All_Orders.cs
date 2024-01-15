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
    public partial class Form_All_Orders : Form
    {
        public Form_All_Orders()
        {
            InitializeComponent();
            BL.All_Orders orders = new BL.All_Orders();
            dataGridView1.DataSource = orders.get_orders();
            comboBox1.Items.Add("قيد الاجراء");
            comboBox1.Items.Add("تم التسليم");
            comboBox1.Items.Add("راجع");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form_Change_State frm =new Form_Change_State();
            // frm.ShowDialog();
            BL.All_Orders ord = new BL.All_Orders();
            ord.update_state(comboBox1.Text.ToString(),Convert.ToInt32( this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            MessageBox.Show("تم تغيير الحالة !");
            dataGridView1.DataSource = ord.get_orders();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            BL.All_Orders ord = new BL.All_Orders();
            ord.delete_order(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            dataGridView1.DataSource = ord.get_orders();
            MessageBox.Show("تم حذف الطلبية");

        }

        private void Form_All_Orders_Load(object sender, EventArgs e)
        {
            PL.Form_Edit edt = new PL.Form_Edit();
            int id =Convert.ToInt32( this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            edt.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            edt.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            edt.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            edt.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            edt.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            edt.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            edt.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            edt.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }
    }
}
