using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Proba.DAL
{
    class Konekcija
    {
        private SqlConnection cn;

        public Konekcija()
        {
            string CnString = null;
           // CnString = "Data Source=DESKTOP-3R1UK85\\SQL_SERVER_2008;Initial Catalog=Poljoprivredno_gazdinstvo;Integrated Security=True";
         CnString = "Data Source=DESKTOP-SO9J5M9\\SQLEXPRESS;Initial Catalog=poljoprivredno_gazdinstvo;Integrated Security=True";
            try
            {
                cn = new SqlConnection(CnString);
            }
            catch (SqlException e)
            {
                Console.WriteLine("GRESKA, neuspela konekcija!" + e);
            }
        }

        public SqlConnection Povezivanje()
        {
            if (cn.State == ConnectionState.Closed || cn.State == ConnectionState.Broken)
            {
                cn.Open();
            }
            return cn;
        }

        public void Prekid()
        {
            cn.Close();
        }
    }

}
