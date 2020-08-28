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
    public partial class frmBrisanjeStavkeRacuna : Form
    {
        public PopunaCmBox combo;
        public KupacBLL kupac;
        public PopunaCmBox dgv;
        public RacunBLL racun;
        public ProizvodBLL proizvod;
        public JedinicaMereBLL jm;
        public StavkaRacunaBLL stavkaRacuna;
        DataTable table;

        public frmBrisanjeStavkeRacuna()
        {
            InitializeComponent();
            combo = new PopunaCmBox();
            kupac = new KupacBLL();
            jm = new JedinicaMereBLL();
            racun = new RacunBLL();
            stavkaRacuna = new StavkaRacunaBLL();
            table = new DataTable();
            dgv = new PopunaCmBox();

            combo.popuniCmbRacun(cmbRacun);
            table = (DataTable)cmbRacun.DataSource;
            combo.popuniCmbKupac(cmbKupac);

            combo.popuniCmbRacun(cmbRacun);

            dgvStavkeRacuna.AllowUserToAddRows = false;
            dgvStavkeRacuna.AllowUserToAddRows = false;
            dgvStavkeRacuna.ReadOnly = true;

        }



        private void frmPrikazStavkiRacuna_Load(object sender, EventArgs e)
        {
          
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStavkeRacuna_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbRedniBroj.Text = dgvStavkeRacuna.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbRacun.SelectedValue != null && tbRedniBroj.Text != "")
            {
                stavkaRacuna.ID_Racuna = int.Parse(cmbRacun.SelectedValue.ToString());
                stavkaRacuna.Redni_Broj = int.Parse(tbRedniBroj.Text);
                stavkaRacuna.izbrisiStavkuRacuna(stavkaRacuna);
                MessageBox.Show("Uspesno ste izbrisali stavku iz evidencije", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                combo.popuniCmbRacun(cmbRacun);
                table = (DataTable)cmbRacun.DataSource;
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                dgvStavkeRacuna.Visible = false;
                tbRedniBroj.Text = "";

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
            else
                MessageBox.Show("Morate izabrati Otkupno mesto");
        }

        private void frmBrisanjeStavkeRacuna_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            dgvStavkeRacuna.Visible = false;
            groupBox3.Visible = false;
        }


    }
}






