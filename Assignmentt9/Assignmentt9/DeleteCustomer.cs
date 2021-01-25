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
    public partial class DeleteCustomer : Form
    {
        ReadWriteHandler ReadWriteHandler = new ReadWriteHandler();
        List<Flight> fligtCollection = ReadWriteHandler.ReadJson(@"d:\temp\as8.json");
        Mainpage mainpage = new Mainpage();
        public DeleteCustomer()
        {
            InitializeComponent();
        }
        public void deleteCustomer(object sender, EventArgs e)
        {
            if (this.flightId.Text == "" || this.customerId.Text == "")
            {
                this.error.Text = "Please fill all fields";
            } else
            {
                var flight = fligtCollection.FirstOrDefault(f => f.Id == this.flightId.Text);
                flight.CustomerList.RemoveAll(c => c.Id == this.customerId.Text);
                this.error.Text = "";
                this.flightId.Text = "";
                this.customerId.Text = "";
                writeData();
            }
        }

        public void writeData()
        {
            ReadWriteHandler.WriteJson(@"d:\temp\as8.json", fligtCollection);
        }
    }
}
