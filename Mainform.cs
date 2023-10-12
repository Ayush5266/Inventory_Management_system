using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        //to show subform in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            main_panel3.Controls.Add(childForm);
            main_panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void User_Button4_Click(object sender, EventArgs e)
        {
            //openChildForm(new UserForm());

            InventoryManagementSystem.UserForm uf = new UserForm();
            uf.TopLevel = false;
            uf.FormBorderStyle = FormBorderStyle.None;
            uf.Dock = DockStyle.Fill;
            main_panel3.Controls.Add(uf);
            main_panel3.Tag = uf;
            uf.BringToFront();
            uf.Show();
           // uf.ShowDialog();
        }
        private void customer_Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm());

            //InventoryManagementSystem.CustomerForm cf = new CustomerForm();
            //cf.TopLevel = false;
            //cf.FormBorderStyle = FormBorderStyle.None;
            //cf.Dock = DockStyle.Fill;
            //main_panel3.Controls.Add(cf);
            //main_panel3.Tag = cf;
            //cf.BringToFront();
            //cf.Show();
        }
        private void category_Button3_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());

        }
        private void product_Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Product.ProductForm());

        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void Order_Button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Order.OrderForm());
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
              Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
