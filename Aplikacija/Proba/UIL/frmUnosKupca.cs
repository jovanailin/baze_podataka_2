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
    public partial class frmUnosKupca : Form
    {
        public PopunaCmBox combo;
        public KupacBLL kupac;
        public AdresaBLL adresa;
        DataTable table;

        public frmUnosKupca()
        {
            InitializeComponent();
            kupac = new KupacBLL();
            adresa = new AdresaBLL();
            combo = new PopunaCmBox();
            table = new DataTable();

            combo.popuniCmbAdresa(cmbAdresa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnSacuvaj_Click(object sender, EventArgs e)
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

                kupac.Naziv_kupca = tbNazivKupca.Text.ToString();
                kupac.PIB = tbPIB.Text.ToString();
                kupac.ID_Adrese = int.Parse(cmbAdresa.SelectedValue.ToString());
                kupac.unosKupca(kupac);
                tbPIB.Text = "";
                tbNazivKupca.Text = "";
                cmbAdresa.Text = "";
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

   





    }
}
