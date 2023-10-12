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

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AKIDEAPAD;Initial Catalog=dbIMS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void showpass_checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass_checkBox1.Checked == false)
            {
                password_tb2.UseSystemPasswordChar = true;
            }
            else
            {
                password_tb2.UseSystemPasswordChar = false;
            }
        }

        private void clr_label4_Click(object sender, EventArgs e)
        {
            username_tb1.Clear();
            password_tb2.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void login_button1_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tbUser WHERE username=@username AND password=@password", con);
                cm.Parameters.AddWithValue("@username", username_tb1.Text);
                cm.Parameters.AddWithValue("@password", password_tb2.Text);
                con.Open();
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Welcome " + dr["fullname"].ToString() +" ","Access Granted",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Mainform main = new Mainform();
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!!!","Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.Message);
            }
        }
    }
}
