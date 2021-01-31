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
    public partial class AddFlight : Form
    {
        public AddFlight()
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
                    label5.Text = sfd.FileName;
                }
            }
        }

        public void addFlight(object sender, EventArgs e)
        {
            if (label5.Text == "")
            {
                this.error.Text = "Please add a file you want to save";
            }
            else
            {
                List<Flight> fligtCollection = Flight.ReadJson(label5.Text);
                if ((this.flightId.Text == "") || (this.origin.Text == "") || (this.destination.Text == "") || (this.dataTime.Text == ""))
                {
                    this.error.Text = "Please fill all fields (flight id, origin, destination, time)";
                }
                else
                {
                    fligtCollection.Add(new Flight(this.flightId.Text, this.origin.Text, this.destination.Text, this.dataTime.Text));
                    this.flightId.Text = "";
                    this.origin.Text = "";
                    this.destination.Text = "";
                    this.dataTime.Text = "";
                    this.error.Text = "";
                    Flight.WriteJson(label5.Text, fligtCollection);
                }
            }

        }
    }
}
