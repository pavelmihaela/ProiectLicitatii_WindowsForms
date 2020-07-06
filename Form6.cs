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
    public partial class Form6 : Form
    {
        List<Oferta> lista2;
        public Form6(List<Oferta>lista)
        {
            lista2 = lista;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Oferta o in lista2)
            {
                ListViewItem itm = new ListViewItem(o.cod.ToString());
                itm.SubItems.Add(o.pret.ToString());
                itm.SubItems.Add(o.denumireProdus.ToString());

                listView1.Items.Add(itm);

            }
        }
    }
}
