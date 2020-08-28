using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proba.DAL;

namespace Proba.BLL
{
    public class KatalogBLL
    {
        public string Broj_kataloga { get; set; }
        public DateTime Datum_izdavanja { get; set; }
        public int rok_vazenja { get; set; }

        public int ID_kupca { get; set; }

        public string Napomena { get; set; }



        DBBroker bk = new DBBroker();
        public string sqlUpit = null;

        public void unosKataloga(KatalogBLL katalog)
        {
            sqlUpit = null;
            sqlUpit = "INSERT INTO  katalog (Broj_kataloga, datum_izdavanja, rok_vazenja, napomena,id_kupca) Values ('"
                           + katalog.Broj_kataloga + "','" + katalog.Datum_izdavanja + "','" + katalog.rok_vazenja +"','" + katalog.Napomena + "','"+ katalog.ID_kupca + "')";
            bk.UnesiObrisi(sqlUpit);
        }


      

    }
}
