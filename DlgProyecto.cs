using System;
using System.Windows.Forms;

namespace PE22A
{
    //---------------------------------------------------------------------
    //Diálogo del proyecto final de la materia Programación Estructurada.
    //CFAC. 07/03/2022.
    //---------------------------------------------------------------------
    public partial class DlgProyecto : Form
    {
        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgProyecto()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------
        //Obtiene un dato de un producto determinado desde la tabal de productos.
        //---------------------------------------------------------------------
        private string GetDatoProducto(string Producto, string NombreColumna)
        {
            string Resultado = null;

            for (int i = 0; i < DgvTblProductos.Rows.Count - 1; i++)
            {
                if (Producto == DgvTblProductos.Rows[i].Cells[0].Value.ToString())
                {
                    Resultado = DgvTblProductos.Rows[i].Cells[NombreColumna].Value.ToString();
                    break;
                }
            }

            return Resultado;
        }

        //---------------------------------------------------------------------
        //Limpia los datos de los TextBoxs.
        //---------------------------------------------------------------------
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtAlto.Text = "";
            TxtAncho.Text = "";
            TxtLargo.Text = "";
            TxtPeso.Text = "";
            TxtFragilidad.Text = "";
        }

        //---------------------------------------------------------------------
        //Llena los datos de prueba en el grid de Carrito.
        //---------------------------------------------------------------------
        private void BtnLlenarCarrito_Click(object sender, EventArgs e)
        {
            DgvCarrito.Rows.Clear();
            for (int i = 0; i < 4; i++)
            {
                DgvCarrito.Rows.Add();
                DgvCarrito.Rows[i].Cells[0].Value = "Producto " + (i + 1);
            }

            //Producto 1.
            DgvCarrito.Rows[0].Cells[1].Value = 1;//Cantidad.

            //Producto 2.
            DgvCarrito.Rows[1].Cells[1].Value = 1;//Cantidad.

            //Producto 3.
            DgvCarrito.Rows[2].Cells[1].Value = 2;//Cantidad.

            //Producto 4.
            DgvCarrito.Rows[3].Cells[1].Value = 2;//Cantidad.

        }

        //---------------------------------------------------------------------
        //Llena los datos de prueba en el grid TblProductos.
        //---------------------------------------------------------------------
        private void BtnLlenarTblProductos_Click(object sender, EventArgs e)
        {
            DgvTblProductos.Rows.Clear();
            for (int i = 0; i < 4; i++)
            {
                DgvTblProductos.Rows.Add();
                DgvTblProductos.Rows[i].Cells[0].Value = "Producto " + (i + 1);

                switch (i)
                {
                    case 0:
                        //Producto 1.
                        DgvTblProductos.Rows[0].Cells[1].Value = 2;//Alto.
                        DgvTblProductos.Rows[0].Cells[2].Value = 2;//Ancho.
                        DgvTblProductos.Rows[0].Cells[3].Value = 2;//Largo.
                        DgvTblProductos.Rows[0].Cells[4].Value = 0.2;//Peso.
                        DgvTblProductos.Rows[0].Cells[5].Value = 3;//Fragilidad.
                        break;

                    case 1:
                        //Producto 2.
                        DgvTblProductos.Rows[1].Cells[1].Value = 5;//Alto.
                        DgvTblProductos.Rows[1].Cells[2].Value = 3;//Ancho.
                        DgvTblProductos.Rows[1].Cells[3].Value = 2;//Largo.
                        DgvTblProductos.Rows[1].Cells[4].Value = 0.5;//Peso.
                        DgvTblProductos.Rows[1].Cells[5].Value = 1;//Fragilidad.
                        break;

                    case 2:
                        //Producto 3.
                        DgvTblProductos.Rows[2].Cells[1].Value = 1;//Alto.
                        DgvTblProductos.Rows[2].Cells[2].Value = 2;//Ancho.
                        DgvTblProductos.Rows[2].Cells[3].Value = 3;//Largo.
                        DgvTblProductos.Rows[2].Cells[4].Value = 1.0;//Peso.
                        DgvTblProductos.Rows[2].Cells[5].Value = 1;//Fragilidad.
                        break;

                    case 3:
                        //Producto 4.
                        DgvTblProductos.Rows[3].Cells[1].Value = 6;//Alto.
                        DgvTblProductos.Rows[3].Cells[2].Value = 8;//Ancho.
                        DgvTblProductos.Rows[3].Cells[3].Value = 10;//Largo.
                        DgvTblProductos.Rows[3].Cells[4].Value = 1.1;//Peso.
                        DgvTblProductos.Rows[3].Cells[5].Value = 2;//Fragilidad.
                        break;
                }
            }
        }

