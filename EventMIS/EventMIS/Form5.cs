using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;

namespace EventMIS
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(AppConnection.getConString()))
            {
                conn.Open();
                string query = "select username, password from Client where username='"+UsernameTextbox.Text+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string user = reader["username"].ToString();
                    // string last = reader["lastname"].ToString();
                    string hashedPassword = reader["password"].ToString();
                    conn.Close();

                    if (BCrypt.Net.BCrypt.Verify(PasswordTextBox.Text, hashedPassword))
                    {
                        if (user == "admin" && PasswordTextBox.Text=="Test123@")
                        {
                            adminDashboard adminform = new adminDashboard();
                            adminform.Show();
                        }
                        else
                        {
                            buyTicketForm buyForm = new buyTicketForm();
                            buyForm.Show();

                        }


                    }
                    else
                    {
                        MessageBox.Show("Wrong username/Password combination");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username/Password combination");
                    conn.Close();
                }
            }
        }

        private void RegisterUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clientRegistrationForm ed = new clientRegistrationForm();
            ed.Show();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
