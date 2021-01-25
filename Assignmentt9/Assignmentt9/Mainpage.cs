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
    public partial class Mainpage : Form
    {
        ReadWriteHandler ReadWriteHandler = new ReadWriteHandler();
        List<Flight> fligtCollection = ReadWriteHandler.ReadJson(@"d:\temp\as8.json");
        Summary summary = null;
        public Mainpage()
        {
            InitializeComponent();
        }

        public Boolean checkFieldEmptyOrNot(string dataCheck)
        {
            if (dataCheck == "Flight")
            {
                if ((this.flightId.Text == "") || (this.origin.Text == "") || (this.destination.Text == "") || (this.dataTime.Text == ""))
                {
                    this.error.Text = "Please fill all fields (flight id, origin, destination, time)";
                    return false;
                }
                else
                {
                    this.error.Text = "";
                    return true;
                }
            }
            if (dataCheck == "Customer")
            {
                if ((this.customerId.Text == "") || (this.firstName.Text == "") || (this.lastName.Text == "") || (this.phoneNumber.Text == "") || (this.flightId.Text == ""))
                {
                    this.error.Text = "Please fill all fields (customer id, name, phone number, flight id)";
                    return false;
                }
                else
                {
                    this.error.Text = "";
                    return true;
                }
            }
            return false;
        }
        public void emptyAllFields()
        {
            this.flightId.Text = "";
            this.origin.Text = "";
            this.destination.Text = "";
            this.dataTime.Text = "";
            this.customerId.Text = "";
            this.firstName.Text = "";
            this.lastName.Text = "";
            this.phoneNumber.Text = "";
        }
        public void writeData()
        {
            ReadWriteHandler.WriteJson(@"d:\temp\as8.json", fligtCollection);
        }
        //This method sets the text content of the lable
        public void addFlight(object sender, EventArgs e)
        {
            if (checkFieldEmptyOrNot("Flight"))
            {
                fligtCollection.Add(new Flight(this.flightId.Text, this.origin.Text, this.destination.Text, this.dataTime.Text));
                emptyAllFields();
                writeData();
            }
        }

        public void addCustomer(object sender, EventArgs e)
        {
            if (checkFieldEmptyOrNot("Customer"))
            {
                var flight = fligtCollection.FirstOrDefault(f => f.Id == this.flightId.Text);
                flight.CustomerList.Add(new Customer(this.customerId.Text, this.firstName.Text, this.lastName.Text, this.phoneNumber.Text));
                emptyAllFields();
                writeData();
            }
        }
        public void deleteData(object sender, EventArgs e)
        {
            if (this.flightId.Text != "" && this.customerId.Text == "")
            {
                fligtCollection.RemoveAll(f => f.Id == this.flightId.Text);
                emptyAllFields();
                writeData();
            }
            if (this.flightId.Text != "" && this.customerId.Text != "")
            {
                var flight = fligtCollection.FirstOrDefault(f => f.Id == this.flightId.Text);
                flight.CustomerList.RemoveAll(c => c.Id == this.customerId.Text);
                emptyAllFields();
                writeData();
            }
        }

        public void updateData(object sender, EventArgs e)
        {
            if (this.flightId.Text != "" && this.customerId.Text == "" && checkFieldEmptyOrNot("Flight"))
            {
                var flight = fligtCollection.FirstOrDefault(f => f.Id == this.flightId.Text);
                flight.Origin = this.origin.Text;
                flight.Destination = this.destination.Text;
                flight.Date = this.dataTime.Text;
                emptyAllFields();
                writeData();
            }
            if (this.flightId.Text != "" && this.customerId.Text != "" && checkFieldEmptyOrNot("Customer"))
            {
                var flight = fligtCollection.FirstOrDefault(f => f.Id == this.flightId.Text);
                var customer = flight.CustomerList.FirstOrDefault(c => c.Id == this.customerId.Text);
                customer.Id = this.customerId.Text;
                customer.FirstName = this.firstName.Text;
                customer.FirstName = this.lastName.Text;
                customer.PhoneNumber = this.phoneNumber.Text;
                emptyAllFields();
                writeData();
            }
        }

        public void searchData(object sender, EventArgs e)
        {
            if (this.flightId.Text != "" && this.customerId.Text == "")
            {
                var flight = fligtCollection.FirstOrDefault(f => f.Id == this.flightId.Text);
                emptyAllFields();
                if (summary == null || summary.IsDisposed)
                {
                    summary = new Summary();
                    summary.showData(flight.ToString());
                    summary.Show();
                }
            }
            if (this.flightId.Text != "" && this.customerId.Text != "")
            {
                var flight = fligtCollection.FirstOrDefault(f => f.Id == this.flightId.Text);
                var customer = flight.CustomerList.FirstOrDefault(c => c.Id == this.customerId.Text);
                emptyAllFields();
                if (summary == null || summary.IsDisposed)
                {
                    summary = new Summary();
                    summary.showData(flight.InformationOfFlight() + "\n" + customer.ToString());
                    summary.Show();
                }
            }
        }

        public void showData(object sender, EventArgs e)
        {
            String res = "";
            foreach (var flight in fligtCollection)
            {
                res += flight.ToString() + "\n\n";
            }
            if (summary == null || summary.IsDisposed)
            {
                summary = new Summary();
                summary.showData(res);
                summary.Show();
            }
        }
    }
}
