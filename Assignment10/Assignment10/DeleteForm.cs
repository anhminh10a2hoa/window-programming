using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Assignment10
{
    public partial class DeleteForm : Form
    {
        MainForm mainForm;
        string connectionString;
        public DeleteForm(MainForm mainForm, string connectionString)
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

        private void deleteFlightButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(flightId.Text))
            {
                MessageBox.Show("Please give valid values!");
                return;
            }
            try
            {
                string Query = "delete from flights where id=" + int.Parse(flightId.Text) + ";";
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                MyConn2.Close();
                flightId.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerId.Text))
            {
                MessageBox.Show("Please give valid values!");
                return;
            }
            try
            {
                string Query = "delete from customers where id=" + int.Parse(customerId.Text) + ";";
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                MyConn2.Close();
                customerId.Text = "";
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
