using System;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing.Imaging;
using TextBox = System.Windows.Forms.TextBox;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml;
using System.IO;

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
        //Terminar la ejecución.
        //---------------------------------------------------------------------
        private void TsmiSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        #region Practica 2
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Practica 2.                                                                +
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //---------------------------------------------------------------------
        //Obtiene un dato de un producto determinado desde la tabla de productos.
        //---------------------------------------------------------------------
        private string GetDatoProducto(string Producto, string NombreColumna)
        {
            string Resultado = null;

            for (int i = 0; i < DgvP2TblProductos.Rows.Count - 1; i++)
            {
                if (Producto == DgvP2TblProductos.Rows[i].Cells[0].Value.ToString())
                {
                    Resultado = DgvP2TblProductos.Rows[i].Cells[NombreColumna].Value.ToString();
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
            TxtP2Alto.Text = "";
            TxtP2Ancho.Text = "";
            TxtP2Largo.Text = "";
            TxtP2Peso.Text = "";
            TxtP2Fragilidad.Text = "";
        }

        //---------------------------------------------------------------------
        //Llena los datos de prueba en el grid de Carrito.
        //---------------------------------------------------------------------
        private void BtnLlenarCarrito_Click(object sender, EventArgs e)
        {
            DgvP2Carrito.Rows.Clear();
            for (int i = 0; i < 4; i++)
            {
                DgvP2Carrito.Rows.Add();
                DgvP2Carrito.Rows[i].Cells[0].Value = "Producto " + (i + 1);
            }

            //Producto 1.
            DgvP2Carrito.Rows[0].Cells[1].Value = 1;//Cantidad.

            //Producto 2.
            DgvP2Carrito.Rows[1].Cells[1].Value = 1;//Cantidad.

            //Producto 3.
            DgvP2Carrito.Rows[2].Cells[1].Value = 2;//Cantidad.

            //Producto 4.
            DgvP2Carrito.Rows[3].Cells[1].Value = 2;//Cantidad.

        }

        //---------------------------------------------------------------------
        //Llena los datos de prueba en el grid TblProductos.
        //---------------------------------------------------------------------
        private void BtnLlenarTblProductos_Click(object sender, EventArgs e)
        {
            DgvP2TblProductos.Rows.Clear();
            for (int i = 0; i < 4; i++)
            {
                DgvP2TblProductos.Rows.Add();
                DgvP2TblProductos.Rows[i].Cells[0].Value = "Producto " + (i + 1);

                switch (i)
                {
                    case 0:
                        //Producto 1.
                        DgvP2TblProductos.Rows[0].Cells[1].Value = 2;//Alto.
                        DgvP2TblProductos.Rows[0].Cells[2].Value = 2;//Ancho.
                        DgvP2TblProductos.Rows[0].Cells[3].Value = 2;//Largo.
                        DgvP2TblProductos.Rows[0].Cells[4].Value = 0.2;//Peso.
                        DgvP2TblProductos.Rows[0].Cells[5].Value = 3;//Fragilidad.
                        break;

                    case 1:
                        //Producto 2.
                        DgvP2TblProductos.Rows[1].Cells[1].Value = 5;//Alto.
                        DgvP2TblProductos.Rows[1].Cells[2].Value = 3;//Ancho.
                        DgvP2TblProductos.Rows[1].Cells[3].Value = 2;//Largo.
                        DgvP2TblProductos.Rows[1].Cells[4].Value = 0.5;//Peso.
                        DgvP2TblProductos.Rows[1].Cells[5].Value = 1;//Fragilidad.
                        break;

                    case 2:
                        //Producto 3.
                        DgvP2TblProductos.Rows[2].Cells[1].Value = 1;//Alto.
                        DgvP2TblProductos.Rows[2].Cells[2].Value = 2;//Ancho.
                        DgvP2TblProductos.Rows[2].Cells[3].Value = 3;//Largo.
                        DgvP2TblProductos.Rows[2].Cells[4].Value = 1.0;//Peso.
                        DgvP2TblProductos.Rows[2].Cells[5].Value = 1;//Fragilidad.
                        break;

                    case 3:
                        //Producto 4.
                        DgvP2TblProductos.Rows[3].Cells[1].Value = 6;//Alto.
                        DgvP2TblProductos.Rows[3].Cells[2].Value = 8;//Ancho.
                        DgvP2TblProductos.Rows[3].Cells[3].Value = 10;//Largo.
                        DgvP2TblProductos.Rows[3].Cells[4].Value = 1.1;//Peso.
                        DgvP2TblProductos.Rows[3].Cells[5].Value = 2;//Fragilidad.
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
            double AltoTotal = 0;
            double AnchoTotal = 0;
            double LargoTotal = 0;
            int NumItems = DgvP2Carrito.Rows.Count - 1;
            int i = 0;

            while (i < NumItems)
            {
                string Producto;
                int Cantidad;
                double Alto;
                double Ancho;
                double Largo;
                double Peso;
                int Fragilidad;

                //--- Carrito de compras ---

                //Validación de la referencia o nombre del producto.
                if (DgvP2Carrito.Rows[i].Cells[0].Value == null)
                {
                    DgvP2Carrito.ClearSelection();
                    MessageBox.Show("Ingrese la referencia del producto");
                    DgvP2Carrito.Rows[i].Cells[0].Selected = true;
                    return;
                }

                //Validación de la cantidad (Vacio).
                if (DgvP2Carrito.Rows[i].Cells[1].Value == null)
                {
                    DgvP2Carrito.ClearSelection();
                    MessageBox.Show("Ingrese la cantidad del producto");
                    DgvP2Carrito.Rows[i].Cells[1].Selected = true;
                    return;
                }

                //Validación de la cantidad (Caracteres).
                if (!Int32.TryParse(DgvP2Carrito.Rows[i].Cells[1].Value.ToString(), out Cantidad))
                {
                    DgvP2Carrito.ClearSelection();
                    MessageBox.Show("Ingrese la cantidad del producto");
                    DgvP2Carrito.Rows[i].Cells[1].Selected = true;
                    return;
                }

                //--- Tabla de productos ---

                //Validación de la referencia o nombre del producto.
                if (DgvP2TblProductos.Rows[i].Cells[0].Value == null)
                {
                    DgvP2TblProductos.ClearSelection();
                    MessageBox.Show("Ingrese la referencia del producto");
                    DgvP2TblProductos.Rows[i].Cells[0].Selected = true;
                    return;
                }

                //Validación del Alto del producto.
                if (DgvP2TblProductos.Rows[i].Cells[1].Value == null)
                {
                    DgvP2TblProductos.ClearSelection();
                    MessageBox.Show("Ingrese el alto del producto");
                    DgvP2TblProductos.Rows[i].Cells[1].Selected = true;
                    return;
                }

                //Validación del Alto (Caracteres).
                if (!Double.TryParse(DgvP2TblProductos.Rows[i].Cells[1].Value.ToString(), out Alto))
                {
                    DgvP2TblProductos.ClearSelection();
                    MessageBox.Show("Ingrese un valor numérico del producto");
                    DgvP2TblProductos.Rows[i].Cells[1].Selected = true;
                    return;
                }

                //Validación del Ancho del producto.
                if (DgvP2TblProductos.Rows[i].Cells[2].Value == null)
                {
                    DgvP2TblProductos.ClearSelection();
                    MessageBox.Show("Ingrese el ancho del producto");
                    DgvP2TblProductos.Rows[i].Cells[2].Selected = true;
                    return;
                }

                //Validación del Ancho (Caracteres).
                if (!Double.TryParse(DgvP2TblProductos.Rows[i].Cells[2].Value.ToString(), out Ancho))
                {
                    DgvP2TblProductos.ClearSelection();
                    MessageBox.Show("Ingrese un valor numérico del producto");
                    DgvP2TblProductos.Rows[i].Cells[2].Selected = true;
                    return;
                }

                //Validación del Largo del producto.
                if (DgvP2TblProductos.Rows[i].Cells[3].Value == null)
                {
                    DgvP2TblProductos.ClearSelection();
                    MessageBox.Show("Ingrese el largo del producto");
                    DgvP2TblProductos.Rows[i].Cells[3].Selected = true;
                    return;
                }

                //Validación del Largo (Caracteres).
                if (!Double.TryParse(DgvP2TblProductos.Rows[i].Cells[3].Value.ToString(), out Largo))
                {
                    DgvP2TblProductos.ClearSelection();
                    MessageBox.Show("Ingrese un valor numérico del producto");
                    DgvP2TblProductos.Rows[i].Cells[3].Selected = true;
                    return;
                }

                //Validación del Peso del producto.
                if (DgvP2TblProductos.Rows[i].Cells[4].Value == null)
                {
                    DgvP2TblProductos.ClearSelection();
                    MessageBox.Show("Ingrese el peso del producto");
                    DgvP2TblProductos.Rows[i].Cells[4].Selected = true;
                    return;
                }

                //Validación del Peso (Caracteres).
                if (!Double.TryParse(DgvP2TblProductos.Rows[i].Cells[4].Value.ToString(), out Peso))
                {
                    DgvP2TblProductos.ClearSelection();
                    MessageBox.Show("Ingrese un valor numérico del producto");
                    DgvP2TblProductos.Rows[i].Cells[4].Selected = true;
                    return;
                }

                //Validación de la fragilidad del producto.
                if (DgvP2TblProductos.Rows[i].Cells[5].Value == null)
                {
                    DgvP2TblProductos.ClearSelection();
                    MessageBox.Show("Ingrese la fragilidad del producto");
                    DgvP2TblProductos.Rows[i].Cells[5].Selected = true;
                    return;
                }

                //Validación de la fragilidad (Caracteres).
                if (!Int32.TryParse(DgvP2TblProductos.Rows[i].Cells[5].Value.ToString(), out Fragilidad))
                {
                    DgvP2TblProductos.ClearSelection();
                    MessageBox.Show("Ingrese un valor numérico del producto");
                    DgvP2TblProductos.Rows[i].Cells[5].Selected = true;
                    return;
                }

                Producto = DgvP2Carrito.Rows[i].Cells[0].Value.ToString();//Almacena el Producto y lo convierte a caddena.
                Cantidad = Convert.ToInt32(DgvP2Carrito.Rows[i].Cells[1].Value);//Almacena la cantidad y la convierte a entero.
                Alto = Convert.ToDouble(GetDatoProducto(Producto, "ColAlto"));//Obtiene y almacena el Alto y lo convierte en entero.
                Ancho = Convert.ToDouble(GetDatoProducto(Producto, "ColAncho"));//Obtiene y almacena el Ancho y lo convierte a entero.
                Largo = Convert.ToDouble(GetDatoProducto(Producto, "ColLargo"));//Obtiene y almacena el Largo y lo convierte a entero.
                Peso = Convert.ToDouble(GetDatoProducto(Producto, "ColPeso"));//Obtiene y almacena el Peso y lo convierte a doble.
                Fragilidad = Convert.ToInt32(GetDatoProducto(Producto, "ColFragilidad"));//Obtiene y almacena la fragilidad y lo convierte a entero.

                PesoTotal = PesoTotal + (Cantidad * Peso);//Acumulación del peso total.

                if (Fragilidad > FragilidadFinal)//Comparación de nivel de fragilidad.
                {
                    FragilidadFinal = Fragilidad;
                }

                if (Alto > Ancho && Alto > Largo)
                {
                    AltoTotal = Alto;
                    AnchoTotal += Cantidad * Ancho;
                    LargoTotal += Cantidad * Largo;
                }

                if (Ancho > Alto && Ancho > Largo)
                {
                    AnchoTotal = Ancho;
                    AltoTotal += Cantidad * Ancho;
                    LargoTotal += Cantidad * Largo;
                }

                if (Largo > Ancho && Largo > Alto)
                {
                    LargoTotal = Largo;
                    AnchoTotal += Cantidad * Ancho;
                    AltoTotal += Cantidad * Alto;
                }

                else
                {
                    AltoTotal += Cantidad * Alto;
                    AnchoTotal += Cantidad * Ancho;
                    LargoTotal += Cantidad * Largo;
                }

                i++;
            }

            TxtP2Peso.Text = PesoTotal.ToString() + " Kg.";//Mostrar el peso total en el TxtPeso.

            switch (FragilidadFinal)//Selección de casos para niveles de fragilidad.
            {
                case 1:
                    TxtP2Fragilidad.Text = "No frágil ( " + FragilidadFinal.ToString() + " )";//Mostrar la fragilidad (1) en el TxtFragilidad.
                    break;

                case 2:
                    TxtP2Fragilidad.Text = "Frágil ( " + FragilidadFinal.ToString() + " )";//Mostrar la fragilidad (2) en el TxtFragilidad.
                    break;

                case 3:
                    TxtP2Fragilidad.Text = "Muy frágil ( " + FragilidadFinal.ToString() + " )";//Mostrar la fragilidad (3) en el TxtFragilidad.
                    break;

                default:
                    TxtP2Fragilidad.Text = "Nivel de frágilidad no existente";//Mostrar la fragilidad no existente en el TxtFragilidad.
                    break;
            }

            TxtP2Alto.Text = $"{AltoTotal} Cm.";
            TxtP2Ancho.Text = $"{AnchoTotal} Cm.";
            TxtP2Largo.Text = $"{LargoTotal} Cm.";
        }

        //---------------------------------------------------------------------
        //Limpia los datos del carrito de compras.
        //---------------------------------------------------------------------
        private void BtnLimpiarDatosCarrito_Click(object sender, EventArgs e)
        {
            DgvP2Carrito.Rows.Clear();
        }
        #endregion

        #region Practica 3
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Practica 3.                                                                +
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //---------------------------------------------------------------------
        //Calcular VP.
        //---------------------------------------------------------------------
        private double CalcularValorPresente(double[] ValorFuturo, int Año, double TasaDeDescuento)
        {
            double VP = 0;
            TasaDeDescuento = TasaDeDescuento * 0.01;

            for (int i = 0; i < Año; i++)
            {
                VP += (ValorFuturo[i] / Math.Pow((1 + TasaDeDescuento), (i + 1)));
            }

            return VP;
        }

        //---------------------------------------------------------------------
        //Limpia los datos de la tabla de productos.
        //---------------------------------------------------------------------
        private void BtnLimpiarDatosTblProductos_Click(object sender, EventArgs e)
        {
            DgvP2TblProductos.Rows.Clear();
        }

        //---------------------------------------------------------------------
        //Llena los datos de prueba de los flujos de efectivo..
        //---------------------------------------------------------------------
        private void BtnLlenarP3_Click(object sender, EventArgs e)
        {
            DgvP3FlujosNetos.Rows.Clear();
            for (int i = 0; i <= 4; i++)
            {
                DgvP3FlujosNetos.Rows.Add();
                DgvP3FlujosNetos.Rows[i].Cells[0].Value = "Año " + (i + 1);
                DgvP3FlujosNetos.Rows[i].Cells[1].Value = "1000";
            }
        }

        //---------------------------------------------------------------------
        //Calcula el valor presente neto de un proyecto de inversión.
        //---------------------------------------------------------------------
        private void BtnVPN_Click(object sender, EventArgs e)
        {
            int i = 0;
            int FlujosNetos = DgvP3FlujosNetos.Rows.Count;
            double InversionInicial;
            double TMAR;
            double[] FlujosDeEfectivo = new double[FlujosNetos];
            double Salida;

            //Validación de vacio.
            if (TxtP3InversionInicial.Text == "")
            {
                MessageBox.Show("Capture la inversión inicial.");
                return;
            }

            //Validación de valor númerico.
            if (!double.TryParse(TxtP3InversionInicial.Text, out Salida))
            {
                MessageBox.Show("Capture un valor númerico.");
                TxtP3InversionInicial.Focus();
                return;
            }

            //Validación de vacio.
            if (TxtP3TMAR.Text == "")
            {
                MessageBox.Show("Capture la tasa mímima aceptable de rendimiento.");
                return;
            }

            //Validación de valor númerico.
            if (!double.TryParse(TxtP3TMAR.Text, out Salida))
            {
                MessageBox.Show("Capture un valor númerico.");
                TxtP3TMAR.Focus();
                return;
            }

            InversionInicial = Convert.ToDouble(TxtP3InversionInicial.Text);
            TMAR = Convert.ToDouble(TxtP3TMAR.Text);

            while (i < DgvP3FlujosNetos.Rows.Count - 1)
            {
                if (DgvP3FlujosNetos.Rows[i].Cells[1].Value == null)
                {
                    DgvP3FlujosNetos.ClearSelection();
                    MessageBox.Show("Capture un flujo de efectivo en el " + DgvP3FlujosNetos.Rows[i].Cells[0].Value.ToString());
                    DgvP3FlujosNetos.Rows[i].Cells[1].Selected = true;
                    return;
                }

                if (!Double.TryParse(DgvP3FlujosNetos.Rows[i].Cells[1].Value.ToString(), out Salida))
                {
                    DgvP3FlujosNetos.ClearSelection();
                    MessageBox.Show("Capture valor numérico en el " + DgvP3FlujosNetos.Rows[i].Cells[0].Value.ToString());
                    DgvP3FlujosNetos.Rows[i].Cells[1].Selected = true;
                    return;
                }

                FlujosDeEfectivo[i] = Convert.ToDouble(DgvP3FlujosNetos.Rows[i].Cells[1].Value);
                i++;
            }

            double VPN = CalcularValorPresente(FlujosDeEfectivo, FlujosNetos, TMAR) - InversionInicial;

            VPN = Math.Truncate(VPN * 100) / 100;

            if (VPN > 0)
            {
                TxtP3Decision.ForeColor = Color.Green;
                TxtP3Decision.BackColor = Color.LightGreen;
                TxtP3Decision.Text = "Factible";
                TxtP3Resultado.ForeColor = Color.Green;
                TxtP3Resultado.BackColor = Color.LightGreen;
            }

            else if (VPN < 0)
            {
                TxtP3Decision.ForeColor = Color.DarkRed;
                TxtP3Decision.BackColor = Color.MediumVioletRed;
                TxtP3Decision.Text = "No factible";
                TxtP3Resultado.ForeColor = Color.DarkRed;
                TxtP3Resultado.BackColor = Color.MediumVioletRed;
            }

            else if (Math.Round(VPN, 2) == 0)
            {
                TxtP3Decision.ForeColor = Color.Yellow;
                TxtP3Decision.BackColor = Color.MediumVioletRed;
                TxtP3Decision.Text = "Indiferente";
                TxtP3Resultado.ForeColor = Color.Yellow;
                TxtP3Resultado.BackColor = Color.MediumVioletRed;
            }

            TxtP3Resultado.Text = $"$ {VPN.ToString()}";
        }

        //---------------------------------------------------------------------
        //Limpia los datos de la tabla de Flujos netos y los TextBoxs.
        //---------------------------------------------------------------------
        private void BtnP3Limpiar_Click(object sender, EventArgs e)
        {
            TxtP3InversionInicial.Text = "0";
            TxtP3TMAR.Text = "0";
            TxtP3Resultado.ForeColor = Color.Black;
            TxtP3Resultado.Text = "$0";
            TxtP3Decision.Text = "";
            DgvP3FlujosNetos.Rows.Clear();
            TxtP3Decision.ForeColor = Color.Black;
            TxtP3Decision.BackColor = Color.White;
            TxtP3Resultado.ForeColor = Color.Black;
            TxtP3Resultado.BackColor = Color.White;
        }
        #endregion

        #region Practica 4
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Practica 4.                                                                +
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //---------------------------------------------------------------------
        //Limpia los datos espaciales y el polígono dibujado.
        //---------------------------------------------------------------------
        private void BtnP4Limpiar_Click(object sender, EventArgs e)
        {
            DgvP4DatosEspaciales.Rows.Clear();
            CbxP4Terrenos.SelectedIndex = -1;
            TpgPractica4.CreateGraphics().Clear(Color.White);
        }

        //---------------------------------------------------------------------
        //Llena datos de prueba según el terreno seleccionado.
        //---------------------------------------------------------------------
        private void CbxP4Terrenos_SelectedIndexChanged(object sender, EventArgs e)
        {
            DgvP4DatosEspaciales.Rows.Clear();

            switch (CbxP4Terrenos.SelectedIndex)
            {
                case 0:
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[0].Cells[0].Value = 1;
                    DgvP4DatosEspaciales.Rows[0].Cells[1].Value = 0;
                    DgvP4DatosEspaciales.Rows[0].Cells[2].Value = 0;
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[1].Cells[0].Value = 2;
                    DgvP4DatosEspaciales.Rows[1].Cells[1].Value = 0;
                    DgvP4DatosEspaciales.Rows[1].Cells[2].Value = 200;
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[2].Cells[0].Value = 3;
                    DgvP4DatosEspaciales.Rows[2].Cells[1].Value = 600;
                    DgvP4DatosEspaciales.Rows[2].Cells[2].Value = 200;
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[3].Cells[0].Value = 4;
                    DgvP4DatosEspaciales.Rows[3].Cells[1].Value = 600;
                    DgvP4DatosEspaciales.Rows[3].Cells[2].Value = 0;
                    break;

                case 1:
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[0].Cells[0].Value = 1;
                    DgvP4DatosEspaciales.Rows[0].Cells[1].Value = 0;
                    DgvP4DatosEspaciales.Rows[0].Cells[2].Value = 0;
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[1].Cells[0].Value = 2;
                    DgvP4DatosEspaciales.Rows[1].Cells[1].Value = 0;
                    DgvP4DatosEspaciales.Rows[1].Cells[2].Value = 200;
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[2].Cells[0].Value = 3;
                    DgvP4DatosEspaciales.Rows[2].Cells[1].Value = 600;
                    DgvP4DatosEspaciales.Rows[2].Cells[2].Value = 200;
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[3].Cells[0].Value = 4;
                    DgvP4DatosEspaciales.Rows[3].Cells[1].Value = 0;
                    DgvP4DatosEspaciales.Rows[3].Cells[2].Value = 0;
                    break;

                case 2:
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[0].Cells[0].Value = 1;
                    DgvP4DatosEspaciales.Rows[0].Cells[1].Value = 0;
                    DgvP4DatosEspaciales.Rows[0].Cells[2].Value = 0;
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[1].Cells[0].Value = 2;
                    DgvP4DatosEspaciales.Rows[1].Cells[1].Value = 20;
                    DgvP4DatosEspaciales.Rows[1].Cells[2].Value = 55;
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[2].Cells[0].Value = 2;
                    DgvP4DatosEspaciales.Rows[2].Cells[1].Value = 10;
                    DgvP4DatosEspaciales.Rows[2].Cells[2].Value = 72;
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[3].Cells[0].Value = 4;
                    DgvP4DatosEspaciales.Rows[3].Cells[1].Value = 60;
                    DgvP4DatosEspaciales.Rows[3].Cells[2].Value = 131;
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[4].Cells[0].Value = 5;
                    DgvP4DatosEspaciales.Rows[4].Cells[1].Value = 180;
                    DgvP4DatosEspaciales.Rows[4].Cells[2].Value = 153;
                    break;

                case 3:
                    for (int i = 0; i < 5; i++)
                    {
                        DgvP4DatosEspaciales.Rows.Add();
                        DgvP4DatosEspaciales.Rows[i].Cells[0].Value = i + 1;
                        DgvP4DatosEspaciales.Rows[i].Cells[1].Value = "44";
                        DgvP4DatosEspaciales.Rows[i].Cells[2].Value = "55";
                    }
                    break;
            }
            DibujaPoligono(20,350);
        }

        //---------------------------------------------------------------------
        //Dibuja el polígono a partir de los datos de la tabla.
        //---------------------------------------------------------------------
        private void DibujaPoligono(int Xorigen, int Yorigen)
        {
            //Limpiar para cambiar de figuras.
            TpgPractica4.CreateGraphics().Clear(Color.White);

            //Declaración de valiables.
            System.Drawing.Point[] Puntos;
            Pen Lapiz;
            Graphics Lienzo;

            if (DgvP4DatosEspaciales.Rows[0].Cells[0].Value == null)
            {
                return;
            }

            //Creación de puntos.
            Puntos = new System.Drawing.Point[DgvP4DatosEspaciales.Rows.Count];

            for (int i = 0; i < DgvP4DatosEspaciales.Rows.Count - 1; i++)
            {
                Puntos[i].X = Convert.ToInt32(DgvP4DatosEspaciales.Rows[i].Cells[1].Value) * Convert.ToInt32(NudP4Zoom.Value); //+ Xorigen;
                Puntos[i].Y = Convert.ToInt32(DgvP4DatosEspaciales.Rows[i].Cells[2].Value) * Convert.ToInt32(NudP4Zoom.Value); //+ Yorigen;
            }

            //Construcción de objetos de dibujo.
            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(0,255), rnd.Next(0,255),rnd.Next(0,255));
            Lapiz = new Pen(randomColor, 2);
            Lienzo = TpgPractica4.CreateGraphics();

            //Dibuja polígono.
            GraphicsContainer Gc = Lienzo.BeginContainer();
            Lienzo.ScaleTransform(1.0f, -1.0f);
            Lienzo.TranslateTransform(Xorigen, -(float)Yorigen);
            Lienzo.SmoothingMode = SmoothingMode.AntiAlias;
            Lienzo.DrawPolygon(Lapiz, Puntos);
            Lienzo.FillPolygon(new SolidBrush(randomColor), Puntos);
            Lienzo.EndContainer(Gc);
        }

        //---------------------------------------------------------------------
        //Dibuja el polígono a partir de los datos de la tabla.
        //---------------------------------------------------------------------
        private void BtnP4Actualizar_Click(object sender, EventArgs e)
        {
            DibujaPoligono(20,350);
        }   

        //---------------------------------------------------------------------
        //Metodo para cambiar la posición de la figura con mouse.
        //---------------------------------------------------------------------
        private void TpgPractica4_MouseMove(object sender, MouseEventArgs e)
        {
            int x;
            int y;

            x = e.X;
            y = e.Y;

            DibujaPoligono(x, y);
        }

        //---------------------------------------------------------------------
        //Metodo para cambiar la posición de la figura con clic.
        //---------------------------------------------------------------------
        private void TpgPractica4_MouseClick(object sender, MouseEventArgs e)
        {
            int x;
            int y;

            x = e.X;
            y = e.Y;

            DibujaPoligono(x,y);
        }
        #endregion

        #region Practica 5
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Practica 5.                                                                +
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //Objetos graficos.
        Graphics Plano, Plano1;
        Pen Lapiz, Lapiz1, Lapiz2;
        Random rnd;
        Color[] puntosColores;

        //---------------------------------------------------------------------
        //Metodos de validación para números en el DgvDatos.
        //---------------------------------------------------------------------
        private void DgvDatos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var dgv = (sender as DataGridView);
            if (dgv.Columns[dgv.CurrentCell.ColumnIndex].Name == "ColVectores" ||
                dgv.Columns[dgv.CurrentCell.ColumnIndex].Name == "ColLongitud" ||
                dgv.Columns[dgv.CurrentCell.ColumnIndex].Name == "ColAngulo")
            {
                TextBox cell = (TextBox)e.Control;

                cell.KeyPress -= new KeyPressEventHandler(this.DgvDatos_KeyPress);
                cell.KeyPress += new KeyPressEventHandler(this.DgvDatos_KeyPress);
            }
        }

        //---------------------------------------------------------------------
        //Metodos de validación para números en el DgvDatos.
        //---------------------------------------------------------------------
        private void DgvDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = (TextBox)sender;
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        //---------------------------------------------------------------------
        //Dibuja plano cartesiano.
        //---------------------------------------------------------------------
        private void BtnP5DibubarPlano_Click(object sender, EventArgs e)
        {
            //LimpiarP5();
            LblP5Y.Text = "Y";
            LblP5X.Text = "X   ";
            Plano1 = PtbP5Lienzo.CreateGraphics();
            Lapiz1 = new Pen(Color.Black, 4);
            Lapiz2 = new Pen(Color.Red, 4);
            int xcentro = PtbP5Lienzo.Width / 2;
            int ycentro = PtbP5Lienzo.Height / 2;
            Plano1.TranslateTransform(xcentro, ycentro);
            Plano1.ScaleTransform(1, -1);

            Plano1.DrawLine(Lapiz1, -xcentro, 0, xcentro * 2,0);//Horizontal
            Plano1.DrawLine(Lapiz1, 0, ycentro, 0, -ycentro);//Vertical

            //Graficar el interlineado de la grafica
            for (int i = -xcentro; i < xcentro; i += 10)
            {
                Plano1.DrawLine(Lapiz2, 5, i, -5, i);//Vertical
                Plano1.DrawLine(Lapiz2, i, 5, i, -5);//Horizontal
            }
        }

        //---------------------------------------------------------------------
        //Dibuja los vectores en el plano cartesiano.
        //---------------------------------------------------------------------
        private void BtnMarcarVectores_Click(object sender, EventArgs e)
        {
            //Variables.
            double x1, y1;
            double Angulo;
            int X, Y;
            int Longitud;
            rnd = new Random();
            int i = 0;
            int ContadorDataGrid = DgvP5Datos.Rows.Count - 1;

            //Validación.
            if (ContadorDataGrid == 0)
            {
                MessageBox.Show("Capture los datos en la tabla");
                return;
            }

            while (i < ContadorDataGrid)
            {
                if (DgvP5Datos.Rows[i].Cells[1].Value == null)
                {
                    DgvP5Datos.ClearSelection();
                    MessageBox.Show("Capture una Longitud en el vector " + DgvP5Datos.Rows[i].Cells[0].Value.ToString());
                    DgvP5Datos.Rows[i].Cells[1].Selected = true;
                    return;
                }

                if (DgvP5Datos.Rows[i].Cells[2].Value == null)
                {
                    DgvP5Datos.ClearSelection();
                    MessageBox.Show("Capture un Ángulo en el vector " + DgvP5Datos.Rows[i].Cells[0].Value.ToString());
                    DgvP5Datos.Rows[i].Cells[1].Selected = true;
                    return;
                }
                i++;
            }

            puntosColores = new Color[DgvP5Datos.Rows.Count];

            for (i = 0; i < DgvP5Datos.Rows.Count - 1; i++)
            {
                //Construcción de objetos de dibujo.
                puntosColores[i] = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                Plano = PtbP5Lienzo.CreateGraphics();
                Lapiz = new Pen(puntosColores[i], 4);

                //Parsear variables a sus respectivos tipos.
                int.TryParse(DgvP5Datos.Rows[i].Cells[1].Value.ToString(), out Longitud);
                double.TryParse(DgvP5Datos.Rows[i].Cells[2].Value.ToString(), out Angulo);

                //Invertir las coordenadas.
                Angulo = (Angulo * -1);
                Angulo = (Angulo * Math.PI) / 180;

                //
                x1 = Longitud * Math.Cos(Angulo);
                y1 = Longitud * Math.Sin(Angulo);

                //Convierte las posiciones X Y en enteras.
                X = Convert.ToInt32(x1);
                Y = Convert.ToInt32(y1);

                //Dibuja los vectores.
                Plano.SmoothingMode = SmoothingMode.AntiAlias;
                Plano.DrawLine(Lapiz, PtbP5Lienzo.Width / 2, PtbP5Lienzo.Height / 2, (X + PtbP5Lienzo.Width / 2), (Y + PtbP5Lienzo.Height / 2));
            }
        }

        //---------------------------------------------------------------------
        //Limpia los datos en la ventana.
        //---------------------------------------------------------------------
        private void LimpiarP5()
        {
            LblP5Y.Text = "";
            LblP5X.Text = "";
            LblP5Url.Text = "";
            DgvP5Datos.Rows.Clear();
            Plano = PtbP5Lienzo.CreateGraphics();
            Plano.Clear(Color.Aquamarine);
        }

        //---------------------------------------------------------------------
        //Botón para limpiar los datos en la ventana.
        //---------------------------------------------------------------------
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarP5();
        }

        //---------------------------------------------------------------------
        //Función para exportar a Excel.
        //---------------------------------------------------------------------

        private void ExportarExcel(DataGridView dataGrid)
        {
            Microsoft.Office.Interop.Excel.Application ExpoExcel = new Microsoft.Office.Interop.Excel.Application();
            ExpoExcel.Application.Workbooks.Add(true);

            int indexColumna = 0;
            foreach (DataGridViewColumn column in dataGrid.Columns)
            {
                indexColumna++;
                ExpoExcel.Cells[1, indexColumna] = column.Name;
            }

            int indexFila = 0;
            foreach (DataGridViewRow fila in dataGrid.Rows)
            {
                indexFila++;
                indexColumna = 0;
                foreach (DataGridViewColumn column in dataGrid.Columns)
                {
                    indexColumna++;
                    ExpoExcel.Cells[indexFila + 1, indexColumna] = fila.Cells[column.Name].Value;
                }
            }
            ExpoExcel.Visible = true;
        }
        //---------------------------------------------------------------------
        //Botón para exportar a Excel.
        //---------------------------------------------------------------------
        private void BtnP5Guardar_Click(object sender, EventArgs e)
        {
            //Variables.
            int i = 0;
            int ContadorDataGrid = DgvP5Datos.Rows.Count - 1;

            //Validación.
            while (i < ContadorDataGrid)
            {

                if (DgvP5Datos.Rows[i].Cells[1].Value == null)
                {
                    DgvP5Datos.ClearSelection();
                    MessageBox.Show("Capture una Longitud en el vector " + DgvP5Datos.Rows[i].Cells[0].Value.ToString());
                    DgvP5Datos.Rows[i].Cells[1].Selected = true;
                    return;
                }

                if (DgvP5Datos.Rows[i].Cells[2].Value == null)
                {
                    DgvP5Datos.ClearSelection();
                    MessageBox.Show("Capture un Ángulo en el vector " + DgvP5Datos.Rows[i].Cells[0].Value.ToString());
                    DgvP5Datos.Rows[i].Cells[1].Selected = true;
                    return;
                }

                i++;
            }

            if (ContadorDataGrid == 0)
            {
                MessageBox.Show("Capture los datos en la tabla");
            }

            else
            {
                ExportarExcel(DgvP5Datos);
            }
        }


        //---------------------------------------------------------------------
        //Botón para importar desde Excel.
        //---------------------------------------------------------------------
        private void BtnP5Abrir_Click(object sender, EventArgs e)
        {
            LimpiarP5();
            Microsoft.Office.Interop.Excel.Application application;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            Microsoft.Office.Interop.Excel.Range range;

            DialogResult Result;
            int filas;
            string NombreArchivo = string.Empty;

            OfdAbrirArchivo.Title = "Explorador de archivos";
            OfdAbrirArchivo.FileName = "Seleccionar";
            OfdAbrirArchivo.Filter = "Archivo de Excel | *.xls; *.xlsx";
            
            Result = OfdAbrirArchivo.ShowDialog();
            
            if (Result == DialogResult.OK)
            {
                NombreArchivo = OfdAbrirArchivo.FileName;
            }

            if (Result == DialogResult.Cancel ||
                Result == DialogResult.Abort)
            {
                return;
            }

            if (NombreArchivo != string.Empty)
            {
                application = new Microsoft.Office.Interop.Excel.Application();
                workbook = application.Workbooks.Open(NombreArchivo);
                worksheet = workbook.Worksheets["Hoja1"];
                range = worksheet.UsedRange;
                int i = 0;

                for (filas = 2; filas <= range.Rows.Count; filas++)
                {
                    i++;
                    DgvP5Datos.Rows.Add(i, range.Cells[filas,2].Text(), range.Cells[filas, 3].Text());
                }

                workbook.Close();
                application.Quit();
            }
        }

        //---------------------------------------------------------------------
        //Botón para guardar plano como png.
        //---------------------------------------------------------------------
        private void BtnGuardarPng_Click(object sender, EventArgs e)
        {
            // Nota: La construcción de la imagen fue con ayuda del compañero
            // Jorge Antonio Macias Zambrano y en su Git Hub está su función
            // que utilicé para mi botón guardar
            // https://github.com/Jorgemacias-12/PE22A-JAMZ/blob/master/DlgProyecto.cs
            // Linea 781 de la función

            int ContadorDataGrid = DgvP5Datos.Rows.Count - 1;

            //Validación.
            if (ContadorDataGrid == 0)
            {
                MessageBox.Show("Capture los datos en la tabla");
                return;
            }

            Graphics g, gg;
            Matrix matrix;
            Bitmap bitmap;

            bitmap = new Bitmap(Convert.ToInt32(1024), Convert.ToInt32(1024), PixelFormat.Format32bppArgb); // Inicialización de bitmap para guardar imagen
            matrix = new Matrix();
            g = Graphics.FromImage(bitmap);
            gg = Graphics.FromImage(bitmap);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            gg.SmoothingMode = SmoothingMode.AntiAlias;
            matrix.Scale(1, 1); // Escala nuestro dibujo
            g.Transform = matrix; // Transforma a la escala dada

            Lapiz1 = new Pen(Color.Black, 4);
            Lapiz2 = new Pen(Color.Red, 4);
            int xcentro = PtbP5Lienzo.Width / 2;
            int ycentro = PtbP5Lienzo.Height / 2;
            gg.TranslateTransform(xcentro, ycentro);
            gg.ScaleTransform(1, -1);

            gg.DrawLine(Lapiz1, -xcentro, 0, xcentro, 0);//Horizontal
            gg.DrawLine(Lapiz1, 0, ycentro, 0, -ycentro);//Vertical

            //Graficar el interlineado de la grafica
            for (int i = -xcentro; i < xcentro; i += 10)
            {
                gg.DrawLine(Lapiz2, 5, i, -5, i);//Vertical
                gg.DrawLine(Lapiz2, i, 5, i, -5);//Horizontal
            }

            puntosColores = new Color[DgvP5Datos.Rows.Count];
            double x1, y1;
            int X, Y;

            for (int i = 0; i < DgvP5Datos.Rows.Count - 1; i++)
            {
                //Construcción de objetos de dibujo.
                puntosColores[i] = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                Lapiz = new Pen(puntosColores[i], 4);

                //Parsear variables a sus respectivos tipos.
                int.TryParse(DgvP5Datos.Rows[i].Cells[1].Value.ToString(), out int Longitud);
                double.TryParse(DgvP5Datos.Rows[i].Cells[2].Value.ToString(), out double Angulo);

                //Invertir las coordenadas.
                Angulo = (Angulo * -1);
                Angulo = (Angulo * Math.PI) / 180;

                //
                x1 = Longitud * Math.Cos(Angulo);
                y1 = Longitud * Math.Sin(Angulo);

                //Convierte las posiciones X Y en enteras.
                X = Convert.ToInt32(x1);
                Y = Convert.ToInt32(y1);

                //Dibuja los vectores.
                g.DrawLine(Lapiz, PtbP5Lienzo.Width / 2, PtbP5Lienzo.Height / 2, (X + PtbP5Lienzo.Width / 2), (Y + PtbP5Lienzo.Height / 2));
            }

            SaveFileDialog saveFileDialog;

            saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Guardar imagen generada";
            saveFileDialog.FileName = "Plano Cartesiano";
            saveFileDialog.Filter = "Image files (*.png)|*.png";
            saveFileDialog.RestoreDirectory = true;

            DialogResult Decision;

            Decision = saveFileDialog.ShowDialog();

            if (Decision == DialogResult.Cancel || Decision == DialogResult.Abort)
            {
                return;
            }

            if (Decision == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
        }

        //---------------------------------------------------------------------
        //Botón para abrir plano como png.
        //---------------------------------------------------------------------
        private void BtnAbrirPng_Click(object sender, EventArgs e)
        {
            LimpiarP5();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Abrir imagen";
            ofd.FileName = "Plano Cartesiano";
            ofd.Filter = "Image files (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string archivo = ofd.FileName;
                LblP5X.Text = "X   ";
                LblP5Y.Text = "Y";
                string nombre = "Nombre del archivo : " + ofd.SafeFileName;
                PtbP5Lienzo.Load(archivo);
                LblP5Url.Text = nombre;

            }
        }
        #endregion

        #region Practica 6
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Practica 6.                                                                +
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //---------------------------------------------------------------------
        //Obtiene las coordenadas geograficas de un lugar a partir de los
        //servicios de Google Maps.
        //---------------------------------------------------------------------
        private async void BtnP6ObtenerCoordenadas_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TxtP6Lugar.Text.Equals(""))
            {
                return;
            }

            RtxtP6KML.Clear();

            //Obtiene coordenadas.
            await GetCoordenadas();
        }

        //---------------------------------------------------------------------
        //Obtiene las coordenadas geograficas de forma asíncrona.
        //---------------------------------------------------------------------
        public async Task GetCoordenadas()
        {
            //Declaración de variables.
            HttpClient clienteHttp;
            Uri direccion;
            HttpResponseMessage respuestaHttp;
            string contenidoHttp;
            XmlDocument documentoXML;
            XmlNodeList elemList;
            XmlElement bookElement;
            string Descripcion;
            string Longitud;
            string Latitud;
            string Llave;
            string Lugar;
            string Estatus;

            //Prepara datos de trabajo.
            Llave = "AIzaSyAqPyie1EMOOceRXH7Nk7fSUBoxuhNv9wI";
            Lugar = TxtP6Lugar.Text;

            //Consulta la API de geolocalización de Google Maps.
            clienteHttp = new HttpClient();
            direccion = new Uri("https://maps.googleapis.com/maps/api/geocode/");
            clienteHttp.BaseAddress = direccion;

            respuestaHttp = await clienteHttp.GetAsync($"xml?address={Lugar}&key={Llave}");
            //respuestaHttp = await clienteHttp.GetAsync("xml?address=Taj Mhal&key=AIzaSyAqPyie1EMOOceRXH7Nk7fSUBoxuhNv9wI");
            contenidoHttp = await respuestaHttp.Content.ReadAsStringAsync();

            //Extraer la descripción, la latitud, la logitud del XML
            documentoXML = new XmlDocument();
            documentoXML.LoadXml(contenidoHttp);

            elemList = documentoXML.GetElementsByTagName("status");
            bookElement = (XmlElement)elemList[0];
            Estatus = bookElement.InnerText;

            if (Estatus == "ZERO_RESULTS")
            {
                TxtP6Descripcion.Text = "Lugar no encontrado";
                TxtP6Longitud.Text = "Lugar no encontrado";
                TxtP6Latitud.Text = "Lugar no encontrado";
                return;
            }

            elemList = documentoXML.GetElementsByTagName("formatted_address");
            bookElement = (XmlElement)elemList[0];
            Descripcion = bookElement.InnerText;

            elemList = documentoXML.GetElementsByTagName("location");
            bookElement = (XmlElement)elemList[0];
            Longitud = bookElement["lng"].InnerText;
            Latitud = bookElement["lat"].InnerText;

            TxtP6Descripcion.Text = Descripcion;
            TxtP6Longitud.Text = Longitud;
            TxtP6Latitud.Text = Latitud;
        }

        //---------------------------------------------------------------------
        //Genera un archivo de texto en formato KML con las coordenadas calculadas.
        //---------------------------------------------------------------------
        private void BtnP6GenerarKML_Click(object sender, EventArgs e)
        {
            //Declaración de variables.
            string Ruta;
            string Nombre;
            string Contenido;
            bool Exito;

            //Inicialización de variables.
            Ruta = @"C:\Users\aaron\Desktop\";
            Nombre = TxtP6Lugar.Text + ".KML";

                Contenido =
                "<?xml version = \"1.0\" encoding = \"UTF-8\"?>\n" +
                "<kml xmlns = \"http://www.opengis.net/kml/2.2\">\n" +
                "  <Placemark>\n" +
                "    <name>\n" +
                "     " + TxtP6Lugar.Text + "\n" +
                "    </name>\n" +
                "    <description>\n" +
                "     " + TxtP6Descripcion.Text + "\n" +
                "    </description>\n" +
                "    <Point>\n" +
                "      <coordinates>\n" +
                "       " + TxtP6Longitud.Text + "," + TxtP6Latitud.Text + "," + "0\n" +
                "      </coordinates>\n" +
                "   </Point>\n" +
                " </Placemark>\n" +
                "</kml>\n";

            //Crear el archivo de Texto con Formato KML.
            try
            {
                using (StreamWriter Escritor = File.CreateText(Ruta + Nombre))
                {
                    Escritor.WriteLine(Contenido);
                    Exito = true;
                }
            }
            catch (Exception Error)
            {
                Exito = false;
            }

            //Maneja el posible error.
            if (Exito)
            {
                RtxtP6KML.Clear();
                RtxtP6KML.Text = Contenido;
                MessageBox.Show("El archivo KML se generó con éxito.");
            }
            else
            {
                MessageBox.Show("Ocurrió un error al intentar generar el archivo.");
            }
        }
        #endregion

        #region Practica 7
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Practica 7.                                                                +
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //---------------------------------------------------------------------
        //Copia las coordenadas geográficas de la práctica 6.
        //---------------------------------------------------------------------
        private void BtnP7CopiarCoordenadas_Click(object sender, EventArgs e)
        {
            TxtP7Latitud.Text = TxtP6Latitud.Text;
            TxtP7Longitud.Text = TxtP6Longitud.Text;
        }

        //---------------------------------------------------------------------
        //Busca los lugares a partir de un punto.
        //---------------------------------------------------------------------
        private async void BtnP7BuscarLugares_Click(object sender, EventArgs e)
        {
            //Validación.
            if (CbxP7Buscar.Text.Equals(""))
            {
                return;
            }

            //Obtiene coordenadas.
            await GetLugares();
        }

        public async Task GetLugares()
        {
            //Declaración de variables.
            HttpClient clienteHttp;
            Uri direccion;
            HttpResponseMessage respuestaHttp;
            string contenidoHttp;
            XmlDocument documentoXML;
            XmlNodeList elemList;
            XmlElement bookElement;
            string Nombre;
            string Longitud;
            string Latitud;
            string Llave;
            string Buscar;
            string Estatus;
            string Direccion;
            string Latitudes;
            string Longitudes;
            string Radio;
            string Lugar;

            //Prepara datos de trabajo.
            Llave = "AIzaSyAqPyie1EMOOceRXH7Nk7fSUBoxuhNv9wI";
            Longitud = TxtP7Longitud.Text;
            Latitud = TxtP7Latitud.Text;
            Buscar = CbxP7Buscar.Text;
            Radio = TxtP7Radio.Text;
            Lugar = TxtP6Lugar.Text;

            //Consulta la API de geolocalización de Google Maps.
            clienteHttp = new HttpClient();
            direccion = new Uri("https://maps.googleapis.com/maps/api/place/nearbysearch/");
            clienteHttp.BaseAddress = direccion;

            respuestaHttp = await clienteHttp.GetAsync($"xml?location={Latitud},{Longitud}&radius={Radio}&type={Buscar}&key={Llave}");
            contenidoHttp = await respuestaHttp.Content.ReadAsStringAsync();

            //Extraer la descripción, la latitud, la logitud del XML
            documentoXML = new XmlDocument();
            documentoXML.LoadXml(contenidoHttp);

            elemList = documentoXML.GetElementsByTagName("status");
            bookElement = (XmlElement)elemList[0];
            Estatus = bookElement.InnerText;

            if (Estatus == "ZERO_RESULTS")
            {
                return;
            }
            if (CbxP7Buscar.SelectedIndex == -1)
            {
                return;
            }

            documentoXML = new XmlDocument();
            documentoXML.LoadXml(contenidoHttp);
            elemList = documentoXML.GetElementsByTagName("result");
            MessageBox.Show("Se encontraron " + elemList.Count + " lugares en un radio de " + Radio + " en " + Lugar);

            float LongitudPrimaria = (float)Convert.ToDouble(TxtP7Longitud.Text);
            float LatitudPrimaria = (float)Convert.ToDouble(TxtP7Latitud.Text);

            DgvP7Datos.Rows.Clear();
            for (int i = 0; i < elemList.Count; i++)
            {
                elemList = documentoXML.GetElementsByTagName("result");
                bookElement = (XmlElement)elemList[i];
                Nombre = bookElement["name"].InnerText;

                bookElement = (XmlElement)elemList[i];
                Direccion = bookElement["vicinity"].InnerText;

                elemList = documentoXML.GetElementsByTagName("location");
                bookElement = (XmlElement)elemList[i];
                Latitudes = bookElement["lat"].InnerText;

                bookElement = (XmlElement)elemList[i];
                Longitudes = bookElement["lng"].InnerText;

                DgvP7Datos.Rows.Add();
                DgvP7Datos.Rows[i].Cells[0].Value = (i + 1);

                DgvP7Datos.Rows.Add();
                DgvP7Datos.Rows[i].Cells[1].Value = Nombre;

                DgvP7Datos.Rows.Add();
                DgvP7Datos.Rows[i].Cells[2].Value = Direccion;

                DgvP7Datos.Rows.Add();
                DgvP7Datos.Rows[i].Cells[3].Value = Longitudes;

                DgvP7Datos.Rows.Add();
                DgvP7Datos.Rows[i].Cells[4].Value = Latitudes;

                float LongitudSecundaria = (float)Convert.ToDouble(Longitudes);
                float LatitudSecundaria = (float)Convert.ToDouble(Latitudes);

                DgvP7Datos.Rows.Add();
                DgvP7Datos.Rows[i].Cells[5].Value = (CalcularDistancia(LatitudPrimaria, LatitudSecundaria, LongitudPrimaria, LongitudSecundaria) * 1000);
            }
            PaintRows();
        }

        //---------------------------------------------------------------------
        //Limpiar los componentes de la ventana.
        //---------------------------------------------------------------------
        private void BtnP7Limpiar_Click(object sender, EventArgs e)
        {
            CbxP7Buscar.SelectedIndex = -1;
            DgvP7Datos.Rows.Clear();
            TxtP7Latitud.Text = "";
            TxtP7Longitud.Text = "";
        }

        //---------------------------------------------------------------------
        //Dar formato a las celdas con menor a mayor distancia.
        //---------------------------------------------------------------------
        public void PaintRows()
        {
            foreach (DataGridViewRow row in DgvP7Datos.Rows)
            {
                if (row.Cells[5].Value == null)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                if (Convert.ToInt32(row.Cells[5].Value) > 1 && Convert.ToInt32(row.Cells[5].Value) < 25)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                if (Convert.ToInt32(row.Cells[5].Value) > 25)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
                if (Convert.ToInt32(row.Cells[5].Value) > 50)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        #endregion

        #region Practica 8
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Practica 8.                                                                +
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //---------------------------------------------------------------------
        //Convierte de grados decimales a radianes.
        //---------------------------------------------------------------------
        private float ToRadian(float GradosDecimales)
        {
            return (float)(Math.PI / 180) * GradosDecimales;
        }

        //---------------------------------------------------------------------
        //Calcula la distancia entre dos coordenadas con base en la fórmula de
        //semiverseno.
        //---------------------------------------------------------------------
        private float CalcularDistancia(float PosOrigenLatitud, float PosDestinoLatitud, float PosOrigenLongitud, float PosDestinoLongitud)
        {
            var R = 6378.0F;//En Kilometros
            var DifLatitud = ToRadian(PosDestinoLatitud - PosOrigenLatitud);
            var DifLongitud = ToRadian(PosDestinoLongitud - PosOrigenLongitud);

            var a = Math.Pow(Math.Sin(DifLatitud / 2), 2) +
                    Math.Cos(ToRadian(PosOrigenLatitud)) *
                    Math.Cos(ToRadian(PosDestinoLatitud)) *
                    Math.Pow(Math.Sin(DifLongitud / 2), 2);

            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * Convert.ToSingle(c);
        }

        private void BtnP8Calcular_Click(object sender, EventArgs e)
        {
            //Declaración de variables.
            float PosOrigenLatitud;
            float PosOrigenLongitud;
            float PosDestinoLatitud;
            float PosDestinoLongitud;
            float Resultado;

            //Inicialización de datos de trabajo.
            PosOrigenLatitud = (float)Convert.ToDouble(TxtP8LatitudOrigen.Text);
            PosOrigenLongitud = (float)Convert.ToDouble(TxtP8LongitudOrigen.Text);
            PosDestinoLatitud = (float)Convert.ToDouble(TxtP8LatitudDestino.Text);
            PosDestinoLongitud = (float)Convert.ToDouble(TxtP8LongitudDestino.Text);

            Resultado = CalcularDistancia(PosOrigenLatitud, PosDestinoLatitud, PosOrigenLongitud, PosDestinoLongitud);
            TxtP8Resultado.Text = Resultado.ToString() + " Kms.";
        }

        //---------------------------------------------------------------------
        //Copiar coordenadas de origen.
        //---------------------------------------------------------------------
        private void BtnP8CopiarCoordenadasOrigen_Click(object sender, EventArgs e)
        {
            TxtP8LatitudOrigen.Text = TxtP6Latitud.Text;
            TxtP8LongitudOrigen.Text = TxtP6Longitud.Text;
            TxtP8LugarOrigen.Text = TxtP6Lugar.Text;
        }

        //---------------------------------------------------------------------
        //Copiar coordenadas de destino.
        //---------------------------------------------------------------------
        private void BtnP8CopiarCoordenadasDestino_Click(object sender, EventArgs e)
        {
            TxtP8LatitudDestino.Text = TxtP6Latitud.Text;
            TxtP8LongitudDestino.Text = TxtP6Longitud.Text;
            TxtP8LugarDestino.Text = TxtP6Lugar.Text;
        }

        #endregion

        #region Practica 9
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Practica 9.                                                                +
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        #endregion

        #region Practica 10
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Practica 10.                                                                +
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //---------------------------------------------------------------------
        //Abre la practica 10.
        //---------------------------------------------------------------------
        private void BtnP10Abrir_Click(object sender, EventArgs e)
        {
            this.Hide();
            DlgLogin dlgLogin = new DlgLogin();
            dlgLogin.ShowDialog();
        }
        #endregion
    }
}