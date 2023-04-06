using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka
{
    internal class Kupac
    {
        public int kupac_id;
        public string ime;
        public string prezime;
        public DateTime datum_rodjenja;
        public string email;
        public string sifra;
        public string kontakt;

        public Kupac(DataRow dataRow) 
        {
            kupac_id = (int)dataRow["kupac_id"];
            ime = dataRow["ime"].ToString();
            prezime = dataRow["prezime"].ToString();
            datum_rodjenja = (DateTime)dataRow["datum_rodjenja"];
            email = dataRow["email"].ToString();
            sifra = dataRow["sifra"].ToString();
            kontakt = dataRow["kontakt"].ToString();
        }
    }
}
