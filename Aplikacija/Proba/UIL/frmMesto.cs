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
using Proba.DAL;

namespace Proba.UIL
{
    public partial class frmMestoBLL : Form
    {
        public MestoBLL mesto;

        public frmMestoBLL()
        {
            InitializeComponent();
            mesto = new MestoBLL();
            popuniCmbMesto();
        }

        public void popuniCmbMesto()
        {
            cmbBrisiMesto.DataSource = null;
            cmbBrisiMesto.Items.Clear();
            cmbBrisiMesto.DataSource = mesto.dajMesto();
            cmbBrisiMesto.ValueMember = "ID_Mesta";
            cmbBrisiMesto.DisplayMember = "mesto";
            cmbBrisiMesto.Text = null;
        }

      
      
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tbMesto.Text != "")
            {
                mesto.Naziv_mesta = tbMesto.Text;
                mesto.unosMesta(mesto);
                tbMesto.Text = "";
                popuniCmbMesto();
            }
            else
            {
                MessageBox.Show("Greška pri unosu, proverite da li ste upisali oznaku kasete");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (tbIzmeniMesto.Text != "")
            {
                mesto.Naziv_mesta = tbIzmeniMesto.Text;
                mesto.ID_Mesta = int.Parse(cmbBrisiMesto.SelectedValue.ToString());
                mesto.izmeniMesto(mesto);
                popuniCmbMesto();
                tbIzmeniMesto.Text = "";
            }
            else
                MessageBox.Show("Greška pri unosu, proverite da li ste upisali oznaku kasete");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mesto.ID_Mesta = int.Parse(cmbBrisiMesto.SelectedValue.ToString());
            mesto.brisiMesto(mesto);
            popuniCmbMesto();
        }

        private void cmbBrisiMesto_SelectedValueChanged(object sender, EventArgs e)
        {
            tbIzmeniMesto.Text = cmbBrisiMesto.Text;
        }






    }
}

