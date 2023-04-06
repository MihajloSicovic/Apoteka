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
    public partial class Pretraga : Form
    {
        string pogled, predmetPretrage;
        public Pretraga(string predmetPretrage)
        {
            InitializeComponent();
            dtPretraga = new DataTable();
            this.predmetPretrage = predmetPretrage;
            label1.Text = predmetPretrage + ":";
            if (predmetPretrage == "Proizvod")
            {
                pogled = "pretraga_lekova";
                this.predmetPretrage = "naziv";
            }
            else pogled = "pretraga_lokala";
        }

        private void btPretrazi_Click(object sender, EventArgs e)
        {
            dtPretraga = new DataTable();
            if (tbPretraga.Text == "")
            {
                Pretraga_Load();
                return;
            }

            string uslov = " WHERE CHARINDEX('" + tbPretraga.Text + "', " + predmetPretrage + ") > 0";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + pogled + uslov, Baza.Konektuj());
            da.Fill(dtPretraga);
            dgPretraga_Populate();
        }

        private void Pretraga_Load()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + pogled, Baza.Konektuj());
            da.Fill(dtPretraga);
            dgPretraga_Populate();
        }

        private void Pretraga_Load(object sender, EventArgs e)
        {
            Pretraga_Load();
        }

        DataTable dtPretraga;
        private void dgPretraga_Populate()
        {
            DataTable nemaRezultata = new DataTable();
            nemaRezultata.Columns.Add(" ");
            nemaRezultata.Rows.Add("Nema rezultata.");
            if (dtPretraga.Rows.Count == 0)
            {
                dgPretraga.ColumnHeadersVisible = false;
                dgPretraga.DataSource = nemaRezultata;
                return;
            }

            dgPretraga.ColumnHeadersVisible = true;
            dgPretraga.DataSource = dtPretraga;
        }
    }
}
