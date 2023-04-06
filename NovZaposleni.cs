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
    public partial class NovZaposleni : Form
    {
        int uloga;
        public NovZaposleni(int uloga)
        {
            this.uloga = uloga;
            InitializeComponent();
        }

        private void cbUloga_Populate()
        {
            string[] uloge = { "Vlasnik", "Menadžer", "Farmaceut", "Farmaceutski tehničar" };
            DataTable dt = new DataTable();
            dt.Columns.Add("uloga_id");
            dt.Columns.Add("status");

            SqlDataAdapter da = new SqlDataAdapter("SELECT uloga FROM zaposleni WHERE zaposleni_id = "
                + cbMenadzer.SelectedValue, Baza.Konektuj());
            DataTable uloga_menadzera = new DataTable();
            da.Fill(uloga_menadzera);
            int um = 0;
            if (uloga_menadzera.Rows.Count > 0) um = Convert.ToInt32(uloga_menadzera.Rows[0]["uloga"]);

            for (int i = Math.Max(uloga, um); i < 4; i++) dt.Rows.Add(i, uloge[i]);

            cbUloga.DataSource = dt;
            cbUloga.ValueMember = "uloga_id";
            cbUloga.DisplayMember = "status";
        }

        private void cbLokal_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT lokal_id, adresa FROM lokal", Baza.Konektuj());
            DataTable lokal = new DataTable();
            da.Fill(lokal);
            lokal.Rows.Add(0, "Nema radno mesto");

            cbLokal.DataSource = lokal;
            cbLokal.ValueMember = "lokal_id";
            cbLokal.DisplayMember = "adresa";
        }

        private void cbMenadzer_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT zaposleni_id, ime + ' ' + prezime AS naziv FROM zaposleni", Baza.Konektuj());
            DataTable menadzer = new DataTable();
            da.Fill(menadzer);
            menadzer.Rows.Add(0, "Nema menadžera");

            cbMenadzer.DataSource = menadzer;
            cbMenadzer.ValueMember = "zaposleni_id";
            cbMenadzer.DisplayMember = "naziv";
        }

        private void btPotvrdi_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbLozinka.Text == "")
            {
                MessageBox.Show("Mejl i lozinka su obavezni!");
                return;
            }

            string vrednost = "null, null, null, null, null, N'" + tbEmail.Text + "', N'"
                + tbLozinka.Text + "', " + cbUloga.SelectedValue 
                + ", " + ((int)cbLokal.SelectedValue == 0 ? "null" : cbLokal.SelectedValue)
                + ", " + ((int)cbMenadzer.SelectedValue == 0 ? "null" : cbMenadzer.SelectedValue);
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("INSERT INTO zaposleni VALUES(" + vrednost + ")", veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                this.Close();
            }
            catch (Exception ex)
            {
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

        private void NovZaposleni_Load(object sender, EventArgs e)
        {
            cbMenadzer_Populate();
            cbUloga_Populate();
            cbLokal_Populate();
        }

        private void cbMenadzer_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbMenadzer.SelectedValue.ToString() != "System.Data.DataRowView") cbUloga_Populate();
        }
    }
}
