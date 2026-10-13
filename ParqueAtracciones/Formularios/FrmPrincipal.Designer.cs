namespace ParqueAtracciones
{
    partial class FrmPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.bntAtracciones = new System.Windows.Forms.Button();
            this.btnOperarios = new System.Windows.Forms.Button();
            this.btnAverias = new System.Windows.Forms.Button();
            this.btnControlAcceso = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntAtracciones
            // 
            this.bntAtracciones.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAtracciones.Location = new System.Drawing.Point(40, 149);
            this.bntAtracciones.Name = "bntAtracciones";
            this.bntAtracciones.Size = new System.Drawing.Size(168, 53);
            this.bntAtracciones.TabIndex = 1;
            this.bntAtracciones.Text = "Atracciones";
            this.bntAtracciones.UseVisualStyleBackColor = true;
            this.bntAtracciones.Click += new System.EventHandler(this.bntAtracciones_Click);
            // 
            // btnOperarios
            // 
            this.btnOperarios.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperarios.Location = new System.Drawing.Point(41, 218);
            this.btnOperarios.Name = "btnOperarios";
            this.btnOperarios.Size = new System.Drawing.Size(165, 55);
            this.btnOperarios.TabIndex = 2;
            this.btnOperarios.Text = "Operaciones";
            this.btnOperarios.UseVisualStyleBackColor = true;
            this.btnOperarios.Click += new System.EventHandler(this.btnOperarios_Click);
            // 
            // btnAverias
            // 
            this.btnAverias.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverias.Location = new System.Drawing.Point(41, 279);
            this.btnAverias.Name = "btnAverias";
            this.btnAverias.Size = new System.Drawing.Size(167, 60);
            this.btnAverias.TabIndex = 3;
            this.btnAverias.Text = "Averias";
            this.btnAverias.UseVisualStyleBackColor = true;
            this.btnAverias.Click += new System.EventHandler(this.btnAverias_Click);
            // 
            // btnControlAcceso
            // 
            this.btnControlAcceso.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlAcceso.Location = new System.Drawing.Point(41, 345);
            this.btnControlAcceso.Name = "btnControlAcceso";
            this.btnControlAcceso.Size = new System.Drawing.Size(169, 88);
            this.btnControlAcceso.TabIndex = 4;
            this.btnControlAcceso.Text = "Control de acceso";
            this.btnControlAcceso.UseVisualStyleBackColor = true;
            this.btnControlAcceso.Click += new System.EventHandler(this.btnControlAcceso_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(41, 450);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(169, 57);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(41, 513);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(169, 65);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(261, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(953, 715);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Eras Bold ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(76, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "MENU";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1226, 705);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnControlAcceso);
            this.Controls.Add(this.btnAverias);
            this.Controls.Add(this.btnOperarios);
            this.Controls.Add(this.bntAtracciones);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntAtracciones;
        private System.Windows.Forms.Button btnOperarios;
        private System.Windows.Forms.Button btnAverias;
        private System.Windows.Forms.Button btnControlAcceso;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

