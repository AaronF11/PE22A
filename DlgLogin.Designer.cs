namespace PE22A
{
    partial class DlgLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgLogin));
            this.LnblContraseñaLogin = new System.Windows.Forms.LinkLabel();
            this.BtnEntrarLogin = new System.Windows.Forms.Button();
            this.LblTituloLogin = new System.Windows.Forms.Label();
            this.TxtContraseñaLogin = new System.Windows.Forms.TextBox();
            this.LblContraseñaLogin = new System.Windows.Forms.Label();
            this.TxtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.PnlIzquierdoLogin = new System.Windows.Forms.Panel();
            this.PtbIzquierdoLogin = new System.Windows.Forms.PictureBox();
            this.LblUsuarioLogin = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnVerOcultar = new System.Windows.Forms.Button();
            this.BtnLoginResize = new System.Windows.Forms.Button();
            this.BtnLoginCerrar = new System.Windows.Forms.Button();
            this.PnlIzquierdoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbIzquierdoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // LnblContraseñaLogin
            // 
            this.LnblContraseñaLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LnblContraseñaLogin.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LnblContraseñaLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnblContraseñaLogin.LinkColor = System.Drawing.Color.DodgerBlue;
            this.LnblContraseñaLogin.Location = new System.Drawing.Point(282, 243);
            this.LnblContraseñaLogin.Name = "LnblContraseñaLogin";
            this.LnblContraseñaLogin.Size = new System.Drawing.Size(448, 25);
            this.LnblContraseñaLogin.TabIndex = 14;
            this.LnblContraseñaLogin.TabStop = true;
            this.LnblContraseñaLogin.Text = "¿Ha olvidado su contraseña?";
            this.LnblContraseñaLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEntrarLogin
            // 
            this.BtnEntrarLogin.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnEntrarLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnEntrarLogin.FlatAppearance.BorderSize = 0;
            this.BtnEntrarLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnEntrarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnEntrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrarLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrarLogin.ForeColor = System.Drawing.Color.Crimson;
            this.BtnEntrarLogin.Location = new System.Drawing.Point(285, 190);
            this.BtnEntrarLogin.Name = "BtnEntrarLogin";
            this.BtnEntrarLogin.Size = new System.Drawing.Size(445, 40);
            this.BtnEntrarLogin.TabIndex = 18;
            this.BtnEntrarLogin.Text = "ENTRAR";
            this.BtnEntrarLogin.UseVisualStyleBackColor = false;
            this.BtnEntrarLogin.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // LblTituloLogin
            // 
            this.LblTituloLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTituloLogin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloLogin.ForeColor = System.Drawing.Color.White;
            this.LblTituloLogin.Location = new System.Drawing.Point(250, 0);
            this.LblTituloLogin.Name = "LblTituloLogin";
            this.LblTituloLogin.Size = new System.Drawing.Size(525, 33);
            this.LblTituloLogin.TabIndex = 21;
            this.LblTituloLogin.Text = "LOGIN";
            this.LblTituloLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTituloLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblTituloLogin_MouseDown);
            // 
            // TxtContraseñaLogin
            // 
            this.TxtContraseñaLogin.BackColor = System.Drawing.Color.Crimson;
            this.TxtContraseñaLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContraseñaLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseñaLogin.ForeColor = System.Drawing.Color.LavenderBlush;
            this.TxtContraseñaLogin.Location = new System.Drawing.Point(285, 127);
            this.TxtContraseñaLogin.Name = "TxtContraseñaLogin";
            this.TxtContraseñaLogin.Size = new System.Drawing.Size(437, 20);
            this.TxtContraseñaLogin.TabIndex = 17;
            this.TxtContraseñaLogin.Text = "CONTRASEÑA";
            this.TxtContraseñaLogin.Enter += new System.EventHandler(this.TxtContraseña_Enter);
            this.TxtContraseñaLogin.Leave += new System.EventHandler(this.TxtContraseña_Leave);
            // 
            // LblContraseñaLogin
            // 
            this.LblContraseñaLogin.AutoSize = true;
            this.LblContraseñaLogin.ForeColor = System.Drawing.Color.White;
            this.LblContraseñaLogin.Location = new System.Drawing.Point(282, 136);
            this.LblContraseñaLogin.Name = "LblContraseñaLogin";
            this.LblContraseñaLogin.Size = new System.Drawing.Size(445, 13);
            this.LblContraseñaLogin.TabIndex = 20;
            this.LblContraseñaLogin.Text = "_________________________________________________________________________";
            // 
            // TxtUsuarioLogin
            // 
            this.TxtUsuarioLogin.BackColor = System.Drawing.Color.Crimson;
            this.TxtUsuarioLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuarioLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuarioLogin.ForeColor = System.Drawing.Color.LavenderBlush;
            this.TxtUsuarioLogin.Location = new System.Drawing.Point(285, 77);
            this.TxtUsuarioLogin.Name = "TxtUsuarioLogin";
            this.TxtUsuarioLogin.Size = new System.Drawing.Size(437, 20);
            this.TxtUsuarioLogin.TabIndex = 16;
            this.TxtUsuarioLogin.Text = "USUARIO";
            this.TxtUsuarioLogin.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuarioLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            this.TxtUsuarioLogin.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // PnlIzquierdoLogin
            // 
            this.PnlIzquierdoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PnlIzquierdoLogin.Controls.Add(this.PtbIzquierdoLogin);
            this.PnlIzquierdoLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdoLogin.Location = new System.Drawing.Point(0, 0);
            this.PnlIzquierdoLogin.Name = "PnlIzquierdoLogin";
            this.PnlIzquierdoLogin.Size = new System.Drawing.Size(250, 290);
            this.PnlIzquierdoLogin.TabIndex = 15;
            // 
            // PtbIzquierdoLogin
            // 
            this.PtbIzquierdoLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbIzquierdoLogin.Image = global::PE22A.Properties.Resources.Fondo;
            this.PtbIzquierdoLogin.Location = new System.Drawing.Point(0, 0);
            this.PtbIzquierdoLogin.Name = "PtbIzquierdoLogin";
            this.PtbIzquierdoLogin.Size = new System.Drawing.Size(250, 290);
            this.PtbIzquierdoLogin.TabIndex = 11;
            this.PtbIzquierdoLogin.TabStop = false;
            // 
            // LblUsuarioLogin
            // 
            this.LblUsuarioLogin.AutoSize = true;
            this.LblUsuarioLogin.ForeColor = System.Drawing.Color.White;
            this.LblUsuarioLogin.Location = new System.Drawing.Point(282, 86);
            this.LblUsuarioLogin.Name = "LblUsuarioLogin";
            this.LblUsuarioLogin.Size = new System.Drawing.Size(445, 13);
            this.LblUsuarioLogin.TabIndex = 19;
            this.LblUsuarioLogin.Text = "_________________________________________________________________________";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Location = new System.Drawing.Point(740, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(35, 30);
            this.BtnCerrar.TabIndex = 22;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // BtnVerOcultar
            // 
            this.BtnVerOcultar.BackColor = System.Drawing.Color.Transparent;
            this.BtnVerOcultar.BackgroundImage = global::PE22A.Properties.Resources.icons8_eye_26px;
            this.BtnVerOcultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVerOcultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnVerOcultar.FlatAppearance.BorderSize = 0;
            this.BtnVerOcultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnVerOcultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnVerOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerOcultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerOcultar.ForeColor = System.Drawing.Color.White;
            this.BtnVerOcultar.Location = new System.Drawing.Point(700, 125);
            this.BtnVerOcultar.Name = "BtnVerOcultar";
            this.BtnVerOcultar.Size = new System.Drawing.Size(22, 22);
            this.BtnVerOcultar.TabIndex = 25;
            this.BtnVerOcultar.UseVisualStyleBackColor = false;
            this.BtnVerOcultar.Click += new System.EventHandler(this.BtnVerOcultar_Click);
            // 
            // BtnLoginResize
            // 
            this.BtnLoginResize.BackColor = System.Drawing.Color.Transparent;
            this.BtnLoginResize.BackgroundImage = global::PE22A.Properties.Resources.icons8_minimize_window_26px;
            this.BtnLoginResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLoginResize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnLoginResize.FlatAppearance.BorderSize = 0;
            this.BtnLoginResize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnLoginResize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnLoginResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoginResize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginResize.ForeColor = System.Drawing.Color.White;
            this.BtnLoginResize.Location = new System.Drawing.Point(719, 8);
            this.BtnLoginResize.Name = "BtnLoginResize";
            this.BtnLoginResize.Size = new System.Drawing.Size(22, 22);
            this.BtnLoginResize.TabIndex = 24;
            this.BtnLoginResize.UseVisualStyleBackColor = false;
            this.BtnLoginResize.Click += new System.EventHandler(this.BtnLoginResize_Click);
            // 
            // BtnLoginCerrar
            // 
            this.BtnLoginCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLoginCerrar.BackgroundImage = global::PE22A.Properties.Resources.icons8_shutdown_26px;
            this.BtnLoginCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLoginCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnLoginCerrar.FlatAppearance.BorderSize = 0;
            this.BtnLoginCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnLoginCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnLoginCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoginCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnLoginCerrar.Location = new System.Drawing.Point(747, 8);
            this.BtnLoginCerrar.Name = "BtnLoginCerrar";
            this.BtnLoginCerrar.Size = new System.Drawing.Size(22, 22);
            this.BtnLoginCerrar.TabIndex = 23;
            this.BtnLoginCerrar.UseVisualStyleBackColor = false;
            this.BtnLoginCerrar.Click += new System.EventHandler(this.BtnLoginCerrar_Click);
            // 
            // DlgLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(775, 290);
            this.Controls.Add(this.BtnVerOcultar);
            this.Controls.Add(this.BtnLoginResize);
            this.Controls.Add(this.BtnLoginCerrar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LnblContraseñaLogin);
            this.Controls.Add(this.BtnEntrarLogin);
            this.Controls.Add(this.LblTituloLogin);
            this.Controls.Add(this.TxtContraseñaLogin);
            this.Controls.Add(this.LblContraseñaLogin);
            this.Controls.Add(this.TxtUsuarioLogin);
            this.Controls.Add(this.PnlIzquierdoLogin);
            this.Controls.Add(this.LblUsuarioLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.DlgLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblTituloLogin_MouseDown);
            this.PnlIzquierdoLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbIzquierdoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbIzquierdoLogin;
        private System.Windows.Forms.LinkLabel LnblContraseñaLogin;
        private System.Windows.Forms.Button BtnEntrarLogin;
        private System.Windows.Forms.Label LblTituloLogin;
        private System.Windows.Forms.TextBox TxtContraseñaLogin;
        private System.Windows.Forms.Label LblContraseñaLogin;
        private System.Windows.Forms.TextBox TxtUsuarioLogin;
        private System.Windows.Forms.Panel PnlIzquierdoLogin;
        private System.Windows.Forms.Label LblUsuarioLogin;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnLoginCerrar;
        private System.Windows.Forms.Button BtnLoginResize;
        private System.Windows.Forms.Button BtnVerOcultar;
    }
}