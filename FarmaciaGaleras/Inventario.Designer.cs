namespace FarmaciaGaleras
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.lblFechaRealizacion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCantidadDisponible = new System.Windows.Forms.TextBox();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.txtConcentracion = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtcodigoProducto = new System.Windows.Forms.TextBox();
            this.txtNumeroEstante = new System.Windows.Forms.TextBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaRealizacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblCantidadDisponible = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.lblConcentracion = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.lblNumeroEstante = new System.Windows.Forms.Label();
            this.erpMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.pibFruta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFruta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaRealizacion
            // 
            this.lblFechaRealizacion.AutoSize = true;
            this.lblFechaRealizacion.Location = new System.Drawing.Point(36, 35);
            this.lblFechaRealizacion.Name = "lblFechaRealizacion";
            this.lblFechaRealizacion.Size = new System.Drawing.Size(110, 13);
            this.lblFechaRealizacion.TabIndex = 0;
            this.lblFechaRealizacion.Text = "&Fecha de Realización";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(347, 371);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(244, 371);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 30);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCantidadDisponible
            // 
            this.txtCantidadDisponible.BackColor = System.Drawing.Color.PeachPuff;
            this.txtCantidadDisponible.Location = new System.Drawing.Point(196, 278);
            this.txtCantidadDisponible.Name = "txtCantidadDisponible";
            this.txtCantidadDisponible.Size = new System.Drawing.Size(200, 20);
            this.txtCantidadDisponible.TabIndex = 13;
            this.txtCantidadDisponible.TextChanged += new System.EventHandler(this.txtCantidadDisponible_TextChanged);
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.BackColor = System.Drawing.Color.PeachPuff;
            this.txtPresentacion.Location = new System.Drawing.Point(196, 241);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(200, 20);
            this.txtPresentacion.TabIndex = 11;
            // 
            // txtConcentracion
            // 
            this.txtConcentracion.BackColor = System.Drawing.Color.PeachPuff;
            this.txtConcentracion.Location = new System.Drawing.Point(196, 198);
            this.txtConcentracion.Name = "txtConcentracion";
            this.txtConcentracion.Size = new System.Drawing.Size(200, 20);
            this.txtConcentracion.TabIndex = 9;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.Color.PeachPuff;
            this.txtNombreProducto.Location = new System.Drawing.Point(196, 162);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(200, 20);
            this.txtNombreProducto.TabIndex = 7;
            // 
            // txtcodigoProducto
            // 
            this.txtcodigoProducto.BackColor = System.Drawing.Color.PeachPuff;
            this.txtcodigoProducto.Location = new System.Drawing.Point(196, 119);
            this.txtcodigoProducto.Name = "txtcodigoProducto";
            this.txtcodigoProducto.Size = new System.Drawing.Size(200, 20);
            this.txtcodigoProducto.TabIndex = 5;
            // 
            // txtNumeroEstante
            // 
            this.txtNumeroEstante.BackColor = System.Drawing.Color.PeachPuff;
            this.txtNumeroEstante.Location = new System.Drawing.Point(196, 79);
            this.txtNumeroEstante.Name = "txtNumeroEstante";
            this.txtNumeroEstante.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroEstante.TabIndex = 3;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(196, 310);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVencimiento.TabIndex = 15;
            // 
            // dtpFechaRealizacion
            // 
            this.dtpFechaRealizacion.CalendarMonthBackground = System.Drawing.SystemColors.Desktop;
            this.dtpFechaRealizacion.Location = new System.Drawing.Point(196, 29);
            this.dtpFechaRealizacion.Name = "dtpFechaRealizacion";
            this.dtpFechaRealizacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRealizacion.TabIndex = 1;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(36, 316);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(112, 13);
            this.lblFechaVencimiento.TabIndex = 14;
            this.lblFechaVencimiento.Text = "F&echa de vencimiento";
            // 
            // lblCantidadDisponible
            // 
            this.lblCantidadDisponible.AutoSize = true;
            this.lblCantidadDisponible.Location = new System.Drawing.Point(36, 281);
            this.lblCantidadDisponible.Name = "lblCantidadDisponible";
            this.lblCantidadDisponible.Size = new System.Drawing.Size(101, 13);
            this.lblCantidadDisponible.TabIndex = 12;
            this.lblCantidadDisponible.Text = "C&antidad Disponible";
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(36, 244);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(69, 13);
            this.lblPresentacion.TabIndex = 10;
            this.lblPresentacion.Text = "&Presentación";
            // 
            // lblConcentracion
            // 
            this.lblConcentracion.AutoSize = true;
            this.lblConcentracion.Location = new System.Drawing.Point(36, 198);
            this.lblConcentracion.Name = "lblConcentracion";
            this.lblConcentracion.Size = new System.Drawing.Size(76, 13);
            this.lblConcentracion.TabIndex = 8;
            this.lblConcentracion.Text = "Co&ncentración";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(36, 162);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(107, 13);
            this.lblNombreProducto.TabIndex = 6;
            this.lblNombreProducto.Text = "N&ombre del Producto";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(36, 119);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(103, 13);
            this.lblCodigoProducto.TabIndex = 4;
            this.lblCodigoProducto.Text = "&Código del Producto";
            // 
            // lblNumeroEstante
            // 
            this.lblNumeroEstante.AutoSize = true;
            this.lblNumeroEstante.Location = new System.Drawing.Point(36, 79);
            this.lblNumeroEstante.Name = "lblNumeroEstante";
            this.lblNumeroEstante.Size = new System.Drawing.Size(83, 13);
            this.lblNumeroEstante.TabIndex = 2;
            this.lblNumeroEstante.Text = "&Número Estante";
            // 
            // erpMensaje
            // 
            this.erpMensaje.ContainerControl = this;
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(36, 349);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(70, 13);
            this.lblValorUnitario.TabIndex = 18;
            this.lblValorUnitario.Text = "&Valor Unitario";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.BackColor = System.Drawing.Color.PeachPuff;
            this.txtValorUnitario.Location = new System.Drawing.Point(196, 342);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(200, 20);
            this.txtValorUnitario.TabIndex = 19;
            // 
            // pibFruta
            // 
            this.pibFruta.Image = ((System.Drawing.Image)(resources.GetObject("pibFruta.Image")));
            this.pibFruta.Location = new System.Drawing.Point(402, 29);
            this.pibFruta.Name = "pibFruta";
            this.pibFruta.Size = new System.Drawing.Size(255, 333);
            this.pibFruta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibFruta.TabIndex = 21;
            this.pibFruta.TabStop = false;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 413);
            this.Controls.Add(this.pibFruta);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.lblValorUnitario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCantidadDisponible);
            this.Controls.Add(this.txtPresentacion);
            this.Controls.Add(this.txtConcentracion);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtcodigoProducto);
            this.Controls.Add(this.txtNumeroEstante);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.dtpFechaRealizacion);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.lblCantidadDisponible);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.lblConcentracion);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.lblNumeroEstante);
            this.Controls.Add(this.lblFechaRealizacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFruta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaRealizacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCantidadDisponible;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.TextBox txtConcentracion;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtcodigoProducto;
        private System.Windows.Forms.TextBox txtNumeroEstante;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaRealizacion;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblCantidadDisponible;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblConcentracion;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Label lblNumeroEstante;
        private System.Windows.Forms.ErrorProvider erpMensaje;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.PictureBox pibFruta;
    }
}