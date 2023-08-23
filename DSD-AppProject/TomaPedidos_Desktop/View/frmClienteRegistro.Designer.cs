namespace TomaPedidos.View
{
    partial class frmClienteRegistro
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
            this.cmbTipoPersona = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDocNumber = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTelf2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelf1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersonaContact = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoPersona
            // 
            this.cmbTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPersona.FormattingEnabled = true;
            this.cmbTipoPersona.Location = new System.Drawing.Point(140, 15);
            this.cmbTipoPersona.Name = "cmbTipoPersona";
            this.cmbTipoPersona.Size = new System.Drawing.Size(248, 21);
            this.cmbTipoPersona.TabIndex = 0;
            this.cmbTipoPersona.SelectionChangeCommitted += new System.EventHandler(this.CmbTipoPersona_SelectionChangeCommitted);
            // 
            // label15
            // 
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Location = new System.Drawing.Point(418, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Dirección";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Location = new System.Drawing.Point(37, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Apellido Materno";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label17.Location = new System.Drawing.Point(37, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Apellido Paterno";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Location = new System.Drawing.Point(37, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Nombres";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label19.Location = new System.Drawing.Point(11, 213);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "N° de Documento";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.Location = new System.Drawing.Point(11, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Razón Social";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label21.Location = new System.Drawing.Point(11, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "Tipo de documento";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(11, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(123, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "Tipo de Persona";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombres
            // 
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(140, 124);
            this.txtNombres.MaxLength = 20;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(248, 22);
            this.txtNombres.TabIndex = 4;
            this.txtNombres.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombres_Validating);
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Enabled = false;
            this.txtApePaterno.Location = new System.Drawing.Point(140, 152);
            this.txtApePaterno.MaxLength = 20;
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(248, 22);
            this.txtApePaterno.TabIndex = 5;
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Enabled = false;
            this.txtApeMaterno.Location = new System.Drawing.Point(140, 180);
            this.txtApeMaterno.MaxLength = 20;
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(248, 22);
            this.txtApeMaterno.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(511, 125);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(248, 22);
            this.txtDireccion.TabIndex = 12;
            // 
            // txtDocNumber
            // 
            this.txtDocNumber.Enabled = false;
            this.txtDocNumber.Location = new System.Drawing.Point(140, 208);
            this.txtDocNumber.MaxLength = 32;
            this.txtDocNumber.Name = "txtDocNumber";
            this.txtDocNumber.Size = new System.Drawing.Size(248, 22);
            this.txtDocNumber.TabIndex = 7;
            this.txtDocNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOnlyNumbers_KeyPress);
            this.txtDocNumber.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDocNumber_Validating);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(140, 70);
            this.txtRazonSocial.MaxLength = 100;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(248, 22);
            this.txtRazonSocial.TabIndex = 2;
            this.txtRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.TxtClientName_Validating);
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.Enabled = false;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(140, 42);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(248, 21);
            this.cmbTipoDoc.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(10, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Crear";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(128, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtTelf2
            // 
            this.txtTelf2.Enabled = false;
            this.txtTelf2.Location = new System.Drawing.Point(511, 70);
            this.txtTelf2.MaxLength = 20;
            this.txtTelf2.Name = "txtTelf2";
            this.txtTelf2.Size = new System.Drawing.Size(248, 22);
            this.txtTelf2.TabIndex = 10;
            this.txtTelf2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOnlyNumbers_KeyPress);
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(382, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Teléfono 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(511, 98);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(248, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(382, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Correo electrónico";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelf1
            // 
            this.txtTelf1.Enabled = false;
            this.txtTelf1.Location = new System.Drawing.Point(511, 43);
            this.txtTelf1.MaxLength = 20;
            this.txtTelf1.Name = "txtTelf1";
            this.txtTelf1.Size = new System.Drawing.Size(248, 22);
            this.txtTelf1.TabIndex = 9;
            this.txtTelf1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOnlyNumbers_KeyPress);
            // 
            // label3
            // 
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(382, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Teléfono 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(511, 16);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(248, 22);
            this.txtCelular.TabIndex = 8;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOnlyNumbers_KeyPress);
            // 
            // label4
            // 
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(382, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Celular";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNotas
            // 
            this.txtNotas.Enabled = false;
            this.txtNotas.Location = new System.Drawing.Point(511, 154);
            this.txtNotas.MaxLength = 100;
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(248, 76);
            this.txtNotas.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(382, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Comentarios";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(14, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Persona de Contacto";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPersonaContact
            // 
            this.txtPersonaContact.Enabled = false;
            this.txtPersonaContact.Location = new System.Drawing.Point(140, 97);
            this.txtPersonaContact.MaxLength = 35;
            this.txtPersonaContact.Name = "txtPersonaContact";
            this.txtPersonaContact.Size = new System.Drawing.Size(248, 22);
            this.txtPersonaContact.TabIndex = 3;
            // 
            // frmClienteRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(777, 279);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPersonaContact);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelf1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelf2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.txtDocNumber);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cmbTipoPersona);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtApeMaterno);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApePaterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClienteRegistro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Cliente";
            this.Load += new System.EventHandler(this.FrmClienteRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cmbTipoPersona;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public System.Windows.Forms.TextBox txtDocNumber;
        public System.Windows.Forms.TextBox txtRazonSocial;
        public System.Windows.Forms.TextBox txtTelf1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTelf2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPersonaContact;
    }
}