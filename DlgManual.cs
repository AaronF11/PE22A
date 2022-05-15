using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE22A
{
    public partial class DlgManual : Form
    {
        public DlgManual()
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

        //╔═══════════════════╗
        //║ Maximizar ventana ║
        //╚═══════════════════╝
        private void BtnFullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        int indexR, indexM = 0;

        //╔═════════════════════════════════╗
        //║ Mover la posición de la ventana ║
        //╚═════════════════════════════════╝
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapure();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);
        private void PnlArribaManual_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AdelantarReproducir(PictureBox img)
        {
            switch (indexR)
            {
                case 0:
                    LblInfoReproducir.Text = "Ingresar usuario y contraseña";
                    img.Image = Properties.Resources.ReproducirPaso__1_;
                    indexR++;
                    break;
                case 1:
                    LblInfoReproducir.Text = "Visualiza el panel desplegable";
                    img.Image = Properties.Resources.ReproducirPaso__2_;
                    indexR++;
                    break;
                case 2:
                    LblInfoReproducir.Text = "Selecciona en el panel desplegable 'Categorias'";
                    img.Image = Properties.Resources.ReproducirPaso__3_;
                    indexR++;
                    break;
                case 3:
                    LblInfoReproducir.Text = "Selecciona la categoria de 'Inicio'";
                    img.Image = Properties.Resources.ReproducirPaso__4_;
                    indexR++;
                    break;
                case 4:
                    LblInfoReproducir.Text = "Visualiza el panel panel de películas disponibles";
                    img.Image = Properties.Resources.ReproducirPaso__5_;
                    indexR++;
                    break;
                case 5:
                    LblInfoReproducir.Text = "Selecciona la película deseada";
                    img.Image = Properties.Resources.ReproducirPaso__6_;
                    indexR++;
                    break;
                case 6:
                    LblInfoReproducir.Text = "Ajustar el reproductor a preferencia propia";
                    img.Image = Properties.Resources.ReproducirPaso__7_;
                    indexR = 0;
                    break;
            }
        }

        private void TimerReproducir_Tick(object sender, EventArgs e)
        {
            AdelantarReproducir(PtbImagenReproducir);
            AdelantarModos(PtbImagenModos);
        }

        private void BtnAutomaticoReproducir_Click(object sender, EventArgs e)
        {
            indexR = 0;
            TimerReproducir.Enabled = true;
        }

        private void BtnPausarReproducir_Click(object sender, EventArgs e)
        {
            TimerReproducir.Enabled = false;

        }

        private void BtnContinuarReproducir_Click(object sender, EventArgs e)
        {
            TimerReproducir.Enabled = true;
        }

        private void AdelantarModos(PictureBox img)
        {
            switch (indexM)
            {
                case 0:
                    LblInfoModos.Text = "Ingresar usuario y contraseña";
                    img.Image = Properties.Resources.ModosPaso__1_;
                    indexM++;
                    break;
                case 1:
                    LblInfoModos.Text = "Selecciona en el panel desplegable 'Configuraciones'";
                    img.Image = Properties.Resources.ModosPaso__2_;
                    indexM++;
                    break;
                case 2:
                    LblInfoModos.Text = "Selecciona el modo que desees";
                    img.Image = Properties.Resources.ModosPaso__3_;
                    indexM = 0;
                    break;

            }
        }

        private void BtnAutomaticoModos_Click(object sender, EventArgs e)
        {
            indexM = 0;
            TimerReproducir.Enabled = true;
        }

        private void BtnPausarModos_Click(object sender, EventArgs e)
        {
            TimerReproducir.Enabled = false;

        }

        private void BtnContinuarModos_Click(object sender, EventArgs e)
        {
            TimerReproducir.Enabled = true;
        }
    }
}
