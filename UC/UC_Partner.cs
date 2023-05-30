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
    public partial class UC_Partner : UserControl
    {
        public UC_Partner()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ivan\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from PartnerTable";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                partnerDGrid.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        private void UC_Partner_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into PartnerTable values('" + txtPartnerID.Text + "','" + txtPartnerName.Text + "','" + txtContact.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfuly Added");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPartnerID.Text == "")
                {
                    MessageBox.Show("Enter User's Contact Number");
                }
                else
                {
                    Con.Open();
                    string myquery = "delete from PartnerTable where ContactNo='" + txtPartnerID.Text + "';";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted");
                    Con.Close();
                    populate();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void partnerDGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPartnerID.Text = partnerDGrid.SelectedRows[0].Cells[0].Value.ToString();
            txtPartnerName.Text = partnerDGrid.SelectedRows[0].Cells[1].Value.ToString();
            txtContact.Text = partnerDGrid.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update PartnerTable set PartnerName='" + txtPartnerName.Text + "',ContactNo='" + txtContact.Text + "'where PartnetID='" + txtPartnerID.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfuly Updated");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }
            
    }
}
