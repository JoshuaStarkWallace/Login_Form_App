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

namespace Login_Form
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=localhost;Initial Catalog=userLogin;Integrated Security=True");
            string query = "SELECT * FROM LoginCridentials WHERE UserName = '" + UserNameTextBox.Text.Trim() + "' AND Password = '" + PasswordTextBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                LoginSuccessForm lsfo = new LoginSuccessForm();
                this.Hide();
                lsfo.Show();
            }

            else
            {
                MessageBox.Show("Your UserName/Password is incorrect.");
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
