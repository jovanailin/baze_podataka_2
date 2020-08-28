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
    public partial class frmAzuriranjeStavkiRacuna : Form
    {
        public PopunaCmBox combo;
        public KupacBLL kupac;
        public PopunaCmBox dgv;
        public RacunBLL racun;
        public ProizvodBLL proizvod;
        public JedinicaMereBLL jm;
        public StavkaRacunaBLL stavkaRacuna;
        DataTable table;

        public frmAzuriranjeStavkiRacuna()
        {
            InitializeComponent();
            combo = new PopunaCmBox();
            kupac = new KupacBLL();
            jm = new JedinicaMereBLL();
            proizvod = new ProizvodBLL();
            racun = new RacunBLL();
            stavkaRacuna = new StavkaRacunaBLL();
            table = new DataTable();
            dgv = new PopunaCmBox();

            combo.popuniCmbRacun(cmbRacun);
            table = (DataTable)cmbRacun.DataSource;
            combo.popuniCmbKupac(cmbKupac);
            combo.popuniCmbRacun(cmbRacun);
            combo.popuniCmbProizvod(cmbProizvod);
            dgvStavkeRacuna.AllowUserToAddRows = false;
            dgvStavkeRacuna.AllowUserToAddRows = false;
            dgvStavkeRacuna.ReadOnly = true;

        }  


        private void cmbRacun_SelectedValueChanged_1(object sender, EventArgs e)
        {


            if (table.Rows.Count > 0 && cmbRacun.SelectedIndex != -1)
            {
                tbBrojRacuna.Text = table.Rows[cmbRacun.SelectedIndex]["Broj_racuna"].ToString();
                tbDatumRacuna.Text = table.Rows[cmbRacun.SelectedIndex]["Datum_izdavanja_racuna"].ToString();
                tbUkupno.Text = table.Rows[cmbRacun.SelectedIndex]["Ukupno"].ToString();
                cmbKupac.SelectedValue = int.Parse(table.Rows[cmbRacun.SelectedIndex]["ID_Kupca"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = int.Parse(cmbRacun.SelectedValue.ToString());
            dgv.dajPregledStavkiRacuna(dgvStavkeRacuna, b);
            cmbRacun.Text = "";
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            dgvStavkeRacuna.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAzuriranjeStavkiRacuna_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            dgvStavkeRacuna.Visible = false;
        }

        private void dgvStavkeRacuna_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbRedniBroj.Text = dgvStavkeRacuna.SelectedRows[0].Cells[0].Value.ToString();
            tbKolicina.Text = dgvStavkeRacuna.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool provera = false;
            foreach (var c in this.Controls)
            {
                if (c is TextBox && ((TextBox)c).Text == "")
                {

                    MessageBox.Show("Morate popuniti sva polja");
                    provera = false;
                    break;

                }
                else if (c is ComboBox && ((ComboBox)c).Text == "")
                {

                    MessageBox.Show("Morate popuniti sva polja");
                    provera = false;
                    break;

                }

                else
                    provera = true;

            }
            if (provera == true)
            {
                stavkaRacuna.Redni_Broj = int.Parse(tbRedniBroj.Text);
                stavkaRacuna.Kolicina = int.Parse(tbKolicina.Text);
                stavkaRacuna.ID_Racuna = int.Parse(cmbRacun.SelectedValue.ToString());
                stavkaRacuna.ID_Proizvoda = int.Parse(cmbProizvod.SelectedValue.ToString());
                stavkaRacuna.izmeniStavkuRacuna(stavkaRacuna);

                MessageBox.Show("Uspesno ste izmenili podatke ", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);


                combo.popuniCmbRacun(cmbRacun);
                combo.popuniCmbProizvod(cmbProizvod);

                table = (DataTable)cmbRacun.DataSource;

                groupBox2.Visible = false;
                groupBox3.Visible = false;
                dgvStavkeRacuna.Visible = false;
                tbRedniBroj.Text = "";
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


    }
}






