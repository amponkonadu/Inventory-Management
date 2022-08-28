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

namespace InventoryManagement
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abena\OneDrive\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CusomerTb1";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        void populateproducts()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTb1";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //.Text = ProductsGv.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventorydbDataSet4.ProductTb1' table. You can move, or remove it, as needed.
            this.productTb1TableAdapter.Fill(this.inventorydbDataSet4.ProductTb1);
            // TODO: This line of code loads data into the 'inventorydbDataSet3.CustomerTb1' table. You can move, or remove it, as needed.
            this.customerTb1TableAdapter.Fill(this.inventorydbDataSet3.CustomerTb1);
            populate();
            populateproducts();
        }

        private void CustomersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomeridTb.Text = CustomersGv.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LinkingPage k = new LinkingPage();
            k.Show(); 
        }

        private void catcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
