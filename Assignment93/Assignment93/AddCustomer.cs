
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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void openData(object sender, EventArgs e)
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

        public void addCustomer(object sender, EventArgs e)
        {
            if(label2.Text == "")
            {
                this.error.Text = "Please add a file you want to save";
            }
            else
            {
                List<Customer> customerCollection = Customer.ReadJson(label2.Text);
                if ((this.customerId.Text == "") || (this.firstName.Text == "") || (this.phoneNumber.Text == "") || (this.flightId.Text == ""))
                {
                    this.error.Text = "Please fill all fields (customer id, name, phone number, flight id)";
                }
                else
                {
                    customerCollection.Add(new Customer(this.customerId.Text, this.firstName.Text, this.flightId.Text, this.phoneNumber.Text));
                    this.flightId.Text = "";
                    this.customerId.Text = "";
                    this.firstName.Text = "";
                    this.phoneNumber.Text = "";
                    this.error.Text = "";
                    Customer.WriteJson(label2.Text, customerCollection);
                }
            }
            
        }
    }
}
