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
    public partial class ProductModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AKIDEAPAD;Initial Catalog=dbIMS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ProductModuleForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            cat_comboBox1.Items.Clear();
            cm = new SqlCommand("SELECT catname FROM tbCategory", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cat_comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void savebutton1_Click(object sender, EventArgs e)
        {
            try
            {
                 
                if (MessageBox.Show("Are you sure?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbProduct(pname,pqty,pprice,pdescription,pcategory)VALUES(@pname,@pqty,@pprice,@pdescription,@pcategory)", con);
                    cm.Parameters.AddWithValue("@pname", this.pn_textBox1.Text);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt64(qty_textBox1.Text));
                    cm.Parameters.AddWithValue("@pprice", Convert.ToInt64(price_textBox2.Text));
                    cm.Parameters.AddWithValue("@pdescription", this.des_textBox1.Text);
                    cm.Parameters.AddWithValue("@pcategory", this.cat_comboBox1.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User succefully saved!!");
                    clr();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        public void clr()
        {
            pn_textBox1.Clear();
            qty_textBox1.Clear();
            price_textBox2.Clear();
            des_textBox1.Clear();
            cat_comboBox1.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void update_button2_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (MessageBox.Show("Are you sure?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbProduct SET pname=@pname, pqty=@pqty,pprice=@pprice,pdescription=@pdescription,pcategory=@pcategory WHERE pid LIKE '" + pid_label7.Text + "' ", con);

                    cm.Parameters.AddWithValue("@pname", this.pn_textBox1.Text);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt64(qty_textBox1.Text));
                    cm.Parameters.AddWithValue("@pprice", Convert.ToInt64(price_textBox2.Text));
                    cm.Parameters.AddWithValue("@pdescription", this.des_textBox1.Text);
                    cm.Parameters.AddWithValue("@pcategory", this.cat_comboBox1.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product succefully updated!!");
                    this.Dispose();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void clear_button3_Click(object sender, EventArgs e)
        {
            clr();
            savebutton1.Enabled = true;
            update_button2.Enabled = false;
        }
    }
}
