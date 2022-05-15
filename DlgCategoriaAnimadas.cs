using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE22A
{
    public partial class DlgCategoriaAnimadas : Form
    {
        public DlgCategoriaAnimadas()
        {
            InitializeComponent();
        }

        private void BntPeli4_Click(object sender, EventArgs e)
        {
            this.Close();
            DlgReproductor dlgReproductor = new DlgReproductor(1);
            dlgReproductor.Show();
        }

        private void BntPeli9_Click(object sender, EventArgs e)
        {
            this.Close();
            DlgReproductor dlgReproductor = new DlgReproductor(9);
            dlgReproductor.Show();
        }

        private void BntPeli10_Click(object sender, EventArgs e)
        {
            this.Close();
            DlgReproductor dlgReproductor = new DlgReproductor(10);
            dlgReproductor.Show();
        }

        private void BntPeli12_Click(object sender, EventArgs e)
        {
            this.Close();
            DlgReproductor dlgReproductor = new DlgReproductor(12);
            dlgReproductor.Show();
        }

        private void BntPeli15_Click(object sender, EventArgs e)
        {
            this.Close();
            DlgReproductor dlgReproductor = new DlgReproductor(15);
            dlgReproductor.Show();
        }

        private void BntPeli19_Click(object sender, EventArgs e)
        {
            this.Close();
            DlgReproductor dlgReproductor = new DlgReproductor(19);
            dlgReproductor.Show();
        }
    }
}
