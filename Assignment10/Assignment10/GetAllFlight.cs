using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Assignment10
{
    public partial class GetAllFlight : Form
    {
        MainForm mainForm;
        string connectionString;
        public GetAllFlight(MainForm mainForm, string connectionString)
        {
            this.mainForm = mainForm;
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void GetAllForm_Load(object sender, EventArgs e)
        {
            try
            {
                string Query = "select * from flights";
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
    }
}
