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
    public partial class frmUnosRacuna : Form
    {
        public PopunaCmBox combo;
        public KupacBLL kupac;
        public RacunBLL racun;
        DataTable table;

        public frmUnosRacuna()
        {
            InitializeComponent();
            kupac = new KupacBLL();
            racun = new RacunBLL();
            combo = new PopunaCmBox();
            table = new DataTable();

            combo.popuniCmbKupac(cmbKupac);
        }





      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

                racun.Broj_racuna = tbBrojRacuna.Text;
                racun.ID_Kupca = int.Parse(cmbKupac.SelectedValue.ToString());
                racun.Datum_izdavanja_racuna = DateTime.Parse(dateTimePicker1.Text);
                
                racun.unosRacuna(racun);



                cmbKupac.Text = "";
                dateTimePicker1.Text = "";
                tbBrojRacuna.Text = "";

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmUnosStavkiRacuna frmUSR = new frmUnosStavkiRacuna();
            frmUSR.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPrikazStavkiRacuna frmPSR = new frmPrikazStavkiRacuna();
            frmPSR.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAzuriranjeStavkiRacuna frmASR = new frmAzuriranjeStavkiRacuna();
            frmASR.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmBrisanjeStavkeRacuna frmBSR = new frmBrisanjeStavkeRacuna();
            frmBSR.Show();
        }

       



    }
}
