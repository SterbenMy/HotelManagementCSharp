using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectHotel
{
    public partial class fRezervare : Form
    {

        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sterben\Desktop\Alexandrescu Proiect\ksdms1.accdb");
        private OleDbCommand cmd = new OleDbCommand();
       


        public fRezervare()
        {
            InitializeComponent();
            dtpDataCazare.MinDate = DateTime.Today;
        }

        private void btAnuleaza_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sigur doriti sa iesiti din acest form?\n            Datele vor fi pierdute", "Anulare", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            { 
                CloseAllForm();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Clienti WHERE  IdClient=(SELECT MAX(IdClient) FROM Clienti) ";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

               
            }
            else { }
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            int i;
            DateTime dInceput = dtpDataCazare.Value.Date;
            DateTime dSfarsit =dtpDataDecazare.Value.Date;
            TimeSpan difference = dSfarsit - dInceput;
            double days = difference.TotalDays;
            // MessageBox.Show("Numarul de zile calculat este  "+days, "Validare", MessageBoxButtons.OK);
            //numarul de zile calculat +1 ca sa avem diferenta
            
            cmd.Connection = con;
            con.Open();
            if (rbRezervare.Checked)
            {
                for (i = 0; i < days + 1; i++)
                {
                    // MessageBox.Show("Numarul de zile calculat este  "  + dInceput.AddDays(i).ToString("dd/MM/yyyy"), "Validare", MessageBoxButtons.OK);
                    cmd.CommandText = "insert into rezervare (idCamera,Data,idClient) select '" + cbNumarCamera.Text + "',#" + dInceput.AddDays(i).ToString("dd/MM/yyyy") + "#, MAX(IdClient) FROM Clienti";
                    //MessageBox.Show(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                DialogResult result = MessageBox.Show("Ati facut o rezervare cu succes", "Rezervare cu succes", MessageBoxButtons.OK);
                CloseAllForm();
            }
            else if (rbCazare.Checked)
            {
                for (i = 0; i < days + 1; i++)
                {
                    // MessageBox.Show("Numarul de zile calculat este  "  + dInceput.AddDays(i).ToString("dd/MM/yyyy"), "Validare", MessageBoxButtons.OK);
                    cmd.CommandText = "insert into Cazare (IdCamera,IdClient,Data) select '" + cbNumarCamera.Text + "',MAX(IdClient),#" + dInceput.AddDays(i).ToString("dd/MM/yyyy") + "# FROM Clienti";
                    //MessageBox.Show(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                DialogResult result = MessageBox.Show("Ati cazat cu succes", "Cazare cu succes", MessageBoxButtons.OK);
                CloseAllForm();
            }
            else {
                DialogResult result = MessageBox.Show("Selectati Cazare sau Rezervare !!!", "Alert", MessageBoxButtons.OK);
                return;
            }
           


        }
        void CloseAllForm()
        {

            for (int x = 0; x < Application.OpenForms.Count; x++)
            {
                if (Application.OpenForms[x] != this)
                    Application.OpenForms[x + 1].Close();
            }
        }

        private void btCauta_Click(object sender, EventArgs e)
        {
            
            DateTime dInceput2 = dtpDataCazare.Value.Date;
            DateTime dSfarsit2 = dtpDataDecazare.Value.Date;
            int result = DateTime.Compare(dInceput2, dSfarsit2);
            
            if (result<=0)
            {
                dtpDataCazare.Enabled = false;
                dtpDataDecazare.Enabled = false;
                cbTipCamera.Visible = true;
                lblTipCamera.Visible = true;
                btCauta.Visible = false;
                btIntroduceAltaData.Visible = true;
            }
            else {
                MessageBox.Show("Data de cazare trebuie sa fie mai mare sau egala cu data decazare\n Introduceti datele corect !!!" , "Validare", MessageBoxButtons.OK);
            }


        }

        private void fRezervare_Load(object sender, EventArgs e)
        {
            cbTipCamera.Items.Add("Single");
            cbTipCamera.Items.Add("Double");
            cbTipCamera.Items.Add("Triple");
            cbEtaj.Items.Add("1");
            cbEtaj.Items.Add("2");
            


        }
        private void cbEtaj_SelectedIndexChanged1(object sender, EventArgs e) {
            cbNumarCamera.Items.Clear();
            cbNumarCamera.Items.Clear();

            lblEtaj.Visible = true;
            cbEtaj.Visible = true;
            cbNumarCamera.ResetText();
            cbEtaj.ResetText();
            btConfirma.Visible = false;
        }

        private void cbNumarCamera_SelectedIndexChanged(object sender, EventArgs e)
        {   
            cbNumarCamera.Items.Clear();
            lblNumarCamera.Visible = true;
            cbNumarCamera.Visible = true;
            SelectamCamereLiber();           
            cbNumarCamera.ResetText();
            btConfirma.Visible = false;


        }
        private void SelectamCamereLiber()
        {
            cmd.Connection = con;
            cmd.CommandText = "SELECT c.NumarCamera FROM  Camere AS c  INNER JOIN TipCamera AS t ON c.IdTipCamera=t.IdTipCamera WHERE " +
                " NOT c.NumarCamera IN (SELECT DISTINCT(NumarCamera)  FROM Camere c INNER JOIN Rezervare r ON c.IdCamera=r.idCamera  WHERE r.Data BETWEEN #" + dtpDataCazare.Value.ToShortDateString() + "# and #" + dtpDataDecazare.Value.ToShortDateString() + "#)" +
                " AND t.TipCamera = '" + cbTipCamera.Text + "' AND Nudisponibila=false AND Etaj= " + cbEtaj.Text+" AND NOT c.NumarCamera IN (SELECT DISTINCT(NumarCamera) FROM Camere c INNER JOIN Cazare cz ON c.IdCamera=cz.idCamera WHERE cz.Data BETWEEN #"+dtpDataCazare.Value.ToShortDateString() +"# and #"+dtpDataDecazare.Value.ToShortDateString()+"#)";
            con.Open();
            //cmd.ExecuteReader();
            OleDbDataReader saReader = cmd.ExecuteReader();
         
            while (saReader.Read())
                {
                
                    cbNumarCamera.Items.Add(saReader[0]);

                }

            con.Close();
        }

        private void cbNumarCamera_A1(object sender, EventArgs e)
        {
                btConfirma.Visible = true;
        }

        private void btIntroduceAltaData_Click(object sender, EventArgs e)
        {
            btIntroduceAltaData.Visible= false;
            btCauta.Visible = true;
            //dtpDataCazare.Enabled = true;
            dtpDataDecazare.Enabled = true;
            cbTipCamera.Visible = false;
            cbEtaj.Visible = false;
            cbNumarCamera.Visible = false;
            lblTipCamera.Visible = false;
            lblEtaj.Visible = false;
            lblNumarCamera.Visible = false;
            cbTipCamera.ResetText();
            cbNumarCamera.ResetText();
            cbEtaj.ResetText();
            if (rbCazare.Checked)
            {
                dtpDataCazare.Enabled = false;
            }
            else {
                dtpDataCazare.Enabled = true;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sigur doriti sa inchideti ?\n            Datele vor fi pierdute", "Avertizare", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CloseAllForm();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Clienti WHERE  IdClient=(SELECT MAX(IdClient) FROM Clienti) ";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            else { }
        }

        private void rbCazare_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataCazare.Value = DateTime.Today;
            dtpDataCazare.Enabled = false;

        }

      
    }
}
