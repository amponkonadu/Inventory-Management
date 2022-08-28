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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abena\OneDrive\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");


        void fillcategory()
        {
            string query = "Select * from CategoryTb1";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                catcombo.ValueMember = "CatName";
                catcombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
        }
        void populate()
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (ProdIdTb.Text == "")
            {
                MessageBox.Show("Enter the Product ID");
            }
            else
            {
                Con.Open();
                string myquery = "delete from ProductTb1 where ProdId = '" + ProdIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTb1 set ProdName= '" + ProdNameTb.Text + "', ProdQty= '"+ QtyTb.Text+"', ProdPrice=  '"+ PriceTb+"', ProdCat= '"+ catcombo.SelectedValue.ToString()+"' where ProdId= '" + ProdIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product updated Successfully");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTb1 values('" + ProdIdTb.Text + "', '" + ProdNameTb.Text + "', '" + QtyTb.Text + "', '" + PriceTb.Text + "', '" + catcombo.SelectedValue.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LinkingPage l = new LinkingPage();
            l.Show();
        }

        private void ProductsGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdIdTb.Text = ProductsGv.SelectedRows[0].Cells[1].Value.ToString();
            ProdNameTb.Text = ProductsGv.SelectedRows[0].Cells[2].Value.ToString();
            QtyTb.Text = ProductsGv.SelectedRows[0].Cells[3].Value.ToString();
            PriceTb.Text = ProductsGv.SelectedRows[0].Cells[4].Value.ToString();
            catcombo.SelectedValue = ProductsGv.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void catcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
