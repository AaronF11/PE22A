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
    public partial class DlgReproductor : Form
    {
        public DlgReproductor(int ruta)
        {
            InitializeComponent();
            Abrir(ruta);
        }

        //╔═════════════════════════════════╗
        //║ Mover la posición de la ventana ║
        //╚═════════════════════════════════╝
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapure();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);
        private void DlgReproductor_Load(object sender, EventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            LblVolumen.Text = (MtbVolumen.Value = WmpReproductor.settings.volume = 50).ToString();
            this.WmpReproductor.uiMode = "none";
        }
        private void PnlArribaDlgReproductor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //╔═══════════════════╗
        //║ Cerrar la ventana ║
        //╚═══════════════════╝
        private void PtbCerrarDlgReproductor_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        private void DlgReproductor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        //╔══════════════════════╗
        //║ Maximizar la ventana ║
        //╚══════════════════════╝
        private void PtbMaximizarDlgReproductor_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        //╔══════════════════════╗
        //║ Minimizar la ventana ║
        //╚══════════════════════╝
        private void PtbMinimizarDlgReproductor_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //╔══════════════════╗
        //║ Botón de volumen ║
        //╚══════════════════╝
        private void BtnVolumen_Click(object sender, EventArgs e)
        {
            if (MtbVolumen.Enabled == true)
            {
                MtbVolumen.Enabled = false;
                MtbVolumen.Value = 0;
            }
            else if (MtbVolumen.Enabled == false)
            {
                MtbVolumen.Enabled = true;
                MtbVolumen.Value = 50;
            }
        }

        //╔════════════════════════╗
        //║ Botón para reproducir  ║
        //╚════════════════════════╝
        private void BtnRepoducir_Click(object sender, EventArgs e)
        {
            BtnPausar.BringToFront();
            WmpReproductor.Ctlcontrols.pause();
            Contador.Stop();
        }

        //╔═══════════════════╗
        //║ Botón para pausar ║
        //╚═══════════════════╝
        private void BtnPausar_Click(object sender, EventArgs e)
        {
            BtnRepoducir.BringToFront();
            WmpReproductor.Ctlcontrols.play();
            Contador.Start();
        }

        //╔═══════════════════════════════════════╗
        //║ Función de las rutas de las películas ║
        //╚═══════════════════════════════════════╝
        public void Abrir(int ruta)
        {
            switch (ruta)
            {
                case 1:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\AQUAMAN.mp4");
                    break;

                case 2:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\Bad Boys 3.mp4");
                    break;

                case 3:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\CAPITANA MARVEL.mp4");
                    break;

                case 4:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\Dead Space Downfall.mp4");
                    break;

                case 5:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\El amor lo es todo, todo.mp4");
                    break;

                case 6:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\EL HOMBRE INVISIBLE.mp4");
                    break;

                case 7:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\Free Guy.mp4");
                    break;

                case 8:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\Godzilla vs. Kong.mp4");
                    break;

                case 9:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\Injustice.mp4");
                    break;

                case 10:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\LA ERA DE HIELO.mp4");
                    break;

                case 11:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\La Purga Infinita.mp4");
                    break;

                case 12:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\Liga de la justicia Crisis en las dos tierras.mp4");
                    break;

                case 13:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\Shang-Chi y la leyenda de los Diez Anillos.mp4");
                    break;

                case 14:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\SONIC.mp4");
                    break;

                case 15:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\SPIDERMAN INTO THE SPIDER-VERSE.mp4");
                    break;

                case 16:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\THOR RAGNAROK.mp4");
                    break;

                case 17:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\Un novato en apuros 2.mp4");
                    break;

                case 18:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\Venom 2.mp4");
                    break;

                case 19:
                    WmpReproductor.URL = (@"D:\Entretenimiento\Peliculas\BOKU NO HERO - HEROES RISING.mp4");
                    break;
            }
            WmpReproductor.Ctlcontrols.play();
            this.Visible = true;
            Contador.Start();
        }

        //╔═══════════════════╗
        //║ Barra del tiempo  ║
        //╚═══════════════════╝
        private void MtbTiempo_ValueChanged(object sender, decimal value)
        {
            MtbTiempo.Maximum = (int)WmpReproductor.currentMedia.duration;
            if (MtbTiempo.Value == (int)WmpReproductor.Ctlcontrols.currentPosition)
            {

            }
            else
            {
                WmpReproductor.Ctlcontrols.currentPosition = MtbTiempo.Value;
            }
        }

        //╔═══════════╗
        //║ Contador  ║
        //╚═══════════╝
        private void Contador_Tick(object sender, EventArgs e)
        {
            try
            {
                MtbTiempo.Value = (int)WmpReproductor.Ctlcontrols.currentPosition;
                LblInicio.Text = WmpReproductor.Ctlcontrols.currentPositionString;
                LblFin.Text = WmpReproductor.currentMedia.durationString;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //╔═══════════════════╗
        //║ Regresar 15 Seg.  ║
        //╚═══════════════════╝
        private void BtnRetroceder_Click(object sender, EventArgs e)
        {
            if ((MtbTiempo.Value = MtbTiempo.Value - 15) < 0)
            {
                MtbTiempo.Value = 0;
            }
            else
            {
                MtbTiempo.Value = MtbTiempo.Value - 15;
            }

        }

        //╔═══════════════════╗
        //║ Regresar 60 Seg.  ║
        //╚═══════════════════╝
        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if ((MtbTiempo.Value = MtbTiempo.Value - 60) < 0)
            {
                MtbTiempo.Value = 0;
            }
            else
            {
                MtbTiempo.Value = MtbTiempo.Value - 60;
            }
        }

        //╔═══════════════════╗
        //║ Aumentar 60 Seg.  ║
        //╚═══════════════════╝
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            MtbTiempo.Value = MtbTiempo.Value + 60;
        }

        //╔═══════════════════╗
        //║ Aumentar 15 Seg.  ║
        //╚═══════════════════╝
        private void BtnAdelantar_Click(object sender, EventArgs e)
        {
            MtbTiempo.Value = MtbTiempo.Value + 15;
        }

        //╔═══════════════════╗
        //║ Barra del volumen ║
        //╚═══════════════════╝
        private void MtbVolumen_ValueChanged(object sender, decimal value)
        {
            WmpReproductor.settings.volume = MtbVolumen.Value;
            LblVolumen.Text = WmpReproductor.settings.volume.ToString();
        }
    }
}

