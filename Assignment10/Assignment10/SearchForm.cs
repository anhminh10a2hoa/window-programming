using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Assignment10
{
    public partial class SearchForm : Form
    {
        MainForm mainForm;
        string connectionString;
        public SearchForm(MainForm mainForm, string connectionString)
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

        private void searchFlightButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(flightId.Text))
            {
                MessageBox.Show("Please give valid values!");
                return;
            }
            try
            {
                string Query = "select * from flights left join customers on flights.id=customers.flight_id where flights.id=" + int.Parse(flightId.Text);
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchCustomerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerId.Text))
            {
                MessageBox.Show("Please give valid values!");
                return;
            }
            try
            {
                string Query = "select * from customers left join flights on customers.flight_id=flights.id where customers.id=" + int.Parse(customerId.Text);
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
