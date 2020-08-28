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
    public partial class frmCenaProizvoda : Form
    {
        public PopunaCmBox combo;
        public CenaProizvodaBLL cenaproizvoda;
        public ProizvodBLL proizvod;
        DataTable table;

        public frmCenaProizvoda()
        {
            InitializeComponent();
            proizvod = new ProizvodBLL();
            combo = new PopunaCmBox();
            cenaproizvoda = new CenaProizvodaBLL();
            table = new DataTable();

            combo.popuniCmbProizvod(cmbProizvod);
        }





        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

                cenaproizvoda.ID_Proizvoda = int.Parse(cmbProizvod.SelectedValue.ToString());
                cenaproizvoda.Datum_pocetka_vazenja = DateTime.Parse(dateTimePicker1.Text);
                cenaproizvoda.Iznos = int.Parse(tbIznos.Text);
                cenaproizvoda.unosCeneProizvoda(cenaproizvoda);



                cmbProizvod.Text = "";
                dateTimePicker1.Text = "";
                tbIznos.Text = "";

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
