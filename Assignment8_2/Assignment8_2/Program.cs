using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment8_2
{
    static class Program
    {
        class MyForm : Form
        {
            //Here we declare an object of type Label
            Label infoLabel;
            Button addDataButton;
            Button summaryButton;
            Label flightIdLabel;
            Label originLabel;
            Label destinationLabel;
            Label dataTimeLabel;
            TextBox flightId;
            TextBox origin;
            TextBox destination;
            TextBox dataTime;
            List<Flight> fligtCollection = new List<Flight>();
            //This is the default constructor
            public MyForm()
            {
                this.Text = "First Windows Form";
                //In the following we set the size, location and background olor
                //of the main window of the application.
                this.Size = new Size(500, 300);
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
                addDataButton = new Button();
                summaryButton = new Button();
                flightId = new TextBox();
                origin = new TextBox();
                destination = new TextBox();
                dataTime = new TextBox();
                //Here we specify that the size of the label is automathic and should
                //change according to its content.
                this.infoLabel.AutoSize = true;
                this.infoLabel.Location = new Point(20, 20);
                this.infoLabel.Text = "";
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
                // Add button
                this.addDataButton.AutoSize = true;
                this.addDataButton.Location = new Point(100, 200);
                this.addDataButton.BackColor = Color.FromArgb(230, 181, 102);
                this.addDataButton.Text = "Add data";
                this.addDataButton.Click += new EventHandler(this.addData);
                // Sumarry button
                this.summaryButton.AutoSize = true;
                this.summaryButton.Location = new Point(300, 200);
                this.summaryButton.BackColor = Color.FromArgb(230, 181, 102);
                this.summaryButton.Text = "Summary";
                this.summaryButton.Click += new EventHandler(this.showData);
                //Here we add the label to the form.
                this.Controls.Add(infoLabel);
                this.Controls.Add(flightIdLabel);
                this.Controls.Add(originLabel);
                this.Controls.Add(destinationLabel);
                this.Controls.Add(dataTimeLabel);
                this.Controls.Add(flightId);
                this.Controls.Add(origin);
                this.Controls.Add(destination);
                this.Controls.Add(dataTime);
                this.Controls.Add(addDataButton);
                this.Controls.Add(summaryButton);
            }
            //This method sets the text content of the lable
            public void addData(object sender, EventArgs e)
            {
                fligtCollection.Add(new Flight(this.flightId.Text, this.origin.Text, this.destination.Text, this.dataTime.Text));
                this.flightId.Text = "";
                this.origin.Text = "";
                this.destination.Text = "";
                this.dataTime.Text = "";
            }
            public void showData(object sender, EventArgs e)
            {
                String res = "";
                foreach (var flight in this.fligtCollection)
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
