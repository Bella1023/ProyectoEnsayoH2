using System;
using System.Windows.Forms;

namespace PPDes
{
    public partial class CatalogoMujer : Form
    {
        public CatalogoMujer()
        {
            InitializeComponent();
        }


        private void deportivaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPrincipal pri = new frmPrincipal();
            pri.Show();
            this.Close();
        }
    }
}