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
    public partial class Lokali : Form
    {
        public Lokali()
        {
            InitializeComponent();
        }

        private void dgLokali_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM lokal", Baza.Konektuj());
            DataTable lokal = new DataTable();
            da.Fill(lokal);
            dgLokali.DataSource = lokal;
            dgLokali.Columns["lokal_id"].Visible = false;
        }

        private bool CheckDataGrid()
        {
            if (dgLokali.RowCount == 0)
            {
                DataTable nemaRezultata = new DataTable();
                nemaRezultata.Columns.Add(" ");
                nemaRezultata.Rows.Add("Nema rezultata.");
                dgLokali.ColumnHeadersVisible = false;
                dgLokali.DataSource = nemaRezultata;
                btBrisi.Enabled = false;
                btIzmeni.Enabled = false;
                return false;
            }
            else
            {
                dgLokali.ColumnHeadersVisible = true;
                btBrisi.Enabled = true;
                btIzmeni.Enabled = true;
                SelectedRowChanged(0);
                return true;
            }
        }

        private void SelectedRowChanged(int n)
        {
            tbAdresa.Text = dgLokali.Rows[n].Cells["adresa"].Value.ToString();
            tbKontakt.Text = dgLokali.Rows[n].Cells["kontakt"].Value.ToString();
        }

        int current_id = 0;
        int current_cellC = 1;
        private void dgLokali_CurrentCellChanged(object sender, EventArgs e)
        {
            if (!dgLokali.Focused || dgLokali.CurrentRow == null) return;
            current_id = dgLokali.CurrentRow.Index;
            current_cellC = dgLokali.CurrentCell.ColumnIndex;
            SelectedRowChanged(current_id);
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            if (tbAdresa.Text == "")
            {
                MessageBox.Show("Polje 'adresa' je obavezno!");
                return;
            }

            SqlConnection veza = Baza.Konektuj();
            string vrednost = "N'" + tbAdresa.Text + "', " + (tbKontakt.Text == "" ? "null" : "N'" + tbKontakt.Text + "'");
            SqlCommand komanda = new SqlCommand("INSERT INTO lokal VALUES (" + vrednost + ")", veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgLokali_Populate();
                current_id = dgLokali.RowCount - 1;
                dgLokali.CurrentCell = dgLokali[current_cellC, current_id];
                btBrisi.Enabled = btIzmeni.Enabled = dgLokali.ColumnHeadersVisible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            if (tbAdresa.Text == "")
            {
                MessageBox.Show("Polje 'adresa' je obavezno!");
                return;
            }

            SqlConnection veza = Baza.Konektuj();
            string pomoc = tbAdresa.Text + "'" + ", kontakt = " +
                (tbKontakt.Text == "" ? "null" : "N'" + tbKontakt.Text + "'") 
                + " WHERE lokal_id = " + dgLokali.Rows[current_id].Cells["lokal_id"].Value;
            SqlCommand komanda = new SqlCommand("UPDATE lokal SET adresa = N'" + pomoc, veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgLokali_Populate();
                dgLokali.CurrentCell = dgLokali[current_cellC, current_id];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("DELETE FROM lokal WHERE lokal_id = " + dgLokali.Rows[current_id].Cells["lokal_id"].Value, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgLokali_Populate();
                if (CheckDataGrid())
                {
                    if (current_id > 0) dgLokali.CurrentCell = dgLokali[current_cellC, --current_id];
                    else dgLokali.CurrentCell = dgLokali[current_cellC, current_id];
                    SelectedRowChanged(current_id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Lokali_Load(object sender, EventArgs e)
        {
            dgLokali_Populate();
            CheckDataGrid();
        }
    }
}
