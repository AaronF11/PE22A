using System;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing.Imaging;

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

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Practica 2.
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

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
            double AltoTotal = 0;
            double AnchoTotal = 0;
            double LargoTotal = 0;
            int NumItems = DgvCarrito.Rows.Count - 1;
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
                if (DgvCarrito.Rows[i].Cells[0].Value == null)
                {
                    DgvCarrito.ClearSelection();
                    MessageBox.Show("Ingrese la referencia del producto");
                    DgvCarrito.Rows[i].Cells[0].Selected = true;
                    return;
                }

                //Validación de la cantidad (Vacio).
                if (DgvCarrito.Rows[i].Cells[1].Value == null)
                {
                    DgvCarrito.ClearSelection();
                    MessageBox.Show("Ingrese la cantidad del producto");
                    DgvCarrito.Rows[i].Cells[1].Selected = true;
                    return;
                }

                //Validación de la cantidad (Caracteres).
                if (!Int32.TryParse(DgvCarrito.Rows[i].Cells[1].Value.ToString(), out Cantidad))
                {
                    DgvCarrito.ClearSelection();
                    MessageBox.Show("Ingrese la cantidad del producto");
                    DgvCarrito.Rows[i].Cells[1].Selected = true;
                    return;
                }

                //--- Tabla de productos ---

                //Validación de la referencia o nombre del producto.
                if (DgvTblProductos.Rows[i].Cells[0].Value == null)
                {
                    DgvTblProductos.ClearSelection();
                    MessageBox.Show("Ingrese la referencia del producto");
                    DgvTblProductos.Rows[i].Cells[0].Selected = true;
                    return;
                }

                //Validación del Alto del producto.
                if (DgvTblProductos.Rows[i].Cells[1].Value == null)
                {
                    DgvTblProductos.ClearSelection();
                    MessageBox.Show("Ingrese el alto del producto");
                    DgvTblProductos.Rows[i].Cells[1].Selected = true;
                    return;
                }

                //Validación del Alto (Caracteres).
                if (!Double.TryParse(DgvTblProductos.Rows[i].Cells[1].Value.ToString(), out Alto))
                {
                    DgvTblProductos.ClearSelection();
                    MessageBox.Show("Ingrese un valor numérico del producto");
                    DgvTblProductos.Rows[i].Cells[1].Selected = true;
                    return;
                }

                //Validación del Ancho del producto.
                if (DgvTblProductos.Rows[i].Cells[2].Value == null)
                {
                    DgvTblProductos.ClearSelection();
                    MessageBox.Show("Ingrese el ancho del producto");
                    DgvTblProductos.Rows[i].Cells[2].Selected = true;
                    return;
                }

                //Validación del Ancho (Caracteres).
                if (!Double.TryParse(DgvTblProductos.Rows[i].Cells[2].Value.ToString(), out Ancho))
                {
                    DgvTblProductos.ClearSelection();
                    MessageBox.Show("Ingrese un valor numérico del producto");
                    DgvTblProductos.Rows[i].Cells[2].Selected = true;
                    return;
                }

                //Validación del Largo del producto.
                if (DgvTblProductos.Rows[i].Cells[3].Value == null)
                {
                    DgvTblProductos.ClearSelection();
                    MessageBox.Show("Ingrese el largo del producto");
                    DgvTblProductos.Rows[i].Cells[3].Selected = true;
                    return;
                }

                //Validación del Largo (Caracteres).
                if (!Double.TryParse(DgvTblProductos.Rows[i].Cells[3].Value.ToString(), out Largo))
                {
                    DgvTblProductos.ClearSelection();
                    MessageBox.Show("Ingrese un valor numérico del producto");
                    DgvTblProductos.Rows[i].Cells[3].Selected = true;
                    return;
                }

                //Validación del Peso del producto.
                if (DgvTblProductos.Rows[i].Cells[4].Value == null)
                {
                    DgvTblProductos.ClearSelection();
                    MessageBox.Show("Ingrese el peso del producto");
                    DgvTblProductos.Rows[i].Cells[4].Selected = true;
                    return;
                }

                //Validación del Peso (Caracteres).
                if (!Double.TryParse(DgvTblProductos.Rows[i].Cells[4].Value.ToString(), out Peso))
                {
                    DgvTblProductos.ClearSelection();
                    MessageBox.Show("Ingrese un valor numérico del producto");
                    DgvTblProductos.Rows[i].Cells[4].Selected = true;
                    return;
                }

                //Validación de la fragilidad del producto.
                if (DgvTblProductos.Rows[i].Cells[5].Value == null)
                {
                    DgvTblProductos.ClearSelection();
                    MessageBox.Show("Ingrese la fragilidad del producto");
                    DgvTblProductos.Rows[i].Cells[5].Selected = true;
                    return;
                }

                //Validación de la fragilidad (Caracteres).
                if (!Int32.TryParse(DgvTblProductos.Rows[i].Cells[5].Value.ToString(), out Fragilidad))
                {
                    DgvTblProductos.ClearSelection();
                    MessageBox.Show("Ingrese un valor numérico del producto");
                    DgvTblProductos.Rows[i].Cells[5].Selected = true;
                    return;
                }

                Producto = DgvCarrito.Rows[i].Cells[0].Value.ToString();//Almacena el Producto y lo convierte a caddena.
                Cantidad = Convert.ToInt32(DgvCarrito.Rows[i].Cells[1].Value);//Almacena la cantidad y la convierte a entero.
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

            TxtAlto.Text = $"{AltoTotal} Cm.";
            TxtAncho.Text = $"{AnchoTotal} Cm.";
            TxtLargo.Text = $"{LargoTotal} Cm.";
        }

        //---------------------------------------------------------------------
        //Limpia los datos del carrito de compras.
        //---------------------------------------------------------------------
        private void BtnLimpiarDatosCarrito_Click(object sender, EventArgs e)
        {
            DgvCarrito.Rows.Clear();
        }

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Practica 3.
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
            DgvTblProductos.Rows.Clear();
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
            if (TxtInversionInicial.Text == "")
            {
                MessageBox.Show("Capture la inversión inicial.");
                return;
            }

            //Validación de valor númerico.
            if (!double.TryParse(TxtInversionInicial.Text, out Salida))
            {
                MessageBox.Show("Capture un valor númerico.");
                TxtInversionInicial.Focus();
                return;
            }

            //Validación de vacio.
            if (TxtTMAR.Text == "")
            {
                MessageBox.Show("Capture la tasa mímima aceptable de rendimiento.");
                return;
            }

            //Validación de valor númerico.
            if (!double.TryParse(TxtTMAR.Text, out Salida))
            {
                MessageBox.Show("Capture un valor númerico.");
                TxtTMAR.Focus();
                return;
            }

            InversionInicial = Convert.ToDouble(TxtInversionInicial.Text);
            TMAR = Convert.ToDouble(TxtTMAR.Text);

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
                TxtDecision.ForeColor = Color.Green;
                TxtDecision.BackColor = Color.LightGreen;
                TxtDecision.Text = "Factible";
                TxtResultado.ForeColor = Color.Green;
                TxtResultado.BackColor = Color.LightGreen;
            }

            else if (VPN < 0)
            {
                TxtDecision.ForeColor = Color.DarkRed;
                TxtDecision.BackColor = Color.MediumVioletRed;
                TxtDecision.Text = "No factible";
                TxtResultado.ForeColor = Color.DarkRed;
                TxtResultado.BackColor = Color.MediumVioletRed;
            }

            else if (Math.Round(VPN, 2) == 0)
            {
                TxtDecision.ForeColor = Color.Yellow;
                TxtDecision.BackColor = Color.MediumVioletRed;
                TxtDecision.Text = "Indiferente";
                TxtResultado.ForeColor = Color.Yellow;
                TxtResultado.BackColor = Color.MediumVioletRed;
            }

            TxtResultado.Text = $"$ {VPN.ToString()}";
        }

        //---------------------------------------------------------------------
        //Limpia los datos de la tabla de Flujos netos y los TextBoxs.
        //---------------------------------------------------------------------
        private void BtnP3Limpiar_Click(object sender, EventArgs e)
        {
            TxtInversionInicial.Text = "0";
            TxtTMAR.Text = "0";
            TxtResultado.ForeColor = Color.Black;
            TxtResultado.Text = "$0";
            TxtDecision.Text = "";
            DgvP3FlujosNetos.Rows.Clear();
            TxtDecision.ForeColor = Color.Black;
            TxtDecision.BackColor = Color.White;
            TxtResultado.ForeColor = Color.Black;
            TxtResultado.BackColor = Color.White;
        }

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Practica 4.
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
                Puntos[i].X = Convert.ToInt32(DgvP4DatosEspaciales.Rows[i].Cells[1].Value) * Convert.ToInt32(NudZoom.Value); //+ Xorigen;
                Puntos[i].Y = Convert.ToInt32(DgvP4DatosEspaciales.Rows[i].Cells[2].Value) * Convert.ToInt32(NudZoom.Value); //+ Yorigen;
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

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Practica 5.
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        
        //Objetos graficos.
        Graphics Plano, Plano1;
        Pen Lapiz, Lapiz1, Lapiz2;
        Random rnd;
        Color[] puntosColores;

        //---------------------------------------------------------------------
        //Dibuja plano cartesiano.
        //---------------------------------------------------------------------
        private void BtnP5DibubarPlano_Click(object sender, EventArgs e)
        {
            LblY.Text = "Y";
            LblX.Text = "X   ";
            Plano1 = PtbLienzo.CreateGraphics();
            Lapiz1 = new Pen(Color.Black, 4);
            Lapiz2 = new Pen(Color.Red, 4);
            int xcentro = PtbLienzo.Width / 2;
            int ycentro = PtbLienzo.Height / 2;
            Plano1.TranslateTransform(xcentro, ycentro);
            Plano1.ScaleTransform(1, -1);

            Plano1.DrawLine(Lapiz1, -xcentro, 0, xcentro * 2,0);//Horizontal
            Plano1.DrawLine(Lapiz1, 0, ycentro, 0, -ycentro);//Vertical

            //Graficar el interlineado de la grafica
            for (int i = -xcentro; i < xcentro; i += 20)
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
            int ContadorDataGrid = DgvDatos.Rows.Count - 1;

            //Validación.
            if (ContadorDataGrid == 0)
            {
                MessageBox.Show("Capture los datos en la tabla");
            }

            while (i < ContadorDataGrid)
            {
                if (DgvDatos.Rows[i].Cells[1].Value == null)
                {
                    DgvDatos.ClearSelection();
                    MessageBox.Show("Capture una Longitud en el vector " + DgvDatos.Rows[i].Cells[0].Value.ToString());
                    DgvDatos.Rows[i].Cells[1].Selected = true;
                    return;
                }

                if (!int.TryParse(DgvDatos.Rows[i].Cells[1].Value.ToString(), out Longitud))
                {
                    DgvDatos.ClearSelection();
                    MessageBox.Show("Capture valor numérico en el vector " + DgvDatos.Rows[i].Cells[0].Value.ToString());
                    DgvDatos.Rows[i].Cells[1].Selected = true;
                    return;
                }

                if (DgvDatos.Rows[i].Cells[2].Value == null)
                {
                    DgvDatos.ClearSelection();
                    MessageBox.Show("Capture una Ángulo en el vector " + DgvDatos.Rows[i].Cells[0].Value.ToString());
                    DgvDatos.Rows[i].Cells[1].Selected = true;
                    return;
                }

                if (!Double.TryParse(DgvDatos.Rows[i].Cells[2].Value.ToString(), out Angulo))
                {
                    DgvDatos.ClearSelection();
                    MessageBox.Show("Capture valor numérico en el vector " + DgvDatos.Rows[i].Cells[0].Value.ToString());
                    DgvDatos.Rows[i].Cells[1].Selected = true;
                    return;
                }
                i++;
            }

            puntosColores = new Color[DgvDatos.Rows.Count];

            for (i = 0; i < DgvDatos.Rows.Count - 1; i++)
            {
                //Construcción de objetos de dibujo.
                puntosColores[i] = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                Plano = PtbLienzo.CreateGraphics();
                Lapiz = new Pen(puntosColores[i], 4);

                //Parsear variables a sus respectivos tipos.
                int.TryParse(DgvDatos.Rows[i].Cells[1].Value.ToString(), out Longitud);
                double.TryParse(DgvDatos.Rows[i].Cells[2].Value.ToString(), out Angulo);

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
                Plano.DrawLine(Lapiz, PtbLienzo.Width/2, PtbLienzo.Height/2, (X + PtbLienzo.Width/2), (Y + PtbLienzo.Height / 2));
            }
        }

        //---------------------------------------------------------------------
        //Limpia los datos en la ventana.
        //---------------------------------------------------------------------
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LblY.Text = "";
            LblX.Text = "";
            DgvDatos.Rows.Clear();
            Plano = PtbLienzo.CreateGraphics();
            Plano.Clear(Color.Aquamarine);
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
            double Angulo;
            int Longitud;
            int i = 0;
            int ContadorDataGrid = DgvDatos.Rows.Count - 1;

            //Validación.
            while (i < ContadorDataGrid)
            {

                if (DgvDatos.Rows[i].Cells[1].Value == null)
                {
                    DgvDatos.ClearSelection();
                    MessageBox.Show("Capture una Longitud en el vector " + DgvDatos.Rows[i].Cells[0].Value.ToString());
                    DgvDatos.Rows[i].Cells[1].Selected = true;
                    return;
                }

                if (!int.TryParse(DgvDatos.Rows[i].Cells[1].Value.ToString(), out Longitud))
                {
                    DgvDatos.ClearSelection();
                    MessageBox.Show("Capture valor numérico en el vector " + DgvDatos.Rows[i].Cells[0].Value.ToString());
                    DgvDatos.Rows[i].Cells[1].Selected = true;
                    return;
                }

                if (DgvDatos.Rows[i].Cells[2].Value == null)
                {
                    DgvDatos.ClearSelection();
                    MessageBox.Show("Capture una Ángulo en el vector " + DgvDatos.Rows[i].Cells[0].Value.ToString());
                    DgvDatos.Rows[i].Cells[1].Selected = true;
                    return;
                }

                if (!Double.TryParse(DgvDatos.Rows[i].Cells[2].Value.ToString(), out Angulo))
                {
                    DgvDatos.ClearSelection();
                    MessageBox.Show("Capture valor numérico en el vector " + DgvDatos.Rows[i].Cells[0].Value.ToString());
                    DgvDatos.Rows[i].Cells[1].Selected = true;
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
                ExportarExcel(DgvDatos);
            }
        }

        //---------------------------------------------------------------------
        //Botón para importar desde Excel.
        //---------------------------------------------------------------------
        private void BtnP5Abrir_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application application;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            Microsoft.Office.Interop.Excel.Range range;

            DialogResult Result;
            int filas;
            string NombreArchivo = string.Empty;

            OfdAbrirArchivo.Filter = "Excel Office | *.xls; *.xlsx";
            
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
                    DgvDatos.Rows.Add(i, range.Cells[filas,2].Text(), range.Cells[filas, 3].Text());
                }

                workbook.Close();
                application.Quit();
            }
        }
    }
}