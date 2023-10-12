
namespace InventoryManagementSystem.Order
{
    partial class OrderModuleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cn_textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cid_textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.search_cust_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCUSTOMER = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clear_button3 = new System.Windows.Forms.Button();
            this.insert_button1 = new System.Windows.Forms.Button();
            this.total_textBox7 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.price_textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pn_textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.search_prod_textBox1 = new System.Windows.Forms.TextBox();
            this.pid_textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPRODUCT = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.qty_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.oid_label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUSTOMER)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::InventoryManagementSystem.Properties.Resources.close;
            this.pictureBox3.Location = new System.Drawing.Point(1235, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 55);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Module";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.oid_label14);
            this.panel2.Controls.Add(this.cn_textBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cid_textBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.search_cust_textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvCUSTOMER);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 557);
            this.panel2.TabIndex = 2;
            // 
            // cn_textBox2
            // 
            this.cn_textBox2.Location = new System.Drawing.Point(160, 451);
            this.cn_textBox2.Name = "cn_textBox2";
            this.cn_textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cn_textBox2.Size = new System.Drawing.Size(263, 30);
            this.cn_textBox2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Customer Name:";
            // 
            // cid_textBox1
            // 
            this.cid_textBox1.Location = new System.Drawing.Point(160, 386);
            this.cid_textBox1.Name = "cid_textBox1";
            this.cid_textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cid_textBox1.Size = new System.Drawing.Size(263, 30);
            this.cid_textBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Customer Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Search:";
            // 
            // search_cust_textBox1
            // 
            this.search_cust_textBox1.Location = new System.Drawing.Point(256, 280);
            this.search_cust_textBox1.Name = "search_cust_textBox1";
            this.search_cust_textBox1.Size = new System.Drawing.Size(181, 30);
            this.search_cust_textBox1.TabIndex = 7;
            this.search_cust_textBox1.TextChanged += new System.EventHandler(this.search_cust_textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(10, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "CUSTOMER";
            // 
            // dgvCUSTOMER
            // 
            this.dgvCUSTOMER.AllowUserToAddRows = false;
            this.dgvCUSTOMER.AllowUserToDeleteRows = false;
            this.dgvCUSTOMER.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCUSTOMER.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCUSTOMER.ColumnHeadersHeight = 30;
            this.dgvCUSTOMER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCUSTOMER.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2});
            this.dgvCUSTOMER.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCUSTOMER.EnableHeadersVisualStyles = false;
            this.dgvCUSTOMER.Location = new System.Drawing.Point(0, 0);
            this.dgvCUSTOMER.Name = "dgvCUSTOMER";
            this.dgvCUSTOMER.ReadOnly = true;
            this.dgvCUSTOMER.RowHeadersVisible = false;
            this.dgvCUSTOMER.RowHeadersWidth = 62;
            this.dgvCUSTOMER.RowTemplate.Height = 28;
            this.dgvCUSTOMER.Size = new System.Drawing.Size(440, 274);
            this.dgvCUSTOMER.TabIndex = 5;
            this.dgvCUSTOMER.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCUSTOMER_CellClick);
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "No";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 71;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Customer ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 155;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.qty_numericUpDown1);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.clear_button3);
            this.panel3.Controls.Add(this.insert_button1);
            this.panel3.Controls.Add(this.total_textBox7);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.price_textBox5);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.pn_textBox3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.search_prod_textBox1);
            this.panel3.Controls.Add(this.pid_textBox4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dgvPRODUCT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(446, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 557);
            this.panel3.TabIndex = 3;
            // 
            // clear_button3
            // 
            this.clear_button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clear_button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_button3.FlatAppearance.BorderSize = 0;
            this.clear_button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button3.ForeColor = System.Drawing.Color.White;
            this.clear_button3.Location = new System.Drawing.Point(711, 488);
            this.clear_button3.Name = "clear_button3";
            this.clear_button3.Size = new System.Drawing.Size(94, 27);
            this.clear_button3.TabIndex = 25;
            this.clear_button3.Text = "Clear";
            this.clear_button3.UseVisualStyleBackColor = false;
            this.clear_button3.Click += new System.EventHandler(this.clear_button3_Click);
            // 
            // insert_button1
            // 
            this.insert_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.insert_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert_button1.FlatAppearance.BorderSize = 0;
            this.insert_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_button1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_button1.ForeColor = System.Drawing.Color.White;
            this.insert_button1.Location = new System.Drawing.Point(585, 488);
            this.insert_button1.Name = "insert_button1";
            this.insert_button1.Size = new System.Drawing.Size(120, 27);
            this.insert_button1.TabIndex = 23;
            this.insert_button1.Text = "Order Insert";
            this.insert_button1.UseVisualStyleBackColor = false;
            this.insert_button1.Click += new System.EventHandler(this.insert_button1_Click);
            // 
            // total_textBox7
            // 
            this.total_textBox7.Location = new System.Drawing.Point(631, 425);
            this.total_textBox7.Name = "total_textBox7";
            this.total_textBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total_textBox7.Size = new System.Drawing.Size(174, 30);
            this.total_textBox7.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(567, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 21);
            this.label12.TabIndex = 20;
            this.label12.Text = "Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(567, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Qty:";
            // 
            // price_textBox5
            // 
            this.price_textBox5.Location = new System.Drawing.Point(631, 333);
            this.price_textBox5.Name = "price_textBox5";
            this.price_textBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.price_textBox5.Size = new System.Drawing.Size(174, 30);
            this.price_textBox5.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(567, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Price:";
            // 
            // pn_textBox3
            // 
            this.pn_textBox3.Location = new System.Drawing.Point(3, 427);
            this.pn_textBox3.Name = "pn_textBox3";
            this.pn_textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pn_textBox3.Size = new System.Drawing.Size(263, 30);
            this.pn_textBox3.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Search:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Product Name:";
            // 
            // search_prod_textBox1
            // 
            this.search_prod_textBox1.Location = new System.Drawing.Point(418, 280);
            this.search_prod_textBox1.Name = "search_prod_textBox1";
            this.search_prod_textBox1.Size = new System.Drawing.Size(395, 30);
            this.search_prod_textBox1.TabIndex = 8;
            this.search_prod_textBox1.TextChanged += new System.EventHandler(this.search_prod_textBox1_TextChanged);
            // 
            // pid_textBox4
            // 
            this.pid_textBox4.Location = new System.Drawing.Point(3, 367);
            this.pid_textBox4.Name = "pid_textBox4";
            this.pid_textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pid_textBox4.Size = new System.Drawing.Size(263, 30);
            this.pid_textBox4.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Product Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(12, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "PRODUCT";
            // 
            // dgvPRODUCT
            // 
            this.dgvPRODUCT.AllowUserToAddRows = false;
            this.dgvPRODUCT.AllowUserToDeleteRows = false;
            this.dgvPRODUCT.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPRODUCT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPRODUCT.ColumnHeadersHeight = 30;
            this.dgvPRODUCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPRODUCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            this.dgvPRODUCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPRODUCT.EnableHeadersVisualStyles = false;
            this.dgvPRODUCT.Location = new System.Drawing.Point(0, 0);
            this.dgvPRODUCT.Name = "dgvPRODUCT";
            this.dgvPRODUCT.ReadOnly = true;
            this.dgvPRODUCT.RowHeadersVisible = false;
            this.dgvPRODUCT.RowHeadersWidth = 62;
            this.dgvPRODUCT.RowTemplate.Height = 28;
            this.dgvPRODUCT.Size = new System.Drawing.Size(817, 274);
            this.dgvPRODUCT.TabIndex = 8;
            this.dgvPRODUCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPRODUCT_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 71;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 139;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Qty";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 89;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Description";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Category";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 132;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 460);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 21);
            this.label13.TabIndex = 26;
            this.label13.Text = "Order Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 485);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 30);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // qty_numericUpDown1
            // 
            this.qty_numericUpDown1.Location = new System.Drawing.Point(631, 378);
            this.qty_numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.qty_numericUpDown1.Name = "qty_numericUpDown1";
            this.qty_numericUpDown1.Size = new System.Drawing.Size(174, 30);
            this.qty_numericUpDown1.TabIndex = 28;
            this.qty_numericUpDown1.ValueChanged += new System.EventHandler(this.qty_numericUpDown1_ValueChanged);
            // 
            // oid_label14
            // 
            this.oid_label14.AutoSize = true;
            this.oid_label14.Location = new System.Drawing.Point(12, 517);
            this.oid_label14.Name = "oid_label14";
            this.oid_label14.Size = new System.Drawing.Size(83, 21);
            this.oid_label14.TabIndex = 13;
            this.oid_label14.Text = "order Id:";
            // 
            // OrderModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 612);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OrderModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderModuleForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUSTOMER)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvCUSTOMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvPRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox search_cust_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox search_prod_textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button clear_button3;
        public System.Windows.Forms.Button insert_button1;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label oid_label14;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox cn_textBox2;
        public System.Windows.Forms.TextBox cid_textBox1;
        public System.Windows.Forms.TextBox total_textBox7;
        public System.Windows.Forms.TextBox price_textBox5;
        public System.Windows.Forms.TextBox pn_textBox3;
        public System.Windows.Forms.TextBox pid_textBox4;
        public System.Windows.Forms.NumericUpDown qty_numericUpDown1;
    }
}