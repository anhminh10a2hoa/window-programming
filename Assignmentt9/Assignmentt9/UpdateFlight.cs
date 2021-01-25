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
    public partial class UpdateFlight : Form
    {
        ReadWriteHandler ReadWriteHandler = new ReadWriteHandler();
        List<Flight> fligtCollection = ReadWriteHandler.ReadJson(@"d:\temp\as8.json");
        public UpdateFlight()
        {
            InitializeComponent();
        }
        public void updateFlight(object sender, EventArgs e)
        {
            if ((this.flightId.Text == "") || (this.origin.Text == "") || (this.destination.Text == "") || (this.dataTime.Text == ""))
            {
                this.error.Text = "Please fill all fields";
            }
            else
            {
                var flight = fligtCollection.FirstOrDefault(f => f.Id == this.flightId.Text);
                if(flight == null)
                {
                    this.error.Text = "Can not find this flight Id";
                } else
                {
                    flight.Origin = this.origin.Text;
                    flight.Destination = this.destination.Text;
                    flight.Date = this.dataTime.Text;
                    this.flightId.Text = "";
                    this.origin.Text = "";
                    this.destination.Text = "";
                    this.dataTime.Text = "";
                    this.error.Text = "";
                    writeData();
                }
            }
        }

        public void writeData()
        {
            ReadWriteHandler.WriteJson(@"d:\temp\as8.json", fligtCollection);
        }
    }
}
