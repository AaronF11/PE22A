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
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnLlenar = new System.Windows.Forms.Button();
            this.BtnCalcularEnvio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSaludo
            // 
            this.BtnSaludo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSaludo.Location = new System.Drawing.Point(224, 13);
            this.BtnSaludo.Name = "BtnSaludo";
            this.BtnSaludo.Size = new System.Drawing.Size(48, 20);
            this.BtnSaludo.TabIndex = 0;
            this.BtnSaludo.Text = "Hola";
            this.BtnSaludo.UseVisualStyleBackColor = false;
            this.BtnSaludo.Click += new System.EventHandler(this.BtnSaludo_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(118, 13);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
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
            this.CbxSexo.Location = new System.Drawing.Point(12, 12);
            this.CbxSexo.Name = "CbxSexo";
            this.CbxSexo.Size = new System.Drawing.Size(100, 21);
            this.CbxSexo.TabIndex = 2;
            // 
            // DgvCarrito
            // 
            this.DgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Producto,
            this.Cantidad,
            this.Peso});
            this.DgvCarrito.Location = new System.Drawing.Point(13, 40);
            this.DgvCarrito.Name = "DgvCarrito";
            this.DgvCarrito.Size = new System.Drawing.Size(443, 150);
            this.DgvCarrito.TabIndex = 3;
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
            // BtnLlenar
            // 
            this.BtnLlenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnLlenar.Location = new System.Drawing.Point(462, 40);
            this.BtnLlenar.Name = "BtnLlenar";
            this.BtnLlenar.Size = new System.Drawing.Size(111, 28);
            this.BtnLlenar.TabIndex = 4;
            this.BtnLlenar.Text = "Llenar datos";
            this.BtnLlenar.UseVisualStyleBackColor = false;
            this.BtnLlenar.Click += new System.EventHandler(this.BtnLlenar_Click);
            // 
            // BtnCalcularEnvio
            // 
            this.BtnCalcularEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnCalcularEnvio.Location = new System.Drawing.Point(462, 74);
            this.BtnCalcularEnvio.Name = "BtnCalcularEnvio";
            this.BtnCalcularEnvio.Size = new System.Drawing.Size(111, 28);
            this.BtnCalcularEnvio.TabIndex = 5;
            this.BtnCalcularEnvio.Text = "Calcular Envio";
            this.BtnCalcularEnvio.UseVisualStyleBackColor = false;
            this.BtnCalcularEnvio.Click += new System.EventHandler(this.BtnCalcularEnvio_Click);
            // 
            // DlgPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(580, 261);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.Button BtnLlenar;
        private System.Windows.Forms.Button BtnCalcularEnvio;
    }
}

