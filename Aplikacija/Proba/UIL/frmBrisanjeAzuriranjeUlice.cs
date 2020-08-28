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
    public partial class frmBrisanjeAzuriranjeUlice : Form
    {
        public PopunaCmBox combo;
        public UlicaBLL ulica;
        public MestoBLL mesto;
        DataTable table;

        public frmBrisanjeAzuriranjeUlice()
        {
            InitializeComponent();
            combo = new PopunaCmBox();
            ulica = new UlicaBLL();
            mesto = new MestoBLL();
            table = new DataTable();

            combo.popuniCmbUlica(cmbUlica);
            combo.popuniCmbMesto(cmbMesto);
            table = (DataTable)cmbUlica.DataSource;
        }



       
     
      

      

        private void frmBrisanjeAzuriranjeUlice_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
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
                ulica.Naziv_Ulice = tbNazivUlice.Text;
                ulica.ID_Ulice = int.Parse(cmbUlica.SelectedValue.ToString());


                groupBox1.Visible = false;

                ulica.izmeniUlicu(ulica);

                MessageBox.Show("Uspesno ste izmenili podatke o: " + cmbUlica.Text + "\n u evidenciju", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);


                combo.popuniCmbUlica(cmbUlica);
                combo.popuniCmbMesto(cmbMesto);
                table = (DataTable)cmbUlica.DataSource;

                groupBox1.Visible = false;

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

        private void cmbUlica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (table.Rows.Count > 0 && cmbUlica.SelectedIndex != -1)
            {
                groupBox1.Visible = true;
                tbNazivUlice.Text = table.Rows[cmbUlica.SelectedIndex]["Naziv_ulice"].ToString();
                tbNazivMesta.Text = table.Rows[cmbUlica.SelectedIndex]["Naziv_mesta"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbUlica.SelectedValue != null)
            {
                ulica.ID_Ulice = int.Parse(cmbUlica.SelectedValue.ToString());
                ulica.brisiUlicu(ulica);
                combo.popuniCmbUlica(cmbUlica);
                table = (DataTable)cmbUlica.DataSource;
                groupBox1.Visible = false;
                MessageBox.Show("Uspesno ste izbrisali ulicu iz evidencije.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                MessageBox.Show("Morate izabrati ulicu");
        }

      
    }
}
