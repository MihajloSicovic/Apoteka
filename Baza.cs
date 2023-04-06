using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Apoteka
{
    public class Baza
    {
        public static SqlConnection Konektuj()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["Apoteka"].ConnectionString);
        }

        public static void Kreiraj()
        {
            StreamReader CreationFile = new StreamReader("CreationFile.xml");

            string ImeBaze;
            using (SqlConnection veza = Konektuj()) ImeBaze = veza.Database;

            using (SqlConnection veza = new SqlConnection(ConfigurationManager.ConnectionStrings["master"].ConnectionString))
            {
                SqlCommand komanda = new SqlCommand("CREATE DATABASE " + ImeBaze, veza);
                try
                {
                    veza.Open();
                    komanda.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (veza.State == ConnectionState.Open) veza.Close();
                }
            }

            using (SqlConnection veza = Konektuj())
            {
                bool b = true;
                while (b)
                {
                    try
                    {
                        veza.Open();
                        veza.Close();
                        b = false;
                    }
                    catch { }
                }
            }

            using (SqlConnection veza = Konektuj())
            {
                while (!CreationFile.EndOfStream)
                {
                    string line = CreationFile.ReadLine();
                    if (line == "") continue;
                    if (line == "/*POGLEDI*/") Baza.UcitajPodatke();
                    SqlCommand komanda = new SqlCommand(line.ToString(), veza);
                    try
                    {
                        veza.Open();
                        komanda.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (veza.State == ConnectionState.Open) veza.Close();
                    }
                }
            }
        }

        public static void Obrisi()
        {
            SqlConnection veza = new SqlConnection(ConfigurationManager.ConnectionStrings["master"].ConnectionString);
            SqlCommand komanda = new SqlCommand("DROP DATABASE " + Konektuj().Database, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (veza.State == ConnectionState.Open) veza.Close();
            }
        }

        public static void Resetuj()
        {
            Obrisi();
            Kreiraj();
        }

        public static bool Postoji()
        {
            SqlConnection veza = Konektuj();
            SqlCommand komanda = new SqlCommand("USE " + veza.Database, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                if (veza.State == ConnectionState.Open) veza.Close();
                return true;
            }
            catch
            {
                if (veza.State == ConnectionState.Open) veza.Close();
                return false;
            }
        }

        public static void SacuvajPodatke()
        {
            string[] tabele = { "proizvod", "lokal", "zaposleni", "dostava", "magacin", "kupac", "kartica", "transakcija", "racun" };
            foreach (string ime in tabele)
            {
                try
                {
                    DataTable tabela = new DataTable(ime);
                    SqlConnection veza = Konektuj();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + ime, veza);
                    da.Fill(tabela);
                    tabela.WriteXml(ime + ".xml", XmlWriteMode.WriteSchema);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void UcitajPodatke()
        {
            string[] tabele = { "proizvod", "lokal", "zaposleni", "dostava", "magacin", "kupac", "kartica", "transakcija", "racun" };
            foreach (string ime in tabele)
            {
                try
                {
                    DataTable tabela = new DataTable(ime);
                    SqlConnection veza = Konektuj();
                    tabela.ReadXml(ime + ".xml");

                    foreach (DataRow slog in tabela.Rows)
                    {
                        string str = "SET IDENTITY_INSERT " + ime + " ON INSERT INTO " + ime + "(";
                        foreach (DataColumn dc in tabela.Columns) str += dc.ColumnName + ", ";
                        str = str.Remove(str.Length - 2) + ") VALUES (";
                        foreach (object kolona in slog.ItemArray)
                        {
                            if (kolona.GetType() == typeof(DateTime)) str += "N'" + Convert.ToDateTime(kolona).ToString("yyyy-MM-dd") + "', ";
                            else if (kolona.GetType() == typeof(Double)) str += kolona.ToString().Replace(',', '.') + ", ";
                            else str += (kolona.ToString() == "" ? "null" : "N'" + kolona.ToString() + "'") + ", ";
                        }
                        str = str.Remove(str.Length - 2) + ")";
                        SqlCommand komanda = new SqlCommand(str, veza);
                        veza.Open();
                        komanda.ExecuteNonQuery();
                        if (veza.State == ConnectionState.Open) veza.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    SqlConnection veza = Konektuj();
                    SqlCommand command = new SqlCommand("SET IDENTITY_INSERT " + ime + " OFF", veza);
                    veza.Open();
                    command.ExecuteNonQuery();
                    veza.Close();
                }
            }
        }
    }
}
