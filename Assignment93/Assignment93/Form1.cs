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

        private void writeData(object sender, EventArgs e)
        {
            List<Flight> flight = new List<Flight>();
            flight.Add(new Flight("VN1", "Vaasa", "Ha Noi", "20/10/2021"));
            flight.Add(new Flight("HCM1", "Ho Chi Minh", "Vaasa", "20/10/2021"));
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer("1", "Minh Hoang", "VN1", "99999999999"));
            customer.Add(new Customer("2", "Justin Bieber", "VN1", "888888888888"));
            customer.Add(new Customer("3", "Ronaldo", "HCM1", "77777777777"));
            customer.Add(new Customer("4", "Messi", "HCM1", "666666666666"));
            Flight.WriteJson(@"d:\temp\ass9_flight.json", flight);
            Customer.WriteJson(@"d:\temp\ass9_customer.json", customer);
        }
    }
}
