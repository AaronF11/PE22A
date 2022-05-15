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
    public partial class DlgCategoriaTerror : Form
    {
        public DlgCategoriaTerror()
        {
            InitializeComponent();
        }

        private void BntPeli4_Click(object sender, EventArgs e)
        {
            this.Close();
            DlgReproductor dlgReproductor = new DlgReproductor(4);
            dlgReproductor.Show();
        }

        private void BntPeli6_Click(object sender, EventArgs e)
        {
            this.Close();
            DlgReproductor dlgReproductor = new DlgReproductor(6);
            dlgReproductor.Show();
        }

        private void BntPeli11_Click(object sender, EventArgs e)
        {
            this.Close();
            DlgReproductor dlgReproductor = new DlgReproductor(11);
            dlgReproductor.Show();
        }
    }
}
