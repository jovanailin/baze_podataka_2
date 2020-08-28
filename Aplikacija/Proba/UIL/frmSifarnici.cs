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
using Proba.UIL;

namespace Proba.UIL
{
    public partial class frmSifarnici : Form
    {
        public frmSifarnici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdresa frmA = new frmAdresa();
            frmA.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMestoBLL frmMes = new frmMestoBLL();
            frmMes.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmJedinicaMere frmJM = new frmJedinicaMere();
            frmJM.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmUlica frmU = new frmUlica();
            frmU.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmUnosProizvoda frmUP = new frmUnosProizvoda();
            frmUP.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmUnosKupca frmUK = new frmUnosKupca();
            frmUK.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmVrstaProizvoda frmVP = new frmVrstaProizvoda();
            frmVP.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmKatalog frmKat = new frmKatalog();
            frmKat.Show();
        }





    }
}
