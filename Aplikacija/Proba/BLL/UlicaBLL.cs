using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proba.DAL;

namespace Proba.BLL
{
    public class UlicaBLL
    {
        public int ID_Ulice { get; set; }
        public string Naziv_Ulice { get; set; }
        public int ID_Mesta { get; set; }


        DBBroker bk = new DBBroker();
        public string sqlUpit = null;

        public void unosUlice(UlicaBLL ulica)
        {
            sqlUpit = null;
            sqlUpit = "INSERT INTO Ulica (Naziv_ulice,ID_Mesta)  Values ('"
                      + ulica.Naziv_Ulice + "','"  + ulica.ID_Mesta + "')";
            bk.UnesiObrisi(sqlUpit);
        }

        public DataTable dajUlicu()
        {
            DataTable dt = new DataTable();

            sqlUpit = null;
            sqlUpit = "select * from ulica";
            dt = bk.Uzmi(sqlUpit);
            dt.Columns.Add("ulica", typeof(string), "Naziv_ulice+ '  ' +Naziv_mesta ");
            return dt;

        }

        public void brisiUlicu(UlicaBLL ulica)
        {
            sqlUpit = null;
            sqlUpit = "delete from Ulica where ID_Ulice=" + ulica.ID_Ulice;
            bk.UnesiObrisi(sqlUpit);
        }

        public void izmeniUlicu(UlicaBLL ulica)
        {
            sqlUpit = null;
            sqlUpit = "UPDATE Ulica SET Naziv_Ulice = '"
                + ulica.Naziv_Ulice + 
                "' WHERE ID_Ulice = " + ulica.ID_Ulice;
            bk.Promeni(sqlUpit);
        }
    }
}
