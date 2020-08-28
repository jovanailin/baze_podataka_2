using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proba.DAL;
using System.Data;

namespace Proba.BLL
{
    public class RacunBLL
    {
        public int ID_Racuna { get; set; }
        public string Broj_racuna { get; set; }
        public int ID_Kupca { get; set; }
        public DateTime Datum_izdavanja_racuna { get; set; }



        DBBroker bk = new DBBroker();
        public string sqlUpit = null;


        public void unosRacuna(RacunBLL racun)
        {
            sqlUpit = null;
            sqlUpit = "INSERT INTO  Racun (Broj_racuna, ID_Kupca,Datum_izdavanja_racuna) Values ('"
                           + racun.Broj_racuna + "','" + racun.ID_Kupca + "','" + racun.Datum_izdavanja_racuna + "')";
            bk.UnesiObrisi(sqlUpit);


        }

        public DataTable dajRacun()
        {
            DataTable dt = new DataTable();
            sqlUpit = null;
            sqlUpit = "select * from racun order by id_racuna desc";
            dt = bk.Uzmi(sqlUpit);
            dt.Columns.Add("racun", typeof(string), "broj_racuna");
            return dt;

        }

        public void brisiRacun(RacunBLL racun)
        {
            sqlUpit = null;
            sqlUpit = "delete from racun where id_racuna=" + racun.ID_Racuna;
            bk.UnesiObrisi(sqlUpit);
        }

       
    }
}
