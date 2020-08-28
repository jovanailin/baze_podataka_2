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
using Proba.UIL;

namespace Proba.UIL
{
    public partial class frmIsporuka : Form
    {
        public PopunaCmBox combo;
        public StatusIsporukeBLL statusisporuke;
        public RacunBLL racun;
        public IsporukaBLL isporuka;
        DataTable table;

        public frmIsporuka()
        {
            InitializeComponent();
            statusisporuke = new StatusIsporukeBLL();
            racun = new RacunBLL();
            combo = new PopunaCmBox();
            isporuka = new IsporukaBLL();
            table = new DataTable();

            combo.popuniCmbRacun(cmbRacun);
            combo.popuniCmbStatusIsporuke(cmbStatusIsporuke);
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


                isporuka.ID_Racuna = int.Parse(cmbRacun.SelectedValue.ToString());
               isporuka.Datum = DateTime.Parse(dateTimePicker1.Text);
              // isporuka.Datum = DateTime.Parse(dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss".ToString());
                //isporuka.Datum = DateTime.Parse(dateTimePicker1.Text.ToString("yyyy'-'MM'-'dd HH':'mm':'ss.fff"));
                isporuka.ID_Statusa_isporuke = int.Parse(cmbStatusIsporuke.SelectedValue.ToString());
                isporuka.unosIsporuke(isporuka);



                cmbRacun.Text = "";
                dateTimePicker1.Text = "";
                cmbStatusIsporuke.Text = "";

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  





    }
}
