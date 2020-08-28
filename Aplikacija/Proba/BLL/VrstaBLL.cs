using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proba.DAL;

namespace Proba.BLL
{
    public class VrstaBLL
    {
        public int ID_Vrste_proizvoda { get; set; }
        public string Naziv_vrste_proizvoda { get; set; }

        DBBroker bk = new DBBroker();

        public string sqlUpit = null;

        public void unosVrsteProizvoda(VrstaBLL vrstaproizvoda)
        {
            sqlUpit = null;
            sqlUpit = "INSERT INTO Vrsta_proizvoda (Naziv_vrste_proizvoda) Values ('" + vrstaproizvoda.Naziv_vrste_proizvoda + "')";
            bk.UnesiObrisi(sqlUpit);
        }

        public DataTable dajVrstuProizvoda()
        {
            DataTable dt = new DataTable();
            sqlUpit = null;
            sqlUpit = "SELECT ID_Vrste_proizvoda, Naziv_vrste_proizvoda AS vrsta FROM vrsta_proizvoda";
            dt = bk.Uzmi(sqlUpit);
            return dt;

        }

        public void brisiVrstuProizvoda(VrstaBLL vrstaproizvoda)
        {
            sqlUpit = null;
            sqlUpit = "delete from vrsta_proizvoda where ID_vrste_proizvoda=" + vrstaproizvoda.ID_Vrste_proizvoda;
            bk.UnesiObrisi(sqlUpit);
        }

        public void izmeniVrstuProizvoda(VrstaBLL vrstaproizvoda)
        {
            sqlUpit = null;
            sqlUpit = "UPDATE vrsta_proizvoda SET Naziv_vrste_proizvoda = '" + vrstaproizvoda.Naziv_vrste_proizvoda + "' WHERE id_vrste_proizvoda = " + vrstaproizvoda.ID_Vrste_proizvoda;
            bk.Promeni(sqlUpit);
        }

    }
}
