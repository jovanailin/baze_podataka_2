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
    public partial class frmPrikazStavkiRacuna : Form
    {
        public PopunaCmBox combo;
        public KupacBLL kupac;
        public PopunaCmBox dgv;
        public RacunBLL racun;
        public ProizvodBLL proizvod;
        public JedinicaMereBLL jm;
        public StavkaRacunaBLL stavkaRacuna;
        DataTable table;

        public frmPrikazStavkiRacuna()
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
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            dgvStavkeRacuna.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int b = int.Parse(cmbRacun.SelectedValue.ToString());

            dgv.dajPregledStavkiRacuna(dgvStavkeRacuna, b);
            cmbRacun.Text = "";
            groupBox2.Visible = true;
            dgvStavkeRacuna.Visible = true;
        }

        private void cmbRacun_SelectedValueChanged(object sender, EventArgs e)
        {


            if (table.Rows.Count > 0 && cmbRacun.SelectedIndex != -1)
            {
                tbBrojRacuna.Text = table.Rows[cmbRacun.SelectedIndex]["Broj_racuna"].ToString();
                tbDatumRacuna.Text = table.Rows[cmbRacun.SelectedIndex]["Datum_izdavanja_racuna"].ToString();
                tbUkupno.Text = table.Rows[cmbRacun.SelectedIndex]["Ukupno"].ToString();
                cmbKupac.SelectedValue = int.Parse(table.Rows[cmbRacun.SelectedIndex]["ID_Kupca"].ToString());
            }
        }

        private void cmbRacun_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }


    }
}






