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
    public partial class Form7 : Form
    {
        int y = 10;
        Oferta[] vectorOferte = { new Oferta(12938, 500, "Ceas"), new Oferta(738,
            200, "Colier"), new Oferta(37, 100,"Bratara"), new Oferta(99,150,"Inel")};

        List<Oferta> lista = new List<Oferta>();
        public Form7()
        {
            InitializeComponent();


            lista.Add(new Oferta(7383,500,"Inel"));
            for (int i = 0; i < vectorOferte.Length; i++)
                lista.Add(vectorOferte[i]);

          
            foreach (Oferta o in lista)
                listBox1.Items.Add(o.ToString());
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.Items.Count > 0)
                listBox1.DoDragDrop(listBox1.SelectedItem,
                    DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if ((e.KeyState & 8) == 8 && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();
            try
            {
                int cod = Convert.ToInt32(text.Split(',')[0]);
               
                float pret = (float)Convert.ToDouble(text.Split(',')[2]);
                string denumire = text.Split(',')[1];
                Oferta oferta = new Oferta(cod, pret,denumire);
                lista.Add(oferta);
                listBox1.Items.Add(oferta.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

    

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            g.DrawString(text, this.Font, new SolidBrush(Color.Black), 13, y);
            y += 20;
            if (y > panel1.Height)
            {
                MessageBox.Show("Cos plin!");
                panel1.Invalidate();
                y = 10;
            }
            if (e.Effect == DragDropEffects.Move)
            {
                
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if ((e.KeyState & 8) == 8 && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;
        }
    }
}
