namespace TomaPedidos.View
{
    partial class frmServAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkServ1 = new System.Windows.Forms.CheckBox();
            this.chkServ2 = new System.Windows.Forms.CheckBox();
            this.chkServ3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el servicio adicional requerido:";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(15, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(96, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkServ1
            // 
            this.chkServ1.AutoSize = true;
            this.chkServ1.Location = new System.Drawing.Point(15, 36);
            this.chkServ1.Name = "chkServ1";
            this.chkServ1.Size = new System.Drawing.Size(251, 17);
            this.chkServ1.TabIndex = 8;
            this.chkServ1.Text = "Servicio de modificación de tubo de escape.";
            this.chkServ1.UseVisualStyleBackColor = true;
            // 
            // chkServ2
            // 
            this.chkServ2.AutoSize = true;
            this.chkServ2.Location = new System.Drawing.Point(15, 59);
            this.chkServ2.Name = "chkServ2";
            this.chkServ2.Size = new System.Drawing.Size(238, 17);
            this.chkServ2.TabIndex = 9;
            this.chkServ2.Text = "Servicio de levantamiento de suspensión.";
            this.chkServ2.UseVisualStyleBackColor = true;
            // 
            // chkServ3
            // 
            this.chkServ3.AutoSize = true;
            this.chkServ3.Location = new System.Drawing.Point(15, 82);
            this.chkServ3.Name = "chkServ3";
            this.chkServ3.Size = new System.Drawing.Size(315, 30);
            this.chkServ3.TabIndex = 10;
            this.chkServ3.Text = "Servicio de levantamiento de suspensión y modificación \r\nde tubo de escape.";
            this.chkServ3.UseVisualStyleBackColor = true;
            // 
            // frmServAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(351, 158);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkServ1);
            this.Controls.Add(this.chkServ2);
            this.Controls.Add(this.chkServ3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios adicionales";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkServ1;
        private System.Windows.Forms.CheckBox chkServ2;
        private System.Windows.Forms.CheckBox chkServ3;
    }
}