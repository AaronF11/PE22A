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
    public partial class DlgLogin : Form
    {
        //╔═══════════╗
        //║ Variables ║
        //╚═══════════╝
        string Usuario = "";
        string Contraseña = "";
        DlgMenu dlgmenu = new DlgMenu();

        public DlgLogin()
        {
            InitializeComponent();
        }

        //╔═════════════════════════════════╗
        //║ Mover la posición de la ventana ║
        //╚═════════════════════════════════╝
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapure();
        
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void LblTituloLogin_MouseDown(object sender, MouseEventArgs e)
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
            DlgProyecto dlgProyecto = new DlgProyecto();
            dlgProyecto.ShowDialog();
        }

        //╔═══════════════════╗
        //║ Minimizar ventana ║
        //╚═══════════════════╝
        private void BtnLoginResize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //╔══════════════════════════════════╗
        //║ Inicialización de cajas de texto ║
        //╚══════════════════════════════════╝
        private void DlgLogin_Load(object sender, EventArgs e)
        {
            TxtUsuarioLogin.Text = "USUARIO";
            TxtUsuarioLogin.ForeColor = Color.LavenderBlush;
            TxtContraseñaLogin.Text = "CONTRASEÑA";
            TxtContraseñaLogin.ForeColor = Color.LavenderBlush;
        }

        //╔══════════════════════════════════════════════════════╗
        //║ Al entrar a la caja de texto se borra su predefinido ║
        //╚══════════════════════════════════════════════════════╝
        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            Usuario = TxtUsuarioLogin.Text;
            if (Usuario.Equals("USUARIO"))
            {
                TxtUsuarioLogin.Text = "";
                TxtUsuarioLogin.ForeColor = Color.LawnGreen;
            }
        }

        //╔══════════════════════════════════════════════════════╗
        //║ Al entrar a la caja de texto se borra su predefinido ║
        //╚══════════════════════════════════════════════════════╝
        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            Contraseña = TxtContraseñaLogin.Text;
            if (Contraseña.Equals("CONTRASEÑA"))
            {
                TxtContraseñaLogin.Text = "";
                TxtContraseñaLogin.ForeColor = Color.LawnGreen;
                TxtContraseñaLogin.UseSystemPasswordChar = true;
            }
        }

        //╔══════════════════════════════════════════════════════╗
        //║ Al dejar la caja de texto se hace hacen validaciones ║
        //╚══════════════════════════════════════════════════════╝
        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            Usuario = TxtUsuarioLogin.Text;
            if (Usuario.Equals("USUARIO"))
            {
                TxtUsuarioLogin.Text = "USUARIO";
                TxtUsuarioLogin.ForeColor = Color.LavenderBlush;
            }
            else
            {
                if (Usuario.Equals(""))
                {
                    TxtUsuarioLogin.Text = "USUARIO";
                    TxtUsuarioLogin.ForeColor = Color.LavenderBlush;
                }
                else
                {
                    TxtUsuarioLogin.Text = Usuario;
                    TxtUsuarioLogin.ForeColor = Color.LawnGreen;
                }
            }
        }

        //╔══════════════════════════════════════════════════════╗
        //║ Al dejar la caja de texto se hace hacen validaciones ║
        //╚══════════════════════════════════════════════════════╝
        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            Contraseña = TxtContraseñaLogin.Text;
            if (Contraseña.Equals("CONTRASEÑA"))
            {
                TxtContraseñaLogin.Text = "CONTRASEÑA";
                TxtContraseñaLogin.ForeColor = Color.LavenderBlush;
                TxtContraseñaLogin.UseSystemPasswordChar = false;
            }
            else
            {
                if (Contraseña.Equals(""))
                {
                    TxtContraseñaLogin.Text = "CONTRASEÑA";
                    TxtContraseñaLogin.ForeColor = Color.LavenderBlush;
                    TxtContraseñaLogin.UseSystemPasswordChar = false;
                }
                else
                {
                    TxtContraseñaLogin.Text = Contraseña;
                    TxtContraseñaLogin.ForeColor = Color.LawnGreen;
                }
            }
        }

        //╔════════════════════════════════════════════════╗
        //║ Validar solo texto en la caja de texto Usuario ║
        //╚════════════════════════════════════════════════╝
        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("El nombre solo debe contener letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //╔════════════════════════════════════════════════════════════╗
        //║ Función para mandar un mensaje si la contraseña es erronea ║
        //╚════════════════════════════════════════════════════════════╝
        private void ContraseñaIncorrecta()
        {
            MessageBox.Show("Contraseña incorrecta", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //╔═══════════════════════════════════════════════╗
        //║ Sí el perfil existe se despliega otra ventana ║
        //╚═══════════════════════════════════════════════╝
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Usuario = TxtUsuarioLogin.Text;
            string UsuarioFinal = Usuario.ToLower();
            Contraseña = TxtContraseñaLogin.Text;

            switch (UsuarioFinal)
            {
                case "aaronfloresp":
                    if (Contraseña == "110803")
                    {
                        dlgmenu.Show();
                        this.Hide();
                        this.Close();
                    }
                    else
                    {
                        ContraseñaIncorrecta();
                        return;
                    }
                    break;

                default:
                    MessageBox.Show("Usuario y/o Contraseña incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }
        }

        //╔═══════════════════════════════════════════╗
        //║ Muestra la contraseña de la caja de texto ║
        //╚═══════════════════════════════════════════╝
        private void BtnVerOcultar_Click(object sender, EventArgs e)
        {
            if (TxtContraseñaLogin.UseSystemPasswordChar == true)
            {
                TxtContraseñaLogin.UseSystemPasswordChar = false;
                BtnVerOcultar.BackgroundImage = Properties.Resources.icons8_eye_26px;
            }

            else if(TxtContraseñaLogin.UseSystemPasswordChar == false)
            {
                Contraseña = TxtContraseñaLogin.Text;
                if (Contraseña.Equals("CONTRASEÑA"))
                {
                    BtnVerOcultar.BackgroundImage = Properties.Resources.icons8_eye_26px;
                    TxtContraseñaLogin.UseSystemPasswordChar = false;
                }
                else
                {
                    TxtContraseñaLogin.UseSystemPasswordChar = true;
                    BtnVerOcultar.BackgroundImage = Properties.Resources.icons8_invisible_26px;
                }
            }
        }
    }
}
