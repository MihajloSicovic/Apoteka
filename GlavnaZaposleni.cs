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
    public partial class GlavnaZaposleni : Form
    {
        Zaposleni zaposleni;
        public GlavnaZaposleni(DataRow korisnik)
        {
            zaposleni = new Zaposleni(korisnik);
            InitializeComponent();
            if (zaposleni.uloga == 0) lokalaToolStripMenuItem.Visible = true;
        }

        private void GlavnaZaposleni_Load()
        {
            label1.Text = "Srećan rad";
            if (zaposleni.ime != "" || zaposleni.prezime != "") label1.Text += ", " + zaposleni.ime + " " + zaposleni.prezime;
            label1.Text += "!";
            if (zaposleni.id_menadzera == 0) nalogZaposlenogToolStripMenuItem.Visible = true;
        }

        private void GlavnaZaposleni_Load(object sender, EventArgs e)
        {
            GlavnaZaposleni_Load();
        }

        private void deaktivirajteNalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da deaktivirate svoj nalog?", "Deaktivirate nalog?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection veza = Baza.Konektuj();
                string uslov = " WHERE zaposleni_id = " + zaposleni.zaposleni_id;
                SqlCommand komanda = new SqlCommand("DELETE FROM zaposleni" + uslov, veza);

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

        private void promeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promeni promeni = new Promeni("zaposleni", (sender as ToolStripMenuItem).Tag.ToString());
            promeni.Show();
            promeni.FormClosed += ApdejtujZaposlenog;
        }

        private void podaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PodaciZaposleni podaci = new PodaciZaposleni(zaposleni.zaposleni_id, zaposleni.ime, zaposleni.prezime, zaposleni.jmbg, zaposleni.adresa);
            podaci.Show();
            podaci.FormClosing += ApdejtujZaposlenog;
        }

        private void ApdejtujZaposlenog(object sender, EventArgs e)
        {
            string uslov = " WHERE zaposleni_id = " + zaposleni.zaposleni_id;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM zaposleni" + uslov, Baza.Konektuj());
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            zaposleni = new Zaposleni(dataTable.Rows[0]);
            GlavnaZaposleni_Load();
        }

        private void proizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proizvodi proizvodi = new Proizvodi();
            proizvodi.Show();
        }

        private void magacinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Magacin magacin = new Magacin(zaposleni.id_lokala);
            magacin.Show();
        }

        private void zaposlenihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledZaposleni pregledZaposleni = new PregledZaposleni(zaposleni.uloga, zaposleni.zaposleni_id, zaposleni.id_menadzera);
            pregledZaposleni.Show();
            pregledZaposleni.FormClosing += PregledZaposleni_FormClosing;
        }

        private void PregledZaposleni_FormClosing(object sender, FormClosingEventArgs e)
        {
            zaposleni.uloga = (sender as PregledZaposleni).uloga;
            zaposleni.id_menadzera = (sender as PregledZaposleni).id_menadzera;
            zaposleni.id_lokala = (sender as PregledZaposleni).id_lokala;
        }

        private void lokalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lokali lokali = new Lokali();
            lokali.Show();
        }

        private void karticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaKartica kartica = new NovaKartica();
            kartica.Show();
        }

        private void dostavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaDostava novaDostava = new NovaDostava(zaposleni.id_lokala);
            novaDostava.Show();
            novaDostava.FormClosed += NovaDostava_FormClosed;
        }

        private void NovaDostava_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("DELETE FROM dostava WHERE dostava_id = " + (sender as NovaDostava).id_dostave, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void transakcijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaTransakcija novaTransakcija = new NovaTransakcija(zaposleni.id_lokala);
            novaTransakcija.Show();
            novaTransakcija.FormClosed += NovaTransakcija_FormClosed;
        }

        private void NovaTransakcija_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("DELETE FROM transakcija WHERE trans_id = " + (sender as NovaTransakcija).id_trans, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void karticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kartice kartice = new Kartice();
            kartice.Show();
        }

        private void dostaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dostave dostave = new Dostave(zaposleni.id_lokala);
            dostave.Show();
        }

        private void transakcijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transakcije transakcije = new Transakcije();
            transakcije.Show();
        }

        private void nalogZaposlenogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovZaposleni novZaposleni = new NovZaposleni(zaposleni.uloga);
            novZaposleni.Show();
        }
    }
}
