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

namespace Proba.UIL
{
    public partial class frmUnosStavkiRacuna : Form
    {
        public PopunaCmBox combo;
        public KupacBLL klijent;
        public RacunBLL racun;
        public ProizvodBLL artikal;
        public JedinicaMereBLL jm;
        public StavkaRacunaBLL stavkaRacuna;
        DataTable table;

        public frmUnosStavkiRacuna()
        {
            InitializeComponent();
            combo = new PopunaCmBox();
            klijent = new KupacBLL();
            artikal = new ProizvodBLL();
            jm = new JedinicaMereBLL();
            racun = new RacunBLL();
            stavkaRacuna = new StavkaRacunaBLL();
            table = new DataTable();

            combo.popuniCmbRacun(cmbRacun);
            table = (DataTable)cmbRacun.DataSource;
            combo.popuniCmbKupac(cmbKupac);
            combo.popuniCmbProizvod(cmbProizvod);
            combo.popuniCmbJM(cmbJM);
        }







      

       

        private void button1_Click_1(object sender, EventArgs e)
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
                stavkaRacuna.ID_Racuna = int.Parse(cmbRacun.SelectedValue.ToString());
                stavkaRacuna.Redni_Broj = int.Parse(tbRedniBroj.Text);
                stavkaRacuna.ID_Proizvoda = int.Parse(cmbProizvod.SelectedValue.ToString());
                stavkaRacuna.ID_Jedinice_mere = int.Parse(cmbJM.SelectedValue.ToString());
                stavkaRacuna.Kolicina = int.Parse(tbKolicina.Text);
                stavkaRacuna.unosStavkeRacuna(stavkaRacuna);

                MessageBox.Show("Uspesno ste uneli:\n " + "Redni broj:" + tbRedniBroj.Text + "\n Artikal:" + cmbProizvod.Text + "\n Kolicina:" + tbKolicina.Text + "\n Jedinica mere:" + cmbJM.Text + "\n u evidenciju.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbRedniBroj.Text = "";
                cmbProizvod.Text = "";
                cmbJM.Text = "";
                tbKolicina.Text = "";

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

        private void frmUnosStavkiRacuna_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void cmbRacun_SelectedValueChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = true;

            if (table.Rows.Count > 0 && cmbRacun.SelectedIndex != -1)
            {
                tbBrojRacuna.Text = table.Rows[cmbRacun.SelectedIndex]["Broj_racuna"].ToString();
                tbDatumRacuna.Text = table.Rows[cmbRacun.SelectedIndex]["Datum_izdavanja_racuna"].ToString();
                cmbKupac.SelectedValue = int.Parse(table.Rows[cmbRacun.SelectedIndex]["ID_Kupca"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




