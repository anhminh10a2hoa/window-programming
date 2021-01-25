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
    public partial class Mainpage : Form
    {
        ReadWriteHandler ReadWriteHandler = new ReadWriteHandler();
        List<Flight> fligtCollection = ReadWriteHandler.ReadJson(@"d:\temp\as8.json");
        Summary summary = null;
        AddFlight addFlightForm = null;
        AddCustomer addCustomerForm = null;
        DeleteFlight deleteFlightForm = null;
        DeleteCustomer deleteCustomerForm = null;
        UpdateFlight updateFlightForm = null;
        UpdateCustomer updateCustomerForm = null;
        SearchFlight searchFlightForm = null;
        SearchCustomer searchCustomerForm = null;

        public Mainpage()
        {
            InitializeComponent();
        }
        //This method sets the text content of the lable
        public void addFlight(object sender, EventArgs e)
        {
            if (addFlightForm == null || addFlightForm.IsDisposed)
            {
                addFlightForm = new AddFlight();
                addFlightForm.Show();
            }
        }

        public void addCustomer(object sender, EventArgs e)
        {
            if (addCustomerForm == null || addCustomerForm.IsDisposed)
            {
                addCustomerForm = new AddCustomer();
                addCustomerForm.Show();
            }
        }
        public void deleteFlight(object sender, EventArgs e)
        {
            if (deleteFlightForm == null || deleteFlightForm.IsDisposed)
            {
                deleteFlightForm = new DeleteFlight();
                deleteFlightForm.Show();
            }
        }

        public void deleteCustomer(object sender, EventArgs e)
        {
            if (deleteCustomerForm == null || deleteCustomerForm.IsDisposed)
            {
                deleteCustomerForm = new DeleteCustomer();
                deleteCustomerForm.Show();
            }
        }

        public void updateFlight(object sender, EventArgs e)
        {
            if (updateFlightForm == null || updateFlightForm.IsDisposed)
            {
                updateFlightForm = new UpdateFlight();
                updateFlightForm.Show();
            }
        }

        public void updateCustomer(object sender, EventArgs e)
        {
            if (updateCustomerForm == null || updateCustomerForm.IsDisposed)
            {
                updateCustomerForm = new UpdateCustomer();
                updateCustomerForm.Show();
            }
        }

        public void searchFlight(object sender, EventArgs e)
        {
            if (searchFlightForm == null || searchFlightForm.IsDisposed)
            {
                searchFlightForm = new SearchFlight();
                searchFlightForm.Show();
            }
        }

        public void searchCustomer(object sender, EventArgs e)
        {
            if (searchCustomerForm == null || searchCustomerForm.IsDisposed)
            {
                searchCustomerForm = new SearchCustomer();
                searchCustomerForm.Show();
            }
        }

        public void showData(object sender, EventArgs e)
        {
            String res = "";
            foreach (var flight in fligtCollection)
            {
                res += flight.ToString() + "\n\n";
            }
            if (summary == null || summary.IsDisposed)
            {
                summary = new Summary();
                summary.showData(res);
                summary.Show();
            }
        }
    }
}
