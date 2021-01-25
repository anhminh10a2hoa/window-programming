using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment8
{
    static class Program
    {
        class MyForm : Form
        {
            //Here we declare an object of type Label
            Label infoLabel;
            int count;
            //This is the default constructor
            public MyForm()
            {
                this.Text = "First Windows Form";
                //In the following we set the size, location and background olor
                //of the main window of the application.
                this.Size = new Size(500, 300);
                this.Location = new Point(0, 0);
                this.BackColor = Color.Aqua;
                //Here we specify that the event handler for cases in which the form is clicked
                //is Form_Click() method
                //this.Click += new System.EventHandler(this.Form_Click);
                this.MouseDoubleClick += new MouseEventHandler(this.Form1_MouseDoubleClick);
                //Here we initialize infoLabel component by defining its size, location and text.
                infoLabel = new Label();
                count = 0;
                //Here we specify that the size of the label is automathic and should
                //change according to its content.
                this.infoLabel.AutoSize = true;
                this.infoLabel.Location = new Point(20, 20);
                this.infoLabel.Size = new Size(35, 13);
                this.infoLabel.Text = "";
                //Here we add the label to the form.
                this.Controls.Add(infoLabel);
            }
            //Here we define Form_Click event handler
            private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                infoLabel.ForeColor = Color.Black;
                // user clicked ok
                count++;
                infoLabel.Text += count + ": Coordinates are: x: " + e.X + "y: " + e.Y + "\n";
            }
            private void Form_Click(object sender, EventArgs e)
            {
                //In the following we check the background color of the form
                //and change it accordingly.
                if (this.BackColor == Color.Aqua)
                {
                    this.BackColor = Color.SteelBlue;
                    //Here we call DisplayData() method to display the data.
                    DisplayData();
                }
                else
                {
                    //Here we change the background color of the form.
                    this.BackColor = Color.Aqua;
                    //Here we delete the text of the label by initializing the text value to empty.
                    infoLabel.Text = "";
                }
            }
            //This method sets the text content of the lable
            public void DisplayData()
            {
                //Here we set the text color of the label.
                infoLabel.ForeColor = Color.Yellow;
                //In the following rows we update the text content of the label.
                //Application.ExecutablePath is the path and file name of the executable file that starts the application
                infoLabel.Text += "ExecutablePath: " + Environment.NewLine + Application.ExecutablePath + Environment.NewLine;
                infoLabel.Text += "--------------------" + Environment.NewLine;
                //Application.StartupPath is similar to ExecutablePath, except the file name is not returned.
                infoLabel.Text += "StartupPath:" + Environment.NewLine + Application.StartupPath + Environment.NewLine; ;
                infoLabel.Text += "--------------------" + Environment.NewLine;
                //Application.CommonAppDataPaththe is path for the data that is common for all users of the application.
                infoLabel.Text += "CommonAppDataPath: " + Environment.NewLine + Application.CommonAppDataPath + Environment.NewLine;
                infoLabel.Text += "--------------------" + Environment.NewLine;
                //Application.LocalUserAppDataPath is similar to CommonAppDataPath with the exception that this property supports roaming.
                infoLabel.Text += "LocalUserAppDataPath: " + Environment.NewLine + Application.LocalUserAppDataPath + Environment.NewLine;
                infoLabel.Text += "--------------------" + Environment.NewLine;
            }
        }
        [STAThread]
        static void Main(string[] args)
        {
            //Here we run the application by creating and loading an object of myForm.
            Application.Run(new MyForm());
        }
    }
}
