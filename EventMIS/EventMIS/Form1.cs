using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Windows.Forms;


namespace EventMIS
{
    public partial class eventForm : Form
    {
        public eventForm()
        {
            InitializeComponent();
        }
        public void viewData()
        {

            using (SqlConnection conn = new SqlConnection(AppConnection.getConString()))
            {
                conn.Open();
                string query = "SELECT * FROM Event";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DataTable dtEvent = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtEvent.Load(sdr);
                    eventGridView.DataSource = dtEvent;

                }
            }


        }

        private void eventId_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void eventForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(AppConnection.getConString()))
            {
                conn.Open();
                string query = "SELECT * FROM Event";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DataTable dtEvent = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtEvent.Load(sdr);
                    eventGridView.DataSource = dtEvent;

                }
            }
        }

        private void viewAll_Click(object sender, EventArgs e)
        {
            viewData();
        }

        private void createEvent_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(AppConnection.getConString()))
            {
                //string query = "SELECT * FROM Event";
                con.Open();
                using (SqlCommand cmd = new SqlCommand("insertData2", con))
                {
                    DateTime selectedDate = eventdate.Value;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@eventName", eventNameTxt.Text);
                    cmd.Parameters.AddWithValue("@location", eventLocationTxt.Text);
                    cmd.Parameters.AddWithValue("@eventDate", selectedDate);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully registered");
                    viewData();
                }
            }
        }

        private void updateEvent_Click(object sender, EventArgs e)
        {

        }

        private void deleteEvent_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}