namespace PE22A
{
    partial class DlgProyecto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgProyecto));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.PnlIzquierdo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlDerecho = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnLlenarTblProductos = new System.Windows.Forms.Button();
            this.BtnLlenarCarrito = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtFragilidad = new System.Windows.Forms.TextBox();
            this.LblFragilidad = new System.Windows.Forms.Label();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.LblPeso = new System.Windows.Forms.Label();
            this.TxtLargo = new System.Windows.Forms.TextBox();
            this.LblLargo = new System.Windows.Forms.Label();
            this.TxtAncho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAlto = new System.Windows.Forms.TextBox();
            this.LblAlto = new System.Windows.Forms.Label();
            this.BtnCalcularCaja = new System.Windows.Forms.Button();
            this.LblTblProductos = new System.Windows.Forms.Label();
            this.LblCarrito = new System.Windows.Forms.Label();
            this.DgvTblProductos = new System.Windows.Forms.DataGridView();
            this.ColProductoTbl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAlto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAncho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFragilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCarrito = new System.Windows.Forms.DataGridView();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.BtnLimpiarDatosCarrito = new System.Windows.Forms.Button();
            this.BtnLimpiarDatosTblProductos = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.PnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTblProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.proyectoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1223, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // proyectoToolStripMenuItem
            // 
            this.proyectoToolStripMenuItem.Name = "proyectoToolStripMenuItem";
            this.proyectoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.proyectoToolStripMenuItem.Text = "Proyecto";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1223, 60);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(150, 57);
            this.toolStripLabel1.Text = "Nuevo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel2.Image")));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(150, 57);
            this.toolStripLabel2.Text = "Abrir";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 60);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel3.Image")));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(150, 57);
            this.toolStripLabel3.Text = "Prueba";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 60);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.AutoSize = false;
            this.toolStripLabel4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel4.Image")));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(150, 57);
            this.toolStripLabel4.Text = "Reporte";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 60);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Orange;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1223, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel1.Text = "PE22A";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel2.Text = "Aarón Flores Pasos";
            // 
            // PnlIzquierdo
            // 
            this.PnlIzquierdo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PnlIzquierdo.Controls.Add(this.pictureBox1);
            this.PnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdo.Location = new System.Drawing.Point(0, 84);
            this.PnlIzquierdo.Name = "PnlIzquierdo";
            this.PnlIzquierdo.Size = new System.Drawing.Size(150, 555);
            this.PnlIzquierdo.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlDerecho
            // 
            this.PnlDerecho.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PnlDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlDerecho.Location = new System.Drawing.Point(1123, 84);
            this.PnlDerecho.Name = "PnlDerecho";
            this.PnlDerecho.Size = new System.Drawing.Size(100, 555);
            this.PnlDerecho.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(150, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 555);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(965, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Práctica 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Cyan;
            this.tabPage2.Controls.Add(this.BtnLimpiarDatosTblProductos);
            this.tabPage2.Controls.Add(this.BtnLimpiarDatosCarrito);
            this.tabPage2.Controls.Add(this.BtnLlenarTblProductos);
            this.tabPage2.Controls.Add(this.BtnLlenarCarrito);
            this.tabPage2.Controls.Add(this.BtnNuevo);
            this.tabPage2.Controls.Add(this.TxtFragilidad);
            this.tabPage2.Controls.Add(this.LblFragilidad);
            this.tabPage2.Controls.Add(this.TxtPeso);
            this.tabPage2.Controls.Add(this.LblPeso);
            this.tabPage2.Controls.Add(this.TxtLargo);
            this.tabPage2.Controls.Add(this.LblLargo);
            this.tabPage2.Controls.Add(this.TxtAncho);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.TxtAlto);
            this.tabPage2.Controls.Add(this.LblAlto);
            this.tabPage2.Controls.Add(this.BtnCalcularCaja);
            this.tabPage2.Controls.Add(this.LblTblProductos);
            this.tabPage2.Controls.Add(this.LblCarrito);
            this.tabPage2.Controls.Add(this.DgvTblProductos);
            this.tabPage2.Controls.Add(this.DgvCarrito);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(965, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Práctica 2";
            // 
            // BtnLlenarTblProductos
            // 
            this.BtnLlenarTblProductos.Location = new System.Drawing.Point(303, 400);
            this.BtnLlenarTblProductos.Name = "BtnLlenarTblProductos";
            this.BtnLlenarTblProductos.Size = new System.Drawing.Size(100, 30);
            this.BtnLlenarTblProductos.TabIndex = 17;
            this.BtnLlenarTblProductos.Text = "Llenar";
            this.BtnLlenarTblProductos.UseVisualStyleBackColor = true;
            this.BtnLlenarTblProductos.Click += new System.EventHandler(this.BtnLlenarTblProductos_Click);
            // 
            // BtnLlenarCarrito
            // 
            this.BtnLlenarCarrito.Location = new System.Drawing.Point(29, 400);
            this.BtnLlenarCarrito.Name = "BtnLlenarCarrito";
            this.BtnLlenarCarrito.Size = new System.Drawing.Size(100, 30);
            this.BtnLlenarCarrito.TabIndex = 16;
            this.BtnLlenarCarrito.Text = "Llenar";
            this.BtnLlenarCarrito.UseVisualStyleBackColor = true;
            this.BtnLlenarCarrito.Click += new System.EventHandler(this.BtnLlenarCarrito_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(303, 13);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(100, 30);
            this.BtnNuevo.TabIndex = 15;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // TxtFragilidad
            // 
            this.TxtFragilidad.Location = new System.Drawing.Point(705, 49);
            this.TxtFragilidad.Name = "TxtFragilidad";
            this.TxtFragilidad.Size = new System.Drawing.Size(159, 20);
            this.TxtFragilidad.TabIndex = 14;
            // 
            // LblFragilidad
            // 
            this.LblFragilidad.AutoSize = true;
            this.LblFragilidad.Location = new System.Drawing.Point(647, 49);
            this.LblFragilidad.Name = "LblFragilidad";
            this.LblFragilidad.Size = new System.Drawing.Size(52, 13);
            this.LblFragilidad.TabIndex = 13;
            this.LblFragilidad.Text = "Fragilidad";
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(689, 23);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(100, 20);
            this.TxtPeso.TabIndex = 12;
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Location = new System.Drawing.Point(647, 23);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(31, 13);
            this.LblPeso.TabIndex = 11;
            this.LblPeso.Text = "Peso";
            // 
            // TxtLargo
            // 
            this.TxtLargo.Location = new System.Drawing.Point(512, 74);
            this.TxtLargo.Name = "TxtLargo";
            this.TxtLargo.Size = new System.Drawing.Size(100, 20);
            this.TxtLargo.TabIndex = 10;
            // 
            // LblLargo
            // 
            this.LblLargo.AutoSize = true;
            this.LblLargo.Location = new System.Drawing.Point(470, 74);
            this.LblLargo.Name = "LblLargo";
            this.LblLargo.Size = new System.Drawing.Size(34, 13);
            this.LblLargo.TabIndex = 9;
            this.LblLargo.Text = "Largo";
            // 
            // TxtAncho
            // 
            this.TxtAncho.Location = new System.Drawing.Point(512, 48);
            this.TxtAncho.Name = "TxtAncho";
            this.TxtAncho.Size = new System.Drawing.Size(100, 20);
            this.TxtAncho.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ancho";
            // 
            // TxtAlto
            // 
            this.TxtAlto.Location = new System.Drawing.Point(512, 22);
            this.TxtAlto.Name = "TxtAlto";
            this.TxtAlto.Size = new System.Drawing.Size(100, 20);
            this.TxtAlto.TabIndex = 6;
            // 
            // LblAlto
            // 
            this.LblAlto.AutoSize = true;
            this.LblAlto.Location = new System.Drawing.Point(470, 22);
            this.LblAlto.Name = "LblAlto";
            this.LblAlto.Size = new System.Drawing.Size(25, 13);
            this.LblAlto.TabIndex = 5;
            this.LblAlto.Text = "Alto";
            // 
            // BtnCalcularCaja
            // 
            this.BtnCalcularCaja.Location = new System.Drawing.Point(303, 49);
            this.BtnCalcularCaja.Name = "BtnCalcularCaja";
            this.BtnCalcularCaja.Size = new System.Drawing.Size(100, 30);
            this.BtnCalcularCaja.TabIndex = 4;
            this.BtnCalcularCaja.Text = "Calcular Caja";
            this.BtnCalcularCaja.UseVisualStyleBackColor = true;
            this.BtnCalcularCaja.Click += new System.EventHandler(this.BtnCalcularCaja_Click);
            // 
            // LblTblProductos
            // 
            this.LblTblProductos.AutoSize = true;
            this.LblTblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTblProductos.Location = new System.Drawing.Point(300, 92);
            this.LblTblProductos.Name = "LblTblProductos";
            this.LblTblProductos.Size = new System.Drawing.Size(118, 13);
            this.LblTblProductos.TabIndex = 3;
            this.LblTblProductos.Text = "Tabla de Productos";
            // 
            // LblCarrito
            // 
            this.LblCarrito.AutoSize = true;
            this.LblCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarrito.Location = new System.Drawing.Point(98, 22);
            this.LblCarrito.Name = "LblCarrito";
            this.LblCarrito.Size = new System.Drawing.Size(114, 13);
            this.LblCarrito.TabIndex = 2;
            this.LblCarrito.Text = "Carrito de Compras";
            // 
            // DgvTblProductos
            // 
            this.DgvTblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTblProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductoTbl,
            this.ColAlto,
            this.ColAncho,
            this.ColLargo,
            this.ColPeso,
            this.ColFragilidad});
            this.DgvTblProductos.Location = new System.Drawing.Point(303, 108);
            this.DgvTblProductos.Name = "DgvTblProductos";
            this.DgvTblProductos.Size = new System.Drawing.Size(642, 286);
            this.DgvTblProductos.TabIndex = 1;
            // 
            // ColProductoTbl
            // 
            this.ColProductoTbl.HeaderText = "Producto";
            this.ColProductoTbl.Name = "ColProductoTbl";
            // 
            // ColAlto
            // 
            this.ColAlto.HeaderText = "Alto";
            this.ColAlto.Name = "ColAlto";
            // 
            // ColAncho
            // 
            this.ColAncho.HeaderText = "Ancho";
            this.ColAncho.Name = "ColAncho";
            // 
            // ColLargo
            // 
            this.ColLargo.HeaderText = "Largo";
            this.ColLargo.Name = "ColLargo";
            // 
            // ColPeso
            // 
            this.ColPeso.HeaderText = "Peso";
            this.ColPeso.Name = "ColPeso";
            // 
            // ColFragilidad
            // 
            this.ColFragilidad.HeaderText = "Fragilidad";
            this.ColFragilidad.Name = "ColFragilidad";
            // 
            // DgvCarrito
            // 
            this.DgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProducto,
            this.ColCantidad});
            this.DgvCarrito.Location = new System.Drawing.Point(29, 38);
            this.DgvCarrito.Name = "DgvCarrito";
            this.DgvCarrito.Size = new System.Drawing.Size(240, 356);
            this.DgvCarrito.TabIndex = 0;
            // 
            // ColProducto
            // 
            this.ColProducto.HeaderText = "Producto";
            this.ColProducto.Name = "ColProducto";
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(965, 517);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Práctica 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(965, 517);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Práctica 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(965, 517);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Práctica 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiarDatosCarrito
            // 
            this.BtnLimpiarDatosCarrito.Location = new System.Drawing.Point(135, 400);
            this.BtnLimpiarDatosCarrito.Name = "BtnLimpiarDatosCarrito";
            this.BtnLimpiarDatosCarrito.Size = new System.Drawing.Size(100, 30);
            this.BtnLimpiarDatosCarrito.TabIndex = 18;
            this.BtnLimpiarDatosCarrito.Text = "Limpiar";
            this.BtnLimpiarDatosCarrito.UseVisualStyleBackColor = true;
            this.BtnLimpiarDatosCarrito.Click += new System.EventHandler(this.BtnLimpiarDatosCarrito_Click);
            // 
            // BtnLimpiarDatosTblProductos
            // 
            this.BtnLimpiarDatosTblProductos.Location = new System.Drawing.Point(409, 400);
            this.BtnLimpiarDatosTblProductos.Name = "BtnLimpiarDatosTblProductos";
            this.BtnLimpiarDatosTblProductos.Size = new System.Drawing.Size(100, 30);
            this.BtnLimpiarDatosTblProductos.TabIndex = 19;
            this.BtnLimpiarDatosTblProductos.Text = "Limpiar";
            this.BtnLimpiarDatosTblProductos.UseVisualStyleBackColor = true;
            this.BtnLimpiarDatosTblProductos.Click += new System.EventHandler(this.BtnLimpiarDatosTblProductos_Click);
            // 
            // DlgProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1223, 661);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.PnlDerecho);
            this.Controls.Add(this.PnlIzquierdo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DlgProyecto";
            this.Text = "DlgProyecto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.PnlIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTblProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel PnlIzquierdo;
        private System.Windows.Forms.Panel PnlDerecho;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTblProductos;
        private System.Windows.Forms.Label LblCarrito;
        private System.Windows.Forms.DataGridView DgvTblProductos;
        private System.Windows.Forms.DataGridView DgvCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.Button BtnCalcularCaja;
        private System.Windows.Forms.TextBox TxtFragilidad;
        private System.Windows.Forms.Label LblFragilidad;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.TextBox TxtLargo;
        private System.Windows.Forms.Label LblLargo;
        private System.Windows.Forms.TextBox TxtAncho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAlto;
        private System.Windows.Forms.Label LblAlto;
        private System.Windows.Forms.Button BtnLlenarTblProductos;
        private System.Windows.Forms.Button BtnLlenarCarrito;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductoTbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAlto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAncho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFragilidad;
        private System.Windows.Forms.Button BtnLimpiarDatosTblProductos;
        private System.Windows.Forms.Button BtnLimpiarDatosCarrito;
    }
}