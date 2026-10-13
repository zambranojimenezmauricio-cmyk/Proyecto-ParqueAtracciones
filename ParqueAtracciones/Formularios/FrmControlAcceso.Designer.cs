namespace ParqueAtracciones.Formularios
{
    partial class FrmControlAcceso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.cboAtraccion = new System.Windows.Forms.ComboBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgvControlAcceso = new System.Windows.Forms.DataGridView();
            this.timerSeguridad = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlAcceso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE ACCESO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Atraccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de Pasajeros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado de Atraccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pasajeros Actuales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Capacidad Maxima";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(26, 210);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(158, 22);
            this.txtCantidad.TabIndex = 7;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(330, 325);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(158, 22);
            this.txtEstado.TabIndex = 8;
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Location = new System.Drawing.Point(26, 325);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(158, 22);
            this.txtOcupacion.TabIndex = 9;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(330, 210);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(158, 22);
            this.txtCapacidad.TabIndex = 10;
            // 
            // cboAtraccion
            // 
            this.cboAtraccion.FormattingEnabled = true;
            this.cboAtraccion.Location = new System.Drawing.Point(28, 119);
            this.cboAtraccion.Name = "cboAtraccion";
            this.cboAtraccion.Size = new System.Drawing.Size(372, 24);
            this.cboAtraccion.TabIndex = 11;
            this.cboAtraccion.SelectedIndexChanged += new System.EventHandler(this.cboAtraccion_SelectedIndexChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(11, 367);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(108, 39);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(133, 367);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 39);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "SALIDA";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(249, 367);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(108, 39);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(363, 367);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 39);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(487, 367);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(108, 39);
            this.btnRegresar.TabIndex = 16;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dgvControlAcceso
            // 
            this.dgvControlAcceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlAcceso.Location = new System.Drawing.Point(17, 453);
            this.dgvControlAcceso.Name = "dgvControlAcceso";
            this.dgvControlAcceso.RowHeadersWidth = 51;
            this.dgvControlAcceso.RowTemplate.Height = 24;
            this.dgvControlAcceso.Size = new System.Drawing.Size(577, 247);
            this.dgvControlAcceso.TabIndex = 17;
            // 
            // timerSeguridad
            // 
            this.timerSeguridad.Interval = 10000;
            this.timerSeguridad.Tick += new System.EventHandler(this.timerSeguridad_Tick);
            // 
            // FrmControlAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 714);
            this.Controls.Add(this.dgvControlAcceso);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.cboAtraccion);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtOcupacion);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmControlAcceso";
            this.Text = "FrmControlAcceso";
            this.Load += new System.EventHandler(this.FrmControlAcceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlAcceso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.ComboBox cboAtraccion;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgvControlAcceso;
        private System.Windows.Forms.Timer timerSeguridad;
    }
}