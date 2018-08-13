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

namespace PayrollSystem
{
    public partial class AdminFrame : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mercy\Desktop\Beni\PayrollSystem\PayrollSystem\RegistrationDB.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        SqlConnection conn;
        SqlDataAdapter adapt;

        
        public AdminFrame()
        {
            InitializeComponent();
        }

        private void AdminFrame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDBDataSet.tblUserAccount' table. You can move, or remove it, as needed.
            this.tblUserAccountTableAdapter.Fill(this.registrationDBDataSet.tblUserAccount);
            display();

            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mercy\Desktop\Beni\PayrollSystem\PayrollSystem\RegistrationDB.mdf;Integrated Security=True";
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from tblEditAccount", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();

            DataTable table = new DataTable();

            dataGridView2.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(rowIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditFrame ef = new EditFrame();
            ef.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  * from tblEditAccount";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mercy\Desktop\Beni\PayrollSystem\PayrollSystem\RegistrationDB.mdf;Integrated Security=True";
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from tblEditAccount where FirstName like '" + txtSearch.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mercy\Desktop\Beni\PayrollSystem\PayrollSystem\RegistrationDB.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(" select * from tblEditAccount ;", con);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bs = new BindingSource();

                bs.DataSource = dt;
                dataGridView2.DataSource = bs;
                da.Update(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mercy\Desktop\Beni\PayrollSystem\PayrollSystem\RegistrationDB.mdf;Integrated Security=True";
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from tblEditAccount where FirstName like '" + txtSearch.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
    }
}
