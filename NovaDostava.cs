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
    public partial class NovaDostava : Form
    {
        int id_lokala;
        public NovaDostava(int id_lokala)
        {
            this.id_lokala = id_lokala;
            InitializeComponent();
        }

        private void dgProizvod_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM proizvod", Baza.Konektuj());
            DataTable proizvod = new DataTable();
            da.Fill(proizvod);
            dgProizvod.DataSource = proizvod;
            dgProizvod.Columns["proizvod_id"].Visible = false;
        }

        private void dgMagacin_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.magacin_dostave(" + id_dostave + ")", Baza.Konektuj());
            DataTable magacin = new DataTable();
            da.Fill(magacin);
            dgMagacin.DataSource = magacin;
            dgMagacin.Columns["magacin_id"].Visible = false;
            dgMagacin.Columns["id_leka"].Visible = false;
        }

        public int id_dostave = 0;
        private void NovaDostava_Load(object sender, EventArgs e)
        {
            dtpRokTrajanja.MinDate = dtpDatum.MinDate = DateTime.Today;
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("INSERT INTO dostava VALUES (null, 0)", veza);

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

            komanda = new SqlCommand("SELECT dbo.najnovija_dostava()", veza);

            try
            {
                veza.Open();
                id_dostave = (int)komanda.ExecuteScalar();
                veza.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgProizvod_Populate();
            CheckDataGrid();
        }

        private bool CheckDataGrid()
        {
            if (dgMagacin.RowCount == 0)
            {
                DataTable nemaRezultata = new DataTable();
                nemaRezultata.Columns.Add(" ");
                nemaRezultata.Rows.Add("Dostava je prazna.");
                dgMagacin.ColumnHeadersVisible = false;
                dgMagacin.DataSource = nemaRezultata;
                btBrisi.Enabled = false;
                btIzmeni.Enabled = false;
                btPotvrdi.Enabled = false;
                return false;
            }
            else
            {
                dgMagacin.ColumnHeadersVisible = true;
                btBrisi.Enabled = true;
                btIzmeni.Enabled = true;
                btPotvrdi.Enabled = true;
                SelectedRowChanged(0);
                return true;
            }
        }

        private void SelectedRowChanged(int n)
        {
            if (dgMagacin.Rows[n].Cells["Rok trajanja"].Value.ToString() == "") dtpRokTrajanja.Checked = false;
            else
            {
                dtpRokTrajanja.Checked = true;
                dtpRokTrajanja.Value = (DateTime)dgMagacin.Rows[n].Cells["Rok trajanja"].Value;
            }
            nudKolicina.Value = (int)dgMagacin.Rows[n].Cells["Količina"].Value;

            int p = 0;
            for (int i = 0; i < dgProizvod.Rows.Count; i++)
            {
                if ((int)dgProizvod.Rows[i].Cells["proizvod_id"].Value == (int)dgMagacin.Rows[n].Cells["id_leka"].Value)
                {
                    p = i;
                    break;
                }
            }

            dgProizvod.CurrentCell = dgProizvod[dgProizvod.CurrentCell.ColumnIndex, p];
        }

        int current_proizvod_id = 0;
        private void dgProizvod_CurrentCellChanged(object sender, EventArgs e)
        {
            if (!dgProizvod.Focused || dgProizvod.CurrentRow == null) return;
            current_proizvod_id = dgProizvod.CurrentRow.Index;
        }

        int current_id = 0;
        int current_cellC = 2;
        private void dgMagacin_CurrentCellChanged(object sender, EventArgs e)
        {
            if (!dgMagacin.Focused || dgMagacin.CurrentRow == null) return;
            current_id = dgMagacin.CurrentRow.Index;
            current_cellC = dgMagacin.CurrentCell.ColumnIndex;
            SelectedRowChanged(current_id);
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            if (nudKolicina.Value == 0)
            {
                MessageBox.Show("Količina proizvoda mora biti veća od 0!");
                return;
            }

            SqlConnection veza = Baza.Konektuj();
            string vrednost = id_dostave + ", " + dgProizvod.Rows[current_proizvod_id].Cells["proizvod_id"].Value 
                + ", " + (dtpRokTrajanja.Checked ? "'" + dtpRokTrajanja.Value.ToString("yyyy-MM-dd") + "'" : "null")
                + ", " + nudKolicina.Value + ", " + id_lokala;
            SqlCommand komanda = new SqlCommand("INSERT INTO magacin VALUES (" + vrednost + ")", veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgMagacin_Populate();
                current_id = dgMagacin.RowCount - 1;
                dgMagacin.CurrentCell = dgMagacin[current_cellC, current_id];
                btBrisi.Enabled = btIzmeni.Enabled = btPotvrdi.Enabled = dgMagacin.ColumnHeadersVisible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            string pomoc = dgProizvod.Rows[current_proizvod_id].Cells["proizvod_id"].Value 
                + ", rok_trajanja = "
                + (dtpRokTrajanja.Checked ? "'" + dtpRokTrajanja.Value.ToString("yyyy-MM-dd") + "'" : "null")
                + ", u_magacinu = " + nudKolicina.Value
                + " WHERE magacin_id = " + dgMagacin.Rows[current_id].Cells["magacin_id"].Value;
            SqlCommand komanda = new SqlCommand("UPDATE magacin SET id_leka = " + pomoc, veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgMagacin_Populate();
                dgMagacin.CurrentCell = dgMagacin[current_cellC, current_id];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("DELETE FROM magacin WHERE magacin_id = " + dgMagacin.Rows[current_id].Cells["magacin_id"].Value, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgMagacin_Populate();
                if (CheckDataGrid())
                {
                    if (current_id > 0) dgMagacin.CurrentCell = dgMagacin[current_cellC, --current_id];
                    else dgMagacin.CurrentCell = dgMagacin[current_cellC, current_id];
                    SelectedRowChanged(current_id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btPotvrdi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("UPDATE dostava SET datum = '" + 
                dtpDatum.Value.ToString("yyyy-MM-dd") + "' WHERE dostava_id = " + id_dostave, veza);
            id_dostave = 0;

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
    }
}
