
namespace Assignment10
{
    partial class DeleteForm
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
            this.flightId = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.customerId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.deleteFlightButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
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
            // flightId
            // 
            this.flightId.Location = new System.Drawing.Point(239, 206);
            this.flightId.Name = "flightId";
            this.flightId.Size = new System.Drawing.Size(100, 20);
            this.flightId.TabIndex = 42;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(189, 209);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 41;
            this.Label1.Text = "Flight Id";
            // 
            // customerId
            // 
            this.customerId.Location = new System.Drawing.Point(473, 206);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(100, 20);
            this.customerId.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Customer Id";
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Location = new System.Drawing.Point(473, 260);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(100, 23);
            this.deleteCustomerButton.TabIndex = 43;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // deleteFlightButton
            // 
            this.deleteFlightButton.Location = new System.Drawing.Point(239, 260);
            this.deleteFlightButton.Name = "deleteFlightButton";
            this.deleteFlightButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFlightButton.TabIndex = 44;
            this.deleteFlightButton.Text = "Delete Flight";
            this.deleteFlightButton.UseVisualStyleBackColor = true;
            this.deleteFlightButton.Click += new System.EventHandler(this.deleteFlightButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(344, 322);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 24);
            this.backButton.TabIndex = 54;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteFlightButton);
            this.Controls.Add(this.deleteCustomerButton);
            this.Controls.Add(this.flightId);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.childMenuStrip);
            this.Name = "DeleteForm";
            this.Text = "InsertForm";
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
        private System.Windows.Forms.TextBox flightId;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox customerId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button deleteFlightButton;
        private System.Windows.Forms.Button backButton;
    }
}