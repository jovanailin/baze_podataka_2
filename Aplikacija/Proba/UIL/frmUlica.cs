using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proba.UIL
{
    public partial class frmUlica : Form
    {
        public frmUlica()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmUnosUlice frmUU= new frmUnosUlice();
            frmUU.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBrisanjeAzuriranjeUlice frmBAU = new frmBrisanjeAzuriranjeUlice();
            frmBAU.Show();
        }
    }
}
