using System;
using System.Collections;
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
    public partial class fCazare : Form
    {
        
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sterben\Desktop\Alexandrescu Proiect\ksdms1.accdb");
        private OleDbCommand cmd = new OleDbCommand();
        public fCazare()
        {
            InitializeComponent();
            dtpSelectData.MinDate = DateTime.Today;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fListaCazati fLC = new fListaCazati();
            fLC.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sigur doriti sa iesiti ?", "Anulare", MessageBoxButtons.YesNo);
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

        private void btSelectData_Click(object sender, EventArgs e)
        {
            dtpSelectData.Enabled = false;
            lblRezervare.Visible = true;
            lbxRezervari.Enabled = true;
            btCazeaza.Visible = true;
            txtRezervare.Visible = true;
            btAltaData.Enabled = true;
            btSelectData.Enabled = false;


            ////////////////////////////////////////////////////////////////////////
            bl();



        }

        private void lbxRezervari_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtRezervare.Text = lbxRezervari.SelectedItem.ToString();
            string[] SplitRezervari = lbxRezervari.SelectedItem.ToString().Split(' ');
            txtRezervare.Text = "pe numele: "+ SplitRezervari[1]+' '+ SplitRezervari[2];
            btCazeaza.Enabled = true;
        }

        private void btCazeaza_Click(object sender, EventArgs e)
        {
            string[] SplitRezervari = lbxRezervari.SelectedItem.ToString().Split(' ');
            cmd.Connection = con;
            cmd.CommandText = "Insert into Cazare(IdCamera,IdClient,Data) Select idCamera,idClient,Data FROM Rezervare " +
                               "WHERE idClient="+ SplitRezervari[0];
            // MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Clientul cu numele "+ SplitRezervari[1] + ' ' + SplitRezervari[2]+" este cazat cu succes", "Adaugat", MessageBoxButtons.OK);
            con.Close();

            cmd.CommandText = "DELETE FROM Rezervare WHERE idClient="+ SplitRezervari[0];
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            lbxRezervari.Items.Clear();
            bl();
        }
        private void bl() {
        
            cmd.Connection = con;
            cmd.CommandText = "SELECT FORMAT(r.idClient)+' '+Format(c.Nume)+' '+Format(c.Prenume)+' , CNP: '+Format(c.CNP) +',  Camera:  '+Format(re.NumarCamera) "+
                                "FROM(SELECT MIN(r.Data) AS Data, c.Nume, c.Prenume, c.CNP, c.IdClient, r.idCamera, r.idClient "+
                                "FROM Clienti c INNER JOIN Rezervare r ON r.idClient = c.IdClient "+
                                "GROUP BY c.IdClient, c.Nume, c.Prenume, c.CNP, idCamera, r.idClient) crt INNER JOIN Camere re ON crt.idCamera = re.IdCamera "+
                               " WHERE Data =#"+dtpSelectData.Value.ToShortDateString() + "# ";
            con.Open();
            OleDbDataReader saReader = cmd.ExecuteReader();

            while (saReader.Read())
            {
                lbxRezervari.Items.Add(saReader[0].ToString());
            }

            con.Close();
        }

        private void btAltaData_Click(object sender, EventArgs e)
        {
            txtRezervare.Visible = false;
            lblRezervare.Visible = false;
            btCazeaza.Visible = false;
            lbxRezervari.Items.Clear();
            btSelectData.Enabled = true;
            dtpSelectData.Enabled = true;
            btAltaData.Enabled = false;
            txtRezervare.Text = "";
        }

        private void btCazeazaAcum_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            fDatePers f00 = new fDatePers();
            f00.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sigur doriti sa inchideti  ?", "Avertizare", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CloseAllForm();
            }
            else { }
        }
    }
}
