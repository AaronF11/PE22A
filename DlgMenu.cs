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
    public partial class DlgMenu : Form
    {

        public DlgMenu()
        {
            InitializeComponent();
            InicializarPaneles();
        }

        //╔═══════════════════╗
        //║ Easter egg        ║
        //╚═══════════════════╝
        private void PtbLogoPanelMenu_Click(object sender, EventArgs e)
        {
            PtbVideoMenu.Image = Properties.Resources.Fondo;
            PtbVideoMenu.BringToFront();
        }

        //╔═══════════════════╗
        //║ Ajustar paneles   ║
        //╚═══════════════════╝
        private void InicializarPaneles()
        {
            PnlCategoriasMenu.Visible = false;
            PnlHerramientasMenu.Visible = false;
            PnlAyudaMenu.Visible = false;
        }

        //╔═════════════════════════════════╗
        //║ Mover la posición de la ventana ║
        //╚═════════════════════════════════╝
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapure();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void PnlArribaMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //╔════════════════╗
        //║ Cerrar ventana ║
        //╚════════════════╝
        private void BtnLoginCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            DlgLogin dlgLogin = new DlgLogin();
            dlgLogin.ShowDialog();
        }

        //╔═══════════════════╗
        //║ Minimizar ventana ║
        //╚═══════════════════╝
        private void BtnLoginResize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //╔═══════════════════╗
        //║ Maximizar ventana ║
        //╚═══════════════════╝
        private void BtnLoginFullScreen_Click(object sender, EventArgs e)
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

        //╔═══════════════════╗
        //║ Minimizar paneles ║
        //╚═══════════════════╝
        private void OcultarSubMenu()
        {
            if (PnlCategoriasMenu.Visible == true)
            {
                PnlCategoriasMenu.Visible = false;
            }
            else if (PnlHerramientasMenu.Visible == true)
            {
                PnlHerramientasMenu.Visible = false;
            }
            else if (PnlAyudaMenu.Visible == true)
            {
                PnlAyudaMenu.Visible = false;
            }
        }

        //╔═══════════════════╗
        //║ Maximizar paneles ║
        //╚═══════════════════╝
        private void MostrarSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                OcultarSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        #region CategoriasMenu
        //╔════════════════════════╗
        //║ Abrir panel categorias ║
        //╚════════════════════════╝
        private void BtnCategoriasMenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PnlCategoriasMenu);
        } 

        //╔════════════════════════╗
        //║ Categoria de Inicio    ║
        //╚════════════════════════╝
        private void BtnCategoriaInicioMenu_Click(object sender, EventArgs e)
        {
            AbrirDgvHijo(new DlgCategoriaInicio());
            OcultarSubMenu();
        }

        //╔════════════════════════╗
        //║ Categoria de Acción    ║
        //╚════════════════════════╝
        private void BtnCategoriaAccionMenu_Click(object sender, EventArgs e)
        {
            AbrirDgvHijo(new DlgCategoriaAccion());
            OcultarSubMenu();
        }

        //╔════════════════════════╗
        //║ Categoria de Animadas  ║
        //╚════════════════════════╝
        private void BtnCategoriaAnimadasMenu_Click(object sender, EventArgs e)
        {
            AbrirDgvHijo(new DlgCategoriaAnimadas());
            OcultarSubMenu();
        }

        //╔════════════════════════╗
        //║ Categoria de Comedias  ║
        //╚════════════════════════╝
        private void BtnCategoriaComediasMenu_Click(object sender, EventArgs e)
        {
            AbrirDgvHijo(new DlgCategoriaComedias());
            OcultarSubMenu();
        }

        //╔════════════════════════╗
        //║ Categoria de Terror    ║
        //╚════════════════════════╝
        private void BtnCategoriaTerrorMenu_Click(object sender, EventArgs e)
        {
            AbrirDgvHijo(new DlgCategoriaTerror());
            OcultarSubMenu();
        }

        #region ConfiguracionesMenu
        //╔════════════════════════╗
        //║ Abrir configuraciones  ║
        //╚════════════════════════╝
        private void BtnConfiguracionesMenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PnlHerramientasMenu);
        }

        //╔══════════════════════════════╗
        //║ Cambia ventana a color claro ║
        //╚══════════════════════════════╝
        private void BtnHerramientaColorClaroMenu_Click(object sender, EventArgs e)
        {
            //Bonotes
            BtnMenuCerrar.BackColor = Color.FromArgb(220, 20, 60);
            BtnMenuFullScreen.BackColor = Color.FromArgb(220, 20, 60);
            BtnMenuResize.BackColor = Color.FromArgb(220, 20, 60);

            //Paneles superiores e inferiores
            PnlArribaMenu.BackColor = Color.FromArgb(220, 20, 60);
            PnlAbajoMenu.BackColor = Color.FromArgb(220, 20, 60);
            StsMenu.BackColor = Color.FromArgb(220, 20, 60);

            //Logo
            PtbLogoPanelMenu.BackColor = Color.FromArgb(255, 240, 245);

            //Panel de los formularios hijos
            PnlFormulariosHijosMenu.BackColor = Color.FromArgb(255, 240, 245);

            //Panel de los controles
            PnlControlesMenu.BackColor = Color.FromArgb(255, 240, 245);

            //Bloque 1. Categorias
            BtnCategoriasMenu.BackColor = Color.FromArgb(255, 240, 245);

            //1.1 Inicio
            BtnCategoriaInicioMenu.BackColor = Color.FromArgb(220, 20, 60);

            //1.2 Animadas
            BtnCategoriaAnimadasMenu.BackColor = Color.FromArgb(220, 20, 60);

            //1.3 Comedias
            BtnCategoriaComediasMenu.BackColor = Color.FromArgb(220, 20, 60);

            //1.4 Terror
            BtnCategoriaTerrorMenu.BackColor = Color.FromArgb(220, 20, 60);

            //1.5 Acción
            BtnCategoriaAccionMenu.BackColor = Color.FromArgb(220, 20, 60);

            //Bloque 2. Configuraciones
            BtnConfiguracionesMenu.BackColor = Color.FromArgb(255, 240, 245);

            //2.1 Claro
            BtnCategoriaInicioMenu.BackColor = Color.FromArgb(220, 20, 60);

            //2.2 Oscuro
            BtnCategoriaAnimadasMenu.BackColor = Color.FromArgb(220, 20, 60);

            //Bloque 3. Ayuda
            BtnAyudaMenu.BackColor = Color.FromArgb(255, 240, 245);

            //3.1 Manual
            BtnManualMenu.BackColor = Color.FromArgb(220, 20, 60);

            //3.2 Acerca de
            BtnAcercaDeMenu.BackColor = Color.FromArgb(220, 20, 60);

            DlgCategoriaInicio dlgCategoriaInicio = new DlgCategoriaInicio();
            dlgCategoriaInicio.BackColor = Color.FromArgb(255, 240, 245);

            OcultarSubMenu();
        }

        //╔═══════════════════════════════╗
        //║ Cambia ventana a color oscuro ║
        //╚═══════════════════════════════╝
        private void BtnHerramientaColorOscuroMenu_Click(object sender, EventArgs e)
        {
            //Bonotes
            BtnMenuCerrar.BackColor = Color.FromArgb(0, 11, 30);
            BtnMenuFullScreen.BackColor = Color.FromArgb(0, 11, 30);
            BtnMenuResize.BackColor = Color.FromArgb(0, 11, 30);

            //Paneles superiores e inferiores
            PnlArribaMenu.BackColor = Color.FromArgb(0, 11, 30);
            PnlAbajoMenu.BackColor = Color.FromArgb(0, 11, 30);
            StsMenu.BackColor = Color.FromArgb(0, 11, 30);

            //Logo
            PtbLogoPanelMenu.BackColor = Color.FromArgb(28, 28, 28);

            //Panel de los formularios hijos
            PnlFormulariosHijosMenu.BackColor = Color.FromArgb(28, 28, 28);

            //Panel de los controles
            PnlControlesMenu.BackColor = Color.FromArgb(28, 28, 28);

            //Bloque 1. Categorias
            BtnCategoriasMenu.BackColor = Color.FromArgb(0, 11, 30);

            //1.1 Inicio
            BtnCategoriaInicioMenu.BackColor = Color.FromArgb(0, 11, 30);

            //1.2 Animadas
            BtnCategoriaAnimadasMenu.BackColor = Color.FromArgb(0, 11, 30);

            //1.3 Comedias
            BtnCategoriaComediasMenu.BackColor = Color.FromArgb(0, 11, 30);

            //1.4 Terror
            BtnCategoriaTerrorMenu.BackColor = Color.FromArgb(0, 11, 30);

            //1.5 Acción
            BtnCategoriaAccionMenu.BackColor = Color.FromArgb(0, 11, 30);

            //Bloque 2. Configuraciones
            BtnConfiguracionesMenu.BackColor = Color.FromArgb(28, 28, 28);

            //2.1 Claro
            BtnCategoriaInicioMenu.BackColor = Color.FromArgb(0, 11, 30);

            //2.2 Oscuro
            BtnCategoriaAnimadasMenu.BackColor = Color.FromArgb(0, 11, 30);

            //Bloque 3. Ayuda
            BtnAyudaMenu.BackColor = Color.FromArgb(28, 28, 28);

            //3.1 Manual
            BtnManualMenu.BackColor = Color.FromArgb(0, 11, 30);

            //3.2 Acerca de
            BtnAcercaDeMenu.BackColor = Color.FromArgb(0, 11, 30);


            OcultarSubMenu();
        }
        #endregion

        #region AyudaMenu
        //╔════════════════════════╗
        //║ Abrir ayuda de menu    ║
        //╚════════════════════════╝
        private void BtnAyudaMenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PnlAyudaMenu);
        }

        //╔════════════════════════╗
        //║ Abre un manual de uso  ║
        //╚════════════════════════╝
        private void BtnManualMenu_Click(object sender, EventArgs e)
        {
            DlgManual dlgManual = new DlgManual();
            dlgManual.Show();
            OcultarSubMenu();
        }

        //╔══════════════════════════════════╗
        //║ Brinda información del programa  ║
        //╚══════════════════════════════════╝
        private void BtnAcercaDeMenu_Click(object sender, EventArgs e)
        {
            DlgAcercaDe dlgAcercaDe = new DlgAcercaDe();
            dlgAcercaDe.Show();
            OcultarSubMenu();
        }
        #endregion

        private Form VentanaActiva = null;
        private void AbrirDgvHijo(Form VentanaHijo)
        {
            if (VentanaActiva != null)
            {
                VentanaActiva.Close();
            }
            VentanaActiva = VentanaHijo;
            VentanaHijo.TopLevel = false;
            VentanaHijo.FormBorderStyle = FormBorderStyle.None;
            VentanaHijo.Dock = DockStyle.Fill;
            PnlFormulariosHijosMenu.Controls.Add(VentanaHijo);
            PnlFormulariosHijosMenu.Tag = VentanaHijo;
            VentanaHijo.BringToFront();
            VentanaHijo.Show();
        }
        #endregion
    }
}
