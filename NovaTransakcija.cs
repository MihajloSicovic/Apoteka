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
    public partial class NovaTransakcija : Form
    {
        int id_lokala;
        public NovaTransakcija(int id_lokala)
        {
            this.id_lokala = id_lokala;
            InitializeComponent();
        }

        private void cbKupac_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT kupac_id, ime + ' ' + prezime AS naziv FROM kupac", Baza.Konektuj());
            DataTable kupac = new DataTable();
            da.Fill(kupac);
            kupac.Rows.Add(0, "Nema kupca");

            cbKupac.DataSource = kupac;
            cbKupac.ValueMember = "kupac_id";
            cbKupac.DisplayMember = "naziv";
        }

        private void cbKartica_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT kartica_id, broj_kartice FROM kartica", Baza.Konektuj());
            DataTable kartice = new DataTable();
            da.Fill(kartice);
            kartice.Rows.Add(0, "Nema kartice");

            cbKartica.DataSource = kartice;
            cbKartica.ValueMember = "kartica_id";
            cbKartica.DisplayMember = "broj_kartice";
        }

        private void dgMagacin_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.magacin_lokala(" + id_lokala + ")" +
                " WHERE Količina > 0", Baza.Konektuj());
            DataTable magacin = new DataTable();
            da.Fill(magacin);
            dgMagacin.DataSource = magacin;
            dgMagacin.Columns["magacin_id"].Visible = false;
            dgMagacin.Columns["id_leka"].Visible = false;
        }

        private void dgRacun_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.racun_transakcije(" + id_trans + ")", Baza.Konektuj());
            DataTable racun = new DataTable();
            da.Fill(racun);
            dgRacun.DataSource = racun;
            dgRacun.Columns["racun_id"].Visible = false;
            dgRacun.Columns["id_magacina"].Visible = false;
        }

        private bool CheckDataGridMagacin()
        {
            if (dgMagacin.RowCount == 0)
            {
                DataTable nemaRezultata = new DataTable();
                nemaRezultata.Columns.Add(" ");
                nemaRezultata.Rows.Add("Magacin je prazan.");
                dgMagacin.DataSource = nemaRezultata;
                dgMagacin.ColumnHeadersVisible = false;
                btDodaj.Enabled = false;
                return false;
            }
            else
            {
                dgMagacin.ColumnHeadersVisible = true;
                btDodaj.Enabled = true;
                return true;
            }
        }

        private bool CheckDataGrid()
        {
            if (dgRacun.RowCount == 0)
            {
                DataTable nemaRezultata = new DataTable();
                nemaRezultata.Columns.Add(" ");
                nemaRezultata.Rows.Add("Račun nema stavki.");
                dgRacun.ColumnHeadersVisible = false;
                dgRacun.DataSource = nemaRezultata;
                btPotvrdi.Enabled = false;
                btBrisi.Enabled = false;
                btIzmeni.Enabled = false;
                return false;
            }
            else
            {
                dgRacun.ColumnHeadersVisible = true;
                btPotvrdi.Enabled= true;
                btBrisi.Enabled = true;
                btIzmeni.Enabled = true;
                SelectedRowChanged(0);
                return true;
            }
        }

        private void SelectedRowChanged(int n)
        {
            nudKolicina.Value = (int)dgRacun.Rows[n].Cells["kolicina"].Value;

            int p = 0;
            for (int i = 0; i < dgMagacin.Rows.Count; i++)
            {
                if ((int)dgMagacin.Rows[i].Cells["magacin_id"].Value == (int)dgRacun.Rows[n].Cells["id_magacina"].Value)
                {
                    p = i;
                    break;
                }
            }

            dgMagacin.CurrentCell = dgMagacin[dgMagacin.CurrentCell.ColumnIndex, p];
        }

        public int id_trans = 0;
        private void NovaTransakcija_Load(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("INSERT INTO transakcija VALUES (0, null, null, null)", veza);

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

            komanda = new SqlCommand("SELECT dbo.najnovija_transakcija()", veza);

            try
            {
                veza.Open();
                id_trans = (int)komanda.ExecuteScalar();
                veza.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cbKupac_Populate();
            cbKartica_Populate();
            cbKartica.SelectedValue = cbKupac.SelectedValue = 0;
            dgMagacin_Populate();
            dgRacun_Populate();
            CheckDataGridMagacin();
            CheckDataGrid();
            dozvoljeno = true;
        }

        int current_magacin_id = 0;
        int current_magacinC = 2;
        private void dgMagacin_CurrentCellChanged(object sender, EventArgs e)
        {
            if (!dgMagacin.Focused || dgMagacin.CurrentRow == null) return;
            current_magacin_id = dgMagacin.CurrentRow.Index;
            current_magacinC = dgMagacin.CurrentCell.ColumnIndex;
        } 

        int current_id = 0;
        int current_cellC = 1;
        private void dgRacun_CurrentCellChanged(object sender, EventArgs e)
        {
            if (!dgRacun.Focused || dgRacun.CurrentRow == null) return;
            current_id = dgRacun.CurrentRow.Index;
            current_cellC = dgRacun.CurrentCell.ColumnIndex;
            SelectedRowChanged(current_id);
        }

        private void UkupnoUpdate()
        {
            if (!dozvoljeno) return;

            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("SELECT dbo.ukupni_racun(" + id_trans + ")", veza);

            try
            {
                veza.Open();
                object obj = komanda.ExecuteScalar();
                if (obj.ToString() == "") obj = 0;
                if ((int)cbKartica.SelectedValue == 0) nudKorisceniPoeni.Maximum = 0;
                else nudKorisceniPoeni.Maximum = Math.Floor(Convert.ToDecimal(obj) + nudKorisceniPoeni.Value);
                tbUkupno.Text = obj.ToString() + " RSD";
                veza.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nudKorisceniPoeni_ValueChanged(object sender, EventArgs e)
        {
            TransakcijaUpdate();
            UkupnoUpdate();
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            if (nudKolicina.Value == 0)
            {
                MessageBox.Show("Količina proizvoda mora biti veća od 0!");
                return;
            }

            SqlConnection veza = Baza.Konektuj();
            string vrednost = dgMagacin.Rows[current_magacin_id].Cells["magacin_id"].Value
                + ", 0, " + nudKolicina.Value + ", " + id_trans;
            SqlCommand komanda = new SqlCommand("INSERT INTO racun VALUES (" + vrednost + ")", veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgRacun_Populate();
                dgMagacin_Populate();
                current_id = dgRacun.RowCount - 1;
                dgRacun.CurrentCell = dgRacun[current_cellC, current_id];
                try { dgMagacin.CurrentCell = dgMagacin[current_magacinC, current_magacin_id]; }
                catch { current_magacin_id = 0; }
                btBrisi.Enabled = btIzmeni.Enabled = btPotvrdi.Enabled = dgRacun.ColumnHeadersVisible = true;
                UkupnoUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            string pomoc = nudKolicina.Value
                + " WHERE racun_id = " + dgRacun.Rows[current_id].Cells["racun_id"].Value;
            SqlCommand komanda = new SqlCommand("UPDATE racun SET kolicina = " + pomoc, veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgRacun_Populate();
                dgMagacin_Populate();
                dgRacun.CurrentCell = dgRacun[current_cellC, current_id];
                try { dgMagacin.CurrentCell = dgMagacin[current_magacinC, current_magacin_id]; }
                catch { current_magacin_id = 0; }
                UkupnoUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("DELETE FROM racun WHERE racun_id = " + dgRacun.Rows[current_id].Cells["racun_id"].Value, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgRacun_Populate();
                dgMagacin_Populate();
                if (CheckDataGrid())
                {
                    if (current_id > 0) dgRacun.CurrentCell = dgRacun[current_cellC, --current_id];
                    else dgRacun.CurrentCell = dgRacun[current_cellC, current_id];
                    SelectedRowChanged(current_id);
                }
                try { dgMagacin.CurrentCell = dgMagacin[current_magacinC, current_magacin_id]; }
                catch { current_magacin_id = 0; }
                UkupnoUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool dozvoljeno = false;
        private void TransakcijaUpdate()
        {
            if (!dozvoljeno) return;
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("UPDATE transakcija SET korisceni_Poeni = " + nudKorisceniPoeni.Value
                + ", datum_obrade = '" + DateTime.Today.ToString("yyyy-MM-dd")
                + "', id_kartice = " + ((int)cbKartica.SelectedValue == 0 ? "null" : cbKartica.SelectedValue.ToString())
                + ", id_kupca = " + ((int)cbKupac.SelectedValue == 0 ? "null" : cbKupac.SelectedValue.ToString())
                + " WHERE trans_id = " + id_trans, veza);

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

            dgMagacin_Populate();
            dgRacun_Populate();
            if (CheckDataGrid()) dgRacun.CurrentCell = dgRacun[current_cellC, current_id];
            if (CheckDataGridMagacin())
            {
                try { dgMagacin.CurrentCell = dgMagacin[current_magacinC, current_magacin_id]; }
                catch { current_magacin_id = 0; }
            }
            UkupnoUpdate();
        }

        private void btPotvrdi_Click(object sender, EventArgs e)
        {
            id_trans = 0;
            this.Close();
        }

        private void cbKupac_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbKupac.SelectedValue.ToString() == "System.Data.DataRowView") return;
            SqlDataAdapter da = new SqlDataAdapter("SELECT kartica_id FROM kartica" +
                " JOIN kupac ON id_kupca = kupac_id WHERE kupac_id = " + cbKupac.SelectedValue, Baza.Konektuj());
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0) cbKartica.SelectedValue = 0;
            else cbKartica.SelectedValue = dt.Rows[0]["kartica_id"];

            TransakcijaUpdate();
            UkupnoUpdate();
        }

        private void cbKartica_SelectedValueChanged(object sender, EventArgs e)
        {
            TransakcijaUpdate();
            UkupnoUpdate();
        }
    }
}
