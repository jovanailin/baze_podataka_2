using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proba.DAL
{
    class DBBroker
    {
        public Konekcija cn;
        public SqlDataAdapter sqlAdapter;


        public DBBroker()
        {
            sqlAdapter = new SqlDataAdapter();
            cn = new Konekcija();

        }

        //INSERT i DELETE metoda
        public bool UnesiObrisi(string sqlUpit)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = cn.Povezivanje();
                myCommand.CommandText = sqlUpit;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("GRESKA!" + e);
                if (e.Number == 2627 || e.Number == 2601)
                    MessageBox.Show("Ta kombinacija vec postoji");
                else
                    //MessageBox.Show(e.Number.ToString());
                    MessageBox.Show(e.Message);
                return false;
            }
            cn.Prekid();
            return true;
        }

        //SELECT metoda
        public DataTable Uzmi(String sqlUpit)
        {
            DataTable dt;
            dt = new DataTable();
            SqlCommand sc = new SqlCommand();
            try
            {
                sc.CommandText = sqlUpit;
                sc.Connection = cn.Povezivanje();
                SqlDataReader reader;
                reader = sc.ExecuteReader();

                dt.Load(reader);
                cn.Prekid();
            }
            catch (SqlException e)
            {
                Console.WriteLine("GRESKA!!!" + e);
                return null;
            }
            return dt;
        }

        //UPDATE metoda
        public bool Promeni(String sqlUpit)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = cn.Povezivanje();
                myCommand.CommandText = sqlUpit;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("GRESKA!!" + e);
                MessageBox.Show(e.ToString());
                cn.Prekid();
                return false;
            }
            cn.Prekid();
            return true;
        }
    }
}


