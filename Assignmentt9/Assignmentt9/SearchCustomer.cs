using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignmentt9
{
    public partial class SearchCustomer : Form
    {
        ReadWriteHandler ReadWriteHandler = new ReadWriteHandler();
        List<Flight> fligtCollection = ReadWriteHandler.ReadJson(@"d:\temp\as8.json");
        Summary summary = null;
        public SearchCustomer()
        {
            InitializeComponent();
        }

        public void searchCustomer(object sender, EventArgs e)
        {
            if (this.flightId.Text == "" || this.customerId.Text == "")
            {
                this.error.Text = "Please fill all fields";
            }
            else
            {
                var flight = fligtCollection.FirstOrDefault(f => f.Id == this.flightId.Text);
                if (flight == null)
                {
                    this.error.Text = "Can not find this flight Id";
                } else
                {
                    var customer = flight.CustomerList.FirstOrDefault(c => c.Id == this.customerId.Text);
                    if (customer == null)
                    {
                        this.error.Text = "Can not find this  customer Id";
                    }
                    else
                    {
                        if (summary == null || summary.IsDisposed)
                        {
                            summary = new Summary();
                            summary.showData(flight.InformationOfFlight() + "\n" + customer.ToString());
                            summary.Show();
                            this.error.Text = "";
                            this.flightId.Text = "";
                            this.customerId.Text = "";
                        }
                    }
                }
                    
               
                
            }
        }

        public void writeData()
        {
            ReadWriteHandler.WriteJson(@"d:\temp\as8.json", fligtCollection);
        }
    }
}
