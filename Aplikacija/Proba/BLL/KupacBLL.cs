using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proba.DAL;

namespace Proba.BLL
{
    public class KupacBLL
    {
        public int ID_Kupca { get; set; }
        public string Naziv_kupca{ get; set; }
        public string PIB { get; set; }
        public int ID_Adrese { get; set; }
      
      

        DBBroker bk = new DBBroker();
        public string sqlUpit = null;

        public void unosKupca(KupacBLL kupac)
        {
            sqlUpit = null;
            sqlUpit = "INSERT INTO kupac (Naziv_kupca, PIB,id_Adrese) VALUES ( '"
            +kupac.Naziv_kupca+"', CONVERT(pib_kupca_struktuirani_tip, '"+kupac.PIB+ "'),'"+kupac.ID_Adrese+"')";
            bk.UnesiObrisi(sqlUpit);
        }


        public DataTable dajKupca()
        {
            DataTable dt = new DataTable();

            sqlUpit = null;
            sqlUpit = "select id_kupca,Naziv_kupca, id_adrese from kupac";
            dt = bk.Uzmi(sqlUpit);
            dt.Columns.Add("kupac", typeof(string), "Naziv_kupca");
            return dt;

        }

        public void brisiKlijenta(KupacBLL kupac)
        {
            sqlUpit = null;
            sqlUpit = "delete from Kupac where id_upca=" + kupac.ID_Kupca;
            bk.UnesiObrisi(sqlUpit);
        }
    }
}
