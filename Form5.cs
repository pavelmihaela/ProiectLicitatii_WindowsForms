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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Pret"].Points.AddXY("Ceasuri", 500);
            this.chart1.Series["Importanta"].Points.AddXY("Ceasuri", 100);

            this.chart1.Series["Pret"].Points.AddXY("Coliere", 1000);
            this.chart1.Series["Importanta"].Points.AddXY("Coliere", 500);
            this.chart1.Series["Pret"].Points.AddXY("Bratari", 200);
            this.chart1.Series["Importanta"].Points.AddXY("Bratari", 10);
            this.chart1.Series["Pret"].Points.AddXY("Inele", 300);
            this.chart1.Series["Importanta"].Points.AddXY("Inele", 150);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
                frm.ShowDialog();

        }
    }
}
