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

namespace EventMIS
{
    public partial class bookTicketForm : Form
    {
        public bookTicketForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(AppConnection.getConString()))
            {
                conn.Open();
                string query = "SELECT eventname FROM Event";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("No data found");
                }
                else
                {
                    while (reader.Read())
                    {
                        eventnamecombo.Items.Add(reader["eventname"].ToString());
                    }
                }

                conn.Close();

            }

        }

        private void eventGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void eventnamecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(AppConnection.getConString()))
            {
                conn.Open();
                if (eventnamecombo.ValueMember != "")
                {
                    // Retrieve the selected event ID from the ComboBox
                    string selectedEventID = eventnamecombo.SelectedValue.ToString();
                    string query = "SELECT * FROM Event WHERE eventname = @eventname";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@eventname", selectedEventID);
                    DataTable dt = new DataTable();
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    eventGridView.DataSource = dt;

                }
                conn.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
