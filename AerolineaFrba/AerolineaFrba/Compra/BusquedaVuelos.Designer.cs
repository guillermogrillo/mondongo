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
            this.SuspendLayout();
            // 
            // lblCiudadOrigen
            // 
            this.lblCiudadOrigen.AutoSize = true;
            this.lblCiudadOrigen.Location = new System.Drawing.Point(13, 42);
            this.lblCiudadOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiudadOrigen.Name = "lblCiudadOrigen";
            this.lblCiudadOrigen.Size = new System.Drawing.Size(99, 17);
            this.lblCiudadOrigen.TabIndex = 0;
            this.lblCiudadOrigen.Text = "Ciudad Origen";
            // 
            // lblCiudadDestino
            // 
            this.lblCiudadDestino.AutoSize = true;
            this.lblCiudadDestino.Location = new System.Drawing.Point(13, 72);
            this.lblCiudadDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiudadDestino.Name = "lblCiudadDestino";
            this.lblCiudadDestino.Size = new System.Drawing.Size(104, 17);
            this.lblCiudadDestino.TabIndex = 2;
            this.lblCiudadDestino.Text = "Ciudad Destino";
            // 
            // lblFechaViaje
            // 
            this.lblFechaViaje.AutoSize = true;
            this.lblFechaViaje.Location = new System.Drawing.Point(13, 102);
            this.lblFechaViaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaViaje.Name = "lblFechaViaje";
            this.lblFechaViaje.Size = new System.Drawing.Size(102, 17);
            this.lblFechaViaje.TabIndex = 4;
            this.lblFechaViaje.Text = "Fecha de Viaje";
            // 
            // tbCiudadDestino
            // 
            this.tbCiudadDestino.Enabled = false;
            this.tbCiudadDestino.Location = new System.Drawing.Point(125, 72);
            this.tbCiudadDestino.Margin = new System.Windows.Forms.Padding(4);
            this.tbCiudadDestino.Name = "tbCiudadDestino";
            this.tbCiudadDestino.Size = new System.Drawing.Size(130, 22);
            this.tbCiudadDestino.TabIndex = 3;
            // 
            // tbCiudadOrigen
            // 
            this.tbCiudadOrigen.Enabled = false;
            this.tbCiudadOrigen.Location = new System.Drawing.Point(125, 42);
            this.tbCiudadOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.tbCiudadOrigen.Name = "tbCiudadOrigen";
            this.tbCiudadOrigen.Size = new System.Drawing.Size(130, 22);
            this.tbCiudadOrigen.TabIndex = 1;
            // 
            // dpFechaViaje
            // 
            this.dpFechaViaje.CustomFormat = "dd/MM/yyyy";
            this.dpFechaViaje.Location = new System.Drawing.Point(125, 102);
            this.dpFechaViaje.Margin = new System.Windows.Forms.Padding(4);
            this.dpFechaViaje.Name = "dpFechaViaje";
            this.dpFechaViaje.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dpFechaViaje.Size = new System.Drawing.Size(165, 22);
            this.dpFechaViaje.TabIndex = 5;
            this.dpFechaViaje.Value = new System.DateTime(2015, 10, 4, 0, 0, 0, 0);
            this.dpFechaViaje.ValueChanged += new System.EventHandler(this.dpFechaViaje_ValueChanged);
            // 
            // lblCantidadPasajeros
            // 
            this.lblCantidadPasajeros.AutoSize = true;
            this.lblCantidadPasajeros.Location = new System.Drawing.Point(13, 132);
            this.lblCantidadPasajeros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadPasajeros.Name = "lblCantidadPasajeros";
            this.lblCantidadPasajeros.Size = new System.Drawing.Size(151, 17);
            this.lblCantidadPasajeros.TabIndex = 6;
            this.lblCantidadPasajeros.Text = "Cantidad de Pasajeros";
            // 
            // tbCantidadPasajeros
            // 
            this.tbCantidadPasajeros.Location = new System.Drawing.Point(178, 132);
            this.tbCantidadPasajeros.Margin = new System.Windows.Forms.Padding(4);
            this.tbCantidadPasajeros.Name = "tbCantidadPasajeros";
            this.tbCantidadPasajeros.Size = new System.Drawing.Size(112, 22);
            this.tbCantidadPasajeros.TabIndex = 7;
            this.tbCantidadPasajeros.TextChanged += new System.EventHandler(this.tbCantidadPasajeros_TextChanged);
            this.tbCantidadPasajeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidadPasajeros_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(16, 162);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 37);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(165, 162);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 37);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(20, 10);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 10;
            // 
            // btnBuscarCiudadDesde
            // 
            this.btnBuscarCiudadDesde.Location = new System.Drawing.Point(262, 42);
            this.btnBuscarCiudadDesde.Name = "btnBuscarCiudadDesde";
            this.btnBuscarCiudadDesde.Size = new System.Drawing.Size(28, 23);
            this.btnBuscarCiudadDesde.TabIndex = 11;
            this.btnBuscarCiudadDesde.Text = "...";
            this.btnBuscarCiudadDesde.UseVisualStyleBackColor = true;
            this.btnBuscarCiudadDesde.Click += new System.EventHandler(this.btnBuscarCiudadDesde_Click);
            // 
            // btnCiudadHasta
            // 
            this.btnCiudadHasta.Location = new System.Drawing.Point(262, 72);
            this.btnCiudadHasta.Name = "btnCiudadHasta";
            this.btnCiudadHasta.Size = new System.Drawing.Size(28, 23);
            this.btnCiudadHasta.TabIndex = 12;
            this.btnCiudadHasta.Text = "...";
            this.btnCiudadHasta.UseVisualStyleBackColor = true;
            this.btnCiudadHasta.Click += new System.EventHandler(this.btnCiudadHasta_Click);
            // 
            // BusquedaVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 253);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BusquedaVuelos";
            this.Text = "Busqueda de Vuelos";
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
    }
}