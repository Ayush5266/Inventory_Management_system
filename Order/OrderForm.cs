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
    public partial class OrderForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AKIDEAPAD;Initial Catalog=dbIMS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public OrderForm()
        {
            InitializeComponent();
            LoadOrder();
        }

        public void LoadOrder()
        {
            int i = 0;
            double total = 0;
            dgvORDER.Rows.Clear();
            cm = new SqlCommand("SELECT orderid,odate,O.pid,P.pname,O.cid,C.cname,qty,price,total FROM tbOrder AS O JOIN tbCustomer AS C ON O.cid=C.cid JOIN tbProduct AS P ON O.pid=P.pid WHERE CONCAT (orderid,odate,O.pid,P.pname,O.cid,C.cname,qty,price) LIKE '%" + search_textBox1.Text + "%' ", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvORDER.Rows.Add(i, dr[0].ToString(),Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                total += Convert.ToInt32(dr[8].ToString());
            }
            dr.Close();
            con.Close();

            qty_label5.Text = i.ToString();
            total_label6.Text = total.ToString();
        }

        private void add_Button1_Click(object sender, EventArgs e)
        {
            Order.OrderModuleForm omf = new OrderModuleForm();
            //omf.insert_button1.Enabled = true;
            //omf.update_button2.Enabled = false;
            omf.ShowDialog();
            LoadOrder();
        }

        private void dgvUSER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvORDER.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbOrder WHERE orderid LIKE '" + dgvORDER.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User succefully deleted!!");

                    //to update(increase after delete order) total quantity
                    cm = new SqlCommand("UPDATE tbProduct SET pqty=(pqty+@pqty) WHERE pid LIKE '" + dgvORDER.Rows[e.RowIndex].Cells[3].Value.ToString() + "' ", con);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt32(dgvORDER.Rows[e.RowIndex].Cells[5].Value.ToString()));

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    return;
                }

            }
            LoadOrder();
        }

        private void search_textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadOrder();
        }
    }
}
