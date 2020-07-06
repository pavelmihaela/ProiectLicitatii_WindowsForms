using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectLicitatii
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
          
        }


     

        public void DrawPieChartOnForm()
        {

            int[] myPiePercent = { 10, 20, 25, 5, 40 };

            Color[] myPieColors = { Color.Red, Color.Pink, Color.Blue, Color.Green, Color.Maroon };

            using (Graphics myPieGraphic = this.CreateGraphics())
            {



                Point myPieLocation = new Point(500, 500);


                Size myPieSize = new Size(150, 150);


                DrawPieChart(myPiePercent, myPieColors, myPieGraphic, myPieLocation, myPieSize);
            }
        }

        
        public void DrawPieChart(int[] myPiePerecents, Color[] myPieColors, Graphics myPieGraphic, Point
                 myPieLocation, Size myPieSize)
        {
            //Check if sections add up to 100.
            int sum = 0;
            foreach (int percent_loopVariable in myPiePerecents)
            {
                sum += percent_loopVariable;
            }

            if (sum != 100)
            {
                MessageBox.Show("Sum Do Not Add Up To 100.");
            }

            if (myPiePerecents.Length != myPieColors.Length)
            {
                MessageBox.Show("There Must Be The Same Number Of Percents And Colors.");
            }

            int PiePercentTotal = 0;
            for (int PiePercents = 0; PiePercents < myPiePerecents.Length; PiePercents++)
            {
                using (SolidBrush brush = new SolidBrush(myPieColors[PiePercents]))
                {

                    myPieGraphic.FillPie(brush, new Rectangle(new Point(300, 110), myPieSize), Convert.ToSingle(PiePercentTotal * 360 / 100), Convert.ToSingle(myPiePerecents[PiePercents] * 360 / 100));

                }

                PiePercentTotal += myPiePerecents[PiePercents];
            }
            return;
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            DrawPieChartOnForm();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
