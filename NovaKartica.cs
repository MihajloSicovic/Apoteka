using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apoteka
{
    public partial class NovaKartica : Form
    {
        public NovaKartica()
        {
            InitializeComponent();
        }

        private void NovaKartica_Load(object sender, EventArgs e)
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

            SqlDataAdapter da = new SqlDataAdapter("SELECT kupac_id, ime + ' ' + prezime AS naziv FROM kupci_bez_kartice", Baza.Konektuj());
            DataTable kupci_bez_kartice = new DataTable();
            da.Fill(kupci_bez_kartice);
            cbKupac.DataSource = kupci_bez_kartice;
            cbKupac.ValueMember = "kupac_id";
            cbKupac.DisplayMember = "naziv";
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Baza.Konektuj();
            string naredba = "INSERT INTO kartica VALUES('" + tbBrojKartice.Text + "', '"
                            + nudPoeni.Value + "', " + cbTipKartice.SelectedValue + ", " + cbKupac.SelectedValue + ")"; 
            SqlCommand komanda = new SqlCommand(naredba, veza);
            
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
