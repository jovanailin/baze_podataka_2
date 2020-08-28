using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proba.DAL;

namespace Proba.BLL
{
    public class ProizvodBLL
    {
        public int ID_Proizvoda { get; set; }
        public int ID_Vrste_proizvoda {get;set;}
        public string Naziv_proizvoda { get; set; }
        public string Sifra_proizvoda { get; set; }
        public string Podsifra_proizvoda { get; set; }
        public int masa { get; set; }
        public int ID_jedinice_mere { get; set; }


        DBBroker bk = new DBBroker();
        public string sqlUpit = null;

        public void unosProizvoda(ProizvodBLL proizvod)
        {
            sqlUpit = null;
            sqlUpit = "INSERT INTO Proizvod(id_vrste_proizvoda,Naziv_proizvoda, sifra_proizvoda, podsifra_proizvoda, masa,id_jedinice_mere)  Values ('"
                      + proizvod.ID_Vrste_proizvoda + "','" + proizvod.Naziv_proizvoda + "','" + proizvod.Sifra_proizvoda + "','" + proizvod.Podsifra_proizvoda + "','" + proizvod.masa + "','" + proizvod.ID_jedinice_mere + "')";
            bk.UnesiObrisi(sqlUpit);
        }

        public DataTable dajProizvod()
        {
            DataTable dt = new DataTable();

            sqlUpit = null;
            sqlUpit = "select * from view_proizvod";
            dt = bk.Uzmi(sqlUpit);
           dt.Columns.Add("proizvod", typeof(string), "proizvod_podaci");
            return dt;

        }

        public void brisiProizvod(ProizvodBLL proizvod)
        {
            sqlUpit = null;
            sqlUpit = "delete from proizvod where ID_proizvoda=" + proizvod.ID_Proizvoda;
            bk.UnesiObrisi(sqlUpit);
        }

        public void izmeniProizvod(ProizvodBLL proizvod)
        {
            sqlUpit = null;
            sqlUpit = "UPDATE Artikal SET naziv_proizvoda = '"
                + proizvod.Naziv_proizvoda + "', id_vrste_proizvoda= '"
                + proizvod.ID_Vrste_proizvoda + "', sifra_proizvoda= '"
                + proizvod.Sifra_proizvoda + "', podsifra_proizvoda= '"
                + proizvod.Podsifra_proizvoda + "', masa= '"
                + proizvod.masa + "', id_jedinice_mere= '"
                + proizvod.ID_jedinice_mere +
                "' WHERE ID_proizvoda = " + proizvod.ID_Proizvoda;
            bk.Promeni(sqlUpit);
        }


    }
}
