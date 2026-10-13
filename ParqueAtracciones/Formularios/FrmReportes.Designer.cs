namespace ParqueAtracciones.Formularios
{
    partial class FrmReportes
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboReporte = new System.Windows.Forms.ComboBox();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTES GENERALES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de reporte";
            // 
            // cboReporte
            // 
            this.cboReporte.FormattingEnabled = true;
            this.cboReporte.Location = new System.Drawing.Point(41, 121);
            this.cboReporte.Name = "cboReporte";
            this.cboReporte.Size = new System.Drawing.Size(428, 24);
            this.cboReporte.TabIndex = 2;
            // 
            // txtReporte
            // 
            this.txtReporte.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReporte.Location = new System.Drawing.Point(34, 166);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.ReadOnly = true;
            this.txtReporte.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReporte.Size = new System.Drawing.Size(554, 403);
            this.txtReporte.TabIndex = 3;
            this.txtReporte.WordWrap = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(29, 617);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(99, 43);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(247, 617);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(127, 43);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "EXPORTAR TXT";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(471, 617);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(99, 43);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 716);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.cboReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboReporte;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnRegresar;
    }
}