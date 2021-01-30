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
    public partial class SearchCustomer : Form
    {
        public SearchCustomer()
        {
            InitializeComponent();
        }

        private void changeBackgroudColor(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.BackColor = cd.Color;
                }
            }
        }

        public void showAllData(string customerData)
        {
            richTextBox1.Text = customerData;
        }

        private void changeForegroudColor(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.ForeColor = cd.Color;
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "")
            {
                richTextBox1.Font = new Font("Microsoft Sans Serif", 8);
            }
            else
            {
                richTextBox1.Font = new Font("Microsoft Sans Serif", Int32.Parse(toolStripTextBox1.Text));
            }
        }
    }
}
