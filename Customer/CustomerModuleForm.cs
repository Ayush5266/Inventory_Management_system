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
    public partial class CustomerModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AKIDEAPAD;Initial Catalog=dbIMS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        public CustomerModuleForm()
        {
            InitializeComponent();
        }

        private void savebutton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Are you sure?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbCustomer(cname,cphone)VALUES(@cname,@cphone)", con);
                    cm.Parameters.AddWithValue("@cname", this.cn_textBox1.Text);
                    cm.Parameters.AddWithValue("@cphone", this.cph_textBox1.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer successfully saved!!");
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
            cn_textBox1.Clear();
            cph_textBox1.Clear();
         
        }

        private void clear_button3_Click(object sender, EventArgs e)
        {
            clr();
            savebutton1.Enabled = true;
            update_button2.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void update_button2_Click(object sender, EventArgs e)
        {
          try{ 
               if (MessageBox.Show("Are you sure?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
               {
                cm = new SqlCommand("UPDATE tbCustomer SET cname=@cname,cphone=@cphone WHERE cid LIKE '" + cid_label5.Text + "' ", con);

                cm.Parameters.AddWithValue("@cname", this.cn_textBox1.Text);
                cm.Parameters.AddWithValue("@cphone", this.cph_textBox1.Text);
                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customer successfully updated!!");
                this.Dispose();

               }

          }
          catch (Exception ex)
          {
                MessageBox.Show("Error: ", ex.Message);
          }
        }
    }
}
