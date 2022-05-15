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
    public partial class DlgAcercaDe : Form
    {
        public DlgAcercaDe()
        {
            InitializeComponent();
        }

        //╔════════════════╗
        //║ Cerrar ventana ║
        //╚════════════════╝
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        //╔═══════════════════╗
        //║ Minimizar ventana ║
        //╚═══════════════════╝
        private void BtnResize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LnkLblAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LnkLblAutor.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/AaronF11");
        }

        private void LnkLblRepositorio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LnkLblRepositorio.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/AaronF11/PE22A");
        }
    }
}
