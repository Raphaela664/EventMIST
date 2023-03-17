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

namespace EventMIS
{
    public partial class buyTicketForm : Form
    {
        public buyTicketForm()
        {
            InitializeComponent();
        }

        private void eventnamecombo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void pricecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (SqlConnection conn = new SqlConnection(AppConnection.getConString()))
            //{
            //  conn.Open();
            // if (eventnamecombo.ValueMember != "")
            {
                // Retrieve the selected event ID from the ComboBox
                //   string selectedEventID = eventnamecombo.SelectedValue.ToString();
                //   string query = "SELECT * FROM Event WHERE eventname = @eventname";
                //   SqlCommand cmd = new SqlCommand(query, conn);
                //   cmd.Parameters.AddWithValue("@eventname", selectedEventID);
                //  DataTable dt = new DataTable();
                // SqlDataReader rd = cmd.ExecuteReader();
                // dt.Load(rd);
                // eventGridView.DataSource = dt;

                // }
                // conn.Close();
            }
        }

        private void EventGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(AppConnection.getConString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("displayItem", conn))
                {
                    string selectedEventName = eventnamecombo.SelectedValue.ToString();

                    cmd.Parameters.AddWithValue("@itemName", selectedEventName);
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataTable dtEvent = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtEvent.Load(sdr);
                    EventGridView.DataSource = dtEvent;

                    conn.Close();

                }
            }
        }

        private void eventnamecombo_Click(object sender, EventArgs e)
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

        private void buyBtn_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(AppConnection.getConString()))
            {
                conn.Open();
                if (eventnamecombo.ValueMember != "" && pricecombo.ValueMember!="")
                {
                    // Retrieve the selected event ID from the ComboBox
                    string selectedEventName = eventnamecombo.SelectedValue.ToString();

                    int selectedPice = pricecombo.SelectedIndex;
                    //SqlDataAdapter da = new SqlDataAdapter();
                    string query = "insert into attendance(event_name,price)values('"+selectedEventName+"','"+selectedPice+"')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //cmd.Parameters.AddWithValue("@eventname", selectedEventName);
                    //cmd.Parameters.AddWithValue()

                    //DataTable dt = new DataTable();
                    //SqlDataReader rd = cmd.ExecuteReader();
                    // dt.Load(rd);
                    // EventGridView.DataSource = dt;
                    MessageBox.Show("Buy Ticket successful");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Buy Ticket unsuccessful");
                }

            }
        }
    }
}
