namespace AerolineaFrba.Compra
{
    partial class Pagador
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
            this.lblDni = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblFNac = new System.Windows.Forms.Label();
            this.dpFNac = new System.Windows.Forms.DateTimePicker();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbDatosTarjeta = new System.Windows.Forms.GroupBox();
            this.tbCodSeguridad = new System.Windows.Forms.TextBox();
            this.lblCodSeguridad = new System.Windows.Forms.Label();
            this.tbVencimiento = new System.Windows.Forms.TextBox();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.cbCuotas = new System.Windows.Forms.ComboBox();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.cbTarjetas = new System.Windows.Forms.ComboBox();
            this.lblTarjetaCredito = new System.Windows.Forms.Label();
            this.tbNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.lblTiposDePago = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.epNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.epApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNroTarjeta = new System.Windows.Forms.ErrorProvider(this.components);
            this.epVencimiento = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCodSeguridad = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDatosPersonales.SuspendLayout();
            this.gbDatosTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNroTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodSeguridad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(49, 13);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(81, 10);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(116, 20);
            this.tbDni.TabIndex = 2;
            this.tbDni.TextChanged += new System.EventHandler(this.tbDni_TextChanged);
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDni_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(216, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 20);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.tbDireccion);
            this.gbDatosPersonales.Controls.Add(this.tbTelefono);
            this.gbDatosPersonales.Controls.Add(this.lblTelefono);
            this.gbDatosPersonales.Controls.Add(this.tbMail);
            this.gbDatosPersonales.Controls.Add(this.lblMail);
            this.gbDatosPersonales.Controls.Add(this.lblCalle);
            this.gbDatosPersonales.Controls.Add(this.lblFNac);
            this.gbDatosPersonales.Controls.Add(this.dpFNac);
            this.gbDatosPersonales.Controls.Add(this.tbApellido);
            this.gbDatosPersonales.Controls.Add(this.lblApellido);
            this.gbDatosPersonales.Controls.Add(this.tbNombre);
            this.gbDatosPersonales.Controls.Add(this.lblNombre);
            this.gbDatosPersonales.Location = new System.Drawing.Point(13, 37);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(621, 114);
            this.gbDatosPersonales.TabIndex = 4;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personales";
            // 
            // tbDireccion
            // 
            this.tbDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDireccion.Location = new System.Drawing.Point(403, 81);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(179, 20);
            this.tbDireccion.TabIndex = 11;
            this.tbDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.tbDireccion_Validating);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(103, 81);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(194, 20);
            this.tbTelefono.TabIndex = 10;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            this.tbTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefono_Validating);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(18, 84);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Teléfono";
            // 
            // tbMail
            // 
            this.tbMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMail.Location = new System.Drawing.Point(403, 52);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(179, 20);
            this.tbMail.TabIndex = 8;
            this.tbMail.Validating += new System.ComponentModel.CancelEventHandler(this.tbMail_Validating);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(349, 55);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(339, 84);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(52, 13);
            this.lblCalle.TabIndex = 6;
            this.lblCalle.Text = "Dirección";
            // 
            // lblFNac
            // 
            this.lblFNac.AutoSize = true;
            this.lblFNac.Location = new System.Drawing.Point(18, 55);
            this.lblFNac.Name = "lblFNac";
            this.lblFNac.Size = new System.Drawing.Size(108, 13);
            this.lblFNac.TabIndex = 5;
            this.lblFNac.Text = "Fecha de Nacimiento";
            // 
            // dpFNac
            // 
            this.dpFNac.CustomFormat = " ";
            this.dpFNac.Location = new System.Drawing.Point(132, 52);
            this.dpFNac.Name = "dpFNac";
            this.dpFNac.Size = new System.Drawing.Size(165, 20);
            this.dpFNac.TabIndex = 4;
            // 
            // tbApellido
            // 
            this.tbApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbApellido.Location = new System.Drawing.Point(403, 23);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(179, 20);
            this.tbApellido.TabIndex = 3;
            this.tbApellido.Validating += new System.ComponentModel.CancelEventHandler(this.tbApellido_Validating);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(339, 26);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // tbNombre
            // 
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Location = new System.Drawing.Point(103, 23);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(194, 20);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.Validating += new System.ComponentModel.CancelEventHandler(this.tbNombre_Validating);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // gbDatosTarjeta
            // 
            this.gbDatosTarjeta.Controls.Add(this.tbCodSeguridad);
            this.gbDatosTarjeta.Controls.Add(this.lblCodSeguridad);
            this.gbDatosTarjeta.Controls.Add(this.tbVencimiento);
            this.gbDatosTarjeta.Controls.Add(this.lblVencimiento);
            this.gbDatosTarjeta.Controls.Add(this.cbCuotas);
            this.gbDatosTarjeta.Controls.Add(this.lblCuotas);
            this.gbDatosTarjeta.Controls.Add(this.cbTarjetas);
            this.gbDatosTarjeta.Controls.Add(this.lblTarjetaCredito);
            this.gbDatosTarjeta.Controls.Add(this.tbNumeroTarjeta);
            this.gbDatosTarjeta.Controls.Add(this.lblNumeroTarjeta);
            this.gbDatosTarjeta.Controls.Add(this.cbTipoPago);
            this.gbDatosTarjeta.Controls.Add(this.lblTiposDePago);
            this.gbDatosTarjeta.Location = new System.Drawing.Point(13, 158);
            this.gbDatosTarjeta.Name = "gbDatosTarjeta";
            this.gbDatosTarjeta.Size = new System.Drawing.Size(621, 119);
            this.gbDatosTarjeta.TabIndex = 5;
            this.gbDatosTarjeta.TabStop = false;
            this.gbDatosTarjeta.Text = "Datos del Pago";
            // 
            // tbCodSeguridad
            // 
            this.tbCodSeguridad.Location = new System.Drawing.Point(403, 82);
            this.tbCodSeguridad.Name = "tbCodSeguridad";
            this.tbCodSeguridad.Size = new System.Drawing.Size(58, 20);
            this.tbCodSeguridad.TabIndex = 11;
            this.tbCodSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodSeguridad_KeyPress);
            this.tbCodSeguridad.Validating += new System.ComponentModel.CancelEventHandler(this.tbCodSeguridad_Validating);
            // 
            // lblCodSeguridad
            // 
            this.lblCodSeguridad.AutoSize = true;
            this.lblCodSeguridad.Location = new System.Drawing.Point(306, 82);
            this.lblCodSeguridad.Name = "lblCodSeguridad";
            this.lblCodSeguridad.Size = new System.Drawing.Size(77, 13);
            this.lblCodSeguridad.TabIndex = 10;
            this.lblCodSeguridad.Text = "Cod.Seguridad";
            // 
            // tbVencimiento
            // 
            this.tbVencimiento.Location = new System.Drawing.Point(103, 79);
            this.tbVencimiento.Name = "tbVencimiento";
            this.tbVencimiento.Size = new System.Drawing.Size(62, 20);
            this.tbVencimiento.TabIndex = 9;
            this.tbVencimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVencimiento_KeyPress);
            this.tbVencimiento.Validating += new System.ComponentModel.CancelEventHandler(this.tbVencimiento_Validating);
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(21, 82);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(65, 13);
            this.lblVencimiento.TabIndex = 8;
            this.lblVencimiento.Text = "Vencimiento";
            // 
            // cbCuotas
            // 
            this.cbCuotas.FormattingEnabled = true;
            this.cbCuotas.Location = new System.Drawing.Point(103, 47);
            this.cbCuotas.Name = "cbCuotas";
            this.cbCuotas.Size = new System.Drawing.Size(194, 21);
            this.cbCuotas.TabIndex = 7;
            this.cbCuotas.SelectedIndexChanged += new System.EventHandler(this.cbCuotas_SelectedIndexChanged);
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(36, 50);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(40, 13);
            this.lblCuotas.TabIndex = 6;
            this.lblCuotas.Text = "Cuotas";
            // 
            // cbTarjetas
            // 
            this.cbTarjetas.FormattingEnabled = true;
            this.cbTarjetas.Location = new System.Drawing.Point(403, 17);
            this.cbTarjetas.Name = "cbTarjetas";
            this.cbTarjetas.Size = new System.Drawing.Size(179, 21);
            this.cbTarjetas.TabIndex = 5;
            this.cbTarjetas.SelectedIndexChanged += new System.EventHandler(this.cbTarjetas_SelectedIndexChanged);
            // 
            // lblTarjetaCredito
            // 
            this.lblTarjetaCredito.AutoSize = true;
            this.lblTarjetaCredito.Location = new System.Drawing.Point(306, 20);
            this.lblTarjetaCredito.Name = "lblTarjetaCredito";
            this.lblTarjetaCredito.Size = new System.Drawing.Size(90, 13);
            this.lblTarjetaCredito.TabIndex = 4;
            this.lblTarjetaCredito.Text = "Tarjeta de crédito";
            // 
            // tbNumeroTarjeta
            // 
            this.tbNumeroTarjeta.Location = new System.Drawing.Point(403, 47);
            this.tbNumeroTarjeta.Name = "tbNumeroTarjeta";
            this.tbNumeroTarjeta.Size = new System.Drawing.Size(179, 20);
            this.tbNumeroTarjeta.TabIndex = 3;
            this.tbNumeroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeroTarjeta_KeyPress);
            this.tbNumeroTarjeta.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumeroTarjeta_Validating);
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(321, 50);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(60, 13);
            this.lblNumeroTarjeta.TabIndex = 2;
            this.lblNumeroTarjeta.Text = "Nro.Tarjeta";
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Location = new System.Drawing.Point(103, 17);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(194, 21);
            this.cbTipoPago.TabIndex = 1;
            this.cbTipoPago.SelectedIndexChanged += new System.EventHandler(this.cbTipoPago_SelectedIndexChanged);
            // 
            // lblTiposDePago
            // 
            this.lblTiposDePago.AutoSize = true;
            this.lblTiposDePago.Location = new System.Drawing.Point(21, 20);
            this.lblTiposDePago.Name = "lblTiposDePago";
            this.lblTiposDePago.Size = new System.Drawing.Size(76, 13);
            this.lblTiposDePago.TabIndex = 0;
            this.lblTiposDePago.Text = "Tipos de Pago";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(319, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(235, 283);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // epNombre
            // 
            this.epNombre.ContainerControl = this;
            // 
            // epApellido
            // 
            this.epApellido.ContainerControl = this;
            // 
            // epMail
            // 
            this.epMail.ContainerControl = this;
            // 
            // epTelefono
            // 
            this.epTelefono.ContainerControl = this;
            // 
            // epDireccion
            // 
            this.epDireccion.ContainerControl = this;
            // 
            // epNroTarjeta
            // 
            this.epNroTarjeta.ContainerControl = this;
            // 
            // epVencimiento
            // 
            this.epVencimiento.ContainerControl = this;
            // 
            // epCodSeguridad
            // 
            this.epCodSeguridad.ContainerControl = this;
            // 
            // Pagador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 314);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.gbDatosTarjeta);
            this.Controls.Add(this.gbDatosPersonales);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lblDni);
            this.Name = "Pagador";
            this.Text = "Datos del Pago";
            this.Load += new System.EventHandler(this.Pagador_Load);
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.gbDatosTarjeta.ResumeLayout(false);
            this.gbDatosTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNroTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodSeguridad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblFNac;
        private System.Windows.Forms.DateTimePicker dpFNac;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbDatosTarjeta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblTiposDePago;
        private System.Windows.Forms.ComboBox cbTipoPago;
        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.TextBox tbNumeroTarjeta;
        private System.Windows.Forms.Label lblTarjetaCredito;
        private System.Windows.Forms.ComboBox cbTarjetas;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.ComboBox cbCuotas;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.TextBox tbVencimiento;
        private System.Windows.Forms.TextBox tbCodSeguridad;
        private System.Windows.Forms.Label lblCodSeguridad;
        private System.Windows.Forms.ErrorProvider epNombre;
        private System.Windows.Forms.ErrorProvider epApellido;
        private System.Windows.Forms.ErrorProvider epMail;
        private System.Windows.Forms.ErrorProvider epTelefono;
        private System.Windows.Forms.ErrorProvider epDireccion;
        private System.Windows.Forms.ErrorProvider epNroTarjeta;
        private System.Windows.Forms.ErrorProvider epVencimiento;
        private System.Windows.Forms.ErrorProvider epCodSeguridad;
    }
}