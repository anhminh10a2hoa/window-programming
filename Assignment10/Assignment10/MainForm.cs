using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment10
{
    public partial class MainForm : Form
    {
        string connectionString = "datasource=mysql.cc.puv.fi;database=e1800956_assignment10;username=e1800956;password=xnmzsakPTzEr";
        private int formCounter;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menuStrip1.MdiWindowListItem = windowToolStripMenuItem;
        }

        private void searchDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCounter++;
            SearchForm newMDIChild = new SearchForm(this, connectionString);
            newMDIChild.Text += " " + formCounter;
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void addDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCounter++;
            AddForm newMDIChild = new AddForm(this, connectionString);
            newMDIChild.Text += " " + formCounter;
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCounter++;
            DeleteForm newMDIChild = new DeleteForm(this, connectionString);
            newMDIChild.Text += " " + formCounter;
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void getAllFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCounter++;
            GetAllFlight newMDIChild = new GetAllFlight(this, connectionString);
            newMDIChild.Text += " " + formCounter;
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void getAllCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCounter++;
            GetAllCustomer newMDIChild = new GetAllCustomer(this, connectionString);
            newMDIChild.Text += " " + formCounter;
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
