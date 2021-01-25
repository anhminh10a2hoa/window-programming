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
    public partial class UpdateCustomer : Form
    {
        ReadWriteHandler ReadWriteHandler = new ReadWriteHandler();
        List<Flight> fligtCollection = ReadWriteHandler.ReadJson(@"d:\temp\as8.json");
        public UpdateCustomer()
        {
            InitializeComponent();
        }
        public void updateCustomer(object sender, EventArgs e)
        {
            if ((this.customerId.Text == "") || (this.firstName.Text == "") || (this.lastName.Text == "") || (this.phoneNumber.Text == "") || (this.flightId.Text == ""))
            {
                this.error.Text = "Please fill all fields";
            }
            else
            {
                var flight = fligtCollection.FirstOrDefault(f => f.Id == this.flightId.Text);
                if (flight == null)
                {
                    this.error.Text = "Can not find this flight Id";
                }
                else
                {
                    var customer = flight.CustomerList.FirstOrDefault(c => c.Id == this.customerId.Text);
                    if (customer == null)
                    {
                        this.error.Text = "Can not find this  customer Id";
                    }
                    else
                    {
                        customer.Id = this.customerId.Text;
                        customer.FirstName = this.firstName.Text;
                        customer.LastName = this.lastName.Text;
                        customer.PhoneNumber = this.phoneNumber.Text;
                        this.flightId.Text = "";
                        this.customerId.Text = "";
                        this.firstName.Text = "";
                        this.lastName.Text = "";
                        this.phoneNumber.Text = "";
                        this.error.Text = "";
                        writeData();
                    }
                }
            }
        }

        public void writeData()
        {
            ReadWriteHandler.WriteJson(@"d:\temp\as8.json", fligtCollection);
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
