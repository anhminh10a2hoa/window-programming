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
    public partial class AddCustomer : Form
    {
        ReadWriteHandler ReadWriteHandler = new ReadWriteHandler();
        List<Flight> fligtCollection = ReadWriteHandler.ReadJson(@"d:\temp\as8.json");
        public AddCustomer()
        {
            InitializeComponent();
        }
        public void addCustomer(object sender, EventArgs e)
        {
            if ((this.customerId.Text == "") || (this.firstName.Text == "") || (this.lastName.Text == "") || (this.phoneNumber.Text == "") || (this.flightId.Text == ""))
            {
                this.error.Text = "Please fill all fields (customer id, name, phone number, flight id)";
            }
            else
            {
                var flight = fligtCollection.FirstOrDefault(f => f.Id == this.flightId.Text);
                flight.CustomerList.Add(new Customer(this.customerId.Text, this.firstName.Text, this.lastName.Text, this.phoneNumber.Text));
                this.flightId.Text = "";
                this.customerId.Text = "";
                this.firstName.Text = "";
                this.lastName.Text = "";
                this.phoneNumber.Text = "";
                this.error.Text = "";
                writeData();
            }
        }
        public void writeData()
        {
            ReadWriteHandler.WriteJson(@"d:\temp\as8.json", fligtCollection);
        }
    }
}
