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
    public partial class frmGlavniMeni : Form
    {
        public frmGlavniMeni()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSifarnici frmSif = new frmSifarnici();
            frmSif.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEvidencija frmE = new frmEvidencija();
            frmE.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
        }

        private void frmGlavniMeni_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
