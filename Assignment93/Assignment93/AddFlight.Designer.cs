namespace Assignment93
{
    partial class AddFlight
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
            this.error = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataTime = new System.Windows.Forms.TextBox();
            this.destination = new System.Windows.Forms.TextBox();
            this.origin = new System.Windows.Forms.TextBox();
            this.flightId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(304, 115);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Add Flight";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addFlight);
            // 
            // dataTime
            // 
            this.dataTime.Location = new System.Drawing.Point(396, 248);
            this.dataTime.Name = "dataTime";
            this.dataTime.Size = new System.Drawing.Size(100, 20);
            this.dataTime.TabIndex = 30;
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(396, 214);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(100, 20);
            this.destination.TabIndex = 29;
            // 
            // origin
            // 
            this.origin.Location = new System.Drawing.Point(396, 183);
            this.origin.Name = "origin";
            this.origin.Size = new System.Drawing.Size(100, 20);
            this.origin.TabIndex = 28;
            // 
            // flightId
            // 
            this.flightId.Location = new System.Drawing.Point(396, 155);
            this.flightId.Name = "flightId";
            this.flightId.Size = new System.Drawing.Size(100, 20);
            this.flightId.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Origin";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(304, 155);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "Flight Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Save file name";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.openData);
            // 
            // AddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.error);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataTime);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.origin);
            this.Controls.Add(this.flightId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Name = "AddFlight";
            this.Text = "AddFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dataTime;
        private System.Windows.Forms.TextBox destination;
        private System.Windows.Forms.TextBox origin;
        private System.Windows.Forms.TextBox flightId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}