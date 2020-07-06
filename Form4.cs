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
    public partial class Form4 : Form
    {
        List<Oferta> listaOferte = new List<Oferta>();

        public Form4()
        {
            InitializeComponent();
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            e.Graphics.DrawString("Licitații câștigate și sumele datorate", 
                new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, new Point(300, 10));
            e.Graphics.DrawString("Ceas Rolex produs unicat   2500$\nColier damă cristale   5000$\nBrățară lucrată manual   500$\nCercei vintage 500$\nAmuletă unicată 700$",
                new Font("Times New Roman", 16, FontStyle.Regular), Brushes.Black, new Point(10, 40));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form5();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(tb_cod.Text);
                float pret = (float)Convert.ToDouble(tb_pret.Text);
                string denumire = tb_denumire.Text;

                Oferta oferta = new Oferta(cod, pret, denumire);
                listaOferte.Add(oferta);

                MessageBox.Show(oferta.ToString());


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb_cod.Clear();
                tb_denumire.Clear();
                tb_pret.Clear();

            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6(listaOferte);
            frm.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.ShowDialog();
        }

        
    }
}
