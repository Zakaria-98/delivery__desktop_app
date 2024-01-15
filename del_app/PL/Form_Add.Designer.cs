namespace del_app.PL
{
    partial class Form_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.custname = new System.Windows.Forms.TextBox();
            this.custtel = new System.Windows.Forms.TextBox();
            this.prodprice = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.city_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "إسم المتجر";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "إسم الزبون";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "رقم الزبون";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "المدينة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "سعر المنتج";
            // 
            // custname
            // 
            this.custname.Location = new System.Drawing.Point(132, 161);
            this.custname.Name = "custname";
            this.custname.Size = new System.Drawing.Size(151, 23);
            this.custname.TabIndex = 7;
            // 
            // custtel
            // 
            this.custtel.Location = new System.Drawing.Point(132, 210);
            this.custtel.Name = "custtel";
            this.custtel.Size = new System.Drawing.Size(151, 23);
            this.custtel.TabIndex = 8;
            // 
            // prodprice
            // 
            this.prodprice.Location = new System.Drawing.Point(132, 263);
            this.prodprice.Name = "prodprice";
            this.prodprice.Size = new System.Drawing.Size(151, 23);
            this.prodprice.TabIndex = 9;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(287, 394);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(266, 73);
            this.addbutton.TabIndex = 11;
            this.addbutton.Text = "إضافة طلبية جديدة";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 23);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(132, 312);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 23);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // city_price
            // 
            this.city_price.Location = new System.Drawing.Point(132, 358);
            this.city_price.Name = "city_price";
            this.city_price.ReadOnly = true;
            this.city_price.Size = new System.Drawing.Size(151, 23);
            this.city_price.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "السعر";
            // 
            // Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.city_price);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.prodprice);
            this.Controls.Add(this.custtel);
            this.Controls.Add(this.custname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Add";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إضافة طلبية جديدة";
            this.Load += new System.EventHandler(this.Form_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox custname;
        private TextBox custtel;
        private TextBox prodprice;
        private Button addbutton;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox city_price;
        private Label label6;
    }
}