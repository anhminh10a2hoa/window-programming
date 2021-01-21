using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            //Here we declare an object of type Label
            Label infoLabel;
            Label flightIdLabel;
            Label originLabel;
            Label destinationLabel;
            Label dataTimeLabel;

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
            Button addDataButton;
            Button summaryButton;
            Button deleteDataButton;
            Button updateDataButton;
            Button searchNameButton;
            Button searchFlightButton;

            List<Flight> fligtCollection = new List<Flight>();
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

                customerIdLabel = new Label();
                firstNameLabel = new Label();
                lastNameLabel = new Label();
                phoneNumberLabel = new Label();


                addDataButton = new Button();
                summaryButton = new Button();
                deleteDataButton = new Button();
                updateDataButton = new Button();
                searchNameButton = new Button();
                searchFlightButton = new Button();

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

                // Add button
                this.addDataButton.AutoSize = true;
                this.addDataButton.Location = new Point(50, 200);
                this.addDataButton.BackColor = Color.FromArgb(230, 181, 102);
                this.addDataButton.Text = "Add data";
                this.addDataButton.Click += new EventHandler(this.addData);
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
                this.deleteDataButton.Click += new EventHandler(this.addData);
                // Update button
                this.updateDataButton.AutoSize = true;
                this.updateDataButton.Location = new Point(250, 200);
                this.updateDataButton.BackColor = Color.FromArgb(230, 181, 102);
                this.updateDataButton.Text = "Update data";
                this.updateDataButton.Click += new EventHandler(this.addData);
                // Search customer button
                this.searchNameButton.AutoSize = true;
                this.searchNameButton.Location = new Point(450, 200);
                this.searchNameButton.BackColor = Color.FromArgb(230, 181, 102);
                this.searchNameButton.Text = "Search customer";
                this.searchNameButton.Click += new EventHandler(this.addData);
                // Search flight button
                this.searchFlightButton.AutoSize = true;
                this.searchFlightButton.Location = new Point(570, 200);
                this.searchFlightButton.BackColor = Color.FromArgb(230, 181, 102);
                this.searchFlightButton.Text = "Search flight";
                this.searchFlightButton.Click += new EventHandler(this.addData);
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


                this.Controls.Add(addDataButton);
                this.Controls.Add(summaryButton);
                this.Controls.Add(deleteDataButton);
                this.Controls.Add(updateDataButton);
                this.Controls.Add(searchNameButton);
                this.Controls.Add(searchFlightButton);
            }
            //This method sets the text content of the lable
            public void addData(object sender, EventArgs e)
            {
                fligtCollection.Add(new Flight(this.flightId.Text, this.origin.Text, this.destination.Text, this.dataTime.Text));
                
                foreach(Flight f in fligtCollection)
                {
                    if(f.Id == this.flightId.Text)
                    {
                        f.CustomerList.Add(new Customer(this.customerId.Text, this.firstName.Text, this.lastName.Text, this.phoneNumber.Text));
                    } 
                }

                this.flightId.Text = "";
                this.origin.Text = "";
                this.destination.Text = "";
                this.dataTime.Text = "";

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
            ;
        }

    }
}