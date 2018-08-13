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
    public partial class RegistrationFrame : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mercy\Desktop\Beni\PayrollSystem\PayrollSystem\RegistrationDB.mdf;Integrated Security=True";
        public RegistrationFrame()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtpass.Text == "")
                MessageBox.Show("Invalid Input!");
            else if (txtpass.Text != ConPass.Text)
                MessageBox.Show("Password do not match!");
            else
            {
                using (SqlConnection Connect = new SqlConnection(connectionString))
                {
                    Connect.Open();
                    SqlCommand Command = new SqlCommand("UserAdd", Connect);
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Username", txtuser.Text.Trim());
                    Command.Parameters.AddWithValue("@Password", txtpass.Text.Trim());
                    Command.ExecuteNonQuery();
                    MessageBox.Show("Successfully Registered!");

                    LoginFrame log = new LoginFrame();
                    log.Show();
                    Clear();
                }
            }
        }

        void Clear()
        {
            txtuser.Text = "";
            txtpass.Text = "";
            ConPass.Text = "";
        }

        private void RegistrationFrame_Load(object sender, EventArgs e)
        {

        }
    }
}
