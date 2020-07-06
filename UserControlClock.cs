using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectLicitatii
{
    public partial class UserControlClock : UserControl
    {

        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Timer clockTimer;
        public UserControlClock()
        {
            InitializeComponent1();


        }

  
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            displayLabel.Text = DateTime.Now.ToLongTimeString();
        }
        private void InitializeComponent1()
        {
            this.displayLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(new System.ComponentModel.Container());
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(4, 10);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(143, 52);
            this.displayLabel.TabIndex = 0;
            this.displayLabel.Text = "12:55:55 AM";
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // ClockUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.displayLabel);
            this.Name = "ClockUserControl";
            this.Size = new System.Drawing.Size(150, 72);
            this.ResumeLayout(false);

        }



    }
}
