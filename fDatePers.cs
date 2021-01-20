using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectHotel
{
    public partial class fDatePers : Form
    {
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sterben\Desktop\Alexandrescu Proiect\ksdms1.accdb");
        private OleDbCommand cmd = new OleDbCommand();
        public fDatePers()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            adauga_inregistrare();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sigur doriti sa iesiti din acest form?\n            Datele vor fi pierdute", "Anulare", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CloseAllForm();
            }
            else { }
        }
        void CloseAllForm()
        {

            for (int x = 0; x < Application.OpenForms.Count; x++)
            {
                if (Application.OpenForms[x] != this)
                    Application.OpenForms[x + 1].Close();
            }
        }
        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;
            DateTime dt = this.dtpDataNasterii.Value.Date;
            DateTime dtoday = DateTime.Now;
            TimeSpan difference = dtoday - dt;
            double days = difference.TotalDays;

            if (txtNume.Text.Trim().Equals("") || txtPrenume.Text.Trim().Equals("") || txtCNP.Text.Trim().Equals("") || txtOras.Text.Trim().Equals("") || txtAdresa.Text.Trim().Equals(""))
            {
                MessageBox.Show("Completati spatiile libere", "Validare", MessageBoxButtons.OK);
            }
            else if (txtCNP.TextLength != 13)
            {
                MessageBox.Show("Verificati CNP-ul", "Validare", MessageBoxButtons.OK);
            }
            else if (days < 6575)
            {
                MessageBox.Show("Nu se permite sa rezerveze  o persoana mai mica de 18 ani", "Validare", MessageBoxButtons.OK);
            }
            else
            {
                cmd.Connection = con;
                listaCampuri = "Nume, Prenume, CNP, Oras, Adresa, DataNasterii";
                listaValori = "'" + txtNume.Text + "'" + ",'" + txtPrenume.Text + "'" + ",'" + txtCNP.Text + "'" + ",'" + txtOras.Text + "'" + ",'" + txtAdresa.Text + "'" + ",'" + dtpDataNasterii.Value + "'";
                cmd.CommandText = "Insert into Clienti(" + listaCampuri + ") " + "Select " + listaValori;
                // MessageBox.Show(cmd.CommandText);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                this.Visible = false;
                fRezervare fRezervare = new fRezervare();
                fRezervare.ShowDialog();
                this.Visible = true;
            }
        }

        private void golireCampuri()
        {
            txtNume.Text = "";
            txtPrenume.Text = "";
            txtCNP.Text = "";
            txtOras.Text = "";
            txtAdresa.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            golireCampuri();
        }
        //pot adauga doar cifre
        private void txtCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        //pot adauga doar litere
        private void OnlyTXT(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sigur doriti sa inchideti  ?\n            Datele vor fi pierdute", "Avertizare", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CloseAllForm();
            }
            else { }
        }
    }
}
