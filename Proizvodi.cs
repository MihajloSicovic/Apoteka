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
    public partial class Proizvodi : Form
    {
        public Proizvodi()
        {
            InitializeComponent();
        }

        private void dgProizvodi_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM proizvod", Baza.Konektuj());
            DataTable proizvod = new DataTable();
            da.Fill(proizvod);
            dgProizvodi.DataSource = proizvod;
            dgProizvodi.Columns["proizvod_id"].Visible = false;
        }

        private void Proizvodi_Load(object sender, EventArgs e)
        {
            dgProizvodi_Populate();
            CheckDataGrid();
        }

        private bool CheckDataGrid()
        {
            if (dgProizvodi.RowCount == 0)
            {
                DataTable nemaRezultata = new DataTable();
                nemaRezultata.Columns.Add(" ");
                nemaRezultata.Rows.Add("Nema rezultata.");
                dgProizvodi.ColumnHeadersVisible = false;
                dgProizvodi.DataSource = nemaRezultata;
                btBrisi.Enabled = false;
                btIzmeni.Enabled = false;
                return false;
            }
            else
            {
                dgProizvodi.ColumnHeadersVisible = true;
                btBrisi.Enabled = true;
                btIzmeni.Enabled = true;
                SelectedRowChanged(0);
                return true;
            }
        }

        private void SelectedRowChanged(int n)
        {
            tbNaziv.Text = dgProizvodi.Rows[n].Cells["naziv"].Value.ToString();
            tbCena.Text = dgProizvodi.Rows[n].Cells["cena"].Value.ToString();
            tbPodvrsta.Text = dgProizvodi.Rows[n].Cells["podvrsta"].Value.ToString();
            tbOpis.Text = dgProizvodi.Rows[n].Cells["opis"].Value.ToString();
            cbLek.Checked = (bool)dgProizvodi.Rows[n].Cells["lek"].Value;
        }

        int current_id = 0;
        int current_cellC = 1;
        private void dgProizvodi_CurrentCellChanged(object sender, EventArgs e)
        {
            if (!dgProizvodi.Focused || dgProizvodi.CurrentRow == null) return;
            current_id = dgProizvodi.CurrentRow.Index;
            current_cellC = dgProizvodi.CurrentCell.ColumnIndex;
            SelectedRowChanged(current_id);
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            string vrednost = "N'" + tbNaziv.Text + "', " + tbCena.Text + ", '" + cbLek.Checked + "', N'"
                + tbPodvrsta.Text + "', N'" + tbOpis.Text + "'";
            SqlCommand komanda = new SqlCommand("INSERT INTO proizvod VALUES (" + vrednost + ")", veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgProizvodi_Populate();
                current_id = dgProizvodi.RowCount - 1;
                dgProizvodi.CurrentCell = dgProizvodi[current_cellC, current_id];
                btBrisi.Enabled = btIzmeni.Enabled = dgProizvodi.ColumnHeadersVisible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            string pomoc = tbNaziv.Text + 
                "', cena = " + tbCena.Text + 
                ", lek = '" + cbLek.Checked + 
                "', podvrsta = N'" + tbPodvrsta.Text + 
                "', opis = N'" + tbOpis.Text + "'"
                + " WHERE proizvod_id = " + dgProizvodi.Rows[current_id].Cells["proizvod_id"].Value;
            SqlCommand komanda = new SqlCommand("UPDATE proizvod SET naziv = N'" + pomoc, veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgProizvodi_Populate();
                dgProizvodi.CurrentCell = dgProizvodi[current_cellC, current_id];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("DELETE FROM proizvod WHERE proizvod_id = " + dgProizvodi.Rows[current_id].Cells["proizvod_id"].Value, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgProizvodi_Populate();
                if (CheckDataGrid())
                {
                    if (current_id > 0) dgProizvodi.CurrentCell = dgProizvodi[current_cellC, --current_id];
                    else dgProizvodi.CurrentCell = dgProizvodi[current_cellC, current_id];
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
