namespace TomaPedidos.View
{
    partial class frmActividadesRelacionadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActividadesRelacionadas));
            this.chkVisualizarPendientes = new System.Windows.Forms.CheckBox();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.numActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaIniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaIniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeticionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblInformar = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnActivity = new System.Windows.Forms.Button();
            this.btnElegirActividad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chkVisualizarPendientes
            // 
            this.chkVisualizarPendientes.AutoSize = true;
            this.chkVisualizarPendientes.Location = new System.Drawing.Point(13, 13);
            this.chkVisualizarPendientes.Name = "chkVisualizarPendientes";
            this.chkVisualizarPendientes.Size = new System.Drawing.Size(238, 17);
            this.chkVisualizarPendientes.TabIndex = 0;
            this.chkVisualizarPendientes.Text = "Visualizar solo las actividades pendientes";
            this.chkVisualizarPendientes.UseVisualStyleBackColor = true;
            this.chkVisualizarPendientes.CheckedChanged += new System.EventHandler(this.chkVisualizarPendientes_CheckedChanged);
            // 
            // dgvActivities
            // 
            this.dgvActivities.AllowUserToAddRows = false;
            this.dgvActivities.AllowUserToDeleteRows = false;
            this.dgvActivities.AllowUserToOrderColumns = true;
            this.dgvActivities.AllowUserToResizeRows = false;
            this.dgvActivities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActivities.AutoGenerateColumns = false;
            this.dgvActivities.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvActivities.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numActividadDataGridViewTextBoxColumn,
            this.diaIniDataGridViewTextBoxColumn,
            this.horaIniDataGridViewTextBoxColumn,
            this.actividadDataGridViewTextBoxColumn,
            this.repeticionDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.detalleDataGridViewTextBoxColumn});
            this.dgvActivities.DataSource = this.activityBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActivities.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActivities.EnableHeadersVisualStyles = false;
            this.dgvActivities.Location = new System.Drawing.Point(13, 36);
            this.dgvActivities.MultiSelect = false;
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.ReadOnly = true;
            this.dgvActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivities.Size = new System.Drawing.Size(916, 221);
            this.dgvActivities.TabIndex = 0;
            this.dgvActivities.TabStop = false;
            this.dgvActivities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivities_CellClick);
            this.dgvActivities.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivities_CellDoubleClick);
            // 
            // numActividadDataGridViewTextBoxColumn
            // 
            this.numActividadDataGridViewTextBoxColumn.DataPropertyName = "NumActividad";
            this.numActividadDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numActividadDataGridViewTextBoxColumn.Name = "numActividadDataGridViewTextBoxColumn";
            this.numActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.numActividadDataGridViewTextBoxColumn.Width = 60;
            // 
            // diaIniDataGridViewTextBoxColumn
            // 
            this.diaIniDataGridViewTextBoxColumn.DataPropertyName = "DiaIni";
            this.diaIniDataGridViewTextBoxColumn.HeaderText = "Fecha de inicio";
            this.diaIniDataGridViewTextBoxColumn.Name = "diaIniDataGridViewTextBoxColumn";
            this.diaIniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaIniDataGridViewTextBoxColumn
            // 
            this.horaIniDataGridViewTextBoxColumn.DataPropertyName = "HoraIni";
            this.horaIniDataGridViewTextBoxColumn.HeaderText = "Hora de inicio";
            this.horaIniDataGridViewTextBoxColumn.Name = "horaIniDataGridViewTextBoxColumn";
            this.horaIniDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaIniDataGridViewTextBoxColumn.Width = 80;
            // 
            // actividadDataGridViewTextBoxColumn
            // 
            this.actividadDataGridViewTextBoxColumn.DataPropertyName = "Actividad";
            this.actividadDataGridViewTextBoxColumn.HeaderText = "Actividad";
            this.actividadDataGridViewTextBoxColumn.Name = "actividadDataGridViewTextBoxColumn";
            this.actividadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repeticionDataGridViewTextBoxColumn
            // 
            this.repeticionDataGridViewTextBoxColumn.DataPropertyName = "Repeticion";
            this.repeticionDataGridViewTextBoxColumn.HeaderText = "Repetición";
            this.repeticionDataGridViewTextBoxColumn.Name = "repeticionDataGridViewTextBoxColumn";
            this.repeticionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombre del Cliente";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detalleDataGridViewTextBoxColumn
            // 
            this.detalleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detalleDataGridViewTextBoxColumn.DataPropertyName = "Detalle";
            this.detalleDataGridViewTextBoxColumn.HeaderText = "Comentarios";
            this.detalleDataGridViewTextBoxColumn.Name = "detalleDataGridViewTextBoxColumn";
            this.detalleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataSource = typeof(TomaPedidos.ServicioTomaPedidos.Activities);
            // 
            // lblInformar
            // 
            this.lblInformar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblInformar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblInformar.Location = new System.Drawing.Point(27, 102);
            this.lblInformar.Name = "lblInformar";
            this.lblInformar.Size = new System.Drawing.Size(887, 123);
            this.lblInformar.TabIndex = 18;
            this.lblInformar.Text = "No hay actividades asociadas a la oportunidad para mostrar";
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
            this.btnReturn.Location = new System.Drawing.Point(937, 168);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(64, 60);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Volver";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnActivity
            // 
            this.btnActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnActivity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActivity.Image = global::TomaPedidos.Properties.Resources.img_bell_plus;
            this.btnActivity.Location = new System.Drawing.Point(937, 36);
            this.btnActivity.Name = "btnActivity";
            this.btnActivity.Size = new System.Drawing.Size(64, 60);
            this.btnActivity.TabIndex = 32;
            this.btnActivity.Text = "Agregar Actividad";
            this.btnActivity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActivity.UseVisualStyleBackColor = false;
            this.btnActivity.Click += new System.EventHandler(this.btnActivity_Click);
            // 
            // btnElegirActividad
            // 
            this.btnElegirActividad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElegirActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.btnElegirActividad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(159)))), ((int)(((byte)(187)))));
            this.btnElegirActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegirActividad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnElegirActividad.Image = global::TomaPedidos.Properties.Resources.img_check;
            this.btnElegirActividad.Location = new System.Drawing.Point(937, 102);
            this.btnElegirActividad.Name = "btnElegirActividad";
            this.btnElegirActividad.Size = new System.Drawing.Size(64, 60);
            this.btnElegirActividad.TabIndex = 33;
            this.btnElegirActividad.Text = "Elegir";
            this.btnElegirActividad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnElegirActividad.UseVisualStyleBackColor = false;
            this.btnElegirActividad.Click += new System.EventHandler(this.btnElegirActividad_Click);
            // 
            // frmActividadesRelacionadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1011, 267);
            this.Controls.Add(this.btnActivity);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblInformar);
            this.Controls.Add(this.dgvActivities);
            this.Controls.Add(this.chkVisualizarPendientes);
            this.Controls.Add(this.btnElegirActividad);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActividadesRelacionadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividades Relacionadas";
            this.Load += new System.EventHandler(this.frmActividadesRelacionadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkVisualizarPendientes;
        private System.Windows.Forms.DataGridView dgvActivities;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private System.Windows.Forms.Label lblInformar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaIniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaIniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeticionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnActivity;
        private System.Windows.Forms.Button btnElegirActividad;
    }
}