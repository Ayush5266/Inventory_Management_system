
namespace InventoryManagementSystem
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_Button1 = new InventoryManagementSystem.CustomerButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUSER = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user = new InventoryManagementSystem.user();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbUserTableAdapter = new InventoryManagementSystem.userTableAdapters.tbUserTableAdapter();
            this.tbUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.add_Button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 60);
            this.panel1.TabIndex = 0;
            // 
            // add_Button1
            // 
            this.add_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Button1.Image = global::InventoryManagementSystem.Properties.Resources._619545_add_create_new_plus_icon;
            this.add_Button1.ImageHover = global::InventoryManagementSystem.Properties.Resources._619537_add_new_plus_create_folder_icon;
            this.add_Button1.ImageNormal = global::InventoryManagementSystem.Properties.Resources._619545_add_create_new_plus_icon;
            this.add_Button1.Location = new System.Drawing.Point(607, 11);
            this.add_Button1.Name = "add_Button1";
            this.add_Button1.Size = new System.Drawing.Size(43, 37);
            this.add_Button1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add_Button1.TabIndex = 3;
            this.add_Button1.TabStop = false;
            this.add_Button1.Click += new System.EventHandler(this.add_Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Users";
            // 
            // dgvUSER
            // 
            this.dgvUSER.AllowUserToAddRows = false;
            this.dgvUSER.AllowUserToDeleteRows = false;
            this.dgvUSER.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUSER.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUSER.ColumnHeadersHeight = 30;
            this.dgvUSER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUSER.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Edit,
            this.Delete});
            this.dgvUSER.EnableHeadersVisualStyles = false;
            this.dgvUSER.Location = new System.Drawing.Point(3, 1);
            this.dgvUSER.Name = "dgvUSER";
            this.dgvUSER.ReadOnly = true;
            this.dgvUSER.RowHeadersWidth = 62;
            this.dgvUSER.RowTemplate.Height = 28;
            this.dgvUSER.Size = new System.Drawing.Size(649, 447);
            this.dgvUSER.TabIndex = 1;
            this.dgvUSER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUSER_CellContentClick);
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
            this.Column1.HeaderText = "User Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 141;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Full  Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 126;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Phone";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 103;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::InventoryManagementSystem.Properties.Resources._2530835_compose_create_edit_edit_file_office_icon;
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 8;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::InventoryManagementSystem.Properties.Resources._9004715_cross_delete_remove_cancel_icon;
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 8;
            // 
            // tbUserBindingSource
            // 
            this.tbUserBindingSource.DataMember = "tbUser";
            this.tbUserBindingSource.DataSource = this.user;
            // 
            // user
            // 
            this.user.DataSetName = "user";
            this.user.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::InventoryManagementSystem.Properties.Resources._2530835_compose_create_edit_edit_file_office_icon;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::InventoryManagementSystem.Properties.Resources._9004715_cross_delete_remove_cancel_icon;
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 150;
            // 
            // tbUserTableAdapter
            // 
            this.tbUserTableAdapter.ClearBeforeFill = true;
            // 
            // tbUserBindingSource1
            // 
            this.tbUserBindingSource1.DataMember = "tbUser";
            this.tbUserBindingSource1.DataSource = this.user;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvUSER);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomerButton add_Button1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private user user;
        private System.Windows.Forms.BindingSource tbUserBindingSource;
        private userTableAdapters.tbUserTableAdapter tbUserTableAdapter;
        private System.Windows.Forms.BindingSource tbUserBindingSource1;
        public System.Windows.Forms.DataGridView dgvUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}