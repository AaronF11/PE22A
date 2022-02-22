namespace PE22A
{
    partial class DlgPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSaludo = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CbxSexo = new System.Windows.Forms.ComboBox();
            this.DgvCarrito = new System.Windows.Forms.DataGridView();
            this.BtnLlenar = new System.Windows.Forms.Button();
            this.BtnCalcularEnvio = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fragilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.TxtFragilidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSaludo
            // 
            this.BtnSaludo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSaludo.Location = new System.Drawing.Point(444, 6);
            this.BtnSaludo.Name = "BtnSaludo";
            this.BtnSaludo.Size = new System.Drawing.Size(111, 28);
            this.BtnSaludo.TabIndex = 0;
            this.BtnSaludo.Text = "Hola";
            this.BtnSaludo.UseVisualStyleBackColor = false;
            this.BtnSaludo.Click += new System.EventHandler(this.BtnSaludo_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(246, 10);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(192, 20);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.Text = "Escribe tu nombre:";
            this.TxtNombre.Enter += new System.EventHandler(this.TxtNombre_Enter);
            // 
            // CbxSexo
            // 
            this.CbxSexo.FormattingEnabled = true;
            this.CbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Prefiero no decirlo",
            "No binario"});
            this.CbxSexo.Location = new System.Drawing.Point(13, 10);
            this.CbxSexo.Name = "CbxSexo";
            this.CbxSexo.Size = new System.Drawing.Size(227, 21);
            this.CbxSexo.TabIndex = 2;
            // 
            // DgvCarrito
            // 
            this.DgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Producto,
            this.Cantidad,
            this.Peso,
            this.Fragilidad});
            this.DgvCarrito.Location = new System.Drawing.Point(13, 40);
            this.DgvCarrito.Name = "DgvCarrito";
            this.DgvCarrito.Size = new System.Drawing.Size(542, 150);
            this.DgvCarrito.TabIndex = 3;
            // 
            // BtnLlenar
            // 
            this.BtnLlenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnLlenar.Location = new System.Drawing.Point(571, 74);
            this.BtnLlenar.Name = "BtnLlenar";
            this.BtnLlenar.Size = new System.Drawing.Size(121, 28);
            this.BtnLlenar.TabIndex = 4;
            this.BtnLlenar.Text = "Llenar datos";
            this.BtnLlenar.UseVisualStyleBackColor = false;
            this.BtnLlenar.Click += new System.EventHandler(this.BtnLlenar_Click);
            // 
            // BtnCalcularEnvio
            // 
            this.BtnCalcularEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnCalcularEnvio.Location = new System.Drawing.Point(571, 108);
            this.BtnCalcularEnvio.Name = "BtnCalcularEnvio";
            this.BtnCalcularEnvio.Size = new System.Drawing.Size(121, 28);
            this.BtnCalcularEnvio.TabIndex = 5;
            this.BtnCalcularEnvio.Text = "Calcular Envio";
            this.BtnCalcularEnvio.UseVisualStyleBackColor = false;
            this.BtnCalcularEnvio.Click += new System.EventHandler(this.BtnCalcularEnvio_Click);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            // 
            // Fragilidad
            // 
            this.Fragilidad.HeaderText = "Fragilidad";
            this.Fragilidad.Name = "Fragilidad";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnNuevo.Location = new System.Drawing.Point(571, 40);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(121, 28);
            this.BtnNuevo.TabIndex = 6;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(571, 142);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(121, 20);
            this.TxtPeso.TabIndex = 7;
            // 
            // TxtFragilidad
            // 
            this.TxtFragilidad.Location = new System.Drawing.Point(571, 168);
            this.TxtFragilidad.Name = "TxtFragilidad";
            this.TxtFragilidad.Size = new System.Drawing.Size(121, 20);
            this.TxtFragilidad.TabIndex = 8;
            // 
            // DlgPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(704, 208);
            this.Controls.Add(this.TxtFragilidad);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnCalcularEnvio);
            this.Controls.Add(this.BtnLlenar);
            this.Controls.Add(this.DgvCarrito);
            this.Controls.Add(this.CbxSexo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BtnSaludo);
            this.Name = "DlgPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSaludo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox CbxSexo;
        private System.Windows.Forms.DataGridView DgvCarrito;
        private System.Windows.Forms.Button BtnLlenar;
        private System.Windows.Forms.Button BtnCalcularEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fragilidad;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.TextBox TxtFragilidad;
    }
}

