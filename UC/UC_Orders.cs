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
    public partial class UC_Orders : UserControl
    {
        public UC_Orders()
        {
            InitializeComponent();
        }

        function fn = new function();
        String query;
        DataSet ds;

        DataTable table = new DataTable();

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ivan\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

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

       /* void populateBreakdown()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from BreakdownTable where=" table.Datar;
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrdersDGrid.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        } */

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
               // stockCboxCat.ValueMember = "Category";
                //stockCboxCat.DataSource = dt;
                stockCboxSearch.ValueMember = "Category";
                stockCboxSearch.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        private void stockCboxSearch_SelectedIndexChanged(object sender, EventArgs e)
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
            }
            catch
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void stockTxtQty_TextChanged(object sender, EventArgs e)
        {

        }

        int flag = 0;
        int stock;
        private void stockDGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            prodname = stockDGrid.SelectedRows[0].Cells[1].Value.ToString();
            stock = Convert.ToInt32(stockDGrid.SelectedRows[0].Cells[2].Value.ToString());
            //qty = Convert.ToInt32(orderTxtQty)
            uprc = Convert.ToInt32(stockDGrid.SelectedRows[0].Cells[3].Value.ToString());
            //totprc = qty * uprc; */
            flag = 1; 
        }
        /*
        void updateProd()
        {
            
            int id = Convert.ToInt32(stockDGrid.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - Convert.ToInt32(orderTxtQty.Text);
            if (newQty < 0)
            {
                MessageBox.Show("Operation Failed.");
            }
            else
            {
                Con.Open();
                string query = "update StockTable set Quantity = " + newQty + " where ID=" + id + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populate();
            }
        }
        */

        private void UC_Orders_Load(object sender, EventArgs e)
        {
            populate();
            fillcategory();

            /*
            table.Columns.Add("Item", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Price", typeof(int));
            table.Columns.Add("Subtotal", typeof(int)); 
            OrdersDGrid.DataSource = table;
            */
        }

        int num = 0;
        string prodname;
        int uprc, totprc, qty;
        int sum = 0, n;
        private void btnOrder_Click(object sender, EventArgs e)
        {

            if (orderTxtQty.Text == "")
                MessageBox.Show("Quantity field is blank");
            else if (flag == 0)
            {
                MessageBox.Show("Select the Product");
            }
            else if (Convert.ToInt32(orderTxtQty.Text) > stock)
            {
                MessageBox.Show("Not enough stock for this product.");
            }
            else
            {
                query = "select Quantity from StockTable where ID='" + Convert.ToInt32(stockDGrid.SelectedRows[0].Cells[0].Value.ToString()) + "'";
                ds = fn.getData(query);

                //qty = int.Parse(ds.)

                n = OrdersDGrid.Rows.Add();
                num = num + 1;
                qty = Convert.ToInt32(orderTxtQty.Text);
                totprc = qty * uprc;

                OrdersDGrid.Rows[n].Cells[0].Value = num.ToString();
                OrdersDGrid.Rows[n].Cells[1].Value = prodname.ToString();
                OrdersDGrid.Rows[n].Cells[2].Value = qty.ToString();
                OrdersDGrid.Rows[n].Cells[3].Value = uprc.ToString();
                OrdersDGrid.Rows[n].Cells[4].Value = totprc.ToString();
                   
                /*
                sum = sum + totprc;
                total.Text = sum.ToString();
                updateProd();
                fn.setData(query, "Item Added");
                */
                flag = 0;
                
                //table.Rows.Add(num, prodname, qty, uprc, totprc);
                //OrdersDGrid.DataSource = table;

                //OrdersDGrid.DataSource = null;
            }

        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            if(orderTxtID.Text == "" || orderTxtName.Text == "" || total.Text == "")
            {
                MessageBox.Show("A Field is not Answered Correctly");
            }
            else
            {
                //populate();
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TransactTable values('" + orderTxtID.Text + "','" + orderTxtName.Text + "','" + dateOrders.Text + "','" + total.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Transaction Successfuly Added");
                    Con.Close();
                }
                catch(SqlException exception)
                {
                    MessageBox.Show("Transaction ID Must be Unique.");
                }
            }
        }

        private void orderTxtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderTxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            OrderList orderList = new OrderList();
            orderList.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
