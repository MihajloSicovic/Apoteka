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
    public partial class PregledZaposleni : Form
    {
        public int uloga, zaposleni_id, id_menadzera, id_lokala;
        public PregledZaposleni(int uloga, int zaposleni_id, int id_menadzera)
        {
            this.uloga = uloga;
            this.zaposleni_id = zaposleni_id;
            this.id_menadzera = id_menadzera;
            InitializeComponent();
        }

        private void dgZaposleni_Populate()
        {
            SqlDataAdapter da;
            if (uloga == 0) da = new SqlDataAdapter("SELECT * FROM svi_zaposleni", Baza.Konektuj());
            else da = new SqlDataAdapter("SELECT * FROM podredjeni_zaposlenom(" + zaposleni_id + ")", Baza.Konektuj());

            DataTable zaposleni = new DataTable();
            da.Fill(zaposleni);
            dgZaposleni.DataSource = zaposleni;
            dgZaposleni.Columns["zaposleni_id"].Visible = false;
            dgZaposleni.Columns["id_lokala"].Visible = false;
            dgZaposleni.Columns["uloga"].Visible = false;
            dgZaposleni.Columns["id_menadzera"].Visible = false;
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
            int id = 0;
            if (dgZaposleni.Rows.Count != 0 && dgZaposleni.Rows.Count != current_id) id = (int)dgZaposleni.Rows[current_id].Cells["zaposleni_id"].Value;
            SqlDataAdapter da = new SqlDataAdapter("SELECT zaposleni_id, ime + ' ' + prezime AS naziv " +
                "FROM zaposleni WHERE zaposleni_id <> " + id, Baza.Konektuj());
            DataTable menadzer = new DataTable();
            da.Fill(menadzer);
            if (id_menadzera == 0) menadzer.Rows.Add(0, "Nema menadžera");

            cbMenadzer.DataSource = menadzer;
            cbMenadzer.ValueMember = "zaposleni_id";
            cbMenadzer.DisplayMember = "naziv";
        }

        private void PregledZaposleni_Load(object sender, EventArgs e)
        {
            dgZaposleni_Populate();
            cbLokal_Populate();
            CheckDataGrid();
        }

        private bool CheckDataGrid()
        {
            if (dgZaposleni.RowCount == 0)
            {
                DataTable nemaRezultata = new DataTable();
                nemaRezultata.Columns.Add(" ");
                nemaRezultata.Rows.Add("Nema rezultata.");
                dgZaposleni.ColumnHeadersVisible = false;
                dgZaposleni.DataSource = nemaRezultata;
                btBrisi.Enabled = false;
                btIzmeni.Enabled = false;
                return false;
            }
            else
            {
                dgZaposleni.ColumnHeadersVisible = true;
                btBrisi.Enabled = true;
                btIzmeni.Enabled = true;
                SelectedRowChanged(0);
                return true;
            }
        }

        private void SelectedRowChanged(int n)
        {
            cbMenadzer_Populate();
            if (dgZaposleni.Rows[n].Cells["id_menadzera"].Value.ToString() == "") cbMenadzer.SelectedValue = 0;
            else cbMenadzer.SelectedValue = (int)dgZaposleni.Rows[n].Cells["id_menadzera"].Value;
            cbUloga.SelectedValue = (int)dgZaposleni.Rows[n].Cells["uloga"].Value;
            if (dgZaposleni.Rows[n].Cells["id_lokala"].Value.ToString() == "") cbLokal.SelectedValue = 0;
            else cbLokal.SelectedValue = (int)dgZaposleni.Rows[n].Cells["id_lokala"].Value;
            if (dgZaposleni.Rows.Count != current_id && (int)dgZaposleni.Rows[current_id].Cells["zaposleni_id"].Value == zaposleni_id) btBrisi.Enabled = false;
            else btBrisi.Enabled = true;
        }

        int current_id = 0;
        int current_cellC = 0;
        private void cbMenadzer_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbMenadzer.SelectedValue.ToString() != "System.Data.DataRowView") cbUloga_Populate();
        }

        private void dgZaposleni_CurrentCellChanged(object sender, EventArgs e)
        {
            if (!dgZaposleni.Focused || dgZaposleni.CurrentRow == null) return;
            current_id = dgZaposleni.CurrentRow.Index;
            current_cellC = dgZaposleni.CurrentCell.ColumnIndex;
            SelectedRowChanged(current_id);
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            string pomoc = cbUloga.SelectedValue + 
                ", id_lokala = " + ((int)cbLokal.SelectedValue == 0 ? "null" : cbLokal.SelectedValue) +
                ", id_menadzera = " + ((int)cbMenadzer.SelectedValue == 0 ? "null" : cbMenadzer.SelectedValue)
                + " WHERE zaposleni_id = " + dgZaposleni.Rows[current_id].Cells["zaposleni_id"].Value;
            SqlCommand komanda = new SqlCommand("UPDATE zaposleni SET uloga = " + pomoc, veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                if ((int)dgZaposleni.Rows[current_id].Cells["zaposleni_id"].Value == zaposleni_id)
                {
                    uloga = Convert.ToInt32(cbUloga.SelectedValue);
                    id_menadzera = Convert.ToInt32(cbMenadzer.SelectedValue);
                    id_lokala = Convert.ToInt32(cbLokal.SelectedValue);
                    cbUloga_Populate();
                }

                dgZaposleni_Populate();
                if (CheckDataGrid())
                {
                    if (current_id == dgZaposleni.Rows.Count) dgZaposleni.CurrentCell = dgZaposleni[current_cellC, --current_id];
                    else dgZaposleni.CurrentCell = dgZaposleni[current_cellC, current_id];
                    SelectedRowChanged(current_id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("DELETE FROM zaposleni WHERE zaposleni_id = " + dgZaposleni.Rows[current_id].Cells["zaposleni_id"].Value, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgZaposleni_Populate();
                if (CheckDataGrid())
                {
                    if (current_id > 0) dgZaposleni.CurrentCell = dgZaposleni[current_cellC, --current_id];
                    else dgZaposleni.CurrentCell = dgZaposleni[current_cellC, current_id];
                    SelectedRowChanged(current_id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
