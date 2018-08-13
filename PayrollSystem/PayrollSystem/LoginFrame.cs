using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PayrollSystem
{
    public partial class LoginFrame : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mercy\Desktop\Beni\PayrollSystem\PayrollSystem\RegistrationDB.mdf;Integrated Security=True";
        public LoginFrame()
        {
            Thread a = new Thread(new ThreadStart(StartForm));
            a.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            a.Abort();
        }

        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationFrame registerform = new RegistrationFrame();
            registerform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userName.Text == "" || passWord.Text == "")
                MessageBox.Show("Invalid Input!");
            else
            {
                using (SqlConnection Con = new SqlConnection(connection))
                {
                    
                    SqlCommand cmd = new SqlCommand("UserAdd", Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", userName.Text);
                    cmd.Parameters.AddWithValue("@password", passWord.Text);

                    Con.Open();
                    if (userName.Text == "Admin" || passWord.Text == "Admin123")
                    {
                        AdminFrame af = new AdminFrame();
                        af.Show();
                    }
                    else
                    {
                        PayrollFrame pf = new PayrollFrame();
                        pf.Show();
                    }
                    Con.Close();
                }
            }
        }
    }
}
