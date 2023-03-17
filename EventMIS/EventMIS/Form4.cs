using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
namespace EventMIS
{
    public partial class clientRegistrationForm : Form
    {
        public clientRegistrationForm()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedValue = PaymentChoiceCombo.SelectedItem.ToString();

            if (namestxtbox.Text=="" || usernametxt.Text=="" || passwordtxt.Text=="" || cofirmtxt.Text=="" || addresstxt.Text ==""  || emailtxt.Text=="" || contactTxt.Text =="" ||selectedValue ==""|| cardInfo.Text=="")
            {
                MessageBox.Show("Fill all the input fields");
            }
            else
            {
                if (passwordtxt.Text == cofirmtxt.Text)
                {
                    using (SqlConnection conn = new SqlConnection(AppConnection.getConString()))
                    {
                        conn.Open();
                        //Console.WriteLine($"Connection state after opening: {conn.State}");


                        //SqlCommand cmd = new SqlCommand();
                        string passHash = BCrypt.Net.BCrypt.HashPassword(passwordtxt.Text);

                        //string query = "INSERT INTO client(fullNames, address, phoneNumber,email,username,password,paymentMethod,cardNo) VALUES('"+namestxtbox.Text+"','"+addresstxt.Text+"','"+contactTxt.Text+"','"+ emailtxt.Text+"','"+usernametxt.Text+"','"+passwordtxt.Text+"','"+selectedValue+"'+'"+cardInfo+"')";

                        //SqlDataReader sdr = cmd.ExecuteReader();
                        //SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                        //sda.SelectCommand.ExecuteNonQuery();
                        //conn.Close();
                        //MessageBox.Show("User successfuly added");
                        using (SqlCommand cmd = new SqlCommand("addUser", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@fullNames", namestxtbox.Text);
                            cmd.Parameters.AddWithValue("@address", addresstxt.Text);
                            cmd.Parameters.AddWithValue("@phoneNumber", contactTxt.Text);
                            cmd.Parameters.AddWithValue("@email", emailtxt.Text);
                            cmd.Parameters.AddWithValue("@username", usernametxt.Text);
                            cmd.Parameters.AddWithValue("@password", passHash);
                            cmd.Parameters.AddWithValue("@paymentMethod", selectedValue);
                            cmd.Parameters.AddWithValue("@cardNo", cardInfo.Text);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Successfully registered");
                            // viewData();
                        }
                    }


                }


                else
                {
                    MessageBox.Show("Password not the same!");
                }
            }
        }

        private void PaymentChoiceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(AppConnection.getConString()))
            {
                // ComboBox paymentChoiceCombo = new ComboBox();
                //PaymentChoiceCombo.Items.Add("Credit card");
                //PaymentChoiceCombo.Items.Add("Debit card");
                //PaymentChoiceCombo.Items.Add("Paypal");


            }
        }
    }
}

