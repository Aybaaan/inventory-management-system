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
    public partial class UC_Account : UserControl
    {
        public UC_Account()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ivan\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from UserTable";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                userDGrid.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void userBtnAdd_Click(object sender, EventArgs e)
        {
            try {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTable values('" + userTxtUsername.Text + "','" + userTxtFullname.Text + "','" + userTxtPassword.Text + "','" + userTxtContact.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfuly Added");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void UC_Account_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void userBtnDelete_Click(object sender, EventArgs e)
        {
            if (userTxtContact.Text == "")
            {
                MessageBox.Show("Enter User's Contact Number");
            } 
            else
            {
                Con.Open();
                string myquery = "delete from UserTable where ContactNo='" + userTxtContact.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void userDGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            userTxtUsername.Text = userDGrid.SelectedRows[0].Cells[0].Value.ToString();
            userTxtFullname.Text = userDGrid.SelectedRows[0].Cells[1].Value.ToString();
            userTxtPassword.Text = userDGrid.SelectedRows[0].Cells[2].Value.ToString();
            userTxtContact.Text = userDGrid.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void userBtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTable set UserName='" + userTxtUsername.Text +"',FullName='" + userTxtFullname.Text +"',Password='" + userTxtPassword.Text +"'where ContactNo='" + userTxtContact.Text +"'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Account Successfuly Updated");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void userTxtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
