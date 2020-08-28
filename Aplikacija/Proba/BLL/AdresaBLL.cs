using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proba.DAL;

namespace Proba.BLL
{
    public class AdresaBLL
    {
        public int ID_Adrese { get; set; }
        public string Broj { get; set; }
        public int ID_Ulice { get; set; }


        DBBroker bk = new DBBroker();
        public string sqlUpit = null;

        public void unosAdrese(AdresaBLL adresa)
        {
            sqlUpit = null;
            sqlUpit = "INSERT INTO Adresa (Broj,ID_Ulice)  Values ('"
                      + adresa.Broj + "','" + adresa.ID_Ulice + "')";
            bk.UnesiObrisi(sqlUpit);
        }

        public DataTable dajAdresu()
        {
            DataTable dt = new DataTable();

            sqlUpit = null;
            sqlUpit = "select * from View_adresa";
            dt = bk.Uzmi(sqlUpit);
            dt.Columns.Add("Adresa", typeof(string), "adresa");
            return dt;

        }

        public void brisiAdresu(AdresaBLL adresa)
        {
            sqlUpit = null;
            sqlUpit = "delete from Adresa where ID_Adrese=" + adresa.ID_Adrese;
            bk.UnesiObrisi(sqlUpit);
        }

        public void izmeniAdresu(AdresaBLL adresa)
        {
            sqlUpit = null;
            sqlUpit = "UPDATE Adresa SET Broj = '"
                + adresa.Broj + "', ID_Ulice= '"
                + adresa.ID_Ulice +
                "' WHERE ID_Adrese = " + adresa.ID_Adrese;
            bk.Promeni(sqlUpit);
        }
    }
}
