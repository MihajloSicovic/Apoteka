using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apoteka
{
    public partial class GlavnaKupac : Form
    {
        Kupac kupac;
        public GlavnaKupac(DataRow korisnik)
        {
            kupac = new Kupac(korisnik);
            InitializeComponent();
        }

        private void poeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string uslov = " WHERE id_kupca = " + kupac.kupac_id;
            SqlDataAdapter da = new SqlDataAdapter("SELECT FLOOR(poeni) AS poeni FROM kartica" + uslov, Baza.Konektuj());
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);

            if (dataTable.Rows.Count == 0) MessageBox.Show("Kreirajte karticu kako biste skupljali poene!");
            else MessageBox.Show("Trenutni broj poena na Vašoj kartici je: " + Convert.ToInt32(dataTable.Rows[0]["poeni"]));
        }

        private void iskorisceniPoeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string uslov = " WHERE id_kupca = " + kupac.kupac_id;
            SqlDataAdapter da = new SqlDataAdapter("SELECT SUM(korisceni_poeni) AS korisceni_poeni FROM transakcija" + uslov, Baza.Konektuj());
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            int korisceni_poeni = 0;

            if (!dataTable.Rows[0].IsNull(0)) korisceni_poeni = Convert.ToInt32(dataTable.Rows[0]["korisceni_poeni"]);
            MessageBox.Show("Trenutni broj iskorišćenih poena je: " + korisceni_poeni);
        }

        private void ukupnoPotrosenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string uslov = " WHERE id_kupca = " + kupac.kupac_id;
            SqlDataAdapter da = new SqlDataAdapter("SELECT SUM(dbo.ukupni_racun(trans_id)) AS ukupno FROM transakcija" + uslov, Baza.Konektuj());
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            decimal ukupno = 0;

            if (!dataTable.Rows[0].IsNull(0)) ukupno = Convert.ToDecimal(dataTable.Rows[0]["ukupno"]);
            MessageBox.Show("Ukupno potrošeno: " + ukupno + " RSD");
        }

        private void promeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promeni promeni = new Promeni("kupac", (sender as ToolStripMenuItem).Tag.ToString());
            promeni.Show();
            promeni.FormClosed += ApdejtujKupca;
        }

        private void ApdejtujKupca(object sender, EventArgs e)
        {
            string uslov = " WHERE kupac_id = " + kupac.kupac_id;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kupac" + uslov, Baza.Konektuj());
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            kupac = new Kupac(dataTable.Rows[0]);
            GlavnaKupac_Load();
        }

        private void deaktivirajNalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da deaktivirate svoj nalog?", "Deaktivirate nalog?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection veza = Baza.Konektuj();
                string uslov = " WHERE kupac_id = " + kupac.kupac_id;
                SqlCommand komanda = new SqlCommand("DELETE FROM kupac" + uslov, veza);

                try
                {
                    veza.Open();
                    komanda.ExecuteNonQuery();
                    veza.Close();
                    this.Close();
                }
                catch (Exception ex) 
                {
                    if (veza.State == ConnectionState.Open) veza.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void GlavnaKupac_Load()
        {
            label1.Text = "Dobrodošli";
            if (kupac.datum_rodjenja.Day == DateTime.Today.Day &&
                kupac.datum_rodjenja.Month == DateTime.Today.Month) label1.Text = "Srećan rodjendan";
            if (kupac.ime != "" || kupac.prezime != "") label1.Text += ", " + kupac.ime + " " + kupac.prezime;
            label1.Text += "!";
        }

        private void GlavnaKupac_Load(object sender, EventArgs e)
        {
            GlavnaKupac_Load();
        }

        private void podaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PodaciKupac podaci = new PodaciKupac(kupac.kupac_id, kupac.ime, kupac.prezime, kupac.datum_rodjenja);
            podaci.Show();
            podaci.FormClosing += ApdejtujKupca;
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pretraga pretraga = new Pretraga((sender as ToolStripMenuItem).Tag.ToString());
            pretraga.Show();
        }
    }
}
