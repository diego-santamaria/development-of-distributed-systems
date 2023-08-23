namespace TomaPedidos.View
{
    partial class FrmClienteBusqueda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteBusqueda));
            this.dgtClientes = new System.Windows.Forms.DataGridView();
            this.cardCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licTradNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bussinesPartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientCode = new System.Windows.Forms.TextBox();
            this.txtClientDoc = new System.Windows.Forms.TextBox();
            this.lblInformar = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cardNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgtClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bussinesPartnerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtClientes
            // 
            this.dgtClientes.AllowUserToAddRows = false;
            this.dgtClientes.AllowUserToDeleteRows = false;
            this.dgtClientes.AllowUserToOrderColumns = true;
            this.dgtClientes.AllowUserToResizeRows = false;
            this.dgtClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgtClientes.AutoGenerateColumns = false;
            this.dgtClientes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgtClientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgtClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardCodeDataGridViewTextBoxColumn,
            this.licTradNumDataGridViewTextBoxColumn,
            this.Telephone1,
            this.cardNameDataGridViewTextBoxColumn});
            this.dgtClientes.DataSource = this.bussinesPartnerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgtClientes.EnableHeadersVisualStyles = false;
            this.dgtClientes.Location = new System.Drawing.Point(12, 71);
            this.dgtClientes.MultiSelect = false;
            this.dgtClientes.Name = "dgtClientes";
            this.dgtClientes.ReadOnly = true;
            this.dgtClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtClientes.Size = new System.Drawing.Size(605, 224);
            this.dgtClientes.TabIndex = 0;
            this.dgtClientes.TabStop = false;
            this.dgtClientes.Click += new System.EventHandler(this.dgtClientes_Click);
            this.dgtClientes.DoubleClick += new System.EventHandler(this.dgtClientes_DoubleClick);
            // 
            // cardCodeDataGridViewTextBoxColumn
            // 
            this.cardCodeDataGridViewTextBoxColumn.DataPropertyName = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.HeaderText = "Código";
            this.cardCodeDataGridViewTextBoxColumn.Name = "cardCodeDataGridViewTextBoxColumn";
            this.cardCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licTradNumDataGridViewTextBoxColumn
            // 
            this.licTradNumDataGridViewTextBoxColumn.DataPropertyName = "LicTradNum";
            this.licTradNumDataGridViewTextBoxColumn.HeaderText = "DNI / RUC";
            this.licTradNumDataGridViewTextBoxColumn.Name = "licTradNumDataGridViewTextBoxColumn";
            this.licTradNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Telephone1
            // 
            this.Telephone1.DataPropertyName = "Telephone1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Telephone1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Telephone1.HeaderText = "Teléfono";
            this.Telephone1.Name = "Telephone1";
            this.Telephone1.ReadOnly = true;
            // 
            // bussinesPartnerBindingSource
            // 
            this.bussinesPartnerBindingSource.DataSource = typeof(TomaPedidos.OfertaVentaWS.BusinessPartner);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre / Razón Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "N° de Documento";
            // 
            // txtClientName
            // 
            this.txtClientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientName.Location = new System.Drawing.Point(138, 12);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(578, 22);
            this.txtClientName.TabIndex = 0;
            this.txtClientName.Click += new System.EventHandler(this.llenarTextboxConDatosEnMemoria_Click);
            this.txtClientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchClient_KeyPress);
            // 
            // txtClientCode
            // 
            this.txtClientCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientCode.Location = new System.Drawing.Point(431, 40);
            this.txtClientCode.Name = "txtClientCode";
            this.txtClientCode.Size = new System.Drawing.Size(111, 22);
            this.txtClientCode.TabIndex = 2;
            this.txtClientCode.Click += new System.EventHandler(this.llenarTextboxConDatosEnMemoria_Click);
            this.txtClientCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchClient_KeyPress);
            // 
            // txtClientDoc
            // 
            this.txtClientDoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientDoc.Location = new System.Drawing.Point(138, 40);
            this.txtClientDoc.Name = "txtClientDoc";
            this.txtClientDoc.Size = new System.Drawing.Size(226, 22);
            this.txtClientDoc.TabIndex = 1;
            this.txtClientDoc.Click += new System.EventHandler(this.llenarTextboxConDatosEnMemoria_Click);
            this.txtClientDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchClient_KeyPress);
            // 
            // lblInformar
            // 
            this.lblInformar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblInformar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblInformar.Location = new System.Drawing.Point(15, 184);
            this.lblInformar.Name = "lblInformar";
            this.lblInformar.Size = new System.Drawing.Size(600, 32);
            this.lblInformar.TabIndex = 14;
            this.lblInformar.Text = "La búsqueda no trajo registros coincidentes";
            this.lblInformar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInformar.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Image = global::TomaPedidos.Properties.Resources.img_keyboard_return;
            this.btnReturn.Location = new System.Drawing.Point(628, 185);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 32);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Volver";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnSelect.Enabled = false;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.Location = new System.Drawing.Point(628, 147);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(90, 32);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Elegir";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(628, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Image = global::TomaPedidos.Properties.Resources.img_search;
            this.btnSearch.Location = new System.Drawing.Point(628, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(12, 298);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(122, 13);
            this.lblTexto.TabIndex = 15;
            this.lblTexto.Text = "Total de coincidencias:";
            this.lblTexto.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(141, 298);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(123, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "0";
            this.lblTotal.Visible = false;
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientPhone.Location = new System.Drawing.Point(605, 40);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(111, 22);
            this.txtClientPhone.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Teléfono";
            // 
            // cardNameDataGridViewTextBoxColumn
            // 
            this.cardNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cardNameDataGridViewTextBoxColumn.DataPropertyName = "CardName";
            this.cardNameDataGridViewTextBoxColumn.HeaderText = "Nombre / Razón Social";
            this.cardNameDataGridViewTextBoxColumn.Name = "cardNameDataGridViewTextBoxColumn";
            this.cardNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmClienteBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(728, 316);
            this.Controls.Add(this.txtClientPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblInformar);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtClientDoc);
            this.Controls.Add(this.txtClientCode);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgtClientes);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClienteBusqueda";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgtClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bussinesPartnerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientCode;
        private System.Windows.Forms.TextBox txtClientDoc;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.BindingSource bussinesPartnerBindingSource;
        private System.Windows.Forms.Label lblInformar;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licTradNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNameDataGridViewTextBoxColumn;
    }
}