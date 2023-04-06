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
    public partial class Magacin : Form
    {
        int id_lokala;
        public Magacin(int id_lokala)
        {
            this.id_lokala = id_lokala;
            InitializeComponent();
        }

        private void cbNaziv_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT proizvod_id, naziv FROM proizvod", Baza.Konektuj());
            DataTable proizvod = new DataTable();
            da.Fill(proizvod);
            cbNaziv.DataSource = proizvod;
            cbNaziv.DisplayMember = "naziv";
            cbNaziv.ValueMember = "proizvod_id";
        }

        private void dgMagacin_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.magacin_lokala(" + id_lokala + ")", Baza.Konektuj());
            DataTable magacin = new DataTable();
            da.Fill(magacin);
            dgMagacin.DataSource = magacin;
            dgMagacin.Columns["magacin_id"].Visible = false;
            dgMagacin.Columns["id_leka"].Visible = false;
        }

        private void Magacin_Load(object sender, EventArgs e)
        {
            dtpRokTrajanja.MinDate = DateTime.Today;
            cbNaziv_Populate();
            dgMagacin_Populate();
            CheckDataGrid();
        }

        private bool CheckDataGrid()
        {
            if (dgMagacin.RowCount == 0)
            {
                DataTable nemaRezultata = new DataTable();
                nemaRezultata.Columns.Add(" ");
                nemaRezultata.Rows.Add("Nema rezultata.");
                dgMagacin.ColumnHeadersVisible = false;
                dgMagacin.DataSource = nemaRezultata;
                btBrisi.Enabled = false;
                btIzmeni.Enabled = false;
                return false;
            }
            else
            {
                dgMagacin.ColumnHeadersVisible = true;
                btBrisi.Enabled = true;
                btIzmeni.Enabled = true;
                SelectedRowChanged(0);
                return true;
            }
        }

        private void SelectedRowChanged(int n)
        {
            cbNaziv.SelectedValue = (int)dgMagacin.Rows[n].Cells["id_leka"].Value;
            if (dgMagacin.Rows[n].Cells["Dostavljeno"].Value.ToString() == "") dtpDostavljeno.Checked = false;
            else
            {
                dtpDostavljeno.Checked = true;
                dtpDostavljeno.Value = (DateTime)dgMagacin.Rows[n].Cells["Dostavljeno"].Value;
            }
            if (dgMagacin.Rows[n].Cells["Rok trajanja"].Value.ToString() == "") dtpRokTrajanja.Checked = false;
            else
            {
                dtpRokTrajanja.Checked = true;
                dtpRokTrajanja.Value = (DateTime)dgMagacin.Rows[n].Cells["Rok trajanja"].Value;
            }
            nudKolicina.Value = (int)dgMagacin.Rows[n].Cells["Količina"].Value;
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
            string vrednost = "null, " + cbNaziv.SelectedValue + ", " 
                + (dtpRokTrajanja.Checked ? "'" + dtpRokTrajanja.Value.ToString("yyyy-MM-dd") + "'" : "null")
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
                btBrisi.Enabled = btIzmeni.Enabled = dgMagacin.ColumnHeadersVisible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            string pomoc = cbNaziv.SelectedValue + ", rok_trajanja = "
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

        private void btRegulisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("EXEC regulisi_magacin " + id_lokala, veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgMagacin_Populate();
                CheckDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
