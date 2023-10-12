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

namespace InventoryManagementSystem.Category
{
    public partial class CategoryModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AKIDEAPAD;Initial Catalog=dbIMS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        public CategoryModuleForm()
        {
            InitializeComponent();
        }

        private void CategoryModuleForm_Load(object sender, EventArgs e)
        {

        }

        private void savebutton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbCategory(catname)VALUES(@catname)", con);
                    cm.Parameters.AddWithValue("@catname", this.catn_textBox1.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category has been successfully saved!!");
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
            catn_textBox1.Clear();
 
        }

        //private void clear_button3_Click(object sender, EventArgs e)
        //{
        
        //}

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        //private void update_button2_Click(object sender, EventArgs e)
        //{
           
        //}

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void update_button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbCategory SET catname=@catname WHERE catid LIKE '" + catid_label5.Text + "' ", con);

                    cm.Parameters.AddWithValue("@catname", this.catn_textBox1.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category has been successfully updated!!");
                    this.Dispose();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void clear_button3_Click_1(object sender, EventArgs e)
        {
            clr();
            savebutton1.Enabled = true;
            update_button2.Enabled = false;
        }
    }
}
