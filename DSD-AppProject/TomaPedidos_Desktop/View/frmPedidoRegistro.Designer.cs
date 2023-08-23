namespace TomaPedidos.View
{
    partial class FrmPedidoRegistro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoRegistro));
            this.label12 = new System.Windows.Forms.Label();
            this.txtClientCode = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtClientDoc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.toolTipVenta = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.btnGeneric = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.btnSelector = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDocNum = new System.Windows.Forms.TextBox();
            this.dtpDuoDate = new System.Windows.Forms.DateTimePicker();
            this.dgtOrderDetails = new System.Windows.Forms.DataGridView();
            this.columCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columCombustible = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columGeneracion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columCilMotor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columCilindrada = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columTipoMulti = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columModeloMulti = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columTipoToma = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.filaSinConfirmar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuOrderDet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarFilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorPrPedido = new System.Windows.Forms.ErrorProvider(this.components);
            this.Label16 = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.txtTotalGeneral = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtOrderDetails)).BeginInit();
            this.contextMenuOrderDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrPedido)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(208, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Cod. Cliente";
            // 
            // txtClientCode
            // 
            this.errorPrPedido.SetIconPadding(this.txtClientCode, 2);
            this.txtClientCode.Location = new System.Drawing.Point(282, 19);
            this.txtClientCode.Name = "txtClientCode";
            this.txtClientCode.Size = new System.Drawing.Size(233, 22);
            this.txtClientCode.TabIndex = 5;
            this.txtClientCode.Leave += new System.EventHandler(this.TxtClientCode_Leave);
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(282, 47);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(462, 22);
            this.txtClientName.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(228, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Nombre";
            // 
            // txtClientDoc
            // 
            this.txtClientDoc.Location = new System.Drawing.Point(611, 19);
            this.txtClientDoc.Name = "txtClientDoc";
            this.txtClientDoc.Size = new System.Drawing.Size(133, 22);
            this.txtClientDoc.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(547, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "DNI / RUC";
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnSearchClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchClient.Image = global::TomaPedidos.Properties.Resources.img_account_search;
            this.btnSearchClient.Location = new System.Drawing.Point(762, 80);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(80, 60);
            this.btnSearchClient.TabIndex = 1;
            this.btnSearchClient.Text = "Buscar  Cliente";
            this.btnSearchClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipVenta.SetToolTip(this.btnSearchClient, "Busque un cliente de la lista");
            this.btnSearchClient.UseVisualStyleBackColor = false;
            this.btnSearchClient.Click += new System.EventHandler(this.BtnSearchClient_Click);
            // 
            // btnGeneric
            // 
            this.btnGeneric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnGeneric.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnGeneric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneric.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeneric.Image = global::TomaPedidos.Properties.Resources.img_account_multiple;
            this.btnGeneric.Location = new System.Drawing.Point(762, 14);
            this.btnGeneric.Name = "btnGeneric";
            this.btnGeneric.Size = new System.Drawing.Size(80, 60);
            this.btnGeneric.TabIndex = 0;
            this.btnGeneric.Text = "Cliente genérico";
            this.btnGeneric.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipVenta.SetToolTip(this.btnGeneric, "Coloque un cliente esporádico para éste pedido");
            this.btnGeneric.UseVisualStyleBackColor = false;
            this.btnGeneric.Click += new System.EventHandler(this.BtnGenerico_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Image = global::TomaPedidos.Properties.Resources.img_save;
            this.btnSave.Location = new System.Drawing.Point(762, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 60);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar Pedido";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipVenta.SetToolTip(this.btnSave, "Crea una Orden de venta");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnSearchItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnSearchItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchItem.Image = global::TomaPedidos.Properties.Resources.img_cart_plus_white;
            this.btnSearchItem.Location = new System.Drawing.Point(762, 212);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(80, 60);
            this.btnSearchItem.TabIndex = 3;
            this.btnSearchItem.Text = "Buscar Artículo";
            this.btnSearchItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipVenta.SetToolTip(this.btnSearchItem, "Busque un artículo de la lista");
            this.btnSearchItem.UseVisualStyleBackColor = false;
            this.btnSearchItem.Click += new System.EventHandler(this.BtnSearchItem_Click);
            // 
            // btnSelector
            // 
            this.btnSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnSelector.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelector.Image = global::TomaPedidos.Properties.Resources.img_cart_plus_white;
            this.btnSelector.Location = new System.Drawing.Point(762, 146);
            this.btnSelector.Name = "btnSelector";
            this.btnSelector.Size = new System.Drawing.Size(80, 60);
            this.btnSelector.TabIndex = 2;
            this.btnSelector.Text = "Selector de actículo";
            this.btnSelector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipVenta.SetToolTip(this.btnSelector, "Busque un artículo de la lista");
            this.btnSelector.UseVisualStyleBackColor = false;
            this.btnSelector.Click += new System.EventHandler(this.BtnSelector_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = "Cod. SAP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 88;
            this.label15.Text = "Fecha";
            // 
            // txtDocNum
            // 
            this.txtDocNum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDocNum.Enabled = false;
            this.txtDocNum.Location = new System.Drawing.Point(77, 19);
            this.txtDocNum.Name = "txtDocNum";
            this.txtDocNum.Size = new System.Drawing.Size(119, 22);
            this.txtDocNum.TabIndex = 89;
            // 
            // dtpDuoDate
            // 
            this.dtpDuoDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDuoDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDuoDate.Location = new System.Drawing.Point(77, 47);
            this.dtpDuoDate.Name = "dtpDuoDate";
            this.dtpDuoDate.Size = new System.Drawing.Size(119, 22);
            this.dtpDuoDate.TabIndex = 90;
            this.dtpDuoDate.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // dgtOrderDetails
            // 
            this.dgtOrderDetails.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgtOrderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgtOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columCodigo,
            this.columDescription,
            this.columPrice,
            this.columCantidad,
            this.columTotal,
            this.columCombustible,
            this.columGeneracion,
            this.columCilMotor,
            this.columCilindrada,
            this.columTipoMulti,
            this.columModeloMulti,
            this.columTipoToma,
            this.filaSinConfirmar});
            this.dgtOrderDetails.ContextMenuStrip = this.contextMenuOrderDet;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtOrderDetails.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgtOrderDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgtOrderDetails.EnableHeadersVisualStyles = false;
            this.dgtOrderDetails.Location = new System.Drawing.Point(15, 21);
            this.dgtOrderDetails.MultiSelect = false;
            this.dgtOrderDetails.Name = "dgtOrderDetails";
            this.dgtOrderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtOrderDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgtOrderDetails.RowHeadersWidth = 50;
            this.dgtOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgtOrderDetails.Size = new System.Drawing.Size(704, 287);
            this.dgtOrderDetails.TabIndex = 91;
            this.dgtOrderDetails.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgtOrderDetails_CellValidating);
            this.dgtOrderDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgtOrderDetails_RowPostPaint);
            this.dgtOrderDetails.Click += new System.EventHandler(this.DgtOrderDetails_Click);
            // 
            // columCodigo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.columCodigo.HeaderText = "Código";
            this.columCodigo.Name = "columCodigo";
            // 
            // columDescription
            // 
            this.columDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.columDescription.DefaultCellStyle = dataGridViewCellStyle3;
            this.columDescription.HeaderText = "Descripción";
            this.columDescription.MinimumWidth = 150;
            this.columDescription.Name = "columDescription";
            this.columDescription.ReadOnly = true;
            // 
            // columPrice
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.columPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.columPrice.HeaderText = "Precio";
            this.columPrice.MinimumWidth = 70;
            this.columPrice.Name = "columPrice";
            this.columPrice.ReadOnly = true;
            // 
            // columCantidad
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.columCantidad.DefaultCellStyle = dataGridViewCellStyle5;
            this.columCantidad.HeaderText = "Cantidad";
            this.columCantidad.Name = "columCantidad";
            // 
            // columTotal
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.columTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.columTotal.HeaderText = "Total";
            this.columTotal.Name = "columTotal";
            this.columTotal.ReadOnly = true;
            // 
            // columCombustible
            // 
            this.columCombustible.HeaderText = "Combustible";
            this.columCombustible.Name = "columCombustible";
            this.columCombustible.Visible = false;
            this.columCombustible.Width = 80;
            // 
            // columGeneracion
            // 
            this.columGeneracion.HeaderText = "Generación";
            this.columGeneracion.Name = "columGeneracion";
            this.columGeneracion.Visible = false;
            // 
            // columCilMotor
            // 
            this.columCilMotor.HeaderText = "N° de Cil. del motor";
            this.columCilMotor.Name = "columCilMotor";
            this.columCilMotor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columCilMotor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columCilMotor.Visible = false;
            // 
            // columCilindrada
            // 
            this.columCilindrada.HeaderText = "Cilindrada (cc)";
            this.columCilindrada.Name = "columCilindrada";
            this.columCilindrada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columCilindrada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columCilindrada.Visible = false;
            // 
            // columTipoMulti
            // 
            this.columTipoMulti.HeaderText = "Tipo de Multiválvula";
            this.columTipoMulti.Name = "columTipoMulti";
            this.columTipoMulti.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columTipoMulti.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columTipoMulti.Visible = false;
            // 
            // columModeloMulti
            // 
            this.columModeloMulti.HeaderText = "Modelo de multiválvula";
            this.columModeloMulti.Name = "columModeloMulti";
            this.columModeloMulti.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columModeloMulti.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columModeloMulti.Visible = false;
            // 
            // columTipoToma
            // 
            this.columTipoToma.HeaderText = "Tipo de toma";
            this.columTipoToma.Name = "columTipoToma";
            this.columTipoToma.Visible = false;
            // 
            // filaSinConfirmar
            // 
            this.filaSinConfirmar.HeaderText = "filaSinConfirmar";
            this.filaSinConfirmar.Name = "filaSinConfirmar";
            this.filaSinConfirmar.Visible = false;
            // 
            // contextMenuOrderDet
            // 
            this.contextMenuOrderDet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarFilaToolStripMenuItem});
            this.contextMenuOrderDet.Name = "contextMenuOrderDet";
            this.contextMenuOrderDet.Size = new System.Drawing.Size(137, 26);
            // 
            // eliminarFilaToolStripMenuItem
            // 
            this.eliminarFilaToolStripMenuItem.Name = "eliminarFilaToolStripMenuItem";
            this.eliminarFilaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.eliminarFilaToolStripMenuItem.Text = "Eliminar fila";
            this.eliminarFilaToolStripMenuItem.Click += new System.EventHandler(this.EliminarFilaToolStripMenuItem_Click);
            // 
            // errorPrPedido
            // 
            this.errorPrPedido.ContainerControl = this;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.Label16.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Label16.Location = new System.Drawing.Point(15, 312);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(113, 17);
            this.Label16.TabIndex = 94;
            this.Label16.Text = "Número de items:";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTotalItems.Location = new System.Drawing.Point(126, 313);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(212, 17);
            this.lblTotalItems.TabIndex = 95;
            this.lblTotalItems.Text = "0";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(370, 332);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubTotal.TabIndex = 97;
            this.txtSubTotal.TabStop = false;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIGV
            // 
            this.txtIGV.Location = new System.Drawing.Point(476, 332);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.ReadOnly = true;
            this.txtIGV.Size = new System.Drawing.Size(100, 22);
            this.txtIGV.TabIndex = 98;
            this.txtIGV.TabStop = false;
            this.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalGeneral
            // 
            this.txtTotalGeneral.Location = new System.Drawing.Point(582, 332);
            this.txtTotalGeneral.Name = "txtTotalGeneral";
            this.txtTotalGeneral.ReadOnly = true;
            this.txtTotalGeneral.Size = new System.Drawing.Size(136, 22);
            this.txtTotalGeneral.TabIndex = 99;
            this.txtTotalGeneral.TabStop = false;
            this.txtTotalGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(582, 316);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 13);
            this.label17.TabIndex = 100;
            this.label17.Text = "Total documento";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(476, 316);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 13);
            this.label18.TabIndex = 101;
            this.label18.Text = "IGV";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(370, 316);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 13);
            this.label19.TabIndex = 102;
            this.label19.Text = "Sub-Total";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dgtOrderDetails);
            this.groupBox.Controls.Add(this.label18);
            this.groupBox.Controls.Add(this.txtSubTotal);
            this.groupBox.Controls.Add(this.txtIGV);
            this.groupBox.Controls.Add(this.txtTotalGeneral);
            this.groupBox.Controls.Add(this.lblTotalItems);
            this.groupBox.Controls.Add(this.Label16);
            this.groupBox.Controls.Add(this.label19);
            this.groupBox.Controls.Add(this.label17);
            this.groupBox.Location = new System.Drawing.Point(12, 80);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(732, 365);
            this.groupBox.TabIndex = 103;
            this.groupBox.TabStop = false;
            // 
            // frmPedidoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(855, 454);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnSelector);
            this.Controls.Add(this.btnSearchItem);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDuoDate);
            this.Controls.Add(this.txtDocNum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSearchClient);
            this.Controls.Add(this.btnGeneric);
            this.Controls.Add(this.txtClientDoc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtClientCode);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedidoRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta de Equipos";
            this.Load += new System.EventHandler(this.FrmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtOrderDetails)).EndInit();
            this.contextMenuOrderDet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorPrPedido)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtClientCode;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtClientDoc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnGeneric;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.ToolTip toolTipVenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDocNum;
        private System.Windows.Forms.DateTimePicker dtpDuoDate;
        public System.Windows.Forms.DataGridView dgtOrderDetails;
        private System.Windows.Forms.ErrorProvider errorPrPedido;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label Label16;
        private System.Windows.Forms.ContextMenuStrip contextMenuOrderDet;
        private System.Windows.Forms.ToolStripMenuItem eliminarFilaToolStripMenuItem;
        private System.Windows.Forms.Button btnSelector;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotalGeneral;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn columCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn columPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columTotal;
        private System.Windows.Forms.DataGridViewComboBoxColumn columCombustible;
        private System.Windows.Forms.DataGridViewComboBoxColumn columGeneracion;
        private System.Windows.Forms.DataGridViewComboBoxColumn columCilMotor;
        private System.Windows.Forms.DataGridViewComboBoxColumn columCilindrada;
        private System.Windows.Forms.DataGridViewComboBoxColumn columTipoMulti;
        private System.Windows.Forms.DataGridViewComboBoxColumn columModeloMulti;
        private System.Windows.Forms.DataGridViewComboBoxColumn columTipoToma;
        private System.Windows.Forms.DataGridViewCheckBoxColumn filaSinConfirmar;
    }
}