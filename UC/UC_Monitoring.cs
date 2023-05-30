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
    public partial class UC_Monitoring : UserControl
    {
        public UC_Monitoring()
        {
            InitializeComponent();
        }

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
                ordersDGrid.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        void populateBreakdown()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from BreakdownTable";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                breakdownGrid.DataSource = ds.Tables[0];
                breakdownGrid.Refresh();
                Con.Close();
            }
            catch
            {

            }
        }

        void populateTransfer()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from TransferTable";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                TransferDGrid.DataSource = ds.Tables[0];
                TransferDGrid.Refresh();
                Con.Close();
            }
            catch
            {

            }
        }

        void populateDisposal()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from DisposalTable";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                disposeDGrid.DataSource = ds.Tables[0];
                disposeDGrid.Refresh();
                Con.Close();
            }
            catch
            {

            }
        }

        private void UC_Monitoring_Load(object sender, EventArgs e)
        {
            populate();
            populateBreakdown();
            populateTransfer();
            populateDisposal();
        }

        private void btnCStock_Click(object sender, EventArgs e)
        {
            breakdownGrid.Visible = false;
            TransferDGrid.Visible = false;
            disposeDGrid.Visible = false;
            ordersDGrid.Visible = true;

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            breakdownGrid.Visible = true;
            ordersDGrid.Visible = false;
            TransferDGrid.Visible = false;
            disposeDGrid.Visible = false;
            breakdownGrid.Refresh();
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            populate();
            populateBreakdown();
            populateTransfer();
            populateDisposal();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            breakdownGrid.Visible = false;
            disposeDGrid.Visible = false;
            ordersDGrid.Visible = false;
            TransferDGrid.Visible = true;
        }

        private void btnDispose_Click(object sender, EventArgs e)
        {
            breakdownGrid.Visible = false;
            disposeDGrid.Visible = true;
            ordersDGrid.Visible = false;
            TransferDGrid.Visible = false;
        }
    }
}
