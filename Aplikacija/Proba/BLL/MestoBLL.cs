using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proba.DAL;

namespace Proba.BLL
{
    public class MestoBLL
    {
        public int ID_Mesta { get; set; }
        public string Naziv_mesta{ get; set; }

        DBBroker bk = new DBBroker();

        public string sqlUpit = null;

        public void unosMesta(MestoBLL mesto)
        {
            sqlUpit = null;
            sqlUpit = "INSERT INTO Mesto (Naziv_mesta) Values ('" + mesto.Naziv_mesta + "')";
            bk.UnesiObrisi(sqlUpit);
        }

        public DataTable dajMesto()
        {
            DataTable dt = new DataTable();
            sqlUpit = null;
            sqlUpit = "select ID_Mesta, naziv_mesta as mesto from mesto";
            dt = bk.Uzmi(sqlUpit);
            return dt;

        }

        public void brisiMesto(MestoBLL mesto)
        {
            sqlUpit = null;
            sqlUpit = "delete from Mesto where ID_Mesta=" + mesto.ID_Mesta;
            bk.UnesiObrisi(sqlUpit);
        }

        public void izmeniMesto(MestoBLL mesto)
        {
            sqlUpit = null;
            sqlUpit = "UPDATE Mesto SET Naziv_mesta = '" + mesto.Naziv_mesta + "' WHERE id_mesta = " + mesto.ID_Mesta;
            bk.Promeni(sqlUpit);
        }

    }
}

