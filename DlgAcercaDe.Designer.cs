namespace PE22A
{
    partial class DlgAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgAcercaDe));
            this.LblVersion = new System.Windows.Forms.Label();
            this.PnlArribaMenu = new System.Windows.Forms.Panel();
            this.BtnMenuResize = new System.Windows.Forms.Button();
            this.BtnMenuCerrar = new System.Windows.Forms.Button();
            this.LnkLblRepositorio = new System.Windows.Forms.LinkLabel();
            this.LblRepositorio = new System.Windows.Forms.Label();
            this.LnkLblAutor = new System.Windows.Forms.LinkLabel();
            this.LblAutor = new System.Windows.Forms.Label();
            this.PnlArribaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblVersion
            // 
            this.LblVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblVersion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersion.Location = new System.Drawing.Point(0, 22);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(291, 48);
            this.LblVersion.TabIndex = 8;
            this.LblVersion.Text = "Versión:\r\n2.0";
            this.LblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PnlArribaMenu
            // 
            this.PnlArribaMenu.BackColor = System.Drawing.Color.Crimson;
            this.PnlArribaMenu.Controls.Add(this.BtnMenuResize);
            this.PnlArribaMenu.Controls.Add(this.BtnMenuCerrar);
            this.PnlArribaMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlArribaMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlArribaMenu.Name = "PnlArribaMenu";
            this.PnlArribaMenu.Size = new System.Drawing.Size(291, 22);
            this.PnlArribaMenu.TabIndex = 7;
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
            this.BtnMenuResize.Location = new System.Drawing.Point(247, 0);
            this.BtnMenuResize.Name = "BtnMenuResize";
            this.BtnMenuResize.Size = new System.Drawing.Size(22, 22);
            this.BtnMenuResize.TabIndex = 28;
            this.BtnMenuResize.UseVisualStyleBackColor = false;
            this.BtnMenuResize.Click += new System.EventHandler(this.BtnResize_Click);
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
            this.BtnMenuCerrar.Location = new System.Drawing.Point(269, 0);
            this.BtnMenuCerrar.Name = "BtnMenuCerrar";
            this.BtnMenuCerrar.Size = new System.Drawing.Size(22, 22);
            this.BtnMenuCerrar.TabIndex = 27;
            this.BtnMenuCerrar.UseVisualStyleBackColor = false;
            this.BtnMenuCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LnkLblRepositorio
            // 
            this.LnkLblRepositorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.LnkLblRepositorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblRepositorio.Location = new System.Drawing.Point(0, 141);
            this.LnkLblRepositorio.Name = "LnkLblRepositorio";
            this.LnkLblRepositorio.Size = new System.Drawing.Size(291, 23);
            this.LnkLblRepositorio.TabIndex = 12;
            this.LnkLblRepositorio.TabStop = true;
            this.LnkLblRepositorio.Text = "PE22A - Práctica 10";
            this.LnkLblRepositorio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LnkLblRepositorio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblRepositorio_LinkClicked);
            // 
            // LblRepositorio
            // 
            this.LblRepositorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblRepositorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRepositorio.Location = new System.Drawing.Point(0, 117);
            this.LblRepositorio.Name = "LblRepositorio";
            this.LblRepositorio.Size = new System.Drawing.Size(291, 24);
            this.LblRepositorio.TabIndex = 10;
            this.LblRepositorio.Text = "Repositorio:";
            this.LblRepositorio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LnkLblAutor
            // 
            this.LnkLblAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.LnkLblAutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblAutor.Location = new System.Drawing.Point(0, 94);
            this.LnkLblAutor.Name = "LnkLblAutor";
            this.LnkLblAutor.Size = new System.Drawing.Size(291, 23);
            this.LnkLblAutor.TabIndex = 11;
            this.LnkLblAutor.TabStop = true;
            this.LnkLblAutor.Text = "Aarón Flores Pasos";
            this.LnkLblAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LnkLblAutor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblAutor_LinkClicked);
            // 
            // LblAutor
            // 
            this.LblAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblAutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.Location = new System.Drawing.Point(0, 70);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(291, 24);
            this.LblAutor.TabIndex = 9;
            this.LblAutor.Text = "Perfil de GitHub:";
            this.LblAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DlgAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 174);
            this.Controls.Add(this.LnkLblRepositorio);
            this.Controls.Add(this.LblRepositorio);
            this.Controls.Add(this.LnkLblAutor);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.PnlArribaMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de";
            this.PnlArribaMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Panel PnlArribaMenu;
        private System.Windows.Forms.LinkLabel LnkLblRepositorio;
        private System.Windows.Forms.Label LblRepositorio;
        private System.Windows.Forms.LinkLabel LnkLblAutor;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Button BtnMenuResize;
        private System.Windows.Forms.Button BtnMenuCerrar;
    }
}