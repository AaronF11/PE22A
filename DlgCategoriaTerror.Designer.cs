namespace PE22A
{
    partial class DlgCategoriaTerror
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
            this.BntPeli4 = new System.Windows.Forms.Button();
            this.BntPeli6 = new System.Windows.Forms.Button();
            this.BntPeli11 = new System.Windows.Forms.Button();
            this.FlpDlgCategoriaInicio = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlAtras = new System.Windows.Forms.Panel();
            this.FlpDlgCategoriaInicio.SuspendLayout();
            this.PnlAtras.SuspendLayout();
            this.SuspendLayout();
            // 
            // BntPeli4
            // 
            this.BntPeli4.BackgroundImage = global::PE22A.Properties.Resources.Dead_space_downfall;
            this.BntPeli4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BntPeli4.FlatAppearance.BorderSize = 0;
            this.BntPeli4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntPeli4.Location = new System.Drawing.Point(53, 28);
            this.BntPeli4.Name = "BntPeli4";
            this.BntPeli4.Size = new System.Drawing.Size(150, 200);
            this.BntPeli4.TabIndex = 3;
            this.BntPeli4.UseVisualStyleBackColor = true;
            this.BntPeli4.Click += new System.EventHandler(this.BntPeli4_Click);
            // 
            // BntPeli6
            // 
            this.BntPeli6.BackgroundImage = global::PE22A.Properties.Resources.El_hombre_invisible;
            this.BntPeli6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BntPeli6.FlatAppearance.BorderSize = 0;
            this.BntPeli6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntPeli6.Location = new System.Drawing.Point(209, 28);
            this.BntPeli6.Name = "BntPeli6";
            this.BntPeli6.Size = new System.Drawing.Size(150, 200);
            this.BntPeli6.TabIndex = 5;
            this.BntPeli6.UseVisualStyleBackColor = true;
            this.BntPeli6.Click += new System.EventHandler(this.BntPeli6_Click);
            // 
            // BntPeli11
            // 
            this.BntPeli11.BackgroundImage = global::PE22A.Properties.Resources.La_purga_infinita;
            this.BntPeli11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BntPeli11.FlatAppearance.BorderSize = 0;
            this.BntPeli11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntPeli11.Location = new System.Drawing.Point(365, 28);
            this.BntPeli11.Name = "BntPeli11";
            this.BntPeli11.Size = new System.Drawing.Size(150, 200);
            this.BntPeli11.TabIndex = 10;
            this.BntPeli11.UseVisualStyleBackColor = true;
            this.BntPeli11.Click += new System.EventHandler(this.BntPeli11_Click);
            // 
            // FlpDlgCategoriaInicio
            // 
            this.FlpDlgCategoriaInicio.BackColor = System.Drawing.Color.Transparent;
            this.FlpDlgCategoriaInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlpDlgCategoriaInicio.Controls.Add(this.BntPeli4);
            this.FlpDlgCategoriaInicio.Controls.Add(this.BntPeli6);
            this.FlpDlgCategoriaInicio.Controls.Add(this.BntPeli11);
            this.FlpDlgCategoriaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpDlgCategoriaInicio.Location = new System.Drawing.Point(0, 0);
            this.FlpDlgCategoriaInicio.Name = "FlpDlgCategoriaInicio";
            this.FlpDlgCategoriaInicio.Padding = new System.Windows.Forms.Padding(50, 25, 0, 25);
            this.FlpDlgCategoriaInicio.Size = new System.Drawing.Size(1039, 678);
            this.FlpDlgCategoriaInicio.TabIndex = 20;
            // 
            // PnlAtras
            // 
            this.PnlAtras.Controls.Add(this.FlpDlgCategoriaInicio);
            this.PnlAtras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAtras.Location = new System.Drawing.Point(0, 0);
            this.PnlAtras.Name = "PnlAtras";
            this.PnlAtras.Size = new System.Drawing.Size(1039, 678);
            this.PnlAtras.TabIndex = 26;
            // 
            // DlgCategoriaTerror
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1039, 678);
            this.Controls.Add(this.PnlAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DlgCategoriaTerror";
            this.Text = "DlgCategoriaTerror";
            this.FlpDlgCategoriaInicio.ResumeLayout(false);
            this.PnlAtras.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BntPeli4;
        private System.Windows.Forms.Button BntPeli6;
        private System.Windows.Forms.Button BntPeli11;
        private System.Windows.Forms.FlowLayoutPanel FlpDlgCategoriaInicio;
        private System.Windows.Forms.Panel PnlAtras;
    }
}