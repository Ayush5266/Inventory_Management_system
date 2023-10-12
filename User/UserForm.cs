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
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AKIDEAPAD;Initial Catalog=dbIMS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user.tbUser' table. You can move, or remove it, as needed.
            //this.tbUserTableAdapter.Fill(this.user.tbUser);

        }

        public void LoadUser()
        {
            int i = 0;
            dgvUSER.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbUser", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUSER.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
            
        }

        private void add_Button1_Click(object sender, EventArgs e)
        {
            UserModuleForm uf = new UserModuleForm();
            uf.savebutton1.Enabled = true;
            uf.update_button2.Enabled = false;
            uf.ShowDialog();
            LoadUser();
            
        }

        private void dgvUSER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUSER.Columns[e.ColumnIndex].Name;
            if (colName=="Edit")
            {
                UserModuleForm um = new UserModuleForm();
                um.un_textBox1.Text = dgvUSER.Rows[e.RowIndex].Cells[1].Value.ToString();
                um.fn_textBox1.Text = dgvUSER.Rows[e.RowIndex].Cells[2].Value.ToString();
                um.pass_textBox2.Text = dgvUSER.Rows[e.RowIndex].Cells[3].Value.ToString();
                um.ph_textBox3.Text = dgvUSER.Rows[e.RowIndex].Cells[4].Value.ToString();
                //--------------------
                um.savebutton1.Enabled = false;
                um.update_button2.Enabled = true;
                um.un_textBox1.Enabled = false;
                um.ShowDialog();
                 
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbUser WHERE username LIKE '" + dgvUSER.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User succefully deleted!!");
                }
                else
                {
                    return;
                }

            }
            LoadUser();
            
        }
    }
}
