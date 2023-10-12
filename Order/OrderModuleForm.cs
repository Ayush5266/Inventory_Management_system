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

namespace InventoryManagementSystem.Order
{
    public partial class OrderModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AKIDEAPAD;Initial Catalog=dbIMS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        int qty = 0;

        public OrderModuleForm()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadCustomer()
        {
            int i = 0;
            dgvCUSTOMER.Rows.Clear();
            cm = new SqlCommand("SELECT cid,cname FROM tbCustomer WHERE CONCAT(cid,cname) LIKE '%" + search_cust_textBox1.Text + "%' ", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCUSTOMER.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();

        }

        public void LoadProduct()
        {
            int i = 0;
            dgvPRODUCT.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pname, pprice, pdescription, pcategory) LIKE '%" + search_prod_textBox1.Text + "%'", con);
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

        private void search_cust_textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void search_prod_textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }


        private void qty_numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Getqty();
            if (Convert.ToInt32(qty_numericUpDown1.Value)>qty)
            {
                MessageBox.Show("Instock quantity is not enough!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                qty_numericUpDown1.Value = qty_numericUpDown1.Value - 1;
                return;
            }
            if (Convert.ToInt32(qty_numericUpDown1.Value) > 0)
            {
            int total = Convert.ToInt32(price_textBox5.Text) * Convert.ToInt32(qty_numericUpDown1.Value);
            total_textBox7.Text = total.ToString();
            }
        }

        private void dgvCUSTOMER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cid_textBox1.Text = dgvCUSTOMER.Rows[e.RowIndex].Cells[1].Value.ToString();
            cn_textBox2.Text = dgvCUSTOMER.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvPRODUCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pid_textBox4.Text = dgvPRODUCT.Rows[e.RowIndex].Cells[1].Value.ToString();
            pn_textBox3.Text = dgvPRODUCT.Rows[e.RowIndex].Cells[2].Value.ToString();
            price_textBox5.Text = dgvPRODUCT.Rows[e.RowIndex].Cells[4].Value.ToString();
           // qty = Convert.ToInt32(dgvPRODUCT.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void insert_button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cid_textBox1.Text == "")
                {
                    MessageBox.Show("Please select the customer!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (pid_textBox4.Text == "")
                {
                    MessageBox.Show("Please select the product!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbOrder(odate,pid,cid,qty,price,total)VALUES(@odate,@pid,@cid,@qty,@price,@total)", con);
                    cm.Parameters.AddWithValue("@odate", dateTimePicker1.Value);
                    cm.Parameters.AddWithValue("@pid", Convert.ToInt32(pid_textBox4.Text));
                    cm.Parameters.AddWithValue("@cid", Convert.ToInt32(cid_textBox1.Text));
                    cm.Parameters.AddWithValue("@qty", Convert.ToInt32(qty_numericUpDown1.Value));
                    cm.Parameters.AddWithValue("@price", Convert.ToInt32(price_textBox5.Text));
                    cm.Parameters.AddWithValue("@total", Convert.ToInt32(total_textBox7.Text));
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Order succefully inserted!!");

                    //to update total quantity
                    cm = new SqlCommand("UPDATE tbProduct SET pqty=(pqty-@pqty) WHERE pid LIKE '" + pid_textBox4.Text + "' ", con);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt32(qty_numericUpDown1.Text));
                    
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    //---------
                    clr();
                    LoadProduct();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }
        public void clr()
        {
            cid_textBox1.Clear();
            cn_textBox2.Clear();
            pid_textBox4.Clear();
            pn_textBox3.Clear();
            price_textBox5.Clear();
            qty_numericUpDown1.Value = 0;
            total_textBox7.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void clear_button3_Click(object sender, EventArgs e)
        {
            clr();
            //insert_button1.Enabled = true;
            //update_button2.Enabled = false;
        }

        public void Getqty()
        {
            cm = new SqlCommand("SELECT pqty FROM tbProduct WHERE pid='"+ pid_textBox4.Text + "'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                qty = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

       
    }
}
