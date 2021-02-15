
namespace Assignment10
{
    partial class SearchForm
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
            this.searchFlightButton = new System.Windows.Forms.Button();
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.flightId = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.customerId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.childMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // searchFlightButton
            // 
            this.searchFlightButton.Location = new System.Drawing.Point(228, 91);
            this.searchFlightButton.Name = "searchFlightButton";
            this.searchFlightButton.Size = new System.Drawing.Size(89, 23);
            this.searchFlightButton.TabIndex = 50;
            this.searchFlightButton.Text = "Search Flight";
            this.searchFlightButton.UseVisualStyleBackColor = true;
            this.searchFlightButton.Click += new System.EventHandler(this.searchFlightButton_Click);
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.Location = new System.Drawing.Point(462, 91);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(100, 23);
            this.searchCustomerButton.TabIndex = 49;
            this.searchCustomerButton.Text = "Search Customer";
            this.searchCustomerButton.UseVisualStyleBackColor = true;
            this.searchCustomerButton.Click += new System.EventHandler(this.searchCustomerButton_Click);
            // 
            // flightId
            // 
            this.flightId.Location = new System.Drawing.Point(228, 37);
            this.flightId.Name = "flightId";
            this.flightId.Size = new System.Drawing.Size(100, 20);
            this.flightId.TabIndex = 48;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(178, 40);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 47;
            this.Label1.Text = "Flight Id";
            // 
            // customerId
            // 
            this.customerId.Location = new System.Drawing.Point(462, 37);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(100, 20);
            this.customerId.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Customer Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 307);
            this.dataGridView1.TabIndex = 51;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchFlightButton);
            this.Controls.Add(this.searchCustomerButton);
            this.Controls.Add(this.flightId);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.childMenuStrip);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.childMenuStrip.ResumeLayout(false);
            this.childMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button searchFlightButton;
        private System.Windows.Forms.Button searchCustomerButton;
        private System.Windows.Forms.TextBox flightId;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox customerId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}