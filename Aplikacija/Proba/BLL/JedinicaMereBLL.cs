using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proba.DAL;

namespace Proba.BLL
{
    public class JedinicaMereBLL
    {
        public int ID_Jedinice_mere { get; set; }
        public string Naziv_jedinice_mere { get; set; }

        DBBroker bk = new DBBroker();

        public string sqlUpit = null;

        public void unosJM(JedinicaMereBLL JM)
        {
            sqlUpit = null;
            sqlUpit = "INSERT INTO Jedinica_Mere (Naziv_jedinice_mere) Values ('" + JM.Naziv_jedinice_mere + "')";
            bk.UnesiObrisi(sqlUpit);
        }

        public DataTable dajJM()
        {
            DataTable dt = new DataTable();
            sqlUpit = null;
            sqlUpit = "select * from Jedinica_Mere";
            dt = bk.Uzmi(sqlUpit);
            return dt;

        }

        public void brisiJM(JedinicaMereBLL JM)
        {
            sqlUpit = null;
            sqlUpit = "delete from Jedinica_Mere where id_jedinice_mere=" + JM.ID_Jedinice_mere;
            bk.UnesiObrisi(sqlUpit);
        }

        public void izmeniJM(JedinicaMereBLL JM)
        {
            sqlUpit = null;
            sqlUpit = "UPDATE Jedinica_Mere SET Naziv_jedinice_mere = '" + JM.Naziv_jedinice_mere + "' WHERE id_jedinice_mere = " + JM.ID_Jedinice_mere;
            bk.Promeni(sqlUpit);
        }

    }
}