        //---------------------------------------------------------------------
        //Calcular el peso total, la fragilidad máxima y dimensiones del paquete.
        //---------------------------------------------------------------------
        private void BtnCalcularCaja_Click(object sender, EventArgs e)
        {
            double PesoTotal = 0;
            int FragilidadFinal = 0;
            int NumItems = DgvCarrito.Rows.Count - 1;
            int i = 0;

            while (i < NumItems)
            {
                string Producto = DgvTblProductos.Rows[i].Cells[0].Value.ToString();//Almacena el Producto y lo convierte a caddena.
                int Cantidad = Convert.ToInt32(DgvCarrito.Rows[i].Cells[1].Value);//Almacena la cantidad y la convierte a entero.
                int Alto = Convert.ToInt32(GetDatoProducto(Producto, "ColAlto"));//Obtiene y almacena el Alto y lo convierte en entero.
                int Ancho = Convert.ToInt32(GetDatoProducto(Producto, "ColAncho"));//Obtiene y almacena el Ancho y lo convierte a entero.
                int Largo = Convert.ToInt32(GetDatoProducto(Producto, "ColLargo"));//Obtiene y almacena el Largo y lo convierte a entero.
                double Peso = Convert.ToDouble(GetDatoProducto(Producto, "ColPeso"));//Obtiene y almacena el Peso y lo convierte a doble.
                int Fragilidad = Convert.ToInt32(GetDatoProducto(Producto, "ColFragilidad"));//Obtiene y almacena la fragilidad y lo convierte a entero.


                PesoTotal = PesoTotal + (Cantidad * Peso);//Acumulación del peso total.

                if (Fragilidad > FragilidadFinal)//Comparación de nivel de fragilidad.
                {
                    FragilidadFinal = Fragilidad;
                }

                i++;
            }

            TxtPeso.Text = PesoTotal.ToString() + " Kg.";//Mostrar el peso total en el TxtPeso.

            switch (FragilidadFinal)//Selección de casos para niveles de fragilidad.
            {
                case 1:
                    TxtFragilidad.Text = "No frágil ( " + FragilidadFinal.ToString() + " )";//Mostrar la fragilidad (1) en el TxtFragilidad.
                    break;

                case 2:
                    TxtFragilidad.Text = "Frágil ( " + FragilidadFinal.ToString() + " )";//Mostrar la fragilidad (2) en el TxtFragilidad.
                    break;

                case 3:
                    TxtFragilidad.Text = "Muy frágil ( " + FragilidadFinal.ToString() + " )";//Mostrar la fragilidad (3) en el TxtFragilidad.
                    break;

                default:
                    TxtFragilidad.Text = "Nivel de frágilidad no existente";//Mostrar la fragilidad no existente en el TxtFragilidad.
                    break;
            }

            TxtAlto.Text = " 0 M";
            TxtAncho.Text = " 0 M";
            TxtLargo.Text = " 0 M";
        }

        //---------------------------------------------------------------------
        //Limpia los datos del carrito de compras.
        //---------------------------------------------------------------------
        private void BtnLimpiarDatosCarrito_Click(object sender, EventArgs e)
        {
            DgvCarrito.Rows.Clear();
        }

        //---------------------------------------------------------------------
        //Limpia los datos de la tabla de productos.
        //---------------------------------------------------------------------
        private void BtnLimpiarDatosTblProductos_Click(object sender, EventArgs e)
        {
            DgvTblProductos.Rows.Clear();
        }
    }
}
