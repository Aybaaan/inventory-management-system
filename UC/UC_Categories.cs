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
    public partial class UC_Categories : UserControl
    {
        public UC_Categories()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ivan\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CategoryTable";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                categoryDGrid.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void catTxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void catBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CategoryTable values('" + catTxtID.Text + "','" + catTxtName.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfuly Added");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void catBtnDelete_Click(object sender, EventArgs e)
        {
            if (catTxtID.Text == "")
            {
                MessageBox.Show("Enter Category ID");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CategoryTable where ID='" + catTxtID.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void catBtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CategoryTable set Category='" + catTxtName.Text + "'where ID='" + catTxtID.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfuly Updated");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void categoryDGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            catTxtID.Text = categoryDGrid.SelectedRows[0].Cells[0].Value.ToString();
            catTxtName.Text = categoryDGrid.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void UC_Categories_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
