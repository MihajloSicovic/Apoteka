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
    public partial class Transakcije : Form
    {
        public Transakcije()
        {
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

        private void dgTransakcije_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM pregled_transakcija", Baza.Konektuj());
            DataTable transakcije = new DataTable();
            da.Fill(transakcije);
            dgTransakcije.DataSource = transakcije;
            dgTransakcije.Columns["trans_id"].Visible = false;
            dgTransakcije.Columns["id_kartice"].Visible = false;
            dgTransakcije.Columns["id_kupca"].Visible = false;
        }

        private bool CheckDataGrid()
        {
            if (dgTransakcije.RowCount == 0)
            {
                DataTable nemaRezultata = new DataTable();
                nemaRezultata.Columns.Add(" ");
                nemaRezultata.Rows.Add("Nema rezultata.");
                dgTransakcije.ColumnHeadersVisible = false;
                dgTransakcije.DataSource = nemaRezultata;
                btBrisi.Enabled = false;
                btIzmeni.Enabled = false;
                return false;
            }
            else
            {
                dgTransakcije.ColumnHeadersVisible = true;
                btBrisi.Enabled = true;
                btIzmeni.Enabled = true;
                SelectedRowChanged(0);
                return true;
            }
        }

        private void SelectedRowChanged(int n)
        {
            nudKorisceniPoeni.Value = (int)dgTransakcije.Rows[n].Cells["korisceni_poeni"].Value;
            cbKartica.SelectedValue = (int)dgTransakcije.Rows[n].Cells["id_kartice"].Value;
            cbKupac.SelectedValue = (int)dgTransakcije.Rows[n].Cells["id_kupca"].Value;
        }   

        private void Transakcije_Load(object sender, EventArgs e)
        {
            cbKartica_Populate();
            cbKupac_Populate();
            dgTransakcije_Populate();
            CheckDataGrid();
        }

        int current_id = 0;
        int current_cellC = 1;
        private void dgTransakcije_CurrentCellChanged(object sender, EventArgs e)
        {
            if (!dgTransakcije.Focused || dgTransakcije.CurrentRow == null) return;
            current_id = dgTransakcije.CurrentRow.Index;
            current_cellC = dgTransakcije.CurrentCell.ColumnIndex;
            SelectedRowChanged(current_id);
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            string pomoc = nudKorisceniPoeni.Value + ", datum_obrade = '" + DateTime.Today.ToString("yyyy-MM-dd")
                + "', id_kupca = " + ((int)cbKupac.SelectedValue == 0 ? "null" : cbKupac.SelectedValue)
                + ", id_kartice = " + ((int)cbKartica.SelectedValue == 0 ? "null" : cbKartica.SelectedValue)
                + " WHERE trans_id = " + dgTransakcije.Rows[current_id].Cells["trans_id"].Value;
            SqlCommand komanda = new SqlCommand("UPDATE transakcija SET korisceni_poeni = " + pomoc, veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgTransakcije_Populate();
                dgTransakcije.CurrentCell = dgTransakcije[current_cellC, current_id];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("DELETE FROM transakcija WHERE trans_id = " + dgTransakcije.Rows[current_id].Cells["trans_id"].Value, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgTransakcije_Populate();
                if (CheckDataGrid())
                {
                    if (current_id > 0) dgTransakcije.CurrentCell = dgTransakcije[current_cellC, --current_id];
                    else dgTransakcije.CurrentCell = dgTransakcije[current_cellC, current_id];
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
