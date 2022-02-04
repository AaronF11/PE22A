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
    public partial class DlgPrincipal : Form
    {
        public DlgPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSaludo_Click(object sender, EventArgs e)
        {
            string NombreUsuario;
            string Sexo;

            NombreUsuario = TxtNombre.Text;
            Sexo = CbxSexo.Text.ToLower();

            MessageBox.Show("Hola mundo. Soy " + NombreUsuario + ", mi género es " + Sexo + " y este es mi primer programa en lenguaje C#");
        }
    }
}
