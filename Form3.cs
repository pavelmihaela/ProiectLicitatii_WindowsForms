using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectLicitatii
{
    public partial class Form3 : Form
    {
       // StreamReader sr = new StreamReader("TextFile1.txt");
        public Form3()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {


            string[] linii = File.ReadAllLines("TextFile1.txt");

            string[] values;
            for(int i=0; i<linii.Length;i++)
            {
                values = linii[i].ToString().Split('/');
                string[] row = new string[values.Length];

                for(int j=0; j<values.Length;j++)
                {
                    row[j] = values[j].Trim();

                }

                table.Rows.Add(row);

            }



        }

        private void Form3_Load(object sender, EventArgs e)
        {

            table.Columns.Add("ID", typeof(int));

            table.Columns.Add("Denumire", typeof(string));

            table.Columns.Add("Pret", typeof(string));
            table.Columns.Add("Tip produs", typeof(string));


            dataGridView1.DataSource = table;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form4();
                frm.ShowDialog();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
