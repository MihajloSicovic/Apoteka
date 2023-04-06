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
    public partial class Promeni : Form
    {
        string tabela, kolona;
        public Promeni(string tabela, string kolona)
        {
            this.tabela = tabela;
            if (kolona == "Broj racuna") this.kolona = "broj_racuna";
            else this.kolona = kolona;
            InitializeComponent();
        }

        private void Promeni_Load(object sender, EventArgs e)
        {
            if (kolona != "sifra")
            {
                label3.Text = kolona.Substring(0, 1).ToUpper() + kolona.Substring(1) + ":";
                btOtkrij2.Visible = false;
                tbPromena.UseSystemPasswordChar = false;
                return;
            }

            label2.Text = "Stara lozinka:";
            label3.Text = "Nova lozinka:";
        }

        private void btOtkrij2_MouseUp(object sender, MouseEventArgs e)
        {
            tbPromena.UseSystemPasswordChar = true;
            btOtkrij2.BackgroundImage = Image.FromFile("PrecrtanoOko.png");
        }

        private void btOtkrij2_MouseDown(object sender, MouseEventArgs e)
        {
            tbPromena.UseSystemPasswordChar = false;
            btOtkrij2.BackgroundImage = Image.FromFile("Oko.png");
            tbPromena.Focus();
        }

        private void btOtkrij1_MouseUp(object sender, MouseEventArgs e)
        {
            tbLozinka.UseSystemPasswordChar = true;
            btOtkrij1.BackgroundImage = Image.FromFile("PrecrtanoOko.png");            
        }

        private void btOtkrij1_MouseDown(object sender, MouseEventArgs e)
        {
            tbLozinka.UseSystemPasswordChar = false;
            btOtkrij1.BackgroundImage = Image.FromFile("Oko.png");
            tbLozinka.Focus();
        }

        private void btPotvrdi_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbLozinka.Text == "" || tbPromena.Text == "")
            {
                MessageBox.Show("Sva polja su obavezna!");
                return;
            }

            SqlConnection veza = Baza.Konektuj();
            string uslov = " WHERE email = N'" + tbEmail.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + tabela + uslov, veza);
            DataTable korisnik = new DataTable();
            da.Fill(korisnik);

            if (korisnik.Rows.Count == 0) MessageBox.Show("Dati nalog ne postoji!");
            else if (string.Compare(tbLozinka.Text, korisnik.Rows[0]["sifra"].ToString()) != 0) MessageBox.Show("Pogresna lozinka!");
            else
            {
                SqlCommand komanda = new SqlCommand("UPDATE " + tabela + " SET " + kolona + " = N'" + tbPromena.Text + "'" + uslov, veza);
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
    }
}
