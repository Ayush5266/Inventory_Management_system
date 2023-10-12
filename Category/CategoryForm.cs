using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace InventoryManagementSystem
{
    public partial class CategoryForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AKIDEAPAD;Initial Catalog=dbIMS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public CategoryForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            int i = 0;
            dgvCATEGORY.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCategory", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCATEGORY.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();

        }
         

        private void add_cat_butt_Click(object sender, EventArgs e)
        {
            Category.CategoryModuleForm catmf = new Category.CategoryModuleForm();
            catmf.savebutton1.Enabled = true;
            catmf.update_button2.Enabled = false;
            catmf.ShowDialog();
            LoadCategory();
        }

         

        private void dgvCATEGORY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCATEGORY.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                Category.CategoryModuleForm catmf = new Category.CategoryModuleForm();
                catmf.catid_label5.Text = dgvCATEGORY.Rows[e.RowIndex].Cells[1].Value.ToString();
                catmf.catn_textBox1.Text = dgvCATEGORY.Rows[e.RowIndex].Cells[2].Value.ToString();
                 //--------------------
                catmf.savebutton1.Enabled = false;
                catmf.update_button2.Enabled = true;
                catmf.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbCategory WHERE catid LIKE '" + dgvCATEGORY.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category succefully deleted!!");
                }
                else
                {
                    return;
                }

            }
            LoadCategory();
        }
    }
}
