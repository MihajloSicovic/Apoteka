using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apoteka
{
    public partial class PodaciKupac : Form
    {
        int kupac_id;
        public PodaciKupac(int kupac_id, string ime, string prezime, DateTime datum_rodjenja)
        {
            InitializeComponent();
            dtpDatumRodjenja.MaxDate = DateTime.Today;
            tbIme.Text = ime;
            tbPrezime.Text = prezime;
            dtpDatumRodjenja.Value = datum_rodjenja;
            this.kupac_id = kupac_id;
        }

        private void btSacuvaj_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            string str = "UPDATE kupac SET ime = " + (tbIme.Text == "" ? "null" : "N'" + tbIme.Text + "'") + ", "
                        + "prezime = " + (tbPrezime.Text == "" ? "null" : "N'" + tbPrezime.Text + "'") + ", "
                        + "datum_rodjenja = '" + dtpDatumRodjenja.Value.Date.ToString("yyyy-MM-dd") + "'"
                        + " WHERE kupac_id = " + kupac_id.ToString();
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
