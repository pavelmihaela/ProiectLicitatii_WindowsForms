using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProiectLicitatii
{
    public partial class Form1 : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mimi\Desktop\ProiectLicitatii\ProiectLicitatii\mydb.accdb");
        OleDbCommand command;
        OleDbDataAdapter adapter;
        DataTable dt = new DataTable();


        public Form1()
        {
            InitializeComponent();

            dataGrid1.ColumnCount = 6;
            dataGrid1.Columns[0].Name = "ID";
            dataGrid1.Columns[1].Name = "Nume";
            dataGrid1.Columns[2].Name = "Prenume";
            dataGrid1.Columns[3].Name = "NumarTelefon";
            dataGrid1.Columns[4].Name = "Adresa";
            dataGrid1.Columns[5].Name = "Gen";

            dataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid1.MultiSelect = false;
        }


        private void add(string nume,string prenume, string numarTelefon, string adresa, string gen)
        {
            string sql= "INSERT INTO Candidat(Nume, Prenume, NumarTelefon, Adresa, Gen) VALUES(@Nume, @Prenume, @NumarTelefon, @Adresa, @Gen)";

            command = new OleDbCommand(sql, con);

            command.Parameters.AddWithValue("@Nume", nume);
            command.Parameters.AddWithValue("@Prenume", prenume);
            command.Parameters.AddWithValue("@NumarTelefon",numarTelefon);
            command.Parameters.AddWithValue("@Adresa", adresa);
            command.Parameters.AddWithValue("@Gen", gen);

            try
            {
                con.Open();
                if(command.ExecuteNonQuery() >0)
                {
                    Clear();
                    MessageBox.Show("S-a inserat cu succes!");
                }
                con.Close();

                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

          
        }

        private void populate(string id, string nume, string prenume, string numartelefon, string adresa,
            string gen)
        {
            dataGrid1.Rows.Add(id, nume, prenume, numartelefon, adresa, gen);

        }
        private void retrieve()
        {
            dataGrid1.Rows.Clear();
            string sql = "SELECT * FROM Candidat";
            command = new OleDbCommand(sql, con);

            try
            {
                con.Open();

                adapter = new OleDbDataAdapter(command);
                adapter.Fill(dt);

                foreach(DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(),
                        row[4].ToString(), row[5].ToString() );
                }

                con.Close();
                dt.Rows.Clear();



            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();

                dt.Rows.Clear();
            }
        }


        private void update(int id, string nume, string prenume, string numartelefon, string adresa,
            string gen)
        {

            string sql = "UPDATE Candidat SET Nume='" + nume + "',Prenume='" + prenume + "',NumarTelefon='" + numartelefon + "',Adresa='" + adresa +

                 "',Gen='" + gen + "' WHERE CandidatID=" + id + "";
            command = new OleDbCommand(sql, con);

            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(command);
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if(adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    Clear();
                    MessageBox.Show("S-a modificat!");
                }

                con.Close();

                retrieve();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void delete(int id)
        {

            string sql = "DELETE FROM Candidat WHERE CandidatID=" + id + "";
            command = new OleDbCommand(sql,con);

            try
            {
                con.Open();


                adapter = new OleDbDataAdapter(command);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;


                if(MessageBox.Show("Sunteti sigur?", "DELETE",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    if(command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("S-a sters cu succes!");

                    }
                }
                con.Close();

                retrieve();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();

            }

        }


        private void btn_adauga_Click(object sender, EventArgs e)
        {
            
            add(tb_nume.Text, tb_prenume.Text, tb_telefon.Text, tb_adresa.Text,
                cb_gen.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Candidat' table. You can move, or remove it, as needed.
            this.candidatTableAdapter.Fill(this.appData.Candidat);
            candidatBindingSource.DataSource = this.appData.Candidat;
           
        }


        
        

        public void Clear()
        {
           
            tb_nume.Text = "";
            tb_prenume.Text = "";
            tb_telefon.Text = "";
            tb_adresa.Text = "";
            cb_gen.Text = "";
       
        }

        private void btn_modifica_Click(object sender, EventArgs e)
        {
            string selected = dataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            update(id, tb_nume.Text, tb_prenume.Text, tb_telefon.Text, tb_adresa.Text,
                cb_gen.Text);


        }

       /* private void dataGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
          
            tb_nume.Text = dataGrid1.Rows[index].Cells[1].Value.ToString();
            tb_prenume.Text = dataGrid1.Rows[index].Cells[2].Value.ToString();
            tb_telefon.Text = dataGrid1.Rows[index].Cells[3].Value.ToString();
            tb_adresa.Text = dataGrid1.Rows[index].Cells[4].Value.ToString();

            cb_gen.Text = dataGrid1.Rows[index].Cells[5].Value.ToString();



        }
        */

        private void btn_sterge_Click(object sender, EventArgs e)
        {
            string selected = dataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            delete(id);

        }

        private void numeValidate(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nume.Text))
            {
                errorProvider1.SetError(tb_nume, "Acest camp trebuie completat");

            }
            else if(tb_nume.Text.Length < 3)
            {
                errorProvider1.SetError(tb_nume, "Trebuie sa contina minim 3 litere!");

            }
            else
            {
                errorProvider1.SetError(tb_nume, null);

            }
            
        }

        private void PrenumeValidate(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_prenume.Text))
            {
                errorProvider1.SetError(tb_prenume, "Acest camp trebuie completat!");

            }
            else if (tb_prenume.Text.Length < 3)
            {
                errorProvider1.SetError(tb_prenume, "Trebuie sa contina minim 3 litere!");

            }
            else
            {
                errorProvider1.SetError(tb_prenume, null);

            }

           
        }

        private void TelefonValidate(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_telefon.Text))
            {
                errorProvider1.SetError(tb_telefon, "Acest camp trebuie completat!");

            }
            else if (tb_telefon.Text.Length < 9)
            {
                errorProvider1.SetError(tb_prenume, "Nu este un numar valid!");

            }
            else
            {
                errorProvider1.SetError(tb_telefon, null);


            }
            

        }

        private void AdresaValidate(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_telefon.Text))
            {
                errorProvider1.SetError(tb_adresa, "Acest camp trebuie completat!");

            }
            else if (tb_adresa.Text.Length < 3)
            {
                errorProvider1.SetError(tb_adresa, "Nu sunt suficiente 3 litere");

            }
            else
            {
                errorProvider1.SetError(tb_adresa, null);

            }

            
        }

        private void numarTelefon_keyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch!= 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void adresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGrid1_MouseClick(object sender, MouseEventArgs e)
        {
           // Clear();

            tb_nume.Text = dataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            tb_prenume.Text = dataGrid1.SelectedRows[0].Cells[2].Value.ToString();
            tb_telefon.Text = dataGrid1.SelectedRows[0].Cells[3].Value.ToString();
            tb_adresa.Text = dataGrid1.SelectedRows[0].Cells[4].Value.ToString();
            cb_gen.Text = dataGrid1.SelectedRows[0].Cells[5].Value.ToString();

        }


        private void btn_next_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.ShowDialog();

        }
    }
}
