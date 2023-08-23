namespace TomaPedidos
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtPassw = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblVersionWebService = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReintentar = new System.Windows.Forms.Button();
            this.btnConversiones = new System.Windows.Forms.Button();
            this.btnVentaEquipos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picbPassw = new System.Windows.Forms.PictureBox();
            this.picbUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOportunidades = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbPassw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(147)))));
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(173)))), ((int)(((byte)(62)))));
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(173)))), ((int)(((byte)(62)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignIn.Location = new System.Drawing.Point(183, 419);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(257, 31);
            this.btnSignIn.TabIndex = 17;
            this.btnSignIn.Text = "Ingresar";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtPassw
            // 
            this.txtPassw.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconPadding(this.txtPassw, 2);
            this.txtPassw.Location = new System.Drawing.Point(170, 378);
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.PasswordChar = '●';
            this.txtPassw.Size = new System.Drawing.Size(280, 29);
            this.txtPassw.TabIndex = 13;
            this.txtPassw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassw_KeyPress);
            this.txtPassw.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassw_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconPadding(this.txtUserName, 2);
            this.txtUserName.Location = new System.Drawing.Point(170, 332);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(280, 29);
            this.txtUserName.TabIndex = 11;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // lblVersionWebService
            // 
            this.lblVersionWebService.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionWebService.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblVersionWebService.Location = new System.Drawing.Point(12, 474);
            this.lblVersionWebService.Name = "lblVersionWebService";
            this.lblVersionWebService.Size = new System.Drawing.Size(438, 13);
            this.lblVersionWebService.TabIndex = 22;
            this.lblVersionWebService.Text = "Versión del WebService";
            this.lblVersionWebService.MouseHover += new System.EventHandler(this.lblVersionWebService_MouseHover);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 150;
            this.errorProvider.ContainerControl = this;
            // 
            // btnReintentar
            // 
            this.btnReintentar.AutoSize = true;
            this.btnReintentar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReintentar.Image = global::TomaPedidos.Properties.Resources.img_autorenew_green;
            this.btnReintentar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReintentar.Location = new System.Drawing.Point(12, 446);
            this.btnReintentar.Name = "btnReintentar";
            this.btnReintentar.Size = new System.Drawing.Size(81, 23);
            this.btnReintentar.TabIndex = 24;
            this.btnReintentar.Text = "Reintentar";
            this.btnReintentar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReintentar.UseVisualStyleBackColor = true;
            this.btnReintentar.Visible = false;
            this.btnReintentar.Click += new System.EventHandler(this.btnReintentar_Click);
            // 
            // btnConversiones
            // 
            this.btnConversiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(173)))), ((int)(((byte)(62)))));
            this.btnConversiones.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConversiones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConversiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversiones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConversiones.Image = global::TomaPedidos.Properties.Resources.img_cached_white;
            this.btnConversiones.Location = new System.Drawing.Point(105, 323);
            this.btnConversiones.Name = "btnConversiones";
            this.btnConversiones.Size = new System.Drawing.Size(203, 56);
            this.btnConversiones.TabIndex = 8;
            this.btnConversiones.Text = "Conversiones";
            this.btnConversiones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConversiones.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConversiones.UseVisualStyleBackColor = false;
            this.btnConversiones.Visible = false;
            this.btnConversiones.Click += new System.EventHandler(this.btnConversiones_Click);
            // 
            // btnVentaEquipos
            // 
            this.btnVentaEquipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(173)))), ((int)(((byte)(62)))));
            this.btnVentaEquipos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVentaEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVentaEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaEquipos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVentaEquipos.Image = global::TomaPedidos.Properties.Resources.img_cart;
            this.btnVentaEquipos.Location = new System.Drawing.Point(314, 323);
            this.btnVentaEquipos.Name = "btnVentaEquipos";
            this.btnVentaEquipos.Size = new System.Drawing.Size(203, 56);
            this.btnVentaEquipos.TabIndex = 9;
            this.btnVentaEquipos.Text = "Venta de Equipos";
            this.btnVentaEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentaEquipos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVentaEquipos.UseVisualStyleBackColor = false;
            this.btnVentaEquipos.Visible = false;
            this.btnVentaEquipos.Click += new System.EventHandler(this.btnVentaEquipos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(173)))), ((int)(((byte)(62)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Image = global::TomaPedidos.Properties.Resources.img_logout_white;
            this.btnSalir.Location = new System.Drawing.Point(314, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(203, 56);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Cerrar sesión";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Visible = false;
            this.btnSalir.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // picbPassw
            // 
            this.picbPassw.Image = global::TomaPedidos.Properties.Resources.img_lock_open;
            this.picbPassw.Location = new System.Drawing.Point(138, 377);
            this.picbPassw.Name = "picbPassw";
            this.picbPassw.Size = new System.Drawing.Size(31, 29);
            this.picbPassw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbPassw.TabIndex = 19;
            this.picbPassw.TabStop = false;
            // 
            // picbUser
            // 
            this.picbUser.Image = global::TomaPedidos.Properties.Resources.img_account_key;
            this.picbUser.Location = new System.Drawing.Point(134, 332);
            this.picbUser.Name = "picbUser";
            this.picbUser.Size = new System.Drawing.Size(31, 29);
            this.picbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbUser.TabIndex = 18;
            this.picbUser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TomaPedidos.Properties.Resources.img_logang;
            this.pictureBox1.Location = new System.Drawing.Point(79, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnOportunidades
            // 
            this.btnOportunidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(173)))), ((int)(((byte)(62)))));
            this.btnOportunidades.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOportunidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOportunidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOportunidades.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOportunidades.Image = global::TomaPedidos.Properties.Resources.img_handshake;
            this.btnOportunidades.Location = new System.Drawing.Point(105, 385);
            this.btnOportunidades.Name = "btnOportunidades";
            this.btnOportunidades.Size = new System.Drawing.Size(203, 56);
            this.btnOportunidades.TabIndex = 10;
            this.btnOportunidades.Text = "Oportunidades";
            this.btnOportunidades.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOportunidades.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOportunidades.UseVisualStyleBackColor = false;
            this.btnOportunidades.Visible = false;
            this.btnOportunidades.Click += new System.EventHandler(this.btnOportunidades_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 495);
            this.Controls.Add(this.btnOportunidades);
            this.Controls.Add(this.btnReintentar);
            this.Controls.Add(this.lblVersionWebService);
            this.Controls.Add(this.btnConversiones);
            this.Controls.Add(this.btnVentaEquipos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.picbPassw);
            this.Controls.Add(this.picbUser);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPassw);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbPassw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbPassw;
        private System.Windows.Forms.PictureBox picbUser;
        private System.Windows.Forms.Button btnConversiones;
        private System.Windows.Forms.Button btnVentaEquipos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtPassw;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVersionWebService;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnReintentar;
        private System.Windows.Forms.Button btnOportunidades;
        private System.Windows.Forms.ToolTip toolTip;

    }
}

