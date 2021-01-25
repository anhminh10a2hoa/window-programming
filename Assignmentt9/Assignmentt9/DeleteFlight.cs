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
    public partial class DeleteFlight : Form
    {
        ReadWriteHandler ReadWriteHandler = new ReadWriteHandler();
        List<Flight> fligtCollection = ReadWriteHandler.ReadJson(@"d:\temp\as8.json");
        public DeleteFlight()
        {
            InitializeComponent();
        }
        public void deleteFlight(object sender, EventArgs e)
        {
            if (this.flightId.Text == "")
            {
                this.error.Text = "Please fill all fields";
            }
            else
            {
                fligtCollection.RemoveAll(f => f.Id == this.flightId.Text);
                this.error.Text = "";
                this.flightId.Text = "";
                writeData();
            }
        }

        public void writeData()
        {
            ReadWriteHandler.WriteJson(@"d:\temp\as8.json", fligtCollection);
        }
    }
}
