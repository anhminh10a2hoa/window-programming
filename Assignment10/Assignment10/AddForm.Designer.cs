
namespace Assignment10
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.childMenuStrip = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.flightId = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.customerId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.dataTimeTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.originTextBox = new System.Windows.Forms.TextBox();
            this.flightIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.originLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addFlightButton = new System.Windows.Forms.Button();
            this.airline = new System.Windows.Forms.Label();
            this.airlineCompanyTextBox = new System.Windows.Forms.TextBox();
            this.childMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // childMenuStrip
            // 
            this.childMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.childMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.childMenuStrip.Name = "childMenuStrip";
            this.childMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.childMenuStrip.TabIndex = 2;
            this.childMenuStrip.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.arrangeIconToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // arrangeIconToolStripMenuItem
            // 
            this.arrangeIconToolStripMenuItem.Name = "arrangeIconToolStripMenuItem";
            this.arrangeIconToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.arrangeIconToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.arrangeIconToolStripMenuItem.Text = "Arrange &Icon";
            this.arrangeIconToolStripMenuItem.Click += new System.EventHandler(this.arrangeIconToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Add Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addButton_Click);
            // 
            // flightId
            // 
            this.flightId.Location = new System.Drawing.Point(276, 195);
            this.flightId.Name = "flightId";
            this.flightId.Size = new System.Drawing.Size(100, 20);
            this.flightId.TabIndex = 50;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(184, 198);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 49;
            this.Label1.Text = "Flight Id";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(276, 230);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 47;
            // 
            // customerId
            // 
            this.customerId.Location = new System.Drawing.Point(276, 158);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(100, 20);
            this.customerId.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Customer Id";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(355, 362);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 24);
            this.backButton.TabIndex = 53;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataTimeTextBox
            // 
            this.dataTimeTextBox.Location = new System.Drawing.Point(542, 243);
            this.dataTimeTextBox.Name = "dataTimeTextBox";
            this.dataTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataTimeTextBox.TabIndex = 61;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(542, 209);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(100, 20);
            this.destinationTextBox.TabIndex = 60;
            // 
            // originTextBox
            // 
            this.originTextBox.Location = new System.Drawing.Point(542, 183);
            this.originTextBox.Name = "originTextBox";
            this.originTextBox.Size = new System.Drawing.Size(100, 20);
            this.originTextBox.TabIndex = 59;
            // 
            // flightIdTextBox
            // 
            this.flightIdTextBox.Location = new System.Drawing.Point(542, 122);
            this.flightIdTextBox.Name = "flightIdTextBox";
            this.flightIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.flightIdTextBox.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Date time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Destination";
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(450, 190);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(34, 13);
            this.originLabel.TabIndex = 55;
            this.originLabel.Text = "Origin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Flight Id";
            // 
            // addFlightButton
            // 
            this.addFlightButton.Location = new System.Drawing.Point(499, 301);
            this.addFlightButton.Name = "addFlightButton";
            this.addFlightButton.Size = new System.Drawing.Size(75, 23);
            this.addFlightButton.TabIndex = 62;
            this.addFlightButton.Text = "Add Flight";
            this.addFlightButton.UseVisualStyleBackColor = true;
            this.addFlightButton.Click += new System.EventHandler(this.addFlightButton_Click);
            // 
            // airline
            // 
            this.airline.AutoSize = true;
            this.airline.Location = new System.Drawing.Point(450, 158);
            this.airline.Name = "airline";
            this.airline.Size = new System.Drawing.Size(82, 13);
            this.airline.TabIndex = 63;
            this.airline.Text = "Airline Company";
            // 
            // airlineCompanyTextBox
            // 
            this.airlineCompanyTextBox.Location = new System.Drawing.Point(542, 155);
            this.airlineCompanyTextBox.Name = "airlineCompanyTextBox";
            this.airlineCompanyTextBox.Size = new System.Drawing.Size(100, 20);
            this.airlineCompanyTextBox.TabIndex = 64;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.airlineCompanyTextBox);
            this.Controls.Add(this.airline);
            this.Controls.Add(this.addFlightButton);
            this.Controls.Add(this.dataTimeTextBox);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.originTextBox);
            this.Controls.Add(this.flightIdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.originLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flightId);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.childMenuStrip);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.childMenuStrip.ResumeLayout(false);
            this.childMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip childMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox flightId;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox customerId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox dataTimeTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox originTextBox;
        private System.Windows.Forms.TextBox flightIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addFlightButton;
        private System.Windows.Forms.Label airline;
        private System.Windows.Forms.TextBox airlineCompanyTextBox;
    }
}