namespace PE22A
{
    partial class DlgReproductor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgReproductor));
            this.Contador = new System.Windows.Forms.Timer(this.components);
            this.PnlArribaDlgReproductor = new System.Windows.Forms.Panel();
            this.BtnResize = new System.Windows.Forms.Button();
            this.BtnFullScreen = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.LblVolumen = new System.Windows.Forms.Label();
            this.MtbVolumen = new XComponent.SliderBar.MACTrackBar();
            this.BtnAdelantar = new System.Windows.Forms.Button();
            this.BtnRetroceder = new System.Windows.Forms.Button();
            this.BtnVolumen = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.LblFin = new System.Windows.Forms.Label();
            this.LblInicio = new System.Windows.Forms.Label();
            this.MtbTiempo = new XComponent.SliderBar.MACTrackBar();
            this.PnlControlesReproductor = new System.Windows.Forms.Panel();
            this.BtnRepoducir = new System.Windows.Forms.Button();
            this.BtnPausar = new System.Windows.Forms.Button();
            this.WmpReproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.PnlArribaDlgReproductor.SuspendLayout();
            this.PnlControlesReproductor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WmpReproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // Contador
            // 
            this.Contador.Tick += new System.EventHandler(this.Contador_Tick);
            // 
            // PnlArribaDlgReproductor
            // 
            this.PnlArribaDlgReproductor.BackColor = System.Drawing.Color.Crimson;
            this.PnlArribaDlgReproductor.Controls.Add(this.BtnResize);
            this.PnlArribaDlgReproductor.Controls.Add(this.BtnFullScreen);
            this.PnlArribaDlgReproductor.Controls.Add(this.BtnCerrar);
            this.PnlArribaDlgReproductor.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlArribaDlgReproductor.Location = new System.Drawing.Point(0, 0);
            this.PnlArribaDlgReproductor.Name = "PnlArribaDlgReproductor";
            this.PnlArribaDlgReproductor.Size = new System.Drawing.Size(1239, 22);
            this.PnlArribaDlgReproductor.TabIndex = 4;
            this.PnlArribaDlgReproductor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlArribaDlgReproductor_MouseDown);
            // 
            // BtnResize
            // 
            this.BtnResize.BackColor = System.Drawing.Color.Crimson;
            this.BtnResize.BackgroundImage = global::PE22A.Properties.Resources.icons8_minimize_window_26px;
            this.BtnResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnResize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnResize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnResize.FlatAppearance.BorderSize = 0;
            this.BtnResize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnResize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResize.ForeColor = System.Drawing.Color.White;
            this.BtnResize.Location = new System.Drawing.Point(1173, 0);
            this.BtnResize.Name = "BtnResize";
            this.BtnResize.Size = new System.Drawing.Size(22, 22);
            this.BtnResize.TabIndex = 29;
            this.BtnResize.UseVisualStyleBackColor = false;
            this.BtnResize.Click += new System.EventHandler(this.PtbMinimizarDlgReproductor_Click);
            // 
            // BtnFullScreen
            // 
            this.BtnFullScreen.BackColor = System.Drawing.Color.Crimson;
            this.BtnFullScreen.BackgroundImage = global::PE22A.Properties.Resources.icons8_drag_26px;
            this.BtnFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFullScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnFullScreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnFullScreen.FlatAppearance.BorderSize = 0;
            this.BtnFullScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnFullScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFullScreen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFullScreen.ForeColor = System.Drawing.Color.White;
            this.BtnFullScreen.Location = new System.Drawing.Point(1195, 0);
            this.BtnFullScreen.Name = "BtnFullScreen";
            this.BtnFullScreen.Size = new System.Drawing.Size(22, 22);
            this.BtnFullScreen.TabIndex = 30;
            this.BtnFullScreen.UseVisualStyleBackColor = false;
            this.BtnFullScreen.Click += new System.EventHandler(this.PtbMaximizarDlgReproductor_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.BackgroundImage = global::PE22A.Properties.Resources.icons8_shutdown_26px;
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(1217, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(22, 22);
            this.BtnCerrar.TabIndex = 28;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.PtbCerrarDlgReproductor_Click);
            // 
            // LblVolumen
            // 
            this.LblVolumen.AutoSize = true;
            this.LblVolumen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVolumen.Location = new System.Drawing.Point(1150, 50);
            this.LblVolumen.Name = "LblVolumen";
            this.LblVolumen.Size = new System.Drawing.Size(21, 16);
            this.LblVolumen.TabIndex = 11;
            this.LblVolumen.Text = "50";
            this.LblVolumen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MtbVolumen
            // 
            this.MtbVolumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.MtbVolumen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.MtbVolumen.BorderStyle = XComponent.SliderBar.MACBorderStyle.Inset;
            this.MtbVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.MtbVolumen.IndentHeight = 6;
            this.MtbVolumen.Location = new System.Drawing.Point(1019, 44);
            this.MtbVolumen.Maximum = 100;
            this.MtbVolumen.Minimum = 0;
            this.MtbVolumen.Name = "MtbVolumen";
            this.MtbVolumen.Size = new System.Drawing.Size(125, 28);
            this.MtbVolumen.TabIndex = 1;
            this.MtbVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.MtbVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.MtbVolumen.TickHeight = 1;
            this.MtbVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MtbVolumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.MtbVolumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.MtbVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.MtbVolumen.TrackLineHeight = 3;
            this.MtbVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.MtbVolumen.Value = 50;
            this.MtbVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.MtbVolumen_ValueChanged);
            // 
            // BtnAdelantar
            // 
            this.BtnAdelantar.FlatAppearance.BorderSize = 0;
            this.BtnAdelantar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdelantar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdelantar.Image")));
            this.BtnAdelantar.Location = new System.Drawing.Point(751, 42);
            this.BtnAdelantar.Name = "BtnAdelantar";
            this.BtnAdelantar.Size = new System.Drawing.Size(60, 30);
            this.BtnAdelantar.TabIndex = 8;
            this.BtnAdelantar.UseVisualStyleBackColor = true;
            this.BtnAdelantar.Click += new System.EventHandler(this.BtnAdelantar_Click);
            // 
            // BtnRetroceder
            // 
            this.BtnRetroceder.FlatAppearance.BorderSize = 0;
            this.BtnRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetroceder.Image = ((System.Drawing.Image)(resources.GetObject("BtnRetroceder.Image")));
            this.BtnRetroceder.Location = new System.Drawing.Point(407, 42);
            this.BtnRetroceder.Name = "BtnRetroceder";
            this.BtnRetroceder.Size = new System.Drawing.Size(60, 30);
            this.BtnRetroceder.TabIndex = 7;
            this.BtnRetroceder.UseVisualStyleBackColor = true;
            this.BtnRetroceder.Click += new System.EventHandler(this.BtnRetroceder_Click);
            // 
            // BtnVolumen
            // 
            this.BtnVolumen.FlatAppearance.BorderSize = 0;
            this.BtnVolumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolumen.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolumen.Image")));
            this.BtnVolumen.Location = new System.Drawing.Point(933, 37);
            this.BtnVolumen.Name = "BtnVolumen";
            this.BtnVolumen.Size = new System.Drawing.Size(80, 40);
            this.BtnVolumen.TabIndex = 6;
            this.BtnVolumen.UseVisualStyleBackColor = true;
            this.BtnVolumen.Click += new System.EventHandler(this.BtnVolumen_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.FlatAppearance.BorderSize = 0;
            this.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("BtnSiguiente.Image")));
            this.BtnSiguiente.Location = new System.Drawing.Point(666, 38);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(80, 40);
            this.BtnSiguiente.TabIndex = 5;
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.FlatAppearance.BorderSize = 0;
            this.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnterior.Image")));
            this.BtnAnterior.Location = new System.Drawing.Point(474, 38);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(80, 40);
            this.BtnAnterior.TabIndex = 4;
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // LblFin
            // 
            this.LblFin.AutoSize = true;
            this.LblFin.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblFin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFin.Location = new System.Drawing.Point(1207, 28);
            this.LblFin.Name = "LblFin";
            this.LblFin.Size = new System.Drawing.Size(32, 16);
            this.LblFin.TabIndex = 2;
            this.LblFin.Text = "0:00";
            this.LblFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicio.Location = new System.Drawing.Point(0, 28);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(32, 16);
            this.LblInicio.TabIndex = 1;
            this.LblInicio.Text = "0:00";
            this.LblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MtbTiempo
            // 
            this.MtbTiempo.BackColor = System.Drawing.Color.Transparent;
            this.MtbTiempo.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.MtbTiempo.Dock = System.Windows.Forms.DockStyle.Top;
            this.MtbTiempo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.MtbTiempo.IndentHeight = 6;
            this.MtbTiempo.Location = new System.Drawing.Point(0, 0);
            this.MtbTiempo.Maximum = 100;
            this.MtbTiempo.Minimum = 0;
            this.MtbTiempo.Name = "MtbTiempo";
            this.MtbTiempo.Size = new System.Drawing.Size(1239, 28);
            this.MtbTiempo.TabIndex = 0;
            this.MtbTiempo.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.MtbTiempo.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.MtbTiempo.TickHeight = 1;
            this.MtbTiempo.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MtbTiempo.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.MtbTiempo.TrackerSize = new System.Drawing.Size(16, 16);
            this.MtbTiempo.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.MtbTiempo.TrackLineHeight = 6;
            this.MtbTiempo.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.MtbTiempo.Value = 0;
            this.MtbTiempo.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.MtbTiempo_ValueChanged);
            // 
            // PnlControlesReproductor
            // 
            this.PnlControlesReproductor.BackColor = System.Drawing.Color.Crimson;
            this.PnlControlesReproductor.Controls.Add(this.LblVolumen);
            this.PnlControlesReproductor.Controls.Add(this.MtbVolumen);
            this.PnlControlesReproductor.Controls.Add(this.BtnAdelantar);
            this.PnlControlesReproductor.Controls.Add(this.BtnRetroceder);
            this.PnlControlesReproductor.Controls.Add(this.BtnVolumen);
            this.PnlControlesReproductor.Controls.Add(this.BtnSiguiente);
            this.PnlControlesReproductor.Controls.Add(this.BtnAnterior);
            this.PnlControlesReproductor.Controls.Add(this.LblFin);
            this.PnlControlesReproductor.Controls.Add(this.LblInicio);
            this.PnlControlesReproductor.Controls.Add(this.MtbTiempo);
            this.PnlControlesReproductor.Controls.Add(this.BtnRepoducir);
            this.PnlControlesReproductor.Controls.Add(this.BtnPausar);
            this.PnlControlesReproductor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlControlesReproductor.Location = new System.Drawing.Point(0, 603);
            this.PnlControlesReproductor.Name = "PnlControlesReproductor";
            this.PnlControlesReproductor.Size = new System.Drawing.Size(1239, 97);
            this.PnlControlesReproductor.TabIndex = 3;
            // 
            // BtnRepoducir
            // 
            this.BtnRepoducir.FlatAppearance.BorderSize = 0;
            this.BtnRepoducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRepoducir.Image = ((System.Drawing.Image)(resources.GetObject("BtnRepoducir.Image")));
            this.BtnRepoducir.Location = new System.Drawing.Point(559, 32);
            this.BtnRepoducir.Name = "BtnRepoducir";
            this.BtnRepoducir.Size = new System.Drawing.Size(100, 50);
            this.BtnRepoducir.TabIndex = 3;
            this.BtnRepoducir.UseVisualStyleBackColor = true;
            this.BtnRepoducir.Click += new System.EventHandler(this.BtnRepoducir_Click);
            // 
            // BtnPausar
            // 
            this.BtnPausar.FlatAppearance.BorderSize = 0;
            this.BtnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPausar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPausar.Image")));
            this.BtnPausar.Location = new System.Drawing.Point(559, 32);
            this.BtnPausar.Name = "BtnPausar";
            this.BtnPausar.Size = new System.Drawing.Size(100, 50);
            this.BtnPausar.TabIndex = 9;
            this.BtnPausar.UseVisualStyleBackColor = true;
            this.BtnPausar.Click += new System.EventHandler(this.BtnPausar_Click);
            // 
            // WmpReproductor
            // 
            this.WmpReproductor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WmpReproductor.Enabled = true;
            this.WmpReproductor.Location = new System.Drawing.Point(0, 22);
            this.WmpReproductor.Name = "WmpReproductor";
            this.WmpReproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WmpReproductor.OcxState")));
            this.WmpReproductor.Size = new System.Drawing.Size(1239, 581);
            this.WmpReproductor.TabIndex = 5;
            // 
            // DlgReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1239, 700);
            this.Controls.Add(this.WmpReproductor);
            this.Controls.Add(this.PnlArribaDlgReproductor);
            this.Controls.Add(this.PnlControlesReproductor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgReproductor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DlgReproductor_Load);
            this.PnlArribaDlgReproductor.ResumeLayout(false);
            this.PnlControlesReproductor.ResumeLayout(false);
            this.PnlControlesReproductor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WmpReproductor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Contador;
        private System.Windows.Forms.Panel PnlArribaDlgReproductor;
        private System.Windows.Forms.Label LblVolumen;
        private XComponent.SliderBar.MACTrackBar MtbVolumen;
        private System.Windows.Forms.Button BtnAdelantar;
        private System.Windows.Forms.Button BtnRetroceder;
        private System.Windows.Forms.Button BtnVolumen;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Label LblFin;
        private System.Windows.Forms.Label LblInicio;
        private XComponent.SliderBar.MACTrackBar MtbTiempo;
        private System.Windows.Forms.Panel PnlControlesReproductor;
        private System.Windows.Forms.Button BtnRepoducir;
        private AxWMPLib.AxWindowsMediaPlayer WmpReproductor;
        private System.Windows.Forms.Button BtnResize;
        private System.Windows.Forms.Button BtnFullScreen;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnPausar;
    }
}