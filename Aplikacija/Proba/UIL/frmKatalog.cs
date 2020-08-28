using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proba.BLL;
using Proba.UIL;

namespace Proba.UIL
{
    public partial class frmKatalog: Form
    {
        public PopunaCmBox combo;
        public KupacBLL kupac;
        public KatalogBLL katalog;
        DataTable table;

        public frmKatalog()
        {
            InitializeComponent();
            kupac = new KupacBLL();
            katalog = new KatalogBLL();
            combo = new PopunaCmBox();
            table = new DataTable();

            combo.popuniCmbKupac(cmbKupac);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool provera = true;


            foreach (var c in this.Controls)
            {
                if (c is TextBox && ((TextBox)c).Text == "")
                {

                    MessageBox.Show("Morate popuniti sva polja");
                    provera = true;
                    break;

                }
                else if (c is ComboBox && ((ComboBox)c).Text == "")
                {

                    MessageBox.Show("Morate popuniti sva polja");
                    provera = true;
                    break;

                }
                else
                {
                    provera = false;
                }

            }
            if (provera == false)
            {

                katalog.Broj_kataloga = tbBrojKataloga.Text;
                katalog.ID_kupca = int.Parse(cmbKupac.SelectedValue.ToString());
                katalog.Datum_izdavanja = DateTime.Parse(dateTimePicker1.Text);
                katalog.rok_vazenja = int.Parse(tbRokVazenja.Text);
                katalog.Napomena = tbNapomena.Text;

                katalog.unosKataloga(katalog);



                cmbKupac.Text = "";
                dateTimePicker1.Text = "";
                tbBrojKataloga.Text = "";
                tbRokVazenja.Text = "";
                tbNapomena.Text = "";

                foreach (var c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;


                    }
                    else if (c is ComboBox)
                        ((ComboBox)c).Text = String.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }






    }
}
