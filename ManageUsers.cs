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

namespace InventoryManagement
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abena\OneDrive\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from Usertb1";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LinkingPage l = new LinkingPage();
            l.Show(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTb1 values('" + uNameTb.Text + "', '" + fNameTb.Text + "', '" + pNumberTb.Text + "', '" + PasswordTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void uNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /**uNameTb.Text = UsersGv.SelectedRows[0].Cells[0].Value.ToString();
            fNameTb.Text = UsersGv.SelectedRows[0].Cells[1].Value.ToString();
            pNumberTb.Text = UsersGv.SelectedRows[0].Cells[2].Value.ToString();
            PasswordTb.Text = UsersGv.SelectedRows[0].Cells[3].Value.ToString();**/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pNumberTb.Text == "")
            {
                MessageBox.Show("Enter the Users Phone number");
            }
            else
            {
                Con.Open();
                string myquery = "delete from Usertb1 where pNumberTb= '" + pNumberTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update Usertb1 set Uname= '"+ uNameTb.Text+"', Ufullname= '"+fNameTb.Text+"', Upassword= '"+PasswordTb.Text+"' where Uphone= '"+pNumberTb.Text+"'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User updated Successfully");
                Con.Close();
            }
            catch
            {

            }
        }

        private void UsersGv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            uNameTb.Text = UsersGv.SelectedRows[0].Cells[1].Value.ToString();
            fNameTb.Text = UsersGv.SelectedRows[0].Cells[2].Value.ToString();
            pNumberTb.Text = UsersGv.SelectedRows[0].Cells[3].Value.ToString();
            PasswordTb.Text = UsersGv.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
