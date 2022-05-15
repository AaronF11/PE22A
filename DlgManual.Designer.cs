namespace PE22A
{
    partial class DlgManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgManual));
            this.TimerReproducir = new System.Windows.Forms.Timer(this.components);
            this.BtnAutomaticoModos = new System.Windows.Forms.Button();
            this.BtnPausarModos = new System.Windows.Forms.Button();
            this.BtnContinuarModos = new System.Windows.Forms.Button();
            this.PtbImagenModos = new System.Windows.Forms.PictureBox();
            this.PnlControlesModos = new System.Windows.Forms.Panel();
            this.TpManualModos = new System.Windows.Forms.TabPage();
            this.LblInfoModos = new System.Windows.Forms.Label();
            this.BtnAutomaticoReproducir = new System.Windows.Forms.Button();
            this.BtnPausarReproducir = new System.Windows.Forms.Button();
            this.LblInfoReproducir = new System.Windows.Forms.Label();
            this.BtnContinuarReproducir = new System.Windows.Forms.Button();
            this.PtbImagenReproducir = new System.Windows.Forms.PictureBox();
            this.PnlControlesReproducir = new System.Windows.Forms.Panel();
            this.TpManualReproducir = new System.Windows.Forms.TabPage();
            this.TbcManuales = new System.Windows.Forms.TabControl();
            this.PnlArribaManual = new System.Windows.Forms.Panel();
            this.BtnMenuResize = new System.Windows.Forms.Button();
            this.BtnMenuFullScreen = new System.Windows.Forms.Button();
            this.BtnMenuCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagenModos)).BeginInit();
            this.PnlControlesModos.SuspendLayout();
            this.TpManualModos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagenReproducir)).BeginInit();
            this.PnlControlesReproducir.SuspendLayout();
            this.TpManualReproducir.SuspendLayout();
            this.TbcManuales.SuspendLayout();
            this.PnlArribaManual.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerReproducir
            // 
            this.TimerReproducir.Interval = 2000;
            this.TimerReproducir.Tick += new System.EventHandler(this.TimerReproducir_Tick);
            // 
            // BtnAutomaticoModos
            // 
            this.BtnAutomaticoModos.BackColor = System.Drawing.Color.Crimson;
            this.BtnAutomaticoModos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAutomaticoModos.ForeColor = System.Drawing.Color.LavenderBlush;
            this.BtnAutomaticoModos.Location = new System.Drawing.Point(0, -3);
            this.BtnAutomaticoModos.Name = "BtnAutomaticoModos";
            this.BtnAutomaticoModos.Size = new System.Drawing.Size(1225, 28);
            this.BtnAutomaticoModos.TabIndex = 3;
            this.BtnAutomaticoModos.Text = "Automatico";
            this.BtnAutomaticoModos.UseVisualStyleBackColor = false;
            this.BtnAutomaticoModos.Click += new System.EventHandler(this.BtnAutomaticoModos_Click);
            // 
            // BtnPausarModos
            // 
            this.BtnPausarModos.BackColor = System.Drawing.Color.Crimson;
            this.BtnPausarModos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnPausarModos.ForeColor = System.Drawing.Color.LavenderBlush;
            this.BtnPausarModos.Location = new System.Drawing.Point(0, 25);
            this.BtnPausarModos.Name = "BtnPausarModos";
            this.BtnPausarModos.Size = new System.Drawing.Size(1225, 28);
            this.BtnPausarModos.TabIndex = 2;
            this.BtnPausarModos.Text = "Pausar";
            this.BtnPausarModos.UseVisualStyleBackColor = false;
            this.BtnPausarModos.Click += new System.EventHandler(this.BtnPausarModos_Click);
            // 
            // BtnContinuarModos
            // 
            this.BtnContinuarModos.BackColor = System.Drawing.Color.Crimson;
            this.BtnContinuarModos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnContinuarModos.ForeColor = System.Drawing.Color.LavenderBlush;
            this.BtnContinuarModos.Location = new System.Drawing.Point(0, 53);
            this.BtnContinuarModos.Name = "BtnContinuarModos";
            this.BtnContinuarModos.Size = new System.Drawing.Size(1225, 28);
            this.BtnContinuarModos.TabIndex = 4;
            this.BtnContinuarModos.Text = "Continuar";
            this.BtnContinuarModos.UseVisualStyleBackColor = false;
            this.BtnContinuarModos.Click += new System.EventHandler(this.BtnContinuarModos_Click);
            // 
            // PtbImagenModos
            // 
            this.PtbImagenModos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PtbImagenModos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbImagenModos.Location = new System.Drawing.Point(3, 29);
            this.PtbImagenModos.Name = "PtbImagenModos";
            this.PtbImagenModos.Size = new System.Drawing.Size(1225, 531);
            this.PtbImagenModos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbImagenModos.TabIndex = 4;
            this.PtbImagenModos.TabStop = false;
            // 
            // PnlControlesModos
            // 
            this.PnlControlesModos.Controls.Add(this.BtnAutomaticoModos);
            this.PnlControlesModos.Controls.Add(this.BtnPausarModos);
            this.PnlControlesModos.Controls.Add(this.BtnContinuarModos);
            this.PnlControlesModos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlControlesModos.Location = new System.Drawing.Point(3, 560);
            this.PnlControlesModos.Name = "PnlControlesModos";
            this.PnlControlesModos.Size = new System.Drawing.Size(1225, 81);
            this.PnlControlesModos.TabIndex = 3;
            // 
            // TpManualModos
            // 
            this.TpManualModos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(30)))));
            this.TpManualModos.Controls.Add(this.PtbImagenModos);
            this.TpManualModos.Controls.Add(this.PnlControlesModos);
            this.TpManualModos.Controls.Add(this.LblInfoModos);
            this.TpManualModos.Location = new System.Drawing.Point(4, 30);
            this.TpManualModos.Name = "TpManualModos";
            this.TpManualModos.Padding = new System.Windows.Forms.Padding(3);
            this.TpManualModos.Size = new System.Drawing.Size(1231, 644);
            this.TpManualModos.TabIndex = 1;
            this.TpManualModos.Text = "Modos";
            // 
            // LblInfoModos
            // 
            this.LblInfoModos.BackColor = System.Drawing.Color.Crimson;
            this.LblInfoModos.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblInfoModos.Location = new System.Drawing.Point(3, 3);
            this.LblInfoModos.Name = "LblInfoModos";
            this.LblInfoModos.Size = new System.Drawing.Size(1225, 26);
            this.LblInfoModos.TabIndex = 2;
            this.LblInfoModos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAutomaticoReproducir
            // 
            this.BtnAutomaticoReproducir.BackColor = System.Drawing.Color.Crimson;
            this.BtnAutomaticoReproducir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAutomaticoReproducir.ForeColor = System.Drawing.Color.LavenderBlush;
            this.BtnAutomaticoReproducir.Location = new System.Drawing.Point(0, -3);
            this.BtnAutomaticoReproducir.Name = "BtnAutomaticoReproducir";
            this.BtnAutomaticoReproducir.Size = new System.Drawing.Size(1225, 28);
            this.BtnAutomaticoReproducir.TabIndex = 3;
            this.BtnAutomaticoReproducir.Text = "Automatico";
            this.BtnAutomaticoReproducir.UseVisualStyleBackColor = false;
            this.BtnAutomaticoReproducir.Click += new System.EventHandler(this.BtnAutomaticoReproducir_Click);
            // 
            // BtnPausarReproducir
            // 
            this.BtnPausarReproducir.BackColor = System.Drawing.Color.Crimson;
            this.BtnPausarReproducir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnPausarReproducir.ForeColor = System.Drawing.Color.LavenderBlush;
            this.BtnPausarReproducir.Location = new System.Drawing.Point(0, 25);
            this.BtnPausarReproducir.Name = "BtnPausarReproducir";
            this.BtnPausarReproducir.Size = new System.Drawing.Size(1225, 28);
            this.BtnPausarReproducir.TabIndex = 2;
            this.BtnPausarReproducir.Text = "Pausar";
            this.BtnPausarReproducir.UseVisualStyleBackColor = false;
            this.BtnPausarReproducir.Click += new System.EventHandler(this.BtnPausarReproducir_Click);
            // 
            // LblInfoReproducir
            // 
            this.LblInfoReproducir.BackColor = System.Drawing.Color.Crimson;
            this.LblInfoReproducir.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblInfoReproducir.Location = new System.Drawing.Point(3, 3);
            this.LblInfoReproducir.Name = "LblInfoReproducir";
            this.LblInfoReproducir.Size = new System.Drawing.Size(1225, 26);
            this.LblInfoReproducir.TabIndex = 0;
            this.LblInfoReproducir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnContinuarReproducir
            // 
            this.BtnContinuarReproducir.BackColor = System.Drawing.Color.Crimson;
            this.BtnContinuarReproducir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnContinuarReproducir.ForeColor = System.Drawing.Color.LavenderBlush;
            this.BtnContinuarReproducir.Location = new System.Drawing.Point(0, 53);
            this.BtnContinuarReproducir.Name = "BtnContinuarReproducir";
            this.BtnContinuarReproducir.Size = new System.Drawing.Size(1225, 28);
            this.BtnContinuarReproducir.TabIndex = 4;
            this.BtnContinuarReproducir.Text = "Continuar";
            this.BtnContinuarReproducir.UseVisualStyleBackColor = false;
            this.BtnContinuarReproducir.Click += new System.EventHandler(this.BtnContinuarReproducir_Click);
            // 
            // PtbImagenReproducir
            // 
            this.PtbImagenReproducir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PtbImagenReproducir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbImagenReproducir.Location = new System.Drawing.Point(3, 29);
            this.PtbImagenReproducir.Name = "PtbImagenReproducir";
            this.PtbImagenReproducir.Size = new System.Drawing.Size(1225, 531);
            this.PtbImagenReproducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbImagenReproducir.TabIndex = 0;
            this.PtbImagenReproducir.TabStop = false;
            // 
            // PnlControlesReproducir
            // 
            this.PnlControlesReproducir.Controls.Add(this.BtnAutomaticoReproducir);
            this.PnlControlesReproducir.Controls.Add(this.BtnPausarReproducir);
            this.PnlControlesReproducir.Controls.Add(this.BtnContinuarReproducir);
            this.PnlControlesReproducir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlControlesReproducir.Location = new System.Drawing.Point(3, 560);
            this.PnlControlesReproducir.Name = "PnlControlesReproducir";
            this.PnlControlesReproducir.Size = new System.Drawing.Size(1225, 81);
            this.PnlControlesReproducir.TabIndex = 1;
            // 
            // TpManualReproducir
            // 
            this.TpManualReproducir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(30)))));
            this.TpManualReproducir.Controls.Add(this.PtbImagenReproducir);
            this.TpManualReproducir.Controls.Add(this.PnlControlesReproducir);
            this.TpManualReproducir.Controls.Add(this.LblInfoReproducir);
            this.TpManualReproducir.Location = new System.Drawing.Point(4, 30);
            this.TpManualReproducir.Name = "TpManualReproducir";
            this.TpManualReproducir.Padding = new System.Windows.Forms.Padding(3);
            this.TpManualReproducir.Size = new System.Drawing.Size(1231, 644);
            this.TpManualReproducir.TabIndex = 0;
            this.TpManualReproducir.Text = "Reproducir";
            // 
            // TbcManuales
            // 
            this.TbcManuales.Controls.Add(this.TpManualReproducir);
            this.TbcManuales.Controls.Add(this.TpManualModos);
            this.TbcManuales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbcManuales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbcManuales.Location = new System.Drawing.Point(0, 22);
            this.TbcManuales.Name = "TbcManuales";
            this.TbcManuales.SelectedIndex = 0;
            this.TbcManuales.Size = new System.Drawing.Size(1239, 678);
            this.TbcManuales.TabIndex = 5;
            // 
            // PnlArribaManual
            // 
            this.PnlArribaManual.BackColor = System.Drawing.Color.Crimson;
            this.PnlArribaManual.Controls.Add(this.BtnMenuResize);
            this.PnlArribaManual.Controls.Add(this.BtnMenuFullScreen);
            this.PnlArribaManual.Controls.Add(this.BtnMenuCerrar);
            this.PnlArribaManual.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlArribaManual.Location = new System.Drawing.Point(0, 0);
            this.PnlArribaManual.Name = "PnlArribaManual";
            this.PnlArribaManual.Size = new System.Drawing.Size(1239, 22);
            this.PnlArribaManual.TabIndex = 4;
            this.PnlArribaManual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlArribaManual_MouseDown);
            // 
            // BtnMenuResize
            // 
            this.BtnMenuResize.BackColor = System.Drawing.Color.Crimson;
            this.BtnMenuResize.BackgroundImage = global::PE22A.Properties.Resources.icons8_minimize_window_26px;
            this.BtnMenuResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenuResize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMenuResize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnMenuResize.FlatAppearance.BorderSize = 0;
            this.BtnMenuResize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnMenuResize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnMenuResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuResize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenuResize.ForeColor = System.Drawing.Color.White;
            this.BtnMenuResize.Location = new System.Drawing.Point(1173, 0);
            this.BtnMenuResize.Name = "BtnMenuResize";
            this.BtnMenuResize.Size = new System.Drawing.Size(22, 22);
            this.BtnMenuResize.TabIndex = 29;
            this.BtnMenuResize.UseVisualStyleBackColor = false;
            this.BtnMenuResize.Click += new System.EventHandler(this.BtnResize_Click);
            // 
            // BtnMenuFullScreen
            // 
            this.BtnMenuFullScreen.BackColor = System.Drawing.Color.Crimson;
            this.BtnMenuFullScreen.BackgroundImage = global::PE22A.Properties.Resources.icons8_drag_26px;
            this.BtnMenuFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenuFullScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMenuFullScreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnMenuFullScreen.FlatAppearance.BorderSize = 0;
            this.BtnMenuFullScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnMenuFullScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnMenuFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuFullScreen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenuFullScreen.ForeColor = System.Drawing.Color.White;
            this.BtnMenuFullScreen.Location = new System.Drawing.Point(1195, 0);
            this.BtnMenuFullScreen.Name = "BtnMenuFullScreen";
            this.BtnMenuFullScreen.Size = new System.Drawing.Size(22, 22);
            this.BtnMenuFullScreen.TabIndex = 30;
            this.BtnMenuFullScreen.UseVisualStyleBackColor = false;
            this.BtnMenuFullScreen.Click += new System.EventHandler(this.BtnFullScreen_Click);
            // 
            // BtnMenuCerrar
            // 
            this.BtnMenuCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnMenuCerrar.BackgroundImage = global::PE22A.Properties.Resources.icons8_shutdown_26px;
            this.BtnMenuCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenuCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMenuCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnMenuCerrar.FlatAppearance.BorderSize = 0;
            this.BtnMenuCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnMenuCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnMenuCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenuCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnMenuCerrar.Location = new System.Drawing.Point(1217, 0);
            this.BtnMenuCerrar.Name = "BtnMenuCerrar";
            this.BtnMenuCerrar.Size = new System.Drawing.Size(22, 22);
            this.BtnMenuCerrar.TabIndex = 28;
            this.BtnMenuCerrar.UseVisualStyleBackColor = false;
            this.BtnMenuCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // DlgManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 700);
            this.Controls.Add(this.TbcManuales);
            this.Controls.Add(this.PnlArribaManual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual";
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagenModos)).EndInit();
            this.PnlControlesModos.ResumeLayout(false);
            this.TpManualModos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagenReproducir)).EndInit();
            this.PnlControlesReproducir.ResumeLayout(false);
            this.TpManualReproducir.ResumeLayout(false);
            this.TbcManuales.ResumeLayout(false);
            this.PnlArribaManual.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimerReproducir;
        private System.Windows.Forms.Button BtnAutomaticoModos;
        private System.Windows.Forms.Button BtnPausarModos;
        private System.Windows.Forms.Button BtnContinuarModos;
        private System.Windows.Forms.PictureBox PtbImagenModos;
        private System.Windows.Forms.Panel PnlControlesModos;
        private System.Windows.Forms.TabPage TpManualModos;
        private System.Windows.Forms.Label LblInfoModos;
        private System.Windows.Forms.Button BtnAutomaticoReproducir;
        private System.Windows.Forms.Button BtnPausarReproducir;
        private System.Windows.Forms.Label LblInfoReproducir;
        private System.Windows.Forms.Button BtnContinuarReproducir;
        private System.Windows.Forms.PictureBox PtbImagenReproducir;
        private System.Windows.Forms.Panel PnlControlesReproducir;
        private System.Windows.Forms.TabPage TpManualReproducir;
        private System.Windows.Forms.TabControl TbcManuales;
        private System.Windows.Forms.Panel PnlArribaManual;
        private System.Windows.Forms.Button BtnMenuResize;
        private System.Windows.Forms.Button BtnMenuFullScreen;
        private System.Windows.Forms.Button BtnMenuCerrar;
    }
}