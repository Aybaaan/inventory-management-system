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
    public partial class UC_Returns : UserControl
    {
        public UC_Returns()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ivan\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        function fn = new function();
        String query;
        DataSet ds;

        DataTable dtInsert;

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

        private void UC_Returns_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void stockDGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductID.Text = stockDGrid.SelectedRows[0].Cells[0].Value.ToString();
            txtProdName.Text = stockDGrid.SelectedRows[0].Cells[1].Value.ToString();
        }

        protected int quantity, newQuantity;

        private void columnList()
        {
            if (dtInsert == null)
            {
                dtInsert = new DataTable();
                DataColumnCollection cols = dtInsert.Columns;
                if (!cols.Contains("Product ID"))
                {
                    DataColumn col_insertproduct_id = new DataColumn("Product ID", typeof(string));
                    dtInsert.Columns.Add(col_insertproduct_id);
                }

                if (!cols.Contains("Product Name"))
                {
                    DataColumn col_insertproduct_id = new DataColumn("Product Name", typeof(string));
                    dtInsert.Columns.Add(col_insertproduct_id);
                }

                if (!cols.Contains("Quantity"))
                {
                    DataColumn col_insertproduct_id = new DataColumn("Quantity", typeof(string));
                    dtInsert.Columns.Add(col_insertproduct_id);
                }

                if (!cols.Contains("Description"))
                {
                    DataColumn col_insertproduct_id = new DataColumn("Description", typeof(string));
                    dtInsert.Columns.Add(col_insertproduct_id);
                }

                if (!cols.Contains("Transaction ID"))
                {
                    DataColumn col_insertproduct_id = new DataColumn("Transaction ID", typeof(string));
                    dtInsert.Columns.Add(col_insertproduct_id);
                }
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            columnList();
            if (txtProductID.Text != "")
            {
                query = "select Quantity from StockTable where ID = '" + txtProductID.Text + "'";
                ds = fn.getData(query);

                quantity = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - int.Parse(txtQty.Text);

                if (newQuantity >= 0)
                {
                    //n = ordersDGrid.Rows.Add();
                    DataRow dr = dtInsert.NewRow();

                    dr[dtInsert.Columns[0]] = txtProductID.Text;
                    dr[dtInsert.Columns[1]] = txtProdName.Text;
                    dr[dtInsert.Columns[2]] = txtQty.Text;
                    dr[dtInsert.Columns[3]] = txtDesc.Text;
                    dr[dtInsert.Columns[4]] = txtTransID.Text;

                    dtInsert.Rows.Add(dr);

                    breakdownDGrid.DataSource = dtInsert;
                    breakdownDGrid.Refresh();

                    //totalAmt = totalAmt + int.Parse(txtSubtotal.Text);
                    //lblTotal.Text = "Php " + totalAmt.ToString();

                    query = "update StockTable set Quantity ='" + newQuantity + "' where ID = '" + txtProductID.Text + "'";
                    fn.setData(query, "Product Added to List");
                }
                else
                {
                    MessageBox.Show("Not Enough Stock\n Only " + quantity + " Left", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                UC_Returns_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Product First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int valueAmt;
        string valueId;
        protected int qty;

        private void breakdownDGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valueId = breakdownDGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            qty = int.Parse(breakdownDGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
        }
        private void stockDGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (valueId != null)
            {
                try
                {
                    breakdownDGrid.Rows.RemoveAt(this.breakdownDGrid.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select Quantity from StockTable where ID ='" + valueId + "'";
                    ds = fn.getData(query);
                    quantity = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + qty;

                    query = "update StockTable set Quantity ='" + newQuantity + "' where ID='" + valueId + "'";
                    fn.setData(query, "Product Removed from List");
                    //totalAmt = totalAmt - valueAmt;

                    //lblTotal.Text = "Php " + totalAmt.ToString();
                }
                UC_Returns_Load(this, null);
            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd;

                //cmd = new SqlCommand("insert into BreakdownTable (ProductID, ProductName, Price, Quantity, Subtotal, OrderDate, CustomerName) values (@ProductID, @ProductName, @Price, @Quantity, @Subtotal, @OrderDate, @CustomerName)", Con);
                string command = "";
                for (int i = 0; i < dtInsert.Rows.Count; i++)
                {
                    command = command + "insert into DisposalTable (ProductID, ProductName, Quantity, Description, TransacNo) values ('" + dtInsert.Rows[i][0].ToString() + "', '" + dtInsert.Rows[i][1].ToString() + "', '" + dtInsert.Rows[i][2].ToString() + "', '" + dtInsert.Rows[i][3].ToString() + "', '" + dtInsert.Rows[i][4].ToString() + "'); ";
                }
                cmd = new SqlCommand(command, Con);
                cmd.ExecuteNonQuery();

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Products Successfuly Disposed");
                dtInsert.Dispose();
                breakdownDGrid.DataSource = null;
                breakdownDGrid.Refresh();
            }
        }

        private void clearAll()
        {
            txtProductID.Clear();
            txtProdName.Clear();
            txtDesc.Clear();
            txtQty.Clear();
            txtTransID.Clear();
        }
    }
}
