using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment9
{
    static class Program
    {
        class MyForm : Form
        {
            ReadWriteHandler ReadWriteHandler = new ReadWriteHandler();
            //Here we declare an object of type Label
            Label infoLabel;
            Label flightIdLabel;
            Label originLabel;
            Label destinationLabel;
            Label dataTimeLabel;

            Label error;

            Label customerIdLabel;
            Label firstNameLabel;
            Label lastNameLabel;
            Label phoneNumberLabel;

            // List of flight's textbox
            TextBox flightId;
            TextBox origin;
            TextBox destination;
            TextBox dataTime;

            // List of customer's textbox
            TextBox customerId;
            TextBox firstName;
            TextBox lastName;
            TextBox phoneNumber;

            // List of buttons
            Button addFlightButton;
            Button addCustomerButton;
            Button summaryButton;
            Button deleteDataButton;
            Button updateDataButton;
            Button searchDatatButton;

            List<Flight> fligtCollection = ReadWriteHandler.ReadJson(@"d:\temp\as8.json");
            //This is the default constructor
            public MyForm()
            {
                this.Text = "First Windows Form";
                //In the following we set the size, location and background olor
                //of the main window of the application.
                this.Size = new Size(800, 300);
                this.Location = new Point(0, 0);
                this.BackColor = Color.FromArgb(232, 233, 161);
                //Here we specify that the event handler for cases in which the form is clicked
                //is Form_Click() method
                //Here we initialize infoLabel component by defining its size, location and text.
                infoLabel = new Label();
                flightIdLabel = new Label();
                originLabel = new Label();
                destinationLabel = new Label();
                dataTimeLabel = new Label();
                // Customer initial label
                customerIdLabel = new Label();
                firstNameLabel = new Label();
                lastNameLabel = new Label();
                phoneNumberLabel = new Label();

                error = new Label();

                addFlightButton = new Button();
                addCustomerButton = new Button();
                summaryButton = new Button();
                deleteDataButton = new Button();
                updateDataButton = new Button();
                searchDatatButton = new Button();

                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Flight~~~~~~~~~~~~~~~~~~~~~~~~~~~~ //
                flightId = new TextBox();
                origin = new TextBox();
                destination = new TextBox();
                dataTime = new TextBox();

                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Cusotmer~~~~~~~~~~~~~~~~~~~~~~~~~~~~ //
                customerId = new TextBox();
                firstName = new TextBox();
                lastName = new TextBox();
                phoneNumber = new TextBox();

                //Here we specify that the size of the label is automathic and should
                //change according to its content.
                this.infoLabel.AutoSize = true;
                this.infoLabel.Location = new Point(20, 20);
                this.infoLabel.Text = "";
                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Flight~~~~~~~~~~~~~~~~~~~~~~~~~~~~ //
                // FlightId
                this.flightIdLabel.AutoSize = true;
                this.flightIdLabel.Location = new Point(100, 40);
                this.flightIdLabel.Text = "Enter Flight Id: ";
                // FlightId TextBox
                this.flightId.AutoSize = true;
                this.flightId.Location = new Point(250, 35);
                this.flightId.Name = "flightId";
                // origin
                this.originLabel.AutoSize = true;
                this.originLabel.Location = new Point(100, 70);
                this.originLabel.Text = "Enter your origin: ";
                // origin TextBox
                this.origin.AutoSize = true;
                this.origin.Location = new Point(250, 65);
                this.origin.Name = "origin";
                // destination
                this.destinationLabel.AutoSize = true;
                this.destinationLabel.Location = new Point(100, 100);
                this.destinationLabel.Text = "Enter your destination: ";
                // destination TextBox
                this.destination.AutoSize = true;
                this.destination.Location = new Point(250, 95);
                this.destination.Name = "destination";
                // destination
                this.dataTimeLabel.AutoSize = true;
                this.dataTimeLabel.Location = new Point(100, 130);
                this.dataTimeLabel.Text = "Date(dd/mm/yyyy): ";
                // date time TextBox
                this.dataTime.AutoSize = true;
                this.dataTime.Location = new Point(250, 125);
                this.dataTime.Name = "datetime";

                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Customer~~~~~~~~~~~~~~~~~~~~~~~~~~~~ //
                // CustomerId
                this.customerIdLabel.AutoSize = true;
                this.customerIdLabel.Location = new Point(400, 40);
                this.customerIdLabel.Text = "Enter Customer Id: ";
                // CustomerId TextBox
                this.customerId.AutoSize = true;
                this.customerId.Location = new Point(550, 35);
                this.customerId.Name = "customerId";
                // firstname
                this.firstNameLabel.AutoSize = true;
                this.firstNameLabel.Location = new Point(400, 70);
                this.firstNameLabel.Text = "Enter first name: ";
                // firstname TextBox
                this.firstName.AutoSize = true;
                this.firstName.Location = new Point(550, 65);
                this.firstName.Name = "firstname";
                // lastname
                this.lastNameLabel.AutoSize = true;
                this.lastNameLabel.Location = new Point(400, 100);
                this.lastNameLabel.Text = "Enter lastname: ";
                // lastname TextBox
                this.lastName.AutoSize = true;
                this.lastName.Location = new Point(550, 95);
                this.lastName.Name = "lastname";
                // phonenumber
                this.phoneNumberLabel.AutoSize = true;
                this.phoneNumberLabel.Location = new Point(400, 130);
                this.phoneNumberLabel.Text = "Enter phone: ";
                // phonenumber TextBox
                this.phoneNumber.AutoSize = true;
                this.phoneNumber.Location = new Point(550, 125);
                this.phoneNumber.Name = "phonenumber";

                // Error
                this.error.ForeColor = Color.Red;
                this.error.AutoSize = true;
                this.error.Location = new Point(250, 10);

                // Add flight button
                this.addFlightButton.AutoSize = true;
                this.addFlightButton.Location = new Point(50, 200);
                this.addFlightButton.BackColor = Color.FromArgb(230, 181, 102);
                this.addFlightButton.Text = "Add flight";
                this.addFlightButton.Click += new EventHandler(this.addFlight);
                // Add customer button
                this.addCustomerButton.AutoSize = true;
                this.addCustomerButton.Location = new Point(550, 200);
                this.addCustomerButton.BackColor = Color.FromArgb(230, 181, 102);
                this.addCustomerButton.Text = "Add customer";
                this.addCustomerButton.Click += new EventHandler(this.addCustomer);
                // Sumarry button
                this.summaryButton.AutoSize = true;
                this.summaryButton.Location = new Point(350, 200);
                this.summaryButton.BackColor = Color.FromArgb(230, 181, 102);
                this.summaryButton.Text = "Summary";
                this.summaryButton.Click += new EventHandler(this.showData);
                // Delete button
                this.deleteDataButton.AutoSize = true;
                this.deleteDataButton.Location = new Point(150, 200);
                this.deleteDataButton.BackColor = Color.FromArgb(230, 181, 102);
                this.deleteDataButton.Text = "Delete data";
                this.deleteDataButton.Click += new EventHandler(this.deleteData);
                // Update button
                this.updateDataButton.AutoSize = true;
                this.updateDataButton.Location = new Point(250, 200);
                this.updateDataButton.BackColor = Color.FromArgb(230, 181, 102);
                this.updateDataButton.Text = "Update data";
                this.updateDataButton.Click += new EventHandler(this.updateData);
                // Search flight button
                this.searchDatatButton.AutoSize = true;
                this.searchDatatButton.Location = new Point(450, 200);
                this.searchDatatButton.BackColor = Color.FromArgb(230, 181, 102);
                this.searchDatatButton.Text = "Search flight";
                this.searchDatatButton.Click += new EventHandler(this.searchFlight);
                //Here we add the label to the form.
                this.Controls.Add(infoLabel);

                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Flight~~~~~~~~~~~~~~~~~~~~~~~~~~~~ //
                this.Controls.Add(flightIdLabel);
                this.Controls.Add(originLabel);
                this.Controls.Add(destinationLabel);
                this.Controls.Add(dataTimeLabel);
                this.Controls.Add(flightId);
                this.Controls.Add(origin);
                this.Controls.Add(destination);
                this.Controls.Add(dataTime);
                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Customer~~~~~~~~~~~~~~~~~~~~~~~~~~~~ //
                this.Controls.Add(customerIdLabel);
                this.Controls.Add(firstNameLabel);
                this.Controls.Add(lastNameLabel);
                this.Controls.Add(phoneNumberLabel);
                this.Controls.Add(customerId);
                this.Controls.Add(lastName);
                this.Controls.Add(firstName);
                this.Controls.Add(phoneNumber);


                this.Controls.Add(addFlightButton);
                this.Controls.Add(addCustomerButton);
                this.Controls.Add(summaryButton);
                this.Controls.Add(deleteDataButton);
                this.Controls.Add(updateDataButton);
                this.Controls.Add(searchDatatButton);

                this.Controls.Add(error);
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
                if(this.flightId.Text != "" && this.customerId.Text == "")
                {
                    fligtCollection.RemoveAll(f => f.Id == this.flightId.Text);
                    emptyAllFields();
                    writeData();
                }
                if(this.flightId.Text != "" && this.customerId.Text != "")
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

            public void searchFlight(object sender, EventArgs e)
            {
                if (this.flightId.Text != "" && this.customerId.Text == "")
                {
                    var flight = fligtCollection.FirstOrDefault(f => f.Id == this.flightId.Text);
                    emptyAllFields();
                    MessageBox.Show(flight.ToString());
                }
                if (this.flightId.Text != "" && this.customerId.Text != "")
                {
                    var flight = fligtCollection.FirstOrDefault(f => f.Id == this.flightId.Text);
                    var customer = flight.CustomerList.FirstOrDefault(c => c.Id == this.customerId.Text);
                    emptyAllFields();
                    MessageBox.Show(customer.ToString() + "\n" + flight.InformationOfFlight());
                }
            }

            public void showData(object sender, EventArgs e)
            {
                String res = "";
                foreach (var flight in fligtCollection)
                {
                    res += flight.ToString() + "\n\n";
                }
                MessageBox.Show(res);
            }
            private void exitButton_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
        }
        [STAThread]
        static void Main(string[] args)
        {
            //Here we run the application by creating and loading an object of myForm.
            Application.Run(new MyForm());
        }
    }
}