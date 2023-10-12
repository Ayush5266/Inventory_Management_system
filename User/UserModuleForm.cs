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
    public partial class UserModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AKIDEAPAD;Initial Catalog=dbIMS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(pass_textBox2.Text != repass_textBox1.Text)
                {
                    MessageBox.Show("Please enter a valid password!!");
                    return;
                }
                if (MessageBox.Show("Are you sure?","Saving Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbUser(username,fullname,password,phone)VALUES(@username,@fullname,@password,@phone)", con);
                    cm.Parameters.AddWithValue("@username", this.un_textBox1.Text);
                    cm.Parameters.AddWithValue("@fullname", this.fn_textBox1.Text);
                    cm.Parameters.AddWithValue("@password", this.pass_textBox2.Text);
                    cm.Parameters.AddWithValue("@phone", this.ph_textBox3.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User succefully saved!!");
                    clr();
                     
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ",ex.Message);
            }
        }

        public void clr()
        {
            un_textBox1.Clear();
            fn_textBox1.Clear();
            pass_textBox2.Clear();
            repass_textBox1.Clear();
            ph_textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clr();
            this.savebutton1.Enabled = true;
            this.update_button2.Enabled = false;
        }

        private void update_button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (pass_textBox2.Text != repass_textBox1.Text)
                {
                    MessageBox.Show("Please enter a valid password!!");
                    return;
                }

                if (MessageBox.Show("Are you sure?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbUser SET fullname=@fullname, password=@password,phone=@phone WHERE username LIKE '"+un_textBox1.Text+ "' ", con);
                  
                    cm.Parameters.AddWithValue("@fullname", this.fn_textBox1.Text);
                    cm.Parameters.AddWithValue("@password", this.pass_textBox2.Text);
                    cm.Parameters.AddWithValue("@phone", this.ph_textBox3.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User succefully updated!!");
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
