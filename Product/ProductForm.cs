using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Product
{
    public partial class ProductForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AKIDEAPAD;Initial Catalog=dbIMS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ProductForm()
        {
            InitializeComponent();
            LoadProduct();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvPRODUCT.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pname, pprice, pdescription, pcategory) LIKE '%"+search_textBox1.Text+"%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvPRODUCT.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();

        }
        private void add_cat_butt_Click(object sender, EventArgs e)
        {
            Product.ProductModuleForm pmf = new ProductModuleForm();
            pmf.savebutton1.Enabled = true;
            pmf.update_button2.Enabled = false;
            pmf.ShowDialog();
            LoadProduct();
         }

        private void dgvPRODUCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvPRODUCT.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                Product.ProductModuleForm pm = new ProductModuleForm();
                pm.pid_label7.Text = dgvPRODUCT.Rows[e.RowIndex].Cells[1].Value.ToString();
                pm.pn_textBox1.Text = dgvPRODUCT.Rows[e.RowIndex].Cells[2].Value.ToString();
                pm.qty_textBox1.Text = dgvPRODUCT.Rows[e.RowIndex].Cells[3].Value.ToString();
                pm.price_textBox2.Text = dgvPRODUCT.Rows[e.RowIndex].Cells[4].Value.ToString();
                pm.des_textBox1.Text = dgvPRODUCT.Rows[e.RowIndex].Cells[5].Value.ToString();
                pm.cat_comboBox1.Text = dgvPRODUCT.Rows[e.RowIndex].Cells[6].Value.ToString();
                //--------------------
                pm.savebutton1.Enabled = false;
                pm.update_button2.Enabled = true;
                pm.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbProduct WHERE pid LIKE '" + dgvPRODUCT.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User succefully deleted!!");
                }
                else
                {
                    return;
                }

            }
            LoadProduct();
        }

        private void search_textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
