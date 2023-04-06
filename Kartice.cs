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
    public partial class Kartice : Form
    {
        public Kartice()
        {
            InitializeComponent();
        }

        private void cbTipKartice_Populate()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("tip_kartice");
            dt.Columns.Add("ime_tipa");
            dt.Rows.Add(0, "Obična");
            dt.Rows.Add(1, "Bebi");
            dt.Rows.Add(2, "Penzioner");
            dt.Rows.Add(3, "VIP");

            cbTipKartice.DataSource = dt;
            cbTipKartice.ValueMember = "tip_kartice";
            cbTipKartice.DisplayMember = "ime_tipa";
        }

        private void cbKupac_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT kupac_id, ime + ' ' + prezime AS naziv FROM kupac", Baza.Konektuj());
            DataTable kupac = new DataTable();
            da.Fill(kupac);

            cbKupac.DataSource = kupac;
            cbKupac.ValueMember = "kupac_id";
            cbKupac.DisplayMember = "naziv";
        }

        private void dgKartice_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM pregled_kartica", Baza.Konektuj());
            DataTable kartice = new DataTable();
            da.Fill(kartice);
            dgKartice.DataSource = kartice;
            dgKartice.Columns["kartica_id"].Visible = false;
            dgKartice.Columns["tip_kartice"].Visible = false;
            dgKartice.Columns["kupac_id"].Visible = false;
        }

        private void Kartice_Load(object sender, EventArgs e)
        {
            cbKupac_Populate();
            cbTipKartice_Populate();
            dgKartice_Populate();
            CheckDataGrid();
        }

        private bool CheckDataGrid()
        {
            if (dgKartice.RowCount == 0)
            {
                DataTable nemaRezultata = new DataTable();
                nemaRezultata.Columns.Add(" ");
                nemaRezultata.Rows.Add("Nema rezultata.");
                tbBrojKartice.Clear();
                nudPoeni.ResetText();
                dgKartice.ColumnHeadersVisible = false;
                dgKartice.DataSource = nemaRezultata;
                btBrisi.Enabled = false;
                btIzmeni.Enabled = false;
                return false;
            }
            else
            {
                dgKartice.ColumnHeadersVisible = true;
                btBrisi.Enabled = true;
                btIzmeni.Enabled = true;
                SelectedRowChanged(0);
                return true;
            }
        }

        private void SelectedRowChanged(int n)
        {
            tbBrojKartice.Text = dgKartice.Rows[n].Cells["broj_kartice"].Value.ToString();
            nudPoeni.Value = Convert.ToInt32(dgKartice.Rows[n].Cells["poeni"].Value);
            cbTipKartice.SelectedValue = Convert.ToInt32(dgKartice.Rows[n].Cells["tip_kartice"].Value);
            cbKupac.SelectedValue = Convert.ToInt32(dgKartice.Rows[n].Cells["kupac_id"].Value);
        }

        int current_id = 0;
        int current_cellC = 1;
        private void dgKartice_CurrentCellChanged(object sender, EventArgs e)
        {
            if (!dgKartice.Focused || dgKartice.CurrentRow == null) return;
            current_id = dgKartice.CurrentRow.Index;
            current_cellC = dgKartice.CurrentCell.ColumnIndex;
            SelectedRowChanged(current_id);
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            string pomoc = tbBrojKartice.Text + "', poeni = " + nudPoeni.Value + 
                ", tip_kartice = " + cbTipKartice.SelectedValue
                + " WHERE kartica_id = " + dgKartice.Rows[current_id].Cells["kartica_id"].Value;
            SqlCommand komanda = new SqlCommand("UPDATE kartica SET broj_kartice = '" + pomoc, veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgKartice_Populate();
                dgKartice.CurrentCell = dgKartice[current_cellC, current_id];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("DELETE FROM kartica WHERE kartica_id = " + dgKartice.Rows[current_id].Cells["kartica_id"].Value, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgKartice_Populate();
                if (CheckDataGrid())
                {
                    if (current_id > 0) dgKartice.CurrentCell = dgKartice[current_cellC, --current_id];
                    else dgKartice.CurrentCell = dgKartice[current_cellC, current_id];
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
