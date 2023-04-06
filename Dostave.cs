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
    public partial class Dostave : Form
    {
        int id_lokala;
        public Dostave(int id_lokala)
        {
            this.id_lokala = id_lokala;
            InitializeComponent();
        }

        private void dgDostave_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dostava_lokala(" + id_lokala + ")", Baza.Konektuj());
            DataTable dostave = new DataTable();
            da.Fill(dostave);
            dgDostave.DataSource = dostave;
            dgDostave.Columns["dostava_id"].Visible = false;
        }

        private void Dostave_Load(object sender, EventArgs e)
        {
            dgDostave_Populate();
            CheckDataGrid();
        }

        private bool CheckDataGrid()
        {
            if (dgDostave.RowCount == 0)
            {
                DataTable nemaRezultata = new DataTable();
                nemaRezultata.Columns.Add(" ");
                nemaRezultata.Rows.Add("Nema rezultata.");
                dgDostave.ColumnHeadersVisible = false;
                dgDostave.DataSource = nemaRezultata;
                btBrisi.Enabled = false;
                btOdlozi.Enabled = false;
                return false;
            }
            else
            {
                dgDostave.ColumnHeadersVisible = true;
                btBrisi.Enabled = true;
                btOdlozi.Enabled = true;
                SelectedRowChanged(0);
                return true;
            }
        }

        private void SelectedRowChanged(int n)
        {
            dtpDatumIsporuke.Value = dtpDatumIsporuke.MinDate = (DateTime)dgDostave.Rows[n].Cells["datum"].Value;
            if ((bool)dgDostave.Rows[n].Cells["primljeno"].Value) btBrisi.Enabled = btOdlozi.Enabled = false;
            else btBrisi.Enabled = btOdlozi.Enabled = true;
        }

        int current_id = 0;
        int current_cellC = 1;
        private void dgDostave_CurrentCellChanged(object sender, EventArgs e)
        {
            if (!dgDostave.Focused || dgDostave.CurrentRow == null) return;
            current_id = dgDostave.CurrentRow.Index;
            current_cellC = dgDostave.CurrentCell.ColumnIndex;
            SelectedRowChanged(current_id);
        }

        private void btOdlozi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            string pomoc = dtpDatumIsporuke.Value.ToString("yyyy-MM-dd")
                + "' WHERE dostava_id = " + dgDostave.Rows[current_id].Cells["dostava_id"].Value;
            SqlCommand komanda = new SqlCommand("UPDATE dostava SET datum = '" + pomoc, veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgDostave_Populate();
                dgDostave.CurrentCell = dgDostave[current_cellC, current_id];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("DELETE FROM dostava WHERE dostava_id = " + dgDostave.Rows[current_id].Cells["dostava_id"].Value, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgDostave_Populate();
                if (CheckDataGrid())
                {
                    if (current_id > 0) dgDostave.CurrentCell = dgDostave[current_cellC, --current_id];
                    else dgDostave.CurrentCell = dgDostave[current_cellC, current_id];
                    SelectedRowChanged(current_id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btPrimi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            SqlCommand komanda = new SqlCommand("EXEC primi_dostave " + id_lokala, veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                dgDostave_Populate();
                CheckDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
