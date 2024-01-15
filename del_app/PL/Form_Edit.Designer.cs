namespace del_app.PL
{
    partial class Form_Edit
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
            this.label6 = new System.Windows.Forms.Label();
            this.city_price = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.prodprice = new System.Windows.Forms.TextBox();
            this.custtel = new System.Windows.Forms.TextBox();
            this.custname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(719, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "السعر";
            // 
            // city_price
            // 
            this.city_price.Location = new System.Drawing.Point(525, 322);
            this.city_price.Name = "city_price";
            this.city_price.ReadOnly = true;
            this.city_price.Size = new System.Drawing.Size(151, 23);
            this.city_price.TabIndex = 40;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(525, 267);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 23);
            this.comboBox2.TabIndex = 39;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(521, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 23);
            this.comboBox1.TabIndex = 38;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(240, 355);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(266, 73);
            this.addbutton.TabIndex = 37;
            this.addbutton.Text = "إضافة طلبية جديدة";
            this.addbutton.UseVisualStyleBackColor = true;
            // 
            // prodprice
            // 
            this.prodprice.Location = new System.Drawing.Point(525, 219);
            this.prodprice.Name = "prodprice";
            this.prodprice.Size = new System.Drawing.Size(151, 23);
            this.prodprice.TabIndex = 36;
            // 
            // custtel
            // 
            this.custtel.Location = new System.Drawing.Point(525, 159);
            this.custtel.Name = "custtel";
            this.custtel.Size = new System.Drawing.Size(151, 23);
            this.custtel.TabIndex = 35;
            // 
            // custname
            // 
            this.custname.Location = new System.Drawing.Point(521, 106);
            this.custname.Name = "custname";
            this.custname.Size = new System.Drawing.Size(151, 23);
            this.custname.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(715, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "سعر المنتج";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "المدينة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "رقم الزبون";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "إسم الزبون";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "إسم المتجر";
            // 
            // Form_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form_Edit";
            this.Text = "Form_Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label label6;
        public TextBox city_price;
        public ComboBox comboBox2;
        public ComboBox comboBox1;
        public Button addbutton;
        public TextBox prodprice;
        public TextBox custtel;
        public TextBox custname;
        public Label label5;
        public Label label4;
        public Label label3;
        public Label label2;
        public Label label1;
    }
}