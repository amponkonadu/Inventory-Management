using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class LinkingPage : Form
    {
        public LinkingPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageUsers u = new ManageUsers();
            u.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login i = new Login();
            i.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageCustomers m = new ManageCustomers();
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageOrders or= new ManageOrders();
            or.Show();
        }
    }
}
