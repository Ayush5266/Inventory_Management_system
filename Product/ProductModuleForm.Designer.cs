
namespace InventoryManagementSystem.Product
{
    partial class ProductModuleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.des_textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clear_button3 = new System.Windows.Forms.Button();
            this.update_button2 = new System.Windows.Forms.Button();
            this.savebutton1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.price_textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.qty_textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cat_comboBox1 = new System.Windows.Forms.ComboBox();
            this.pid_label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Module";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 55);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::InventoryManagementSystem.Properties.Resources.close;
            this.pictureBox3.Location = new System.Drawing.Point(533, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // des_textBox1
            // 
            this.des_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.des_textBox1.Location = new System.Drawing.Point(136, 180);
            this.des_textBox1.Name = "des_textBox1";
            this.des_textBox1.Size = new System.Drawing.Size(383, 30);
            this.des_textBox1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Description:";
            // 
            // clear_button3
            // 
            this.clear_button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clear_button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_button3.FlatAppearance.BorderSize = 0;
            this.clear_button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button3.ForeColor = System.Drawing.Color.White;
            this.clear_button3.Location = new System.Drawing.Point(429, 253);
            this.clear_button3.Name = "clear_button3";
            this.clear_button3.Size = new System.Drawing.Size(90, 27);
            this.clear_button3.TabIndex = 25;
            this.clear_button3.Text = "Clear";
            this.clear_button3.UseVisualStyleBackColor = false;
            this.clear_button3.Click += new System.EventHandler(this.clear_button3_Click);
            // 
            // update_button2
            // 
            this.update_button2.BackColor = System.Drawing.Color.Olive;
            this.update_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_button2.FlatAppearance.BorderSize = 0;
            this.update_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button2.ForeColor = System.Drawing.Color.White;
            this.update_button2.Location = new System.Drawing.Point(333, 253);
            this.update_button2.Name = "update_button2";
            this.update_button2.Size = new System.Drawing.Size(90, 27);
            this.update_button2.TabIndex = 24;
            this.update_button2.Text = "Update";
            this.update_button2.UseVisualStyleBackColor = false;
            this.update_button2.Click += new System.EventHandler(this.update_button2_Click);
            // 
            // savebutton1
            // 
            this.savebutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.savebutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebutton1.FlatAppearance.BorderSize = 0;
            this.savebutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton1.ForeColor = System.Drawing.Color.White;
            this.savebutton1.Location = new System.Drawing.Point(237, 253);
            this.savebutton1.Name = "savebutton1";
            this.savebutton1.Size = new System.Drawing.Size(90, 27);
            this.savebutton1.TabIndex = 23;
            this.savebutton1.Text = "Save";
            this.savebutton1.UseVisualStyleBackColor = false;
            this.savebutton1.Click += new System.EventHandler(this.savebutton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Category:";
            // 
            // price_textBox2
            // 
            this.price_textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price_textBox2.Location = new System.Drawing.Point(135, 147);
            this.price_textBox2.Name = "price_textBox2";
            this.price_textBox2.Size = new System.Drawing.Size(383, 30);
            this.price_textBox2.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Price:";
            // 
            // qty_textBox1
            // 
            this.qty_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qty_textBox1.Location = new System.Drawing.Point(135, 114);
            this.qty_textBox1.Name = "qty_textBox1";
            this.qty_textBox1.Size = new System.Drawing.Size(383, 30);
            this.qty_textBox1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Quantity:";
            // 
            // pn_textBox1
            // 
            this.pn_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_textBox1.Location = new System.Drawing.Point(135, 81);
            this.pn_textBox1.Name = "pn_textBox1";
            this.pn_textBox1.Size = new System.Drawing.Size(383, 30);
            this.pn_textBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Product Name:";
            // 
            // cat_comboBox1
            // 
            this.cat_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cat_comboBox1.FormattingEnabled = true;
            this.cat_comboBox1.Location = new System.Drawing.Point(136, 213);
            this.cat_comboBox1.Name = "cat_comboBox1";
            this.cat_comboBox1.Size = new System.Drawing.Size(383, 29);
            this.cat_comboBox1.TabIndex = 28;
            // 
            // pid_label7
            // 
            this.pid_label7.AutoSize = true;
            this.pid_label7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid_label7.Location = new System.Drawing.Point(39, 253);
            this.pid_label7.Name = "pid_label7";
            this.pid_label7.Size = new System.Drawing.Size(91, 19);
            this.pid_label7.TabIndex = 29;
            this.pid_label7.Text = "Product_id";
            this.pid_label7.Visible = false;
            // 
            // ProductModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 288);
            this.Controls.Add(this.pid_label7);
            this.Controls.Add(this.cat_comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.des_textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clear_button3);
            this.Controls.Add(this.update_button2);
            this.Controls.Add(this.savebutton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.price_textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qty_textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pn_textBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProductModuleForm";
            this.Text = "ProductModuleForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.TextBox des_textBox1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button clear_button3;
        public System.Windows.Forms.Button update_button2;
        public System.Windows.Forms.Button savebutton1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox price_textBox2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox qty_textBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox pn_textBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cat_comboBox1;
        public System.Windows.Forms.Label pid_label7;
    }
}