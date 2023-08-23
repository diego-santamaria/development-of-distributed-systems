using TomaPedidos.Commons;
namespace TomaPedidos.View
{
    partial class frmActividadRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActividadRegistro));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbActividad = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDiaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHorafin = new System.Windows.Forms.DateTimePicker();
            this.dtpDiafin = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.cmbRepetición = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtTlf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAsunto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabCtrlDetalles = new System.Windows.Forms.TabControl();
            this.tabPagGeneral = new System.Windows.Forms.TabPage();
            this.txtRepeticionAux = new System.Windows.Forms.TextBox();
            this.txtPrioridadAux = new System.Windows.Forms.TextBox();
            this.txtDiaInicioAux = new System.Windows.Forms.TextBox();
            this.txtDiaFinAux = new System.Windows.Forms.TextBox();
            this.txtHoraInicioAux = new System.Windows.Forms.TextBox();
            this.txtHoraFinAux = new System.Windows.Forms.TextBox();
            this.tabPagContenido = new System.Windows.Forms.TabPage();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.errorProvAct = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNumActividad = new System.Windows.Forms.TextBox();
            this.chkCerrarActividad = new System.Windows.Forms.CheckBox();
            this.toolTipActividades = new System.Windows.Forms.ToolTip(this.components);
            this.txtActividadAux = new System.Windows.Forms.TextBox();
            this.tabCtrlDetalles.SuspendLayout();
            this.tabPagGeneral.SuspendLayout();
            this.tabPagContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvAct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actividad";
            // 
            // cmbActividad
            // 
            this.cmbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActividad.FormattingEnabled = true;
            this.cmbActividad.Location = new System.Drawing.Point(102, 14);
            this.cmbActividad.Name = "cmbActividad";
            this.cmbActividad.Size = new System.Drawing.Size(175, 21);
            this.cmbActividad.TabIndex = 1;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(102, 41);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(175, 21);
            this.cmbTipo.TabIndex = 2;
            this.cmbTipo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(372, 41);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(188, 22);
            this.txtNombreCliente.TabIndex = 7;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(104, 75);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(416, 22);
            this.txtDetalle.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Comentarios:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(372, 14);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.ReadOnly = true;
            this.txtCodCliente.Size = new System.Drawing.Size(188, 22);
            this.txtCodCliente.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cod. Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hora de inicio";
            // 
            // dtpDiaInicio
            // 
            this.dtpDiaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiaInicio.Location = new System.Drawing.Point(104, 17);
            this.dtpDiaInicio.Name = "dtpDiaInicio";
            this.dtpDiaInicio.Size = new System.Drawing.Size(98, 22);
            this.dtpDiaInicio.TabIndex = 5;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(208, 17);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(86, 22);
            this.dtpHoraInicio.TabIndex = 6;
            this.dtpHoraInicio.Value = new System.DateTime(2016, 7, 6, 8, 0, 0, 0);
            // 
            // dtpHorafin
            // 
            this.dtpHorafin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorafin.Location = new System.Drawing.Point(208, 44);
            this.dtpHorafin.Name = "dtpHorafin";
            this.dtpHorafin.Size = new System.Drawing.Size(86, 22);
            this.dtpHorafin.TabIndex = 8;
            this.dtpHorafin.Value = new System.DateTime(2016, 7, 6, 8, 30, 0, 0);
            // 
            // dtpDiafin
            // 
            this.dtpDiafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiafin.Location = new System.Drawing.Point(104, 44);
            this.dtpDiafin.Name = "dtpDiafin";
            this.dtpDiafin.Size = new System.Drawing.Size(98, 22);
            this.dtpDiafin.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Hora de fin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Prioridad";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(374, 17);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(146, 21);
            this.cmbPrioridad.TabIndex = 9;
            // 
            // cmbRepetición
            // 
            this.cmbRepetición.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepetición.FormattingEnabled = true;
            this.cmbRepetición.Location = new System.Drawing.Point(374, 44);
            this.cmbRepetición.Name = "cmbRepetición";
            this.cmbRepetición.Size = new System.Drawing.Size(146, 21);
            this.cmbRepetición.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Repetición";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(95, 253);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrear.Location = new System.Drawing.Point(14, 253);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 14;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtTlf
            // 
            this.txtTlf.Location = new System.Drawing.Point(371, 69);
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Size = new System.Drawing.Size(189, 22);
            this.txtTlf.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Teléfono";
            // 
            // cmbAsunto
            // 
            this.cmbAsunto.FormattingEnabled = true;
            this.cmbAsunto.Location = new System.Drawing.Point(102, 69);
            this.cmbAsunto.Name = "cmbAsunto";
            this.cmbAsunto.Size = new System.Drawing.Size(175, 21);
            this.cmbAsunto.TabIndex = 3;
            this.cmbAsunto.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Asunto";
            this.label11.Visible = false;
            // 
            // tabCtrlDetalles
            // 
            this.tabCtrlDetalles.Controls.Add(this.tabPagGeneral);
            this.tabCtrlDetalles.Controls.Add(this.tabPagContenido);
            this.tabCtrlDetalles.Location = new System.Drawing.Point(14, 102);
            this.tabCtrlDetalles.Name = "tabCtrlDetalles";
            this.tabCtrlDetalles.SelectedIndex = 0;
            this.tabCtrlDetalles.Size = new System.Drawing.Size(547, 135);
            this.tabCtrlDetalles.TabIndex = 12;
            // 
            // tabPagGeneral
            // 
            this.tabPagGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPagGeneral.Controls.Add(this.label5);
            this.tabPagGeneral.Controls.Add(this.txtDetalle);
            this.tabPagGeneral.Controls.Add(this.label7);
            this.tabPagGeneral.Controls.Add(this.label8);
            this.tabPagGeneral.Controls.Add(this.label3);
            this.tabPagGeneral.Controls.Add(this.label10);
            this.tabPagGeneral.Controls.Add(this.cmbPrioridad);
            this.tabPagGeneral.Controls.Add(this.cmbRepetición);
            this.tabPagGeneral.Controls.Add(this.dtpDiaInicio);
            this.tabPagGeneral.Controls.Add(this.dtpHoraInicio);
            this.tabPagGeneral.Controls.Add(this.dtpHorafin);
            this.tabPagGeneral.Controls.Add(this.dtpDiafin);
            this.tabPagGeneral.Controls.Add(this.txtRepeticionAux);
            this.tabPagGeneral.Controls.Add(this.txtPrioridadAux);
            this.tabPagGeneral.Controls.Add(this.txtDiaInicioAux);
            this.tabPagGeneral.Controls.Add(this.txtDiaFinAux);
            this.tabPagGeneral.Controls.Add(this.txtHoraInicioAux);
            this.tabPagGeneral.Controls.Add(this.txtHoraFinAux);
            this.tabPagGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPagGeneral.Name = "tabPagGeneral";
            this.tabPagGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagGeneral.Size = new System.Drawing.Size(539, 109);
            this.tabPagGeneral.TabIndex = 0;
            this.tabPagGeneral.Text = "General";
            this.tabPagGeneral.UseVisualStyleBackColor = true;
            // 
            // txtRepeticionAux
            // 
            this.txtRepeticionAux.Location = new System.Drawing.Point(374, 16);
            this.txtRepeticionAux.Name = "txtRepeticionAux";
            this.txtRepeticionAux.ReadOnly = true;
            this.txtRepeticionAux.Size = new System.Drawing.Size(146, 22);
            this.txtRepeticionAux.TabIndex = 23;
            this.txtRepeticionAux.Visible = false;
            // 
            // txtPrioridadAux
            // 
            this.txtPrioridadAux.Location = new System.Drawing.Point(374, 43);
            this.txtPrioridadAux.Name = "txtPrioridadAux";
            this.txtPrioridadAux.ReadOnly = true;
            this.txtPrioridadAux.Size = new System.Drawing.Size(146, 22);
            this.txtPrioridadAux.TabIndex = 22;
            this.txtPrioridadAux.Visible = false;
            // 
            // txtDiaInicioAux
            // 
            this.txtDiaInicioAux.Location = new System.Drawing.Point(104, 17);
            this.txtDiaInicioAux.Name = "txtDiaInicioAux";
            this.txtDiaInicioAux.ReadOnly = true;
            this.txtDiaInicioAux.Size = new System.Drawing.Size(98, 22);
            this.txtDiaInicioAux.TabIndex = 30;
            this.txtDiaInicioAux.Visible = false;
            // 
            // txtDiaFinAux
            // 
            this.txtDiaFinAux.Location = new System.Drawing.Point(104, 44);
            this.txtDiaFinAux.Name = "txtDiaFinAux";
            this.txtDiaFinAux.ReadOnly = true;
            this.txtDiaFinAux.Size = new System.Drawing.Size(98, 22);
            this.txtDiaFinAux.TabIndex = 31;
            this.txtDiaFinAux.Visible = false;
            // 
            // txtHoraInicioAux
            // 
            this.txtHoraInicioAux.Location = new System.Drawing.Point(208, 17);
            this.txtHoraInicioAux.Name = "txtHoraInicioAux";
            this.txtHoraInicioAux.ReadOnly = true;
            this.txtHoraInicioAux.Size = new System.Drawing.Size(86, 22);
            this.txtHoraInicioAux.TabIndex = 32;
            this.txtHoraInicioAux.Visible = false;
            // 
            // txtHoraFinAux
            // 
            this.txtHoraFinAux.Location = new System.Drawing.Point(208, 44);
            this.txtHoraFinAux.Name = "txtHoraFinAux";
            this.txtHoraFinAux.ReadOnly = true;
            this.txtHoraFinAux.Size = new System.Drawing.Size(86, 22);
            this.txtHoraFinAux.TabIndex = 33;
            this.txtHoraFinAux.Visible = false;
            // 
            // tabPagContenido
            // 
            this.tabPagContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPagContenido.Controls.Add(this.txtNotas);
            this.tabPagContenido.Location = new System.Drawing.Point(4, 22);
            this.tabPagContenido.Name = "tabPagContenido";
            this.tabPagContenido.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagContenido.Size = new System.Drawing.Size(539, 109);
            this.tabPagContenido.TabIndex = 1;
            this.tabPagContenido.Text = "Contenido";
            this.tabPagContenido.UseVisualStyleBackColor = true;
            // 
            // txtNotas
            // 
            this.txtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotas.Location = new System.Drawing.Point(6, 6);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(525, 95);
            this.txtNotas.TabIndex = 13;
            // 
            // errorProvAct
            // 
            this.errorProvAct.ContainerControl = this;
            // 
            // txtNumActividad
            // 
            this.txtNumActividad.Enabled = false;
            this.txtNumActividad.Location = new System.Drawing.Point(-2, -2);
            this.txtNumActividad.Name = "txtNumActividad";
            this.txtNumActividad.Size = new System.Drawing.Size(21, 22);
            this.txtNumActividad.TabIndex = 28;
            this.txtNumActividad.Visible = false;
            // 
            // chkCerrarActividad
            // 
            this.chkCerrarActividad.AutoSize = true;
            this.chkCerrarActividad.Location = new System.Drawing.Point(450, 257);
            this.chkCerrarActividad.Name = "chkCerrarActividad";
            this.chkCerrarActividad.Size = new System.Drawing.Size(107, 17);
            this.chkCerrarActividad.TabIndex = 29;
            this.chkCerrarActividad.Text = "Cerrar Actividad";
            this.toolTipActividades.SetToolTip(this.chkCerrarActividad, "Marcar esta actividad como cerrada");
            this.chkCerrarActividad.UseVisualStyleBackColor = true;
            this.chkCerrarActividad.Visible = false;
            // 
            // txtActividadAux
            // 
            this.txtActividadAux.Location = new System.Drawing.Point(102, 13);
            this.txtActividadAux.Name = "txtActividadAux";
            this.txtActividadAux.ReadOnly = true;
            this.txtActividadAux.Size = new System.Drawing.Size(175, 22);
            this.txtActividadAux.TabIndex = 22;
            this.txtActividadAux.Visible = false;
            // 
            // frmActividadRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(581, 288);
            this.Controls.Add(this.chkCerrarActividad);
            this.Controls.Add(this.txtNumActividad);
            this.Controls.Add(this.tabCtrlDetalles);
            this.Controls.Add(this.cmbAsunto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTlf);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbActividad);
            this.Controls.Add(this.txtActividadAux);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActividadRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad";
            this.Load += new System.EventHandler(this.frmActividad_Load);
            this.tabCtrlDetalles.ResumeLayout(false);
            this.tabPagGeneral.ResumeLayout(false);
            this.tabPagGeneral.PerformLayout();
            this.tabPagContenido.ResumeLayout(false);
            this.tabPagContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvAct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDiaInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHorafin;
        private System.Windows.Forms.DateTimePicker dtpDiafin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.ComboBox cmbRepetición;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtTlf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbAsunto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabCtrlDetalles;
        private System.Windows.Forms.TabPage tabPagGeneral;
        private System.Windows.Forms.TabPage tabPagContenido;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.ErrorProvider errorProvAct;
        private System.Windows.Forms.TextBox txtNumActividad;
        private System.Windows.Forms.CheckBox chkCerrarActividad;
        private System.Windows.Forms.ToolTip toolTipActividades;
        private System.Windows.Forms.TextBox txtActividadAux;
        private System.Windows.Forms.TextBox txtPrioridadAux;
        private System.Windows.Forms.TextBox txtRepeticionAux;
        private System.Windows.Forms.TextBox txtDiaInicioAux;
        private System.Windows.Forms.TextBox txtDiaFinAux;
        private System.Windows.Forms.TextBox txtHoraInicioAux;
        private System.Windows.Forms.TextBox txtHoraFinAux;
    }
}