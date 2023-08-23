namespace SalesOpportunityManagement.UserControls
{
    partial class ActivityUserControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PrioButto = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.UpdButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInformar = new System.Windows.Forms.Label();
            this.dgtActividades = new System.Windows.Forms.DataGridView();
            this.cClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNivelPrioridadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOportunidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoRepeticionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dComentariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPersonaContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRazonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fModificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.btnFindCli = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodActividad = new System.Windows.Forms.TextBox();
            this.chkCerrado = new System.Windows.Forms.CheckBox();
            this.cmbRepeticion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindOp = new System.Windows.Forms.Button();
            this.dtpDiaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHorafin = new System.Windows.Forms.DateTimePicker();
            this.dtpDiafin = new System.Windows.Forms.DateTimePicker();
            this.ActionBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodOpportunidad = new System.Windows.Forms.TextBox();
            this.cmbActividad = new System.Windows.Forms.ComboBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.panel4.Controls.Add(this.PrioButto);
            this.panel4.Controls.Add(this.DelButton);
            this.panel4.Controls.Add(this.UpdButton);
            this.panel4.Controls.Add(this.AddButton);
            this.panel4.Controls.Add(this.FindButton);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1009, 72);
            this.panel4.TabIndex = 16;
            // 
            // PrioButto
            // 
            this.PrioButto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrioButto.ForeColor = System.Drawing.Color.White;
            this.PrioButto.Image = global::SalesOpportunityManagement.Properties.Resources.notification_alert;
            this.PrioButto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrioButto.Location = new System.Drawing.Point(508, 11);
            this.PrioButto.Name = "PrioButto";
            this.PrioButto.Size = new System.Drawing.Size(117, 51);
            this.PrioButto.TabIndex = 4;
            this.PrioButto.Text = "        Priorizar";
            this.PrioButto.UseVisualStyleBackColor = true;
            this.PrioButto.Click += new System.EventHandler(this.PrioButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelButton.ForeColor = System.Drawing.Color.White;
            this.DelButton.Image = global::SalesOpportunityManagement.Properties.Resources.notification_delete;
            this.DelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DelButton.Location = new System.Drawing.Point(386, 11);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(117, 51);
            this.DelButton.TabIndex = 3;
            this.DelButton.Text = "        Eliminar";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // UpdButton
            // 
            this.UpdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdButton.ForeColor = System.Drawing.Color.White;
            this.UpdButton.Image = global::SalesOpportunityManagement.Properties.Resources.notification_update;
            this.UpdButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdButton.Location = new System.Drawing.Point(263, 11);
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(117, 51);
            this.UpdButton.TabIndex = 2;
            this.UpdButton.Text = "        Actualizar";
            this.UpdButton.UseVisualStyleBackColor = true;
            this.UpdButton.Click += new System.EventHandler(this.UpdButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Image = global::SalesOpportunityManagement.Properties.Resources.notification_add;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(140, 11);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 51);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "        Agregar";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindButton.ForeColor = System.Drawing.Color.White;
            this.FindButton.Image = global::SalesOpportunityManagement.Properties.Resources.notification_find;
            this.FindButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FindButton.Location = new System.Drawing.Point(17, 11);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(117, 51);
            this.FindButton.TabIndex = 0;
            this.FindButton.Text = "        Buscar";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gestión de actividades";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblInformar);
            this.panel1.Controls.Add(this.dgtActividades);
            this.panel1.Location = new System.Drawing.Point(478, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 496);
            this.panel1.TabIndex = 66;
            // 
            // lblInformar
            // 
            this.lblInformar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblInformar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblInformar.Location = new System.Drawing.Point(0, 0);
            this.lblInformar.Name = "lblInformar";
            this.lblInformar.Size = new System.Drawing.Size(499, 496);
            this.lblInformar.TabIndex = 17;
            this.lblInformar.Text = "La búsqueda no trajo registros coincidentes";
            this.lblInformar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgtActividades
            // 
            this.dgtActividades.AllowUserToAddRows = false;
            this.dgtActividades.AllowUserToDeleteRows = false;
            this.dgtActividades.AllowUserToOrderColumns = true;
            this.dgtActividades.AllowUserToResizeRows = false;
            this.dgtActividades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgtActividades.AutoGenerateColumns = false;
            this.dgtActividades.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgtActividades.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgtActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgtActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cClienteDataGridViewTextBoxColumn,
            this.cNivelPrioridadDataGridViewTextBoxColumn,
            this.cOportunidadDataGridViewTextBoxColumn,
            this.cTipoActividadDataGridViewTextBoxColumn,
            this.cTipoRepeticionDataGridViewTextBoxColumn,
            this.cUsuarioDataGridViewTextBoxColumn,
            this.dComentariosDataGridViewTextBoxColumn,
            this.dPersonaContactoDataGridViewTextBoxColumn,
            this.dRazonSocialDataGridViewTextBoxColumn,
            this.fFinDataGridViewTextBoxColumn,
            this.fInicioDataGridViewTextBoxColumn,
            this.fModificacionDataGridViewTextBoxColumn,
            this.fRegistroDataGridViewTextBoxColumn,
            this.nActividadDataGridViewTextBoxColumn,
            this.nTelefonoDataGridViewTextBoxColumn,
            this.sEstadoDataGridViewTextBoxColumn});
            this.dgtActividades.DataSource = this.actividadBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtActividades.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgtActividades.EnableHeadersVisualStyles = false;
            this.dgtActividades.Location = new System.Drawing.Point(0, 1);
            this.dgtActividades.MultiSelect = false;
            this.dgtActividades.Name = "dgtActividades";
            this.dgtActividades.ReadOnly = true;
            this.dgtActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtActividades.Size = new System.Drawing.Size(499, 496);
            this.dgtActividades.TabIndex = 16;
            this.dgtActividades.TabStop = false;
            this.dgtActividades.Click += new System.EventHandler(this.dgtActividades_Click);
            // 
            // cClienteDataGridViewTextBoxColumn
            // 
            this.cClienteDataGridViewTextBoxColumn.DataPropertyName = "cCliente";
            this.cClienteDataGridViewTextBoxColumn.HeaderText = "cCliente";
            this.cClienteDataGridViewTextBoxColumn.Name = "cClienteDataGridViewTextBoxColumn";
            this.cClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNivelPrioridadDataGridViewTextBoxColumn
            // 
            this.cNivelPrioridadDataGridViewTextBoxColumn.DataPropertyName = "cNivelPrioridad";
            this.cNivelPrioridadDataGridViewTextBoxColumn.HeaderText = "cNivelPrioridad";
            this.cNivelPrioridadDataGridViewTextBoxColumn.Name = "cNivelPrioridadDataGridViewTextBoxColumn";
            this.cNivelPrioridadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOportunidadDataGridViewTextBoxColumn
            // 
            this.cOportunidadDataGridViewTextBoxColumn.DataPropertyName = "cOportunidad";
            this.cOportunidadDataGridViewTextBoxColumn.HeaderText = "cOportunidad";
            this.cOportunidadDataGridViewTextBoxColumn.Name = "cOportunidadDataGridViewTextBoxColumn";
            this.cOportunidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTipoActividadDataGridViewTextBoxColumn
            // 
            this.cTipoActividadDataGridViewTextBoxColumn.DataPropertyName = "cTipoActividad";
            this.cTipoActividadDataGridViewTextBoxColumn.HeaderText = "cTipoActividad";
            this.cTipoActividadDataGridViewTextBoxColumn.Name = "cTipoActividadDataGridViewTextBoxColumn";
            this.cTipoActividadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTipoRepeticionDataGridViewTextBoxColumn
            // 
            this.cTipoRepeticionDataGridViewTextBoxColumn.DataPropertyName = "cTipoRepeticion";
            this.cTipoRepeticionDataGridViewTextBoxColumn.HeaderText = "cTipoRepeticion";
            this.cTipoRepeticionDataGridViewTextBoxColumn.Name = "cTipoRepeticionDataGridViewTextBoxColumn";
            this.cTipoRepeticionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUsuarioDataGridViewTextBoxColumn
            // 
            this.cUsuarioDataGridViewTextBoxColumn.DataPropertyName = "cUsuario";
            this.cUsuarioDataGridViewTextBoxColumn.HeaderText = "cUsuario";
            this.cUsuarioDataGridViewTextBoxColumn.Name = "cUsuarioDataGridViewTextBoxColumn";
            this.cUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dComentariosDataGridViewTextBoxColumn
            // 
            this.dComentariosDataGridViewTextBoxColumn.DataPropertyName = "dComentarios";
            this.dComentariosDataGridViewTextBoxColumn.HeaderText = "dComentarios";
            this.dComentariosDataGridViewTextBoxColumn.Name = "dComentariosDataGridViewTextBoxColumn";
            this.dComentariosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dPersonaContactoDataGridViewTextBoxColumn
            // 
            this.dPersonaContactoDataGridViewTextBoxColumn.DataPropertyName = "dPersonaContacto";
            this.dPersonaContactoDataGridViewTextBoxColumn.HeaderText = "dPersonaContacto";
            this.dPersonaContactoDataGridViewTextBoxColumn.Name = "dPersonaContactoDataGridViewTextBoxColumn";
            this.dPersonaContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dRazonSocialDataGridViewTextBoxColumn
            // 
            this.dRazonSocialDataGridViewTextBoxColumn.DataPropertyName = "dRazonSocial";
            this.dRazonSocialDataGridViewTextBoxColumn.HeaderText = "dRazonSocial";
            this.dRazonSocialDataGridViewTextBoxColumn.Name = "dRazonSocialDataGridViewTextBoxColumn";
            this.dRazonSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fFinDataGridViewTextBoxColumn
            // 
            this.fFinDataGridViewTextBoxColumn.DataPropertyName = "fFin";
            this.fFinDataGridViewTextBoxColumn.HeaderText = "fFin";
            this.fFinDataGridViewTextBoxColumn.Name = "fFinDataGridViewTextBoxColumn";
            this.fFinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fInicioDataGridViewTextBoxColumn
            // 
            this.fInicioDataGridViewTextBoxColumn.DataPropertyName = "fInicio";
            this.fInicioDataGridViewTextBoxColumn.HeaderText = "fInicio";
            this.fInicioDataGridViewTextBoxColumn.Name = "fInicioDataGridViewTextBoxColumn";
            this.fInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fModificacionDataGridViewTextBoxColumn
            // 
            this.fModificacionDataGridViewTextBoxColumn.DataPropertyName = "fModificacion";
            this.fModificacionDataGridViewTextBoxColumn.HeaderText = "fModificacion";
            this.fModificacionDataGridViewTextBoxColumn.Name = "fModificacionDataGridViewTextBoxColumn";
            this.fModificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fRegistroDataGridViewTextBoxColumn
            // 
            this.fRegistroDataGridViewTextBoxColumn.DataPropertyName = "fRegistro";
            this.fRegistroDataGridViewTextBoxColumn.HeaderText = "fRegistro";
            this.fRegistroDataGridViewTextBoxColumn.Name = "fRegistroDataGridViewTextBoxColumn";
            this.fRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nActividadDataGridViewTextBoxColumn
            // 
            this.nActividadDataGridViewTextBoxColumn.DataPropertyName = "nActividad";
            this.nActividadDataGridViewTextBoxColumn.HeaderText = "nActividad";
            this.nActividadDataGridViewTextBoxColumn.Name = "nActividadDataGridViewTextBoxColumn";
            this.nActividadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nTelefonoDataGridViewTextBoxColumn
            // 
            this.nTelefonoDataGridViewTextBoxColumn.DataPropertyName = "nTelefono";
            this.nTelefonoDataGridViewTextBoxColumn.HeaderText = "nTelefono";
            this.nTelefonoDataGridViewTextBoxColumn.Name = "nTelefonoDataGridViewTextBoxColumn";
            this.nTelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sEstadoDataGridViewTextBoxColumn
            // 
            this.sEstadoDataGridViewTextBoxColumn.DataPropertyName = "sEstado";
            this.sEstadoDataGridViewTextBoxColumn.HeaderText = "sEstado";
            this.sEstadoDataGridViewTextBoxColumn.Name = "sEstadoDataGridViewTextBoxColumn";
            this.sEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actividadBindingSource
            // 
            this.actividadBindingSource.DataSource = typeof(SalesOpportunityManagement.OfertaVentaWS.Actividad);
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.btnFindCli);
            this.InfoPanel.Controls.Add(this.label4);
            this.InfoPanel.Controls.Add(this.txtCodActividad);
            this.InfoPanel.Controls.Add(this.chkCerrado);
            this.InfoPanel.Controls.Add(this.cmbRepeticion);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.btnFindOp);
            this.InfoPanel.Controls.Add(this.dtpDiaInicio);
            this.InfoPanel.Controls.Add(this.dtpHoraInicio);
            this.InfoPanel.Controls.Add(this.dtpHorafin);
            this.InfoPanel.Controls.Add(this.dtpDiafin);
            this.InfoPanel.Controls.Add(this.ActionBtn);
            this.InfoPanel.Controls.Add(this.label13);
            this.InfoPanel.Controls.Add(this.label5);
            this.InfoPanel.Controls.Add(this.txtNotas);
            this.InfoPanel.Controls.Add(this.lblRazonSocial);
            this.InfoPanel.Controls.Add(this.txtCodigoCliente);
            this.InfoPanel.Controls.Add(this.label3);
            this.InfoPanel.Controls.Add(this.txtCodOpportunidad);
            this.InfoPanel.Controls.Add(this.cmbActividad);
            this.InfoPanel.Controls.Add(this.cmbPrioridad);
            this.InfoPanel.Controls.Add(this.label6);
            this.InfoPanel.Controls.Add(this.label8);
            this.InfoPanel.Controls.Add(this.label7);
            this.InfoPanel.Controls.Add(this.txtNombreCliente);
            this.InfoPanel.Controls.Add(this.txtTelefono);
            this.InfoPanel.Controls.Add(this.label16);
            this.InfoPanel.Controls.Add(this.txtContacto);
            this.InfoPanel.Controls.Add(this.label17);
            this.InfoPanel.Controls.Add(this.label18);
            this.InfoPanel.Location = new System.Drawing.Point(17, 134);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(438, 509);
            this.InfoPanel.TabIndex = 67;
            // 
            // btnFindCli
            // 
            this.btnFindCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCli.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCli.Image = global::SalesOpportunityManagement.Properties.Resources.search;
            this.btnFindCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindCli.Location = new System.Drawing.Point(359, 66);
            this.btnFindCli.Name = "btnFindCli";
            this.btnFindCli.Size = new System.Drawing.Size(77, 25);
            this.btnFindCli.TabIndex = 9;
            this.btnFindCli.Text = "   Buscar";
            this.btnFindCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindCli.UseVisualStyleBackColor = true;
            this.btnFindCli.Click += new System.EventHandler(this.btnFindCli_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = "Código de actividad";
            // 
            // txtCodActividad
            // 
            this.txtCodActividad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodActividad.Location = new System.Drawing.Point(172, 14);
            this.txtCodActividad.Name = "txtCodActividad";
            this.txtCodActividad.Size = new System.Drawing.Size(264, 25);
            this.txtCodActividad.TabIndex = 5;
            // 
            // chkCerrado
            // 
            this.chkCerrado.AutoSize = true;
            this.chkCerrado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCerrado.Location = new System.Drawing.Point(173, 367);
            this.chkCerrado.Name = "chkCerrado";
            this.chkCerrado.Size = new System.Drawing.Size(75, 21);
            this.chkCerrado.TabIndex = 20;
            this.chkCerrado.Text = "Cerrado";
            this.chkCerrado.UseVisualStyleBackColor = true;
            // 
            // cmbRepeticion
            // 
            this.cmbRepeticion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepeticion.Enabled = false;
            this.cmbRepeticion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRepeticion.FormattingEnabled = true;
            this.cmbRepeticion.Location = new System.Drawing.Point(172, 275);
            this.cmbRepeticion.Name = "cmbRepeticion";
            this.cmbRepeticion.Size = new System.Drawing.Size(264, 25);
            this.cmbRepeticion.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Repetición";
            // 
            // btnFindOp
            // 
            this.btnFindOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindOp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindOp.Image = global::SalesOpportunityManagement.Properties.Resources.search;
            this.btnFindOp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindOp.Location = new System.Drawing.Point(359, 40);
            this.btnFindOp.Name = "btnFindOp";
            this.btnFindOp.Size = new System.Drawing.Size(77, 25);
            this.btnFindOp.TabIndex = 7;
            this.btnFindOp.Text = "   Buscar";
            this.btnFindOp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindOp.UseVisualStyleBackColor = true;
            this.btnFindOp.Click += new System.EventHandler(this.btnFindOp_Click);
            // 
            // dtpDiaInicio
            // 
            this.dtpDiaInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDiaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiaInicio.Location = new System.Drawing.Point(172, 170);
            this.dtpDiaInicio.Name = "dtpDiaInicio";
            this.dtpDiaInicio.Size = new System.Drawing.Size(143, 25);
            this.dtpDiaInicio.TabIndex = 13;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(319, 170);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(117, 25);
            this.dtpHoraInicio.TabIndex = 14;
            this.dtpHoraInicio.Value = new System.DateTime(2016, 7, 6, 8, 0, 0, 0);
            // 
            // dtpHorafin
            // 
            this.dtpHorafin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHorafin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorafin.Location = new System.Drawing.Point(319, 197);
            this.dtpHorafin.Name = "dtpHorafin";
            this.dtpHorafin.Size = new System.Drawing.Size(117, 25);
            this.dtpHorafin.TabIndex = 16;
            this.dtpHorafin.Value = new System.DateTime(2016, 7, 6, 8, 30, 0, 0);
            // 
            // dtpDiafin
            // 
            this.dtpDiafin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDiafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiafin.Location = new System.Drawing.Point(172, 197);
            this.dtpDiafin.Name = "dtpDiafin";
            this.dtpDiafin.Size = new System.Drawing.Size(143, 25);
            this.dtpDiafin.TabIndex = 15;
            // 
            // ActionBtn
            // 
            this.ActionBtn.BackColor = System.Drawing.Color.White;
            this.ActionBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionBtn.Enabled = false;
            this.ActionBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ActionBtn.FlatAppearance.BorderSize = 2;
            this.ActionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ActionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActionBtn.Location = new System.Drawing.Point(0, 481);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(438, 28);
            this.ActionBtn.TabIndex = 21;
            this.ActionBtn.Text = "BUSCAR ACTIVIDAD";
            this.ActionBtn.UseVisualStyleBackColor = false;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 63;
            this.label13.Text = "Comentarios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Código de oportunidad";
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(172, 301);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(264, 63);
            this.txtNotas.TabIndex = 20;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(4, 68);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(111, 17);
            this.lblRazonSocial.TabIndex = 23;
            this.lblRazonSocial.Text = "Código de cliente";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(172, 66);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(185, 25);
            this.txtCodigoCliente.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Hora fin";
            // 
            // txtCodOpportunidad
            // 
            this.txtCodOpportunidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodOpportunidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodOpportunidad.Location = new System.Drawing.Point(172, 40);
            this.txtCodOpportunidad.Name = "txtCodOpportunidad";
            this.txtCodOpportunidad.Size = new System.Drawing.Size(185, 25);
            this.txtCodOpportunidad.TabIndex = 6;
            // 
            // cmbActividad
            // 
            this.cmbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActividad.Enabled = false;
            this.cmbActividad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActividad.FormattingEnabled = true;
            this.cmbActividad.Location = new System.Drawing.Point(172, 223);
            this.cmbActividad.Name = "cmbActividad";
            this.cmbActividad.Size = new System.Drawing.Size(264, 25);
            this.cmbActividad.TabIndex = 17;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.Enabled = false;
            this.cmbPrioridad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(172, 249);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(264, 25);
            this.cmbPrioridad.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tipo de actividad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(4, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Nombre / Razón social";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Prioridad";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(172, 92);
            this.txtNombreCliente.MaxLength = 35;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(264, 25);
            this.txtNombreCliente.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(172, 144);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(264, 25);
            this.txtTelefono.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Location = new System.Drawing.Point(4, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 17);
            this.label16.TabIndex = 53;
            this.label16.Text = "Hora de inicio";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContacto
            // 
            this.txtContacto.Enabled = false;
            this.txtContacto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacto.Location = new System.Drawing.Point(172, 118);
            this.txtContacto.MaxLength = 20;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(264, 25);
            this.txtContacto.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label17.Location = new System.Drawing.Point(3, 146);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 17);
            this.label17.TabIndex = 52;
            this.label17.Text = "Número de teléfono";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Location = new System.Drawing.Point(4, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 17);
            this.label18.TabIndex = 51;
            this.label18.Text = "Persona de contacto";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ActivityUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Name = "ActivityUserControl";
            this.Load += new System.EventHandler(this.ActivityUserControl_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button PrioButto;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button UpdButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInformar;
        private System.Windows.Forms.DataGridView dgtActividades;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button ActionBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodOpportunidad;
        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpDiaInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHorafin;
        private System.Windows.Forms.DateTimePicker dtpDiafin;
        private System.Windows.Forms.Button btnFindOp;
        private System.Windows.Forms.ComboBox cmbRepeticion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCerrado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodActividad;
        private System.Windows.Forms.Button btnFindCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAsuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNivelPrioridadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOportunidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoRepeticionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dComentariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPersonaContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRazonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fModificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource actividadBindingSource;
    }
}
