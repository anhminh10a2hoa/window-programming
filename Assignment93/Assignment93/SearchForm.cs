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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        SearchFlight searchFlightForm = null;
        SearchCustomer searchCustomerForm = null;
        Flight Flight = new Flight();
        List<Flight> fligtCollection = Flight.ReadJson(@"d:\temp\ass9_flight.json");
        Customer Customer = new Customer();
        List<Customer> customerCollection = Customer.ReadJson(@"d:\temp\ass9_customer.json");

        private void searchCustomer(object sender, EventArgs e)
        {
            String res = "";
            foreach (var c in this.customerCollection)
            {
                if (c.Id == textBox2.Text)
                {
                    res += c.ToString() + "\n\n";
                    foreach (var f in this.fligtCollection)
                    {
                        if (f.Id == c.FlightId)
                        {
                            res += f.ToString() + "\n\n";
                        }
                    }
                }
            }
            
            if (searchCustomerForm == null || searchCustomerForm.IsDisposed)
            {
                searchCustomerForm = new SearchCustomer();
                searchCustomerForm.showAllData(res);
                searchCustomerForm.Show();
            }
        }

        private void searchFlight(object sender, EventArgs e)
        {
            String res = "";
            foreach (var f in this.fligtCollection)
            {
                if (f.Id == textBox1.Text)
                {
                    res += f.ToString() + "\n\n";
                    res += "List of customers\n\n";
                    foreach (var c in this.customerCollection)
                    {
                        if (c.FlightId == f.Id)
                        {
                            res += c.ToString() + "\n\n";
                        }
                    }
                }
            }
            if (searchFlightForm == null || searchFlightForm.IsDisposed)
            {
                searchFlightForm = new SearchFlight();
                searchFlightForm.showAllData(res);
                searchFlightForm.Show();
            }
        }
    }
}
