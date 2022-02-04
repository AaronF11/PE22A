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
            this.SuspendLayout();
            // 
            // BtnSaludo
            // 
            this.BtnSaludo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSaludo.Location = new System.Drawing.Point(86, 160);
            this.BtnSaludo.Name = "BtnSaludo";
            this.BtnSaludo.Size = new System.Drawing.Size(100, 50);
            this.BtnSaludo.TabIndex = 0;
            this.BtnSaludo.Text = "Hola";
            this.BtnSaludo.UseVisualStyleBackColor = false;
            this.BtnSaludo.Click += new System.EventHandler(this.BtnSaludo_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(86, 118);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.Text = "Escribe tu nombre:";
            // 
            // CbxSexo
            // 
            this.CbxSexo.FormattingEnabled = true;
            this.CbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Prefiero no decirlo",
            "No binario"});
            this.CbxSexo.Location = new System.Drawing.Point(86, 80);
            this.CbxSexo.Name = "CbxSexo";
            this.CbxSexo.Size = new System.Drawing.Size(100, 21);
            this.CbxSexo.TabIndex = 2;
            // 
            // DlgPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CbxSexo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BtnSaludo);
            this.Name = "DlgPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSaludo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox CbxSexo;
    }
}

