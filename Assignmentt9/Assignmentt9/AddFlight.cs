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
    public partial class AddFlight : Form
    {
        ReadWriteHandler ReadWriteHandler = new ReadWriteHandler();
        List<Flight> fligtCollection = ReadWriteHandler.ReadJson(@"d:\temp\as8.json");

        public AddFlight()
        {
            InitializeComponent();
        }

        public void addFlight(object sender, EventArgs e)
        {
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
                writeData();
            }
        }
        public void writeData()
        {
            ReadWriteHandler.WriteJson(@"d:\temp\as8.json", fligtCollection);
        }
    }
}
