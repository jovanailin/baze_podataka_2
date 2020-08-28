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
    public partial class frmVrstaProizvoda : Form
    {
        public VrstaBLL vrstaproizvoda;

        public frmVrstaProizvoda()
        {
            InitializeComponent();
            vrstaproizvoda = new VrstaBLL();
            popuniCmbVrstaProizvoda();
        }

        public void popuniCmbVrstaProizvoda()
        {
            cmbBrisiVrstuProizvoda.DataSource = null;
            cmbBrisiVrstuProizvoda.Items.Clear();
            cmbBrisiVrstuProizvoda.DataSource = vrstaproizvoda.dajVrstuProizvoda();
            cmbBrisiVrstuProizvoda.ValueMember = "ID_vrste_proizvoda";
            cmbBrisiVrstuProizvoda.DisplayMember = "vrsta";
            cmbBrisiVrstuProizvoda.Text = null;
        }



      

        

        private void button3_Click(object sender, EventArgs e)
        {
             if (tbIzmeniVrstuProizvoda.Text != "")
            {
                vrstaproizvoda.Naziv_vrste_proizvoda = tbIzmeniVrstuProizvoda.Text;
                vrstaproizvoda.ID_Vrste_proizvoda = int.Parse(cmbBrisiVrstuProizvoda.SelectedValue.ToString());
                vrstaproizvoda.izmeniVrstuProizvoda(vrstaproizvoda);
                popuniCmbVrstaProizvoda();
                tbIzmeniVrstuProizvoda.Text = "";
            }
            else
                MessageBox.Show("Greška pri unosu, proverite da li ste upisali oznaku kasete");
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vrstaproizvoda.ID_Vrste_proizvoda = int.Parse(cmbBrisiVrstuProizvoda.SelectedValue.ToString());
            vrstaproizvoda.brisiVrstuProizvoda(vrstaproizvoda);
            popuniCmbVrstaProizvoda();
        }

        private void cmbBrisiKategoriju_SelectedValueChanged(object sender, EventArgs e)
        {
            tbIzmeniVrstuProizvoda.Text = cmbBrisiVrstuProizvoda.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbVrstaProizvoda.Text != "")
            {
                vrstaproizvoda.Naziv_vrste_proizvoda = tbVrstaProizvoda.Text;
                vrstaproizvoda.unosVrsteProizvoda(vrstaproizvoda);
                MessageBox.Show("Uspesno ste uneli: " + tbVrstaProizvoda.Text + "\n u evidenciju", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbVrstaProizvoda.Text = "";
                popuniCmbVrstaProizvoda();
            }
            else
            {
                MessageBox.Show("Greška pri unosu, proverite da li ste upisali oznaku kasete");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       






    }
}
