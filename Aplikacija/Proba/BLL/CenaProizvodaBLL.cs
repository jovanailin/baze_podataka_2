using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proba.DAL;

namespace Proba.BLL
{
    public class CenaProizvodaBLL
    {
        public int ID_Cene_proizvoda { get; set; }
        public int ID_Proizvoda { get; set; }
        public int Iznos { get; set; }
        public DateTime Datum_pocetka_vazenja { get; set; }



        DBBroker bk = new DBBroker();
        public string sqlUpit = null;

        public void unosCeneProizvoda(CenaProizvodaBLL cenaproizvoda)
        {
            sqlUpit = null;
            sqlUpit = "INSERT INTO cena_proizvoda (ID_Proizvoda, iznos, Datum_pocetka_vazenja)  Values ('"
                      + cenaproizvoda.ID_Proizvoda + "','" + cenaproizvoda.Iznos + "','" + cenaproizvoda.Datum_pocetka_vazenja + "')";
            bk.UnesiObrisi(sqlUpit);
        }

       

    }
}
