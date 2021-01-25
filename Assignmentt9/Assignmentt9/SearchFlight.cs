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
    public partial class SearchFlight : Form
    {
        ReadWriteHandler ReadWriteHandler = new ReadWriteHandler();
        List<Flight> fligtCollection = ReadWriteHandler.ReadJson(@"d:\temp\as8.json");
        Summary summary = null;
        public SearchFlight()
        {
            InitializeComponent();
        }

        public void searchFlight(object sender, EventArgs e)
        {
            if (this.flightId.Text == "")
            {
                this.error.Text = "Please fill all fields";
            } else
            {
                var flight = fligtCollection.FirstOrDefault(f => f.Id == this.flightId.Text);
                if(flight == null)
                {
                    this.error.Text = "Can not find this flight Id";
                } else
                {
                    if (summary == null || summary.IsDisposed)
                    {
                        summary = new Summary();
                        summary.showData(flight.ToString());
                        summary.Show();
                        this.flightId.Text = "";
                        this.error.Text = "";
                    }
                }
            }
        }

        public void writeData()
        {
            ReadWriteHandler.WriteJson(@"d:\temp\as8.json", fligtCollection);
        }
    }
}
