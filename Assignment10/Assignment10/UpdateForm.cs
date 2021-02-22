using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Assignment10
{
    public partial class UpdateForm : Form
    {
        MainForm mainForm;
        string connectionString;
        MySqlConnection mySqlConn;
        public UpdateForm(MainForm mainForm, string connectionString)
        {
            this.mainForm = mainForm;
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(flightId.Text) || string.IsNullOrEmpty(firstName.Text) ||
                       string.IsNullOrEmpty(customerId.Text))
            {
                MessageBox.Show("Please give valid values!");
                return;
            }
            try
            {
                string query = "update customers set flight_id = "+ int.Parse(flightId.Text) + " ,name = '" + firstName.Text + "' where id = " + int.Parse(customerId.Text);
                mySqlConn = new MySqlConnection(connectionString);

                MySqlCommand command = new MySqlCommand(query, mySqlConn);
                MySqlDataReader MyReader2;
                mySqlConn.Open();
                MyReader2 = command.ExecuteReader();
                MessageBox.Show("Update Data");
                customerId.Text = "";
                flightId.Text = "";
                firstName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateFlightButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(flightIdTextBox.Text) || string.IsNullOrEmpty(originTextBox.Text) ||
                       string.IsNullOrEmpty(destinationTextBox.Text) || string.IsNullOrEmpty(dataTimeTextBox.Text) || string.IsNullOrEmpty(airlineCompanyTextBox.Text))
            {
                MessageBox.Show("Please give valid values!");
                return;
            }
            try
            {
                string query = "update flights set airline_company = '" + airlineCompanyTextBox.Text + "' ,origin = '" + originTextBox.Text + "' ,destination = '" + destinationTextBox.Text + 
                    "' , date = '" + dataTimeTextBox.Text + "' where id = " + int.Parse(flightIdTextBox.Text);
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

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
