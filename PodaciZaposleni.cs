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
    public partial class PodaciZaposleni : Form
    {
        int zaposleni_id;
        public PodaciZaposleni(int zaposleni_id, string ime, string prezime, string jmbg, string adresa)
        {
            InitializeComponent();
            this.zaposleni_id = zaposleni_id;
            tbIme.Text = ime;
            tbPrezime.Text = prezime;
            tbJMBG.Text = jmbg;
            tbAdresa.Text = adresa;
        }

        private void btSacuvaj_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            string str = "UPDATE zaposleni SET ime = " + (tbIme.Text == "" ? "null" : "N'" + tbIme.Text + "'") + ", "
                        + "prezime = " + (tbPrezime.Text == "" ? "null" : "N'" + tbPrezime.Text + "'") + ", "
                        + "jmbg = " + (tbJMBG.Text == "" ? "null" : "N'" + tbJMBG.Text + "'") + ", "
                        + "adresa = " + (tbAdresa.Text == "" ? "null" : "N'" + tbAdresa.Text + "'")
                        + " WHERE zaposleni_id = " + zaposleni_id.ToString();
            SqlCommand komanda = new SqlCommand(str, veza);
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
