using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Proba.DAL;

namespace Proba.BLL
{
    public class StavkaRacunaBLL
    {
        public int ID_Racuna { get; set; }
        public int Redni_Broj { get; set; }
        public int ID_Proizvoda { get; set; }
        public int ID_Jedinice_mere { get; set; }
        public int Kolicina { get; set; }

        DBBroker bk = new DBBroker();
        public string sqlUpit = null;



        public void unosStavkeRacuna(StavkaRacunaBLL stavkaRacuna)
        {
            sqlUpit = null;
            sqlUpit = "INSERT INTO Stavka_Racuna(ID_Racuna,Redni_Broj, ID_proizvoda,id_jedinice_mere, Kolicina)  Values ('"
                      + stavkaRacuna.ID_Racuna + "','" + stavkaRacuna.Redni_Broj + "','" + stavkaRacuna.ID_Proizvoda + "','" + stavkaRacuna.ID_Jedinice_mere + "','" + stavkaRacuna.Kolicina + "')";
            bk.UnesiObrisi(sqlUpit);
        }

        public void izmeniStavkuRacuna(StavkaRacunaBLL stavkaRacuna)
        {
            sqlUpit = null;
            sqlUpit = "UPDATE    Stavka_Racuna SET Kolicina= '" + stavkaRacuna.Kolicina + "', id_proizvoda='" +stavkaRacuna.ID_Proizvoda
+ "' WHERE     (ID_Racuna = '" + stavkaRacuna.ID_Racuna + "' and Redni_Broj= '" + stavkaRacuna.Redni_Broj + "')";
            bk.Promeni(sqlUpit);
        }

        public void izbrisiStavkuRacuna(StavkaRacunaBLL stavkaRacuna)
        {
            sqlUpit = null;
            sqlUpit = "delete from Stavka_Racuna WHERE (ID_Racuna = '" + stavkaRacuna.ID_Racuna + "' and Redni_Broj= '" + stavkaRacuna.Redni_Broj + "')";
            bk.Promeni(sqlUpit);
        }

        public DataTable dajStavkuRacuna(int a)
        {
            DataTable dt = new DataTable();

            sqlUpit = null;
            sqlUpit = "SELECT Stavka_racuna.Redni_broj, Proizvod.Naziv_proizvoda,Jedinica_mere.Naziv_jedinice_mere,Stavka_racuna.Kolicina,Proizvod.Aktuelna_cena FROM Stavka_racuna INNER JOIN Proizvod ON Stavka_racuna.ID_Proizvoda = Proizvod.ID_Proizvoda  INNER JOIN Jedinica_mere  ON  Jedinica_mere.ID_Jedinice_mere=stavka_racuna.id_jedinice_mere  WHERE (Stavka_racuna.ID_Racuna = '" + a + "')";
            dt = bk.Uzmi(sqlUpit);
            return dt;

        }


    }
}
