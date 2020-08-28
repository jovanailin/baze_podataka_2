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
    public partial class frmJedinicaMere : Form
    {
        public JedinicaMereBLL JM;

        public frmJedinicaMere()
        {
            InitializeComponent();
            JM = new JedinicaMereBLL();
            popuniCmbJM();
        }

        public void popuniCmbJM()
        {
            cmbBrisiJM.DataSource = null;
            cmbBrisiJM.Items.Clear();
            cmbBrisiJM.DataSource = JM.dajJM();
            cmbBrisiJM.ValueMember = "ID_Jedinice_mere";
            cmbBrisiJM.DisplayMember = "Naziv_jedinice_mere";
            cmbBrisiJM.Text = null;
        }

  
       

        private void cmbBrisiJM_SelectedValueChanged(object sender, EventArgs e)
        {
            tbIzmeniJM.Text = cmbBrisiJM.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (tbIzmeniJM.Text != "")
            {
                JM.Naziv_jedinice_mere= tbIzmeniJM.Text;
                JM.ID_Jedinice_mere = int.Parse(cmbBrisiJM.SelectedValue.ToString());
                JM.izmeniJM(JM);
                MessageBox.Show("Uspesno ste azurirali izabranu stavku", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                popuniCmbJM();
                tbIzmeniJM.Text = "";

            }
            else
                MessageBox.Show("Greška pri unosu, proverite da li ste upisali naziv Jedinice mere", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JM.ID_Jedinice_mere = int.Parse(cmbBrisiJM.SelectedValue.ToString());
            JM.brisiJM(JM);
            MessageBox.Show("Uspesno ste izbrisali stavku iz evidencije", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            popuniCmbJM();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNazivJM.Text != "")
            {
                JM.Naziv_jedinice_mere = tbNazivJM.Text;
                JM.unosJM(JM);
                MessageBox.Show("Uspesno ste uneli: " + tbNazivJM.Text + "\n u evidenciju", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNazivJM.Text = "";
                popuniCmbJM();


            }
            else
            {
                MessageBox.Show("Greška pri unosu, proverite da li ste upisali naziv Jedinice mere", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       

       

      

       


    }
}
