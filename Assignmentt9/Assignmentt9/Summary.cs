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
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }

        public void showData(string flightData)
        {
            richTextBox1.Text = flightData;
        }
    }
}
