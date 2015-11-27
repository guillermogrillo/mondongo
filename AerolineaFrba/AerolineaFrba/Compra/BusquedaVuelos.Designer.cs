namespace AerolineaFrba.Compra
{
    partial class BusquedaVuelos
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
            this.lblCiudadOrigen = new System.Windows.Forms.Label();
            this.lblCiudadDestino = new System.Windows.Forms.Label();
            this.lblFechaViaje = new System.Windows.Forms.Label();
            this.tbCiudadDestino = new System.Windows.Forms.TextBox();
            this.tbCiudadOrigen = new System.Windows.Forms.TextBox();
            this.dpFechaViaje = new System.Windows.Forms.DateTimePicker();
            this.lblCantidadPasajeros = new System.Windows.Forms.Label();
            this.tbCantidadPasajeros = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnBuscarCiudadDesde = new System.Windows.Forms.Button();
            this.btnCiudadHasta = new System.Windows.Forms.Button();
            this.cbEncomienda = new System.Windows.Forms.CheckBox();
            this.tbKg = new System.Windows.Forms.TextBox();
            this.lblKgs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCiudadOrigen
            // 
            this.lblCiudadOrigen.AutoSize = true;
            this.lblCiudadOrigen.Location = new System.Drawing.Point(30, 33);
            this.lblCiudadOrigen.Name = "lblCiudadOrigen";
            this.lblCiudadOrigen.Size = new System.Drawing.Size(74, 13);
            this.lblCiudadOrigen.TabIndex = 0;
            this.lblCiudadOrigen.Text = "Ciudad Origen";
            // 
            // lblCiudadDestino
            // 
            this.lblCiudadDestino.AutoSize = true;
            this.lblCiudadDestino.Location = new System.Drawing.Point(30, 58);
            this.lblCiudadDestino.Name = "lblCiudadDestino";
            this.lblCiudadDestino.Size = new System.Drawing.Size(79, 13);
            this.lblCiudadDestino.TabIndex = 2;
            this.lblCiudadDestino.Text = "Ciudad Destino";
            // 
            // lblFechaViaje
            // 
            this.lblFechaViaje.AutoSize = true;
            this.lblFechaViaje.Location = new System.Drawing.Point(30, 80);
            this.lblFechaViaje.Name = "lblFechaViaje";
            this.lblFechaViaje.Size = new System.Drawing.Size(78, 13);
            this.lblFechaViaje.TabIndex = 4;
            this.lblFechaViaje.Text = "Fecha de Viaje";
            // 
            // tbCiudadDestino
            // 
            this.tbCiudadDestino.Enabled = false;
            this.tbCiudadDestino.Location = new System.Drawing.Point(134, 54);
            this.tbCiudadDestino.Name = "tbCiudadDestino";
            this.tbCiudadDestino.Size = new System.Drawing.Size(153, 20);
            this.tbCiudadDestino.TabIndex = 3;
            // 
            // tbCiudadOrigen
            // 
            this.tbCiudadOrigen.Enabled = false;
            this.tbCiudadOrigen.Location = new System.Drawing.Point(134, 30);
            this.tbCiudadOrigen.Name = "tbCiudadOrigen";
            this.tbCiudadOrigen.Size = new System.Drawing.Size(153, 20);
            this.tbCiudadOrigen.TabIndex = 1;
            // 
            // dpFechaViaje
            // 
            this.dpFechaViaje.CustomFormat = "dd/MM/yyyy";
            this.dpFechaViaje.Location = new System.Drawing.Point(134, 80);
            this.dpFechaViaje.Name = "dpFechaViaje";
            this.dpFechaViaje.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dpFechaViaje.Size = new System.Drawing.Size(153, 20);
            this.dpFechaViaje.TabIndex = 5;
            this.dpFechaViaje.Value = new System.DateTime(2015, 11, 11, 0, 0, 0, 0);
            // 
            // lblCantidadPasajeros
            // 
            this.lblCantidadPasajeros.AutoSize = true;
            this.lblCantidadPasajeros.Location = new System.Drawing.Point(15, 106);
            this.lblCantidadPasajeros.Name = "lblCantidadPasajeros";
            this.lblCantidadPasajeros.Size = new System.Drawing.Size(113, 13);
            this.lblCantidadPasajeros.TabIndex = 6;
            this.lblCantidadPasajeros.Text = "Cantidad de Pasajeros";
            // 
            // tbCantidadPasajeros
            // 
            this.tbCantidadPasajeros.Location = new System.Drawing.Point(134, 104);
            this.tbCantidadPasajeros.MaxLength = 2;
            this.tbCantidadPasajeros.Name = "tbCantidadPasajeros";
            this.tbCantidadPasajeros.Size = new System.Drawing.Size(49, 20);
            this.tbCantidadPasajeros.TabIndex = 7;
            this.tbCantidadPasajeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidadPasajeros_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(55, 156);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 30);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(164, 156);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(15, 8);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 10;
            // 
            // btnBuscarCiudadDesde
            // 
            this.btnBuscarCiudadDesde.Location = new System.Drawing.Point(292, 31);
            this.btnBuscarCiudadDesde.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCiudadDesde.Name = "btnBuscarCiudadDesde";
            this.btnBuscarCiudadDesde.Size = new System.Drawing.Size(21, 19);
            this.btnBuscarCiudadDesde.TabIndex = 11;
            this.btnBuscarCiudadDesde.Text = "...";
            this.btnBuscarCiudadDesde.UseVisualStyleBackColor = true;
            this.btnBuscarCiudadDesde.Click += new System.EventHandler(this.btnBuscarCiudadDesde_Click);
            // 
            // btnCiudadHasta
            // 
            this.btnCiudadHasta.Location = new System.Drawing.Point(292, 55);
            this.btnCiudadHasta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCiudadHasta.Name = "btnCiudadHasta";
            this.btnCiudadHasta.Size = new System.Drawing.Size(21, 19);
            this.btnCiudadHasta.TabIndex = 12;
            this.btnCiudadHasta.Text = "...";
            this.btnCiudadHasta.UseVisualStyleBackColor = true;
            this.btnCiudadHasta.Click += new System.EventHandler(this.btnCiudadHasta_Click);
            // 
            // cbEncomienda
            // 
            this.cbEncomienda.AutoSize = true;
            this.cbEncomienda.Location = new System.Drawing.Point(24, 131);
            this.cbEncomienda.Name = "cbEncomienda";
            this.cbEncomienda.Size = new System.Drawing.Size(91, 17);
            this.cbEncomienda.TabIndex = 13;
            this.cbEncomienda.Text = "Encomienda?";
            this.cbEncomienda.UseVisualStyleBackColor = true;
            this.cbEncomienda.CheckedChanged += new System.EventHandler(this.cbEncomienda_CheckedChanged);
            // 
            // tbKg
            // 
            this.tbKg.Location = new System.Drawing.Point(134, 130);
            this.tbKg.MaxLength = 2;
            this.tbKg.Name = "tbKg";
            this.tbKg.Size = new System.Drawing.Size(52, 20);
            this.tbKg.TabIndex = 14;
            this.tbKg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKg_KeyPress);
            // 
            // lblKgs
            // 
            this.lblKgs.AutoSize = true;
            this.lblKgs.Location = new System.Drawing.Point(192, 135);
            this.lblKgs.Name = "lblKgs";
            this.lblKgs.Size = new System.Drawing.Size(28, 13);
            this.lblKgs.TabIndex = 15;
            this.lblKgs.Text = "Kgs.";
            // 
            // BusquedaVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 206);
            this.ControlBox = false;
            this.Controls.Add(this.lblKgs);
            this.Controls.Add(this.tbKg);
            this.Controls.Add(this.cbEncomienda);
            this.Controls.Add(this.btnCiudadHasta);
            this.Controls.Add(this.btnBuscarCiudadDesde);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbCantidadPasajeros);
            this.Controls.Add(this.lblCantidadPasajeros);
            this.Controls.Add(this.dpFechaViaje);
            this.Controls.Add(this.lblFechaViaje);
            this.Controls.Add(this.tbCiudadDestino);
            this.Controls.Add(this.lblCiudadDestino);
            this.Controls.Add(this.tbCiudadOrigen);
            this.Controls.Add(this.lblCiudadOrigen);
            this.Name = "BusquedaVuelos";
            this.Text = "Busqueda de Vuelos";
            this.Load += new System.EventHandler(this.BusquedaVuelos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCiudadOrigen;
        private System.Windows.Forms.Label lblCiudadDestino;
        private System.Windows.Forms.Label lblFechaViaje;
        private System.Windows.Forms.TextBox tbCiudadDestino;
        private System.Windows.Forms.TextBox tbCiudadOrigen;
        private System.Windows.Forms.DateTimePicker dpFechaViaje;
        private System.Windows.Forms.Label lblCantidadPasajeros;
        private System.Windows.Forms.TextBox tbCantidadPasajeros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnBuscarCiudadDesde;
        private System.Windows.Forms.Button btnCiudadHasta;
        private System.Windows.Forms.CheckBox cbEncomienda;
        private System.Windows.Forms.TextBox tbKg;
        private System.Windows.Forms.Label lblKgs;
    }
}