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
    public partial class frmAdresa : Form
    {
        public frmAdresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUnosAdrese frmUA = new frmUnosAdrese();
            frmUA.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBrisanjeAzuriranjeAdrese frmBAA = new frmBrisanjeAzuriranjeAdrese();
            frmBAA.Show();
        }
    }
}
