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
    public partial class EditFrame : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mercy\Desktop\Beni\PayrollSystem\PayrollSystem\RegistrationDB.mdf;Integrated Security=True");
        public EditFrame()
        {
            InitializeComponent();
        }

        private void EditFrame_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String images = "";
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All files(*.*)|*.*";

                if(file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    images = file.FileName;

                    picture.ImageLocation = images;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tblEditAccount values('"+fname.Text+"','"+lastn.Text+"','"+num.Text+"','"+gender.Text+"','"+add.Text+"','"+no1.Text+"','"+no2.Text+"','"+no3.Text+"','"+dept.Text+"','"+dhired.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Added!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fname.Text = "";
            lastn.Text = "";
            num.Text = "";
            gender.Text = "";
            add.Text = "";
            no1.Text = "";
            no2.Text = "";
            no3.Text = "";
            dept.Text = "";
            dhired.Text = "";
        }

        
    }
}
