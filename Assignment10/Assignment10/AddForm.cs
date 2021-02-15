using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Assignment10
{
    public partial class AddForm : Form
    {
        MainForm mainForm;
        string connectionString;
        MySqlConnection mySqlConn;
        public AddForm(MainForm mainForm, string connectionString)
        {
            this.mainForm = mainForm;
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiParent.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiParent.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiParent.LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiParent.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(flightId.Text) || string.IsNullOrEmpty(firstName.Text) ||
                       string.IsNullOrEmpty(customerId.Text))
            {
                MessageBox.Show("Please give valid values!");
                return;
            }
            try
            {
                string query = "insert into customers (id, flight_id, name) values( " + int.Parse(customerId.Text) + ", " + int.Parse(flightId.Text) + ", '" + firstName.Text + "')";
                mySqlConn = new MySqlConnection(connectionString);

                MySqlCommand command = new MySqlCommand(query, mySqlConn);
                MySqlDataReader MyReader2;
                mySqlConn.Open();
                MyReader2 = command.ExecuteReader(); 
                MessageBox.Show("Save Data");
                customerId.Text = "";
                flightId.Text = "";
                firstName.Text = "";
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addFlightButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(flightIdTextBox.Text) || string.IsNullOrEmpty(originTextBox.Text) ||
                       string.IsNullOrEmpty(destinationTextBox.Text) || string.IsNullOrEmpty(dataTimeTextBox.Text) || string.IsNullOrEmpty(airlineCompanyTextBox.Text))
            {
                MessageBox.Show("Please give valid values!");
                return;
            }
            try
            {
                string query = "insert into flights (id, airline_company, origin, destination, date) values( " + 
                    int.Parse(flightIdTextBox.Text) + ", '" + airlineCompanyTextBox.Text + "', '" + originTextBox.Text + "', '" + 
                    destinationTextBox.Text + "', '" + dataTimeTextBox.Text + "')";
                mySqlConn = new MySqlConnection(connectionString);

                MySqlCommand command = new MySqlCommand(query, mySqlConn);
                MySqlDataReader MyReader2;
                mySqlConn.Open();
                MyReader2 = command.ExecuteReader();
                MessageBox.Show("Save Data");
                flightIdTextBox.Text = "";
                originTextBox.Text = "";
                destinationTextBox.Text = "";
                dataTimeTextBox.Text = "";
                airlineCompanyTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
