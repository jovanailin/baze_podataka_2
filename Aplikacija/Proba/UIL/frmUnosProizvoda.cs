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
    public partial class frmUnosProizvoda : Form
    {
        public PopunaCmBox combo;
        public ProizvodBLL proizvod;
        public VrstaBLL vrstaproizvoda;
        public JedinicaMereBLL jedinicamere;
        DataTable table;

        public frmUnosProizvoda()
        {
            InitializeComponent();
            proizvod = new ProizvodBLL();
            vrstaproizvoda = new VrstaBLL();
            jedinicamere = new JedinicaMereBLL();
            combo = new PopunaCmBox();
            table = new DataTable();
            combo.popuniCmbVrstaProizvoda(cmbVrstaProizvoda);
            combo.popuniCmbJM(cmbJedinicaMere);
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

                proizvod.ID_Vrste_proizvoda = int.Parse(cmbVrstaProizvoda.SelectedValue.ToString());
                proizvod.Naziv_proizvoda = tbNazivProizvoda.Text.ToString();
                proizvod.Sifra_proizvoda = tbSifraProizvoda.Text.ToString();
                proizvod.Podsifra_proizvoda = tbPodsifraProizvoda.Text.ToString();
                proizvod.masa = int.Parse(tbMasa.Text);
                proizvod.ID_jedinice_mere = int.Parse(cmbJedinicaMere.SelectedValue.ToString());

                proizvod.unosProizvoda(proizvod);
                tbNazivProizvoda.Text = "";
                tbSifraProizvoda.Text = "";
                tbPodsifraProizvoda.Text = "";
                tbMasa.Text = "";
                cmbJedinicaMere.Text = "";
                cmbVrstaProizvoda.Text = "";

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

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
