using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace Apoteka
{
    public partial class Ulogovanje : Form
    {
        public Ulogovanje()
        {
            InitializeComponent();
        }

        private void Ulogovanje_Load(object sender, EventArgs e)
        {
            if (!Baza.Postoji())
            {
                Baza.Kreiraj();
            }
        }

        private void btOtkrij_MouseUp(object sender, MouseEventArgs e)
        {
            tbLozinka.UseSystemPasswordChar = true;
            btOtkrij.BackgroundImage = Image.FromFile("PrecrtanoOko.png");
        }

        private void btOtkrij_MouseDown(object sender, MouseEventArgs e)
        {
            tbLozinka.UseSystemPasswordChar = false;
            btOtkrij.BackgroundImage = Image.FromFile("Oko.png");
            tbLozinka.Focus();
        }

        string strana;
        private void btStrana_Click(object sender, EventArgs e)
        {
            btOtkrij.Visible = btNazad.Visible = label1.Visible = label2.Visible = btPotvrdi.Visible = tbEmail.Visible = tbLozinka.Visible = true;
            btZaposleni.Visible = btKupac.Visible = false;
            tbEmail.Clear();
            tbLozinka.Clear();
            strana = (sender as Button).Tag.ToString();

            if (strana == "kupac") label3.Visible = llbNapraviNalog.Visible = true;
        }

        private void btNazad_Click(object sender, EventArgs e)
        {
            btOtkrij.Visible = btNazad.Visible = label1.Visible = label2.Visible = label3.Visible = llbNapraviNalog.Visible = btPotvrdi.Visible = tbEmail.Visible = tbLozinka.Visible = false;
            btZaposleni.Visible = btKupac.Visible = true;
        }

        private void btPotvrdi_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbLozinka.Text == "")
            {
                MessageBox.Show("Morate uneti mejl i lozinku!");
                return;
            }
            
            string uslov = " WHERE email = '" + tbEmail.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + strana + uslov, Baza.Konektuj());
            DataTable korisnik = new DataTable();
            da.Fill(korisnik);

            if (korisnik.Rows.Count == 0) MessageBox.Show("Dati nalog ne postoji!");
            else if (string.Compare(tbLozinka.Text, korisnik.Rows[0]["sifra"].ToString()) != 0) MessageBox.Show("Pogresna lozinka!");
            else
            {
                if (strana == "zaposleni")
                {
                    GlavnaZaposleni zaposleni = new GlavnaZaposleni(korisnik.Rows[0]);
                    zaposleni.Load += Glavna_Load;
                    zaposleni.Show();
                }
                else
                {
                    GlavnaKupac kupac = new GlavnaKupac(korisnik.Rows[0]);
                    kupac.Load += Glavna_Load;
                    kupac.Show();
                }
            }
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            tbEmail.Clear();
            tbLozinka.Clear();
        }

        private void Ulogovanje_FormClosing(object sender, FormClosingEventArgs e)
        {
            Baza.SacuvajPodatke();
        }

        private void llbNapraviNalog_MouseClick(object sender, MouseEventArgs e)
        {
            NapraviNalog napraviNalog = new NapraviNalog();
            napraviNalog.Show();
            napraviNalog.FormClosed += NapraviNalog_FormClosed;
        }

        private void NapraviNalog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((sender as NapraviNalog).NalogNapravljen)
            {
                tbEmail.Text = (sender as NapraviNalog).email;
                tbLozinka.Text = (sender as NapraviNalog).lozinka;
                btPotvrdi.PerformClick();
            }
        }
    }
}
