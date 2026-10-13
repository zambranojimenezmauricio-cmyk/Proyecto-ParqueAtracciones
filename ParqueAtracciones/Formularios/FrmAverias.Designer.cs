namespace ParqueAtracciones.Formularios
{
    partial class FrmAverias
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdAveria = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboComponente = new System.Windows.Forms.ComboBox();
            this.cboAtraccion = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvAverias = new System.Windows.Forms.DataGridView();
            this.cboAnclaje = new System.Windows.Forms.ComboBox();
            this.btnVerificarAnclaje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAverias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CENTRAL RECEPTORA DE AVERIAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Averia ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Atraccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de vehiculo/vagon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de componente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripcion de la averia ";
            // 
            // txtIdAveria
            // 
            this.txtIdAveria.Location = new System.Drawing.Point(34, 114);
            this.txtIdAveria.Name = "txtIdAveria";
            this.txtIdAveria.Size = new System.Drawing.Size(132, 22);
            this.txtIdAveria.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(327, 196);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(177, 22);
            this.txtNumero.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(34, 266);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(603, 57);
            this.txtDescripcion.TabIndex = 8;
            // 
            // cboComponente
            // 
            this.cboComponente.FormattingEnabled = true;
            this.cboComponente.Location = new System.Drawing.Point(41, 191);
            this.cboComponente.Name = "cboComponente";
            this.cboComponente.Size = new System.Drawing.Size(125, 24);
            this.cboComponente.TabIndex = 9;
            // 
            // cboAtraccion
            // 
            this.cboAtraccion.FormattingEnabled = true;
            this.cboAtraccion.Location = new System.Drawing.Point(322, 114);
            this.cboAtraccion.Name = "cboAtraccion";
            this.cboAtraccion.Size = new System.Drawing.Size(171, 24);
            this.cboAtraccion.TabIndex = 10;
            this.cboAtraccion.SelectedIndexChanged += new System.EventHandler(this.cboAtraccion_SelectedIndexChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(4, 357);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(122, 42);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "REGISTAR AVERIA";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(146, 357);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(95, 42);
            this.btnFinalizar.TabIndex = 12;
            this.btnFinalizar.Text = "FINALIZAR REPARACION";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(266, 357);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 30);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(398, 357);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(95, 30);
            this.btnRegresar.TabIndex = 14;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(528, 357);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 30);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvAverias
            // 
            this.dgvAverias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAverias.Location = new System.Drawing.Point(18, 445);
            this.dgvAverias.Name = "dgvAverias";
            this.dgvAverias.RowHeadersWidth = 51;
            this.dgvAverias.RowTemplate.Height = 24;
            this.dgvAverias.Size = new System.Drawing.Size(634, 175);
            this.dgvAverias.TabIndex = 16;
            this.dgvAverias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAverias_CellContentClick);
            // 
            // cboAnclaje
            // 
            this.cboAnclaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnclaje.FormattingEnabled = true;
            this.cboAnclaje.Location = new System.Drawing.Point(537, 61);
            this.cboAnclaje.Name = "cboAnclaje";
            this.cboAnclaje.Size = new System.Drawing.Size(123, 24);
            this.cboAnclaje.TabIndex = 17;
            // 
            // btnVerificarAnclaje
            // 
            this.btnVerificarAnclaje.Location = new System.Drawing.Point(537, 103);
            this.btnVerificarAnclaje.Name = "btnVerificarAnclaje";
            this.btnVerificarAnclaje.Size = new System.Drawing.Size(113, 73);
            this.btnVerificarAnclaje.TabIndex = 18;
            this.btnVerificarAnclaje.Text = "VERIFICAR ANCLAJE";
            this.btnVerificarAnclaje.UseVisualStyleBackColor = true;
            this.btnVerificarAnclaje.Click += new System.EventHandler(this.btnVerificarAnclaje_Click);
            // 
            // FrmAverias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 657);
            this.Controls.Add(this.btnVerificarAnclaje);
            this.Controls.Add(this.cboAnclaje);
            this.Controls.Add(this.dgvAverias);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cboAtraccion);
            this.Controls.Add(this.cboComponente);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtIdAveria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAverias";
            this.Text = "FrmAverias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAverias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdAveria;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboComponente;
        private System.Windows.Forms.ComboBox cboAtraccion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvAverias;
        private System.Windows.Forms.ComboBox cboAnclaje;
        private System.Windows.Forms.Button btnVerificarAnclaje;
    }
}