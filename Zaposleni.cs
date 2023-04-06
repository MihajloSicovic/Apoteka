using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka
{
    internal class Zaposleni
    {
        public int zaposleni_id;
        public string ime;
        public string prezime;
        public string jmbg;
        public string adresa;
        public string broj_racuna;
        public string email;
        public string sifra;
        public int uloga;
        public int id_lokala;
        public int id_menadzera;

        public Zaposleni(DataRow dataRow)
        {
            zaposleni_id = (int)dataRow["zaposleni_id"];
            ime = dataRow["ime"].ToString();
            prezime = dataRow["prezime"].ToString();
            jmbg = dataRow["jmbg"].ToString();
            adresa = dataRow["adresa"].ToString();
            broj_racuna = dataRow["broj_racuna"].ToString();
            email = dataRow["email"].ToString();
            sifra = dataRow["sifra"].ToString();
            uloga = (int)dataRow["uloga"];
            id_lokala = dataRow["id_lokala"].ToString() == "" ? 0 : (int)dataRow["id_lokala"];
            id_menadzera = dataRow["id_menadzera"].ToString() == "" ? 0 : (int)dataRow["id_menadzera"];
        }
    }
}
