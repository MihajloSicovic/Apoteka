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
    public partial class NapraviNalog : Form
    {
        public string email, lozinka;
        public bool NalogNapravljen = false;
        public NapraviNalog()
        {
            InitializeComponent();
        }

        private void NapraviNalog_Load(object sender, EventArgs e)
        {
            dtpDatumRodjenja.MaxDate = DateTime.Today;
        }

        private void btNapravi_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbLozinka.Text == "")
            {
                MessageBox.Show("Mejl i lozinka su obavezni podaci!");
                return;
            }

            email = tbEmail.Text;
            lozinka = tbLozinka.Text;
            SqlConnection veza = Baza.Konektuj();
            string vrednost = (tbIme.Text == "" ? "null" : "N'" + tbIme.Text + "'") + ", " 
                            + (tbPrezime.Text == "" ? "null" : "N'" + tbPrezime.Text + "'") + ", "
                            + "'" + dtpDatumRodjenja.Value.Date.ToString("yyyy-MM-dd") + "', " 
                            + ("'" + tbEmail.Text + "', ") + ("N'" + tbLozinka.Text + "', ")
                            + (tbKontakt.Text == "" ? "null" : "N'" + tbKontakt.Text + "'");
            SqlCommand komanda = new SqlCommand("INSERT INTO kupac VALUES(" + vrednost + ")", veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                NalogNapravljen = true;
                this.Close();
            }
            catch (Exception ex)
            {
                if (veza.State == ConnectionState.Open) veza.Close();
                MessageBox.Show(ex.Message);
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
    }
}
