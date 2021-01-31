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

        private void openFlightFile(object sender, EventArgs e)
        {
            using (OpenFileDialog sfd = new OpenFileDialog())
            {
                sfd.InitialDirectory = "D:\temp";
                sfd.Filter = "All Files|*.json*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = sfd.FileName;
                }
            }
        }

        private void openCustomerFile(object sender, EventArgs e)
        {
            using (OpenFileDialog sfd = new OpenFileDialog())
            {
                sfd.InitialDirectory = "D:\temp";
                sfd.Filter = "All Files|*.json*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    label2.Text = sfd.FileName;
                }
            }
        }


        private void searchCustomer(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(label1.Text) || String.IsNullOrEmpty(label2.Text))
            {
                error.Text = "Please provide files you want to search data";
            }
            else
            {
                error.Text = "";
                List<Customer> customerCollection = Customer.ReadJson(label2.Text);
                List<Flight> flightCollection = Flight.ReadJson(label1.Text);
                if(String.IsNullOrEmpty(textBox2.Text))
                {
                    error.Text = "Please file customerId";
                } else {
                    error.Text = "";
                    String res = "";
                    foreach (var c in customerCollection)
                    {
                        if (c.Id == textBox2.Text)
                        {
                            res += c.ToString() + "\n\n";
                            foreach (var f in flightCollection)
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
                
            }
        }

        private void searchFlight(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label1.Text) || String.IsNullOrEmpty(label2.Text))
            {
                error.Text = "Please provide files you want to search data";
            }
            else
            {
                error.Text = "";
                List<Customer> customerCollection = Customer.ReadJson(label2.Text);
                List<Flight> flightCollection = Flight.ReadJson(label1.Text);
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    error.Text = "Please file flighId";
                } else
                {
                    error.Text = "";
                    String res = "";
                    foreach (var f in flightCollection)
                    {
                        if (f.Id == textBox1.Text)
                        {
                            res += f.ToString() + "\n\n";
                            res += "List of customers\n\n";
                            foreach (var c in customerCollection)
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
    }
}
