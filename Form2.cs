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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn dv = new DataGridViewImageColumn();

            dv.HeaderText = "Imagine";
            dv.ImageLayout = DataGridViewImageCellLayout.Stretch;
           
            DataGridViewTextBoxColumn dvCod = new DataGridViewTextBoxColumn();
            dvCod.HeaderText = "Cod";

            DataGridViewTextBoxColumn dvDenumire = new DataGridViewTextBoxColumn();
            dvDenumire.HeaderText = "Denumire";

       
            DataGridViewTextBoxColumn dvPret = new DataGridViewTextBoxColumn();
            dvPret.HeaderText = "Pret";




                dataGridView1.Columns.Add(dvCod);
                dataGridView1.Columns.Add(dv);
                dataGridView1.Columns.Add(dvDenumire);
                dataGridView1.Columns.Add(dvPret);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowTemplate.Height = 120;
                dataGridView1.AllowUserToAddRows = false;
           



        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Alege Imagine(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if(open.ShowDialog()== DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(open.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);

                byte[] img = ms.ToArray();

               

                    dataGridView1.Rows.Add(tb_cod.Text, img, tb_denumire.Text, tb_pret.Text);
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
                tb_pret.Clear();
                tb_cod.Clear();
                tb_denumire.Text = "";
            }
           

        }

        private void btn_urmator_Click(object sender, EventArgs e)
        {
            Form frm3 = new Form3();
            frm3.ShowDialog();

        }
    }
}
