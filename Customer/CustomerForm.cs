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
    public partial class CustomerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AKIDEAPAD;Initial Catalog=dbIMS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomer();
        }

        public void LoadCustomer()
        {
            int i = 0;
            dgvCUSTOMER.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCustomer", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCUSTOMER.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void add_Button1_Click(object sender, EventArgs e)
        {
            CustomerModuleForm cmf = new CustomerModuleForm();
            cmf.savebutton1.Enabled = true;
            cmf.update_button2.Enabled = false;
            cmf.ShowDialog();
            LoadCustomer();
        }

        private void dgvCUSTOMER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCUSTOMER.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CustomerModuleForm cmf = new CustomerModuleForm();
                cmf.cid_label5.Text = dgvCUSTOMER.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmf.cn_textBox1.Text = dgvCUSTOMER.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmf.cph_textBox1.Text = dgvCUSTOMER.Rows[e.RowIndex].Cells[3].Value.ToString();
                 //--------------------
                cmf.savebutton1.Enabled = false;
                cmf.update_button2.Enabled = true;
                cmf.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbCustomer WHERE cid LIKE '" + dgvCUSTOMER.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User succefully deleted!!");
                }
                else
                {
                    return;
                }

            }
            LoadCustomer();
        }
    }
}
