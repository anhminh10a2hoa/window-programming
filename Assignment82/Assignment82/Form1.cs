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
    public partial class Form1 : Form
    {
        List<Flight> fligtCollection = new List<Flight>();
        Summary summary = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void addFlightData()
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
            {
                label5.Text = "Please fill all fields";
            }
            else
            {
                fligtCollection.Add(new Flight(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                label5.Text = "";
            } 
        }

        private void showData()
        {
            String res = "";
            foreach (var flight in this.fligtCollection)
            {
                res += flight.ToString() + "\n\n";
            }
            if (summary == null || summary.IsDisposed)
            {
                summary = new Summary();
                summary.showAllData(res);
                summary.Show();
            }
        }
        private void searchData()
        {
            String res = "";
            if (textBox1.Text == "")
            {
                label5.Text = "Please provide flight id";
            }
            else
            {
                foreach (var flight in this.fligtCollection)
                {
                    if (flight.Id == textBox1.Text)
                    {
                        res += flight.ToString() + "\n\n";
                    }
                }
                if (summary == null || summary.IsDisposed)
                {
                    summary = new Summary();
                    summary.showAllData(res);
                    summary.Show();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.addFlightData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.searchData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.showData();
        }
    }
}
