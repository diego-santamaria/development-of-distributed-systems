namespace TomaPedidos.View
{
    partial class frmArticuloBusqueda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticuloBusqueda));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblInformar = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.itemcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdescripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-1, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(81, 10);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(321, 22);
            this.txtItemCode.TabIndex = 0;
            this.txtItemCode.Click += new System.EventHandler(this.llenarTextboxConDatosEnMemoria_Click);
            this.txtItemCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemCode_KeyPress);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(81, 37);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(321, 22);
            this.txtItemName.TabIndex = 1;
            this.txtItemName.Click += new System.EventHandler(this.llenarTextboxConDatosEnMemoria_Click);
            this.txtItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemName_KeyPress);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToOrderColumns = true;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvItems.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemcodeDataGridViewTextBoxColumn,
            this.itemdescripDataGridViewTextBoxColumn,
            this.itempriceDataGridViewTextBoxColumn});
            this.dgvItems.DataSource = this.itemBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.Location = new System.Drawing.Point(12, 70);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(616, 300);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.TabStop = false;
            this.dgvItems.Click += new System.EventHandler(this.dgvItems_Click);
            this.dgvItems.DoubleClick += new System.EventHandler(this.dgvItems_DoubleClick);
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
            this.btnReturn.Location = new System.Drawing.Point(562, 10);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(66, 49);
            this.btnReturn.TabIndex = 4;
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
            this.btnSelect.Location = new System.Drawing.Point(490, 10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(66, 49);
            this.btnSelect.TabIndex = 3;
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
            this.btnSearch.Location = new System.Drawing.Point(418, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 49);
            this.btnSearch.TabIndex = 2;
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
            this.lblInformar.Location = new System.Drawing.Point(81, 207);
            this.lblInformar.Name = "lblInformar";
            this.lblInformar.Size = new System.Drawing.Size(489, 32);
            this.lblInformar.TabIndex = 13;
            this.lblInformar.Text = "La búsqueda no trajo registros coincidentes";
            this.lblInformar.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(141, 374);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(123, 13);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "0";
            this.lblTotal.Visible = false;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(12, 374);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(123, 13);
            this.lblTexto.TabIndex = 17;
            this.lblTexto.Text = "Total de coincidencias:";
            this.lblTexto.Visible = false;
            // 
            // itemcodeDataGridViewTextBoxColumn
            // 
            this.itemcodeDataGridViewTextBoxColumn.DataPropertyName = "Itemcode";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.itemcodeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.itemcodeDataGridViewTextBoxColumn.HeaderText = "Código de artículo";
            this.itemcodeDataGridViewTextBoxColumn.Name = "itemcodeDataGridViewTextBoxColumn";
            this.itemcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemcodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemdescripDataGridViewTextBoxColumn
            // 
            this.itemdescripDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemdescripDataGridViewTextBoxColumn.DataPropertyName = "Itemdescrip";
            this.itemdescripDataGridViewTextBoxColumn.HeaderText = "Descrición";
            this.itemdescripDataGridViewTextBoxColumn.Name = "itemdescripDataGridViewTextBoxColumn";
            this.itemdescripDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itempriceDataGridViewTextBoxColumn
            // 
            this.itempriceDataGridViewTextBoxColumn.DataPropertyName = "Itemprice";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.itempriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            this.itempriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.itempriceDataGridViewTextBoxColumn.Width = 120;
            // 
            // frmArticuloBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(639, 382);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblInformar);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArticuloBusqueda";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de artículos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.Label lblInformar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdescripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
    }
}