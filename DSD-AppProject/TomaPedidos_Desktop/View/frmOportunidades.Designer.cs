namespace TomaPedidos.View
{
    partial class frmOportunidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOportunidades));
            this.dgtOportunidades = new System.Windows.Forms.DataGridView();
            this.opprIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opportunityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDocNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblInformar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtOportunidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opportunityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtOportunidades
            // 
            this.dgtOportunidades.AllowUserToAddRows = false;
            this.dgtOportunidades.AllowUserToDeleteRows = false;
            this.dgtOportunidades.AllowUserToOrderColumns = true;
            this.dgtOportunidades.AllowUserToResizeRows = false;
            this.dgtOportunidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgtOportunidades.AutoGenerateColumns = false;
            this.dgtOportunidades.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgtOportunidades.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgtOportunidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtOportunidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opprIdDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.openDateDataGridViewTextBoxColumn,
            this.cardCodeDataGridViewTextBoxColumn,
            this.cardNameDataGridViewTextBoxColumn});
            this.dgtOportunidades.DataSource = this.opportunityBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtOportunidades.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgtOportunidades.EnableHeadersVisualStyles = false;
            this.dgtOportunidades.Location = new System.Drawing.Point(12, 74);
            this.dgtOportunidades.MultiSelect = false;
            this.dgtOportunidades.Name = "dgtOportunidades";
            this.dgtOportunidades.ReadOnly = true;
            this.dgtOportunidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtOportunidades.Size = new System.Drawing.Size(839, 405);
            this.dgtOportunidades.TabIndex = 0;
            this.dgtOportunidades.TabStop = false;
            this.dgtOportunidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtOportunidades_CellDoubleClick);
            // 
            // opprIdDataGridViewTextBoxColumn
            // 
            this.opprIdDataGridViewTextBoxColumn.DataPropertyName = "OpprId";
            this.opprIdDataGridViewTextBoxColumn.HeaderText = "Número de oportunidad";
            this.opprIdDataGridViewTextBoxColumn.Name = "opprIdDataGridViewTextBoxColumn";
            this.opprIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Estado del documento";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // openDateDataGridViewTextBoxColumn
            // 
            this.openDateDataGridViewTextBoxColumn.DataPropertyName = "OpenDate";
            this.openDateDataGridViewTextBoxColumn.HeaderText = "Fecha de inicio";
            this.openDateDataGridViewTextBoxColumn.Name = "openDateDataGridViewTextBoxColumn";
            this.openDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.openDateDataGridViewTextBoxColumn.Width = 110;
            // 
            // cardCodeDataGridViewTextBoxColumn
            // 
            this.cardCodeDataGridViewTextBoxColumn.DataPropertyName = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.HeaderText = "Código del cliente";
            this.cardCodeDataGridViewTextBoxColumn.Name = "cardCodeDataGridViewTextBoxColumn";
            this.cardCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cardCodeDataGridViewTextBoxColumn.Width = 128;
            // 
            // cardNameDataGridViewTextBoxColumn
            // 
            this.cardNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cardNameDataGridViewTextBoxColumn.DataPropertyName = "CardName";
            this.cardNameDataGridViewTextBoxColumn.HeaderText = "Nombre del cliente";
            this.cardNameDataGridViewTextBoxColumn.Name = "cardNameDataGridViewTextBoxColumn";
            this.cardNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opportunityBindingSource
            // 
            this.opportunityBindingSource.DataSource = typeof(TomaPedidos.ServicioTomaPedidos.Opportunity);
            // 
            // txtDocNum
            // 
            this.txtDocNum.Location = new System.Drawing.Point(153, 12);
            this.txtDocNum.Name = "txtDocNum";
            this.txtDocNum.Size = new System.Drawing.Size(162, 22);
            this.txtDocNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Oportunidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre / Razón Social";
            // 
            // txtCardName
            // 
            this.txtCardName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardName.Location = new System.Drawing.Point(153, 40);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(539, 22);
            this.txtCardName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código del Cliente";
            // 
            // txtCardCode
            // 
            this.txtCardCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardCode.Location = new System.Drawing.Point(438, 12);
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.Size = new System.Drawing.Size(254, 22);
            this.txtCardCode.TabIndex = 5;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnOpen.Enabled = false;
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(785, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(66, 50);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Abrir";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Image = global::TomaPedidos.Properties.Resources.img_search;
            this.btnSearch.Location = new System.Drawing.Point(713, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 50);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblInformar
            // 
            this.lblInformar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblInformar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblInformar.Location = new System.Drawing.Point(15, 140);
            this.lblInformar.Name = "lblInformar";
            this.lblInformar.Size = new System.Drawing.Size(835, 294);
            this.lblInformar.TabIndex = 14;
            this.lblInformar.Text = "La búsqueda no trajo registros coincidentes";
            this.lblInformar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInformar.Visible = false;
            // 
            // frmOportunidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(862, 491);
            this.Controls.Add(this.lblInformar);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCardCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocNum);
            this.Controls.Add(this.dgtOportunidades);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(878, 529);
            this.Name = "frmOportunidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Oportunidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgtOportunidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opportunityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtOportunidades;
        private System.Windows.Forms.TextBox txtDocNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCardCode;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblInformar;
        private System.Windows.Forms.DataGridViewTextBoxColumn opprIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource opportunityBindingSource;
    }
}