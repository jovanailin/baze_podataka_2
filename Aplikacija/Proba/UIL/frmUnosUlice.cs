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
    public partial class frmUnosUlice : Form
    {
        public PopunaCmBox combo;
        public MestoBLL mesto;
        public UlicaBLL ulica;
        DataTable table;

        public frmUnosUlice()
        {
            InitializeComponent();
            ulica = new UlicaBLL();
            combo = new PopunaCmBox();
            mesto = new MestoBLL();
            table = new DataTable();

            combo.popuniCmbMesto(cmbMesta);
        }





        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ComboBox cmbMesto { get; set; }

        private void button2_Click_1(object sender, EventArgs e)
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

                ulica.Naziv_Ulice = tbNazivUlice.Text.ToString();
                ulica.ID_Mesta = int.Parse(cmbMesta.SelectedValue.ToString());
                ulica.unosUlice(ulica);

                MessageBox.Show("Uspesno ste uneli:\n " + "\n Naziv ulice:" + tbNazivUlice.Text + "\n Mesto:" + cmbMesta.Text + "\n u evidenciju.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbNazivUlice.Text = "";
                cmbMesta.Text = "";

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //125
        }
    }
}
