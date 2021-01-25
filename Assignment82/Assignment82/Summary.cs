using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment82
{
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }

        public void showAllData(string flightData)
        {
            richTextBox1.Text = flightData;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Summary_Load(object sender, EventArgs e)
        {

        }

        private void Summary_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Closing Form");
        }
    }
}
