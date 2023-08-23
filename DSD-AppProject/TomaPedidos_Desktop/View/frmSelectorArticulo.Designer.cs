namespace TomaPedidos.View
{
    partial class frmSelectorArticulo
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
            this.cmbTipoDeToma = new System.Windows.Forms.ComboBox();
            this.cmbGeneration = new System.Windows.Forms.ComboBox();
            this.cmbGasType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbValveModel = new System.Windows.Forms.ComboBox();
            this.cmbCilMotorNumber = new System.Windows.Forms.ComboBox();
            this.cmbCylinderCapacity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbValveType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.itemcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdescripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblInformar = new System.Windows.Forms.Label();
            this.cmbListaPrecios = new System.Windows.Forms.ComboBox();
            this.lblListaPrecios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoDeToma
            // 
            this.cmbTipoDeToma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeToma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipoDeToma.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbTipoDeToma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbTipoDeToma.FormattingEnabled = true;
            this.cmbTipoDeToma.Location = new System.Drawing.Point(144, 174);
            this.cmbTipoDeToma.Name = "cmbTipoDeToma";
            this.cmbTipoDeToma.Size = new System.Drawing.Size(292, 21);
            this.cmbTipoDeToma.TabIndex = 15;
            // 
            // cmbGeneration
            // 
            this.cmbGeneration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGeneration.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbGeneration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbGeneration.FormattingEnabled = true;
            this.cmbGeneration.Location = new System.Drawing.Point(144, 39);
            this.cmbGeneration.Name = "cmbGeneration";
            this.cmbGeneration.Size = new System.Drawing.Size(292, 21);
            this.cmbGeneration.TabIndex = 10;
            // 
            // cmbGasType
            // 
            this.cmbGasType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGasType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGasType.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbGasType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbGasType.FormattingEnabled = true;
            this.cmbGasType.Location = new System.Drawing.Point(144, 12);
            this.cmbGasType.Name = "cmbGasType";
            this.cmbGasType.Size = new System.Drawing.Size(292, 21);
            this.cmbGasType.TabIndex = 9;
            this.cmbGasType.SelectionChangeCommitted += new System.EventHandler(this.cmbGasType_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(11, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Toma de carga";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbValveModel
            // 
            this.cmbValveModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValveModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbValveModel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbValveModel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbValveModel.FormattingEnabled = true;
            this.cmbValveModel.Location = new System.Drawing.Point(144, 147);
            this.cmbValveModel.Name = "cmbValveModel";
            this.cmbValveModel.Size = new System.Drawing.Size(292, 21);
            this.cmbValveModel.TabIndex = 14;
            // 
            // cmbCilMotorNumber
            // 
            this.cmbCilMotorNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCilMotorNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCilMotorNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbCilMotorNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbCilMotorNumber.FormattingEnabled = true;
            this.cmbCilMotorNumber.Items.AddRange(new object[] {
            "3",
            "4",
            "6",
            "8"});
            this.cmbCilMotorNumber.Location = new System.Drawing.Point(144, 66);
            this.cmbCilMotorNumber.Name = "cmbCilMotorNumber";
            this.cmbCilMotorNumber.Size = new System.Drawing.Size(292, 21);
            this.cmbCilMotorNumber.TabIndex = 11;
            this.cmbCilMotorNumber.SelectionChangeCommitted += new System.EventHandler(this.cmbCilMotorNumber_SelectionChangeCommitted);
            // 
            // cmbCylinderCapacity
            // 
            this.cmbCylinderCapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCylinderCapacity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCylinderCapacity.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbCylinderCapacity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbCylinderCapacity.FormattingEnabled = true;
            this.cmbCylinderCapacity.Location = new System.Drawing.Point(144, 93);
            this.cmbCylinderCapacity.Name = "cmbCylinderCapacity";
            this.cmbCylinderCapacity.Size = new System.Drawing.Size(292, 21);
            this.cmbCylinderCapacity.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(11, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ubicación de tanque";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(11, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Capacidad de tanque";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cilindrada (cc)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "N° de Cil. del motor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbValveType
            // 
            this.cmbValveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValveType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbValveType.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbValveType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbValveType.FormattingEnabled = true;
            this.cmbValveType.Location = new System.Drawing.Point(144, 120);
            this.cmbValveType.Name = "cmbValveType";
            this.cmbValveType.Size = new System.Drawing.Size(292, 21);
            this.cmbValveType.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Generación";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Combustible";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemcodeDataGridViewTextBoxColumn,
            this.itemdescripDataGridViewTextBoxColumn,
            this.itempriceDataGridViewTextBoxColumn});
            this.dgvItems.DataSource = this.itemBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.Location = new System.Drawing.Point(12, 240);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(511, 194);
            this.dgvItems.TabIndex = 95;
            // 
            // itemcodeDataGridViewTextBoxColumn
            // 
            this.itemcodeDataGridViewTextBoxColumn.DataPropertyName = "Itemcode";
            this.itemcodeDataGridViewTextBoxColumn.HeaderText = "Código de artículo";
            this.itemcodeDataGridViewTextBoxColumn.Name = "itemcodeDataGridViewTextBoxColumn";
            this.itemcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemcodeDataGridViewTextBoxColumn.Width = 130;
            // 
            // itemdescripDataGridViewTextBoxColumn
            // 
            this.itemdescripDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemdescripDataGridViewTextBoxColumn.DataPropertyName = "Itemdescrip";
            this.itemdescripDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.itemdescripDataGridViewTextBoxColumn.Name = "itemdescripDataGridViewTextBoxColumn";
            this.itemdescripDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itempriceDataGridViewTextBoxColumn
            // 
            this.itempriceDataGridViewTextBoxColumn.DataPropertyName = "Itemprice";
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            this.itempriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(TomaPedidos.ServicioTomaPedidos.Item);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Image = global::TomaPedidos.Properties.Resources.img_keyboard_return;
            this.btnReturn.Location = new System.Drawing.Point(451, 121);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(66, 49);
            this.btnReturn.TabIndex = 98;
            this.btnReturn.Text = "Volver";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnSelect.Enabled = false;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelect.Image = global::TomaPedidos.Properties.Resources.img_check;
            this.btnSelect.Location = new System.Drawing.Point(451, 66);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(66, 49);
            this.btnSelect.TabIndex = 97;
            this.btnSelect.Text = "Elegir";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Image = global::TomaPedidos.Properties.Resources.img_search;
            this.btnSearch.Location = new System.Drawing.Point(451, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 49);
            this.btnSearch.TabIndex = 96;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblInformar
            // 
            this.lblInformar.AutoSize = true;
            this.lblInformar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblInformar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblInformar.Location = new System.Drawing.Point(22, 312);
            this.lblInformar.Name = "lblInformar";
            this.lblInformar.Size = new System.Drawing.Size(489, 32);
            this.lblInformar.TabIndex = 99;
            this.lblInformar.Text = "La búsqueda no trajo registros coincidentes";
            this.lblInformar.Visible = false;
            // 
            // cmbListaPrecios
            // 
            this.cmbListaPrecios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbListaPrecios.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbListaPrecios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbListaPrecios.FormattingEnabled = true;
            this.cmbListaPrecios.Location = new System.Drawing.Point(144, 201);
            this.cmbListaPrecios.Name = "cmbListaPrecios";
            this.cmbListaPrecios.Size = new System.Drawing.Size(292, 21);
            this.cmbListaPrecios.TabIndex = 101;
            // 
            // lblListaPrecios
            // 
            this.lblListaPrecios.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblListaPrecios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblListaPrecios.Location = new System.Drawing.Point(11, 204);
            this.lblListaPrecios.Name = "lblListaPrecios";
            this.lblListaPrecios.Size = new System.Drawing.Size(111, 13);
            this.lblListaPrecios.TabIndex = 100;
            this.lblListaPrecios.Text = "Lista de precios";
            this.lblListaPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSelectorArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(533, 443);
            this.Controls.Add(this.cmbListaPrecios);
            this.Controls.Add(this.lblListaPrecios);
            this.Controls.Add(this.lblInformar);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbTipoDeToma);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.cmbGeneration);
            this.Controls.Add(this.cmbGasType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbValveModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCilMotorNumber);
            this.Controls.Add(this.cmbValveType);
            this.Controls.Add(this.cmbCylinderCapacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(549, 481);
            this.Name = "frmSelectorArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selector de artículo";
            this.Load += new System.EventHandler(this.frmSelectorArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoDeToma;
        private System.Windows.Forms.ComboBox cmbGeneration;
        private System.Windows.Forms.ComboBox cmbGasType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbValveModel;
        private System.Windows.Forms.ComboBox cmbCilMotorNumber;
        private System.Windows.Forms.ComboBox cmbCylinderCapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbValveType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdescripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblInformar;
        private System.Windows.Forms.ComboBox cmbListaPrecios;
        private System.Windows.Forms.Label lblListaPrecios;
    }
}