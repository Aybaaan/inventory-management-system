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

namespace InventoryMngmt.UC
{
    public partial class UC_Stocks : UserControl
    {
        public UC_Stocks()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ivan\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        void fillcategory()
        {
            string query = "select * from CategoryTable";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;

            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Category", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                stockCboxCat.ValueMember = "Category";
                stockCboxCat.DataSource = dt;
                stockCboxSearch.ValueMember = "Category";
                stockCboxSearch.DataSource = dt;
                Con.Close();
            } catch
            {

            }
        }

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from StockTable";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                stockDGrid.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        void filterCategory()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from StockTable where Category='" + stockCboxSearch.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                stockDGrid.DataSource = ds.Tables[0];
                Con.Close();
                stockDGrid.Refresh();
            }
            catch
            {

            }
        }

        private void UC_Stocks_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
           // filterCategory();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void stockBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into StockTable values('" + stockTxtPID.Text + "','" + stockTxtPName.Text + "','" + stockTxtQty.Text + "','" + stockTxtPrice.Text + "','" + stockTxtDesc.Text + "','" + stockCboxCat.SelectedValue.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfuly Added");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void stockBtnDelete_Click(object sender, EventArgs e)
        {
            if (stockTxtPID.Text == "")
            {
                MessageBox.Show("Enter the Product's ID");
            }
            else
            {
                Con.Open();
                string myquery = "delete from StockTable where ID='" + stockTxtPID.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void stockDGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            stockTxtPID.Text = stockDGrid.SelectedRows[0].Cells[0].Value.ToString();
            stockTxtPName.Text = stockDGrid.SelectedRows[0].Cells[1].Value.ToString();
            stockTxtQty.Text = stockDGrid.SelectedRows[0].Cells[2].Value.ToString();
            stockTxtPrice.Text = stockDGrid.SelectedRows[0].Cells[3].Value.ToString();
            stockTxtDesc.Text = stockDGrid.SelectedRows[0].Cells[4].Value.ToString();
            stockCboxCat.SelectedValue = stockDGrid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void stockBtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update StockTable set ProductName='" + stockTxtPName.Text + "',Quantity='" + stockTxtQty.Text + "',Price='" + stockTxtPrice.Text + "',Description='" + stockTxtDesc.Text + "',Category='" + stockCboxCat.SelectedValue.ToString() + "'where ID='" + stockTxtPID.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Details Successfuly Updated");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filterCategory();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void stockCboxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stockCboxCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
