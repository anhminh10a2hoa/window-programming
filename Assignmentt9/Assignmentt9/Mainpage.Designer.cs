namespace Assignmentt9
{
    partial class Mainpage
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 89);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Flight";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addFlight);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 89);
            this.button2.TabIndex = 18;
            this.button2.Text = "Add Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addCustomer);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 89);
            this.button3.TabIndex = 19;
            this.button3.Text = "Delete Flight";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteFlight);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(559, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 89);
            this.button4.TabIndex = 20;
            this.button4.Text = "Search Flight";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.searchFlight);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(559, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 89);
            this.button5.TabIndex = 21;
            this.button5.Text = "Search Customer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.searchCustomer);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(289, 349);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(210, 89);
            this.button6.TabIndex = 22;
            this.button6.Text = "Summary";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.showData);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(289, 221);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 89);
            this.button7.TabIndex = 23;
            this.button7.Text = "Delete Customer";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.deleteCustomer);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(424, 221);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 89);
            this.button8.TabIndex = 25;
            this.button8.Text = "Update Customer";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.updateCustomer);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(424, 91);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 89);
            this.button9.TabIndex = 24;
            this.button9.Text = "Update Flight";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.updateFlight);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(244, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "ASSIGNMENT 9 - Minh Hoang";
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Mainpage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
    }
}

