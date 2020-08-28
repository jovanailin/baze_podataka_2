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
    public partial class frmBrisanjeAzuriranjeAdrese : Form
    {
        public PopunaCmBox combo;
        public UlicaBLL ulica;
        public AdresaBLL adresa;
        DataTable table;

        public frmBrisanjeAzuriranjeAdrese()
        {
            InitializeComponent();
            combo = new PopunaCmBox();
            ulica = new UlicaBLL();
            adresa = new AdresaBLL();
            table = new DataTable();

            combo.popuniCmbUlica(cmbUlica);
            combo.popuniCmbAdresa(cmbAdresa);
            table = (DataTable)cmbAdresa.DataSource;
        }

  

    

        private void frmBrisanjeAzuriranjeAdrese_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (cmbUlica.SelectedValue != null)
            {
                adresa.ID_Adrese = int.Parse(cmbAdresa.SelectedValue.ToString());
                adresa.brisiAdresu(adresa);
                combo.popuniCmbAdresa(cmbAdresa);
                table = (DataTable)cmbAdresa.DataSource;
                groupBox1.Visible = false;
                MessageBox.Show("Uspesno ste izbrisali adresu iz evidencije.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void cmbAdresa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (table.Rows.Count > 0 && cmbAdresa.SelectedIndex != -1)
            {
                groupBox1.Visible = true;
                tbBroj.Text = table.Rows[cmbAdresa.SelectedIndex]["broj"].ToString();
                cmbUlica.SelectedValue = int.Parse(table.Rows[cmbAdresa.SelectedIndex]["ID_Ulice"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                adresa.Broj = tbBroj.Text;
                adresa.ID_Ulice = int.Parse(cmbUlica.SelectedValue.ToString());
                adresa.ID_Adrese = int.Parse(cmbAdresa.SelectedValue.ToString());


                groupBox1.Visible = false;


                adresa.izmeniAdresu(adresa);

                MessageBox.Show("Uspesno ste izmenili podatke o: " + cmbAdresa.Text + "\n u evidenciju", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);


                combo.popuniCmbUlica(cmbUlica);
                combo.popuniCmbAdresa(cmbAdresa);
                table = (DataTable)cmbAdresa.DataSource;

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

        private void cmbAdresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbadresa
        }


    }
}
