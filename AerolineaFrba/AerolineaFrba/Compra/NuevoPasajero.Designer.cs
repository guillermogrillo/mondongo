namespace AerolineaFrba.Compra
{
    partial class NuevoPasajero
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
            this.gbButaca = new System.Windows.Forms.GroupBox();
            this.cbPisoButaca = new System.Windows.Forms.ComboBox();
            this.lblButacaPiso = new System.Windows.Forms.Label();
            this.cbNumeroButaca = new System.Windows.Forms.ComboBox();
            this.lblNumeroButaca = new System.Windows.Forms.Label();
            this.cbTipoButaca = new System.Windows.Forms.ComboBox();
            this.lblButacaTipo = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.epNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.epApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDatosPersonales.SuspendLayout();
            this.gbButaca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDireccion)).BeginInit();
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
            this.tbDni.TabIndex = 1;
            this.tbDni.TextChanged += new System.EventHandler(this.tbDni_TextChanged);
            this.tbDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDni_KeyDown);
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDni_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(216, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 20);
            this.btnBuscar.TabIndex = 2;
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
            this.gbDatosPersonales.TabIndex = 3;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personales";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(353, 81);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(229, 20);
            this.tbDireccion.TabIndex = 11;
            this.tbDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.tbDireccion_Validating);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(68, 81);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(229, 20);
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
            this.tbMail.Location = new System.Drawing.Point(353, 52);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(229, 20);
            this.tbMail.TabIndex = 8;
            this.tbMail.Validating += new System.ComponentModel.CancelEventHandler(this.tbMail_Validating);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(321, 55);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(303, 84);
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
            this.tbApellido.Location = new System.Drawing.Point(353, 23);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(229, 20);
            this.tbApellido.TabIndex = 3;
            this.tbApellido.Validating += new System.ComponentModel.CancelEventHandler(this.tbApellido_Validating);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(303, 26);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(68, 23);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(229, 20);
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
            // gbButaca
            // 
            this.gbButaca.Controls.Add(this.cbPisoButaca);
            this.gbButaca.Controls.Add(this.lblButacaPiso);
            this.gbButaca.Controls.Add(this.cbNumeroButaca);
            this.gbButaca.Controls.Add(this.lblNumeroButaca);
            this.gbButaca.Controls.Add(this.cbTipoButaca);
            this.gbButaca.Controls.Add(this.lblButacaTipo);
            this.gbButaca.Location = new System.Drawing.Point(12, 157);
            this.gbButaca.Name = "gbButaca";
            this.gbButaca.Size = new System.Drawing.Size(621, 63);
            this.gbButaca.TabIndex = 4;
            this.gbButaca.TabStop = false;
            this.gbButaca.Text = "Datos de la butaca";
            // 
            // cbPisoButaca
            // 
            this.cbPisoButaca.FormattingEnabled = true;
            this.cbPisoButaca.Location = new System.Drawing.Point(280, 23);
            this.cbPisoButaca.Name = "cbPisoButaca";
            this.cbPisoButaca.Size = new System.Drawing.Size(46, 21);
            this.cbPisoButaca.TabIndex = 5;
            // 
            // lblButacaPiso
            // 
            this.lblButacaPiso.AutoSize = true;
            this.lblButacaPiso.Location = new System.Drawing.Point(247, 26);
            this.lblButacaPiso.Name = "lblButacaPiso";
            this.lblButacaPiso.Size = new System.Drawing.Size(27, 13);
            this.lblButacaPiso.TabIndex = 4;
            this.lblButacaPiso.Text = "Piso";
            // 
            // cbNumeroButaca
            // 
            this.cbNumeroButaca.FormattingEnabled = true;
            this.cbNumeroButaca.Location = new System.Drawing.Point(400, 23);
            this.cbNumeroButaca.Name = "cbNumeroButaca";
            this.cbNumeroButaca.Size = new System.Drawing.Size(58, 21);
            this.cbNumeroButaca.TabIndex = 3;
            // 
            // lblNumeroButaca
            // 
            this.lblNumeroButaca.AutoSize = true;
            this.lblNumeroButaca.Location = new System.Drawing.Point(350, 26);
            this.lblNumeroButaca.Name = "lblNumeroButaca";
            this.lblNumeroButaca.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroButaca.TabIndex = 2;
            this.lblNumeroButaca.Text = "Número";
            // 
            // cbTipoButaca
            // 
            this.cbTipoButaca.FormattingEnabled = true;
            this.cbTipoButaca.Location = new System.Drawing.Point(104, 23);
            this.cbTipoButaca.Name = "cbTipoButaca";
            this.cbTipoButaca.Size = new System.Drawing.Size(121, 21);
            this.cbTipoButaca.TabIndex = 1;
            // 
            // lblButacaTipo
            // 
            this.lblButacaTipo.AutoSize = true;
            this.lblButacaTipo.Location = new System.Drawing.Point(18, 26);
            this.lblButacaTipo.Name = "lblButacaTipo";
            this.lblButacaTipo.Size = new System.Drawing.Size(80, 13);
            this.lblButacaTipo.TabIndex = 0;
            this.lblButacaTipo.Text = "Tipo de Butaca";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(234, 226);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(318, 226);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // NuevoPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 259);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.gbButaca);
            this.Controls.Add(this.gbDatosPersonales);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lblDni);
            this.Name = "NuevoPasajero";
            this.Text = "Nuevo Pasajero";
            this.Load += new System.EventHandler(this.NuevoPasajero_Load);
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.gbButaca.ResumeLayout(false);
            this.gbButaca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFNac;
        private System.Windows.Forms.DateTimePicker dpFNac;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.GroupBox gbButaca;
        private System.Windows.Forms.Label lblButacaTipo;
        private System.Windows.Forms.ComboBox cbNumeroButaca;
        private System.Windows.Forms.Label lblNumeroButaca;
        private System.Windows.Forms.ComboBox cbTipoButaca;
        private System.Windows.Forms.Label lblButacaPiso;
        private System.Windows.Forms.ComboBox cbPisoButaca;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider epNombre;
        private System.Windows.Forms.ErrorProvider epApellido;
        private System.Windows.Forms.ErrorProvider epMail;
        private System.Windows.Forms.ErrorProvider epTelefono;
        private System.Windows.Forms.ErrorProvider epDireccion;
    }
}