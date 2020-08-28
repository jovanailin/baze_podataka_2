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
    public partial class frmUnosAdrese : Form
    {
        public PopunaCmBox combo;
        public AdresaBLL adresa;
        public UlicaBLL ulica;
        DataTable table;

        public frmUnosAdrese()
        {
            InitializeComponent();
            ulica = new UlicaBLL();
            combo = new PopunaCmBox();
            adresa = new AdresaBLL();
            table = new DataTable();

            combo.popuniCmbUlica(cmbUl);
        }





        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ComboBox cmbUlice { get; set; }



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

                adresa.Broj = tbAdresa.Text.ToString();
                adresa.ID_Ulice = int.Parse(cmbUl.SelectedValue.ToString());
                adresa.unosAdrese(adresa);

                MessageBox.Show("Uspesno ste uneli:\n " + "\n broj:" + tbAdresa.Text + "\n Ulica:" + cmbUl.Text + "\n u evidenciju.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbAdresa.Text = "";
                cmbUl.Text = "";

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
