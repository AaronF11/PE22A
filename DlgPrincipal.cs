using System;
using System.Windows.Forms;

namespace PE22A
{
    //---------------------------------------------------------------------
    //Clase del diálogo principal de la aplicación.
    //---------------------------------------------------------------------
    public partial class DlgPrincipal : Form
    {
        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgPrincipal()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------
        //Hola Mundo.
        //---------------------------------------------------------------------
        private void BtnSaludo_Click(object sender, EventArgs e)
        {
            string NombreUsuario;
            string Sexo;

            NombreUsuario = TxtNombre.Text;
            Sexo = CbxSexo.Text.ToLower();

            MessageBox.Show("Hola mundo. Soy " + NombreUsuario + ", mi género es " + Sexo + " y este es mi primer programa en lenguaje C#");
        }

        //---------------------------------------------------------------------
        //Llena los datos de prueba en el grid.
        //---------------------------------------------------------------------
        private void BtnLlenar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                DgvCarrito.Rows.Add();
                DgvCarrito.Rows[i].Cells[0].Value = (i + 1);
                DgvCarrito.Rows[i].Cells[1].Value = "Producto " + (i + 1);
                DgvCarrito.Rows[i].Cells[2].Value = 1;
                DgvCarrito.Rows[i].Cells[3].Value = 2;
            }
        }

        //---------------------------------------------------------------------
        //Calcula la paqutería de envío.
        //---------------------------------------------------------------------
        private void BtnCalcularEnvio_Click(object sender, EventArgs e)
        {
            double PesoTotal = 0;
            int NumItems = DgvCarrito.Rows.Count - 1;
            int i = 0;

            while (i < NumItems)
            {
                int Cantidad = 0;
                double PesoUnitario = 0;

                Cantidad = Convert.ToInt32(DgvCarrito.Rows[i].Cells[2].Value);
                PesoUnitario = Convert.ToDouble(DgvCarrito.Rows[i].Cells[3].Value);

                PesoTotal = PesoTotal + (Cantidad * PesoUnitario);
                i++;
            }

            MessageBox.Show("El peso total es de " + PesoTotal.ToString() + " kg.");
        }

        //---------------------------------------------------------------------
        //Limpia caja de texto.
        //---------------------------------------------------------------------
        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
        }
    }
}
