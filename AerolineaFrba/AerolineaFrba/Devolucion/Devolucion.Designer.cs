namespace AerolineaFrba.Devolucion
{
    partial class Devolucion
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
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbDniPagador = new System.Windows.Forms.TextBox();
            this.lblDniPagador = new System.Windows.Forms.Label();
            this.flpPasajeros = new System.Windows.Forms.FlowLayoutPanel();
            this.gbPasajeros = new System.Windows.Forms.GroupBox();
            this.dgvPasajeros = new System.Windows.Forms.DataGridView();
            this.btnCancelarPasaje = new System.Windows.Forms.Button();
            this.flpPaquetes = new System.Windows.Forms.FlowLayoutPanel();
            this.gbPaquete = new System.Windows.Forms.GroupBox();
            this.lblTextoCantidadKg = new System.Windows.Forms.Label();
            this.lblCantKg = new System.Windows.Forms.Label();
            this.btnCancelarPaquete = new System.Windows.Forms.Button();
            this.lblTextoMonto = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.gbVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.flpPasajeros.SuspendLayout();
            this.gbPasajeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).BeginInit();
            this.flpPaquetes.SuspendLayout();
            this.gbPaquete.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVentas
            // 
            this.gbVentas.Controls.Add(this.btnVolver);
            this.gbVentas.Controls.Add(this.btnCancelarVenta);
            this.gbVentas.Controls.Add(this.btnDetalle);
            this.gbVentas.Controls.Add(this.dgvVentas);
            this.gbVentas.Controls.Add(this.btnBuscar);
            this.gbVentas.Controls.Add(this.tbDniPagador);
            this.gbVentas.Controls.Add(this.lblDniPagador);
            this.gbVentas.Location = new System.Drawing.Point(13, 13);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(572, 250);
            this.gbVentas.TabIndex = 0;
            this.gbVentas.TabStop = false;
            this.gbVentas.Text = "Ventas";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(381, 22);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 30);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Location = new System.Drawing.Point(289, 211);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(100, 30);
            this.btnCancelarVenta.TabIndex = 5;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(183, 211);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(100, 30);
            this.btnDetalle.TabIndex = 4;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(7, 54);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(559, 151);
            this.dgvVentas.TabIndex = 3;
            this.dgvVentas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVentas_CellMouseClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(275, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbDniPagador
            // 
            this.tbDniPagador.Location = new System.Drawing.Point(169, 28);
            this.tbDniPagador.MaxLength = 9;
            this.tbDniPagador.Name = "tbDniPagador";
            this.tbDniPagador.Size = new System.Drawing.Size(100, 20);
            this.tbDniPagador.TabIndex = 1;
            this.tbDniPagador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDniPagador_KeyPress);
            // 
            // lblDniPagador
            // 
            this.lblDniPagador.AutoSize = true;
            this.lblDniPagador.Location = new System.Drawing.Point(91, 31);
            this.lblDniPagador.Name = "lblDniPagador";
            this.lblDniPagador.Size = new System.Drawing.Size(72, 13);
            this.lblDniPagador.TabIndex = 0;
            this.lblDniPagador.Text = "Dni (Pagador)";
            // 
            // flpPasajeros
            // 
            this.flpPasajeros.Controls.Add(this.gbPasajeros);
            this.flpPasajeros.Location = new System.Drawing.Point(13, 270);
            this.flpPasajeros.Name = "flpPasajeros";
            this.flpPasajeros.Size = new System.Drawing.Size(572, 185);
            this.flpPasajeros.TabIndex = 1;
            this.flpPasajeros.VisibleChanged += new System.EventHandler(this.flpPasajeros_VisibleChanged);
            // 
            // gbPasajeros
            // 
            this.gbPasajeros.Controls.Add(this.btnCancelarPasaje);
            this.gbPasajeros.Controls.Add(this.dgvPasajeros);
            this.gbPasajeros.Location = new System.Drawing.Point(3, 3);
            this.gbPasajeros.Name = "gbPasajeros";
            this.gbPasajeros.Size = new System.Drawing.Size(563, 182);
            this.gbPasajeros.TabIndex = 0;
            this.gbPasajeros.TabStop = false;
            this.gbPasajeros.Text = "Pasajeros";
            // 
            // dgvPasajeros
            // 
            this.dgvPasajeros.AllowUserToAddRows = false;
            this.dgvPasajeros.AllowUserToDeleteRows = false;
            this.dgvPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajeros.Location = new System.Drawing.Point(7, 20);
            this.dgvPasajeros.Name = "dgvPasajeros";
            this.dgvPasajeros.ReadOnly = true;
            this.dgvPasajeros.Size = new System.Drawing.Size(550, 112);
            this.dgvPasajeros.TabIndex = 0;
            this.dgvPasajeros.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPasajeros_CellMouseClick);
            // 
            // btnCancelarPasaje
            // 
            this.btnCancelarPasaje.Location = new System.Drawing.Point(231, 146);
            this.btnCancelarPasaje.Name = "btnCancelarPasaje";
            this.btnCancelarPasaje.Size = new System.Drawing.Size(100, 30);
            this.btnCancelarPasaje.TabIndex = 5;
            this.btnCancelarPasaje.Text = "Cancelar Pasaje";
            this.btnCancelarPasaje.UseVisualStyleBackColor = true;
            this.btnCancelarPasaje.Click += new System.EventHandler(this.btnCancelarPasaje_Click);
            // 
            // flpPaquetes
            // 
            this.flpPaquetes.Controls.Add(this.gbPaquete);
            this.flpPaquetes.Location = new System.Drawing.Point(12, 461);
            this.flpPaquetes.Name = "flpPaquetes";
            this.flpPaquetes.Size = new System.Drawing.Size(572, 62);
            this.flpPaquetes.TabIndex = 2;
            this.flpPaquetes.VisibleChanged += new System.EventHandler(this.flpPaquetes_VisibleChanged);
            // 
            // gbPaquete
            // 
            this.gbPaquete.Controls.Add(this.lblMonto);
            this.gbPaquete.Controls.Add(this.lblTextoMonto);
            this.gbPaquete.Controls.Add(this.btnCancelarPaquete);
            this.gbPaquete.Controls.Add(this.lblCantKg);
            this.gbPaquete.Controls.Add(this.lblTextoCantidadKg);
            this.gbPaquete.Location = new System.Drawing.Point(3, 3);
            this.gbPaquete.Name = "gbPaquete";
            this.gbPaquete.Size = new System.Drawing.Size(563, 49);
            this.gbPaquete.TabIndex = 0;
            this.gbPaquete.TabStop = false;
            this.gbPaquete.Text = "Encomiendas";
            // 
            // lblTextoCantidadKg
            // 
            this.lblTextoCantidadKg.AutoSize = true;
            this.lblTextoCantidadKg.Location = new System.Drawing.Point(88, 22);
            this.lblTextoCantidadKg.Name = "lblTextoCantidadKg";
            this.lblTextoCantidadKg.Size = new System.Drawing.Size(83, 13);
            this.lblTextoCantidadKg.TabIndex = 0;
            this.lblTextoCantidadKg.Text = "Cantidad de Kg.";
            // 
            // lblCantKg
            // 
            this.lblCantKg.AutoSize = true;
            this.lblCantKg.Location = new System.Drawing.Point(177, 22);
            this.lblCantKg.Name = "lblCantKg";
            this.lblCantKg.Size = new System.Drawing.Size(52, 13);
            this.lblCantKg.TabIndex = 1;
            this.lblCantKg.Text = "lblCantKg";
            // 
            // btnCancelarPaquete
            // 
            this.btnCancelarPaquete.Location = new System.Drawing.Point(421, 13);
            this.btnCancelarPaquete.Name = "btnCancelarPaquete";
            this.btnCancelarPaquete.Size = new System.Drawing.Size(100, 30);
            this.btnCancelarPaquete.TabIndex = 6;
            this.btnCancelarPaquete.Text = "Cancelar Paquete";
            this.btnCancelarPaquete.UseVisualStyleBackColor = true;
            this.btnCancelarPaquete.Click += new System.EventHandler(this.btnCancelarPaquete_Click);
            // 
            // lblTextoMonto
            // 
            this.lblTextoMonto.AutoSize = true;
            this.lblTextoMonto.Location = new System.Drawing.Point(249, 22);
            this.lblTextoMonto.Name = "lblTextoMonto";
            this.lblTextoMonto.Size = new System.Drawing.Size(37, 13);
            this.lblTextoMonto.TabIndex = 7;
            this.lblTextoMonto.Text = "Monto";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(303, 22);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(36, 13);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "monto";
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 535);
            this.ControlBox = false;
            this.Controls.Add(this.flpPaquetes);
            this.Controls.Add(this.flpPasajeros);
            this.Controls.Add(this.gbVentas);
            this.Name = "Devolucion";
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.Devolucion_Load);
            this.gbVentas.ResumeLayout(false);
            this.gbVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.flpPasajeros.ResumeLayout(false);
            this.gbPasajeros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).EndInit();
            this.flpPaquetes.ResumeLayout(false);
            this.gbPaquete.ResumeLayout(false);
            this.gbPaquete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVentas;
        private System.Windows.Forms.Label lblDniPagador;
        private System.Windows.Forms.TextBox tbDniPagador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.FlowLayoutPanel flpPasajeros;
        private System.Windows.Forms.GroupBox gbPasajeros;
        private System.Windows.Forms.DataGridView dgvPasajeros;
        private System.Windows.Forms.Button btnCancelarPasaje;
        private System.Windows.Forms.FlowLayoutPanel flpPaquetes;
        private System.Windows.Forms.GroupBox gbPaquete;
        private System.Windows.Forms.Label lblTextoCantidadKg;
        private System.Windows.Forms.Label lblCantKg;
        private System.Windows.Forms.Button btnCancelarPaquete;
        private System.Windows.Forms.Label lblTextoMonto;
        private System.Windows.Forms.Label lblMonto;
    }
}