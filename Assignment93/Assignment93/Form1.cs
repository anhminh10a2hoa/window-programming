using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment93
{
    public partial class Form1 : Form
    {
        SearchForm searchForm = null;
        AddCustomer addCustomerForm = null;
        AddFlight addFlightForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void searchCustomer(object sender, EventArgs e)
        {
            if (searchForm == null || searchForm.IsDisposed)
            {
                searchForm = new SearchForm();
                searchForm.Show();
            }
        }

        private void searchFlight(object sender, EventArgs e)
        {
            if (searchForm == null || searchForm.IsDisposed)
            {
                searchForm = new SearchForm();
                searchForm.Show();
            }
        }

        private void addCustomer(object sender, EventArgs e)
        {
            if (addCustomerForm == null || addCustomerForm.IsDisposed)
            {
                addCustomerForm = new AddCustomer();
                addCustomerForm.Show();
            }
        }

        private void addFlight(object sender, EventArgs e)
        {
            if (addFlightForm == null || addFlightForm.IsDisposed)
            {
                addFlightForm = new AddFlight();
                addFlightForm.Show();
            }
        }

        private void exitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
