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

namespace InventoryMngmt
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ivan\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void Home_Load(object sender, EventArgs e)
        {
            uC_Homepage1.Visible = true;
            uC_Account1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e) //LOGOUT BUTTON
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDelivery_Click(object sender, EventArgs e) // ORDERS
        {
            uC_Homepage1.Visible = true;
            uC_Homepage1.BringToFront();
        }
      

        private void btnUser_Click(object sender, EventArgs e)
        {
            uC_Account1.Visible = true;
            uC_Account1.BringToFront(); 
        }

        private void btnHome_Click(object sender, EventArgs e) //CATEGORY
        {
            uC_Categories1.Visible = true;
            uC_Categories1.BringToFront();
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            uC_Stocks1.Visible = true;
            uC_Stocks1.BringToFront();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            uC_Returns1.Visible = true;
            uC_Returns1.BringToFront();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            uC_Monitoring1.Visible = true;
            uC_Monitoring1.BringToFront();
        }

        private void btnPartners_Click(object sender, EventArgs e)
        {
            uC_Partner1.Visible = true;
            uC_Partner1.BringToFront();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            uC_Transfer1.Visible = true;
            uC_Transfer1.BringToFront();
        }
    }
}
