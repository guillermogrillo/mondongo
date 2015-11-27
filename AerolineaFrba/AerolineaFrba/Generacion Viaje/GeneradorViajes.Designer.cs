namespace AerolineaFrba.Generacion_Viaje
{
    partial class GeneradorViajes
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
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.lblAeronave = new System.Windows.Forms.Label();
            this.tbCiudadOrigen = new System.Windows.Forms.TextBox();
            this.btnBuscarCiudadOrigen = new System.Windows.Forms.Button();
            this.tbCiudadDestino = new System.Windows.Forms.TextBox();
            this.btnBuscarCiudadDestino = new System.Windows.Forms.Button();
            this.dpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.cbAeronaves = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dpFechaLlegadaEstimada = new System.Windows.Forms.DateTimePicker();
            this.lblFechaLlegadaEstimada = new System.Windows.Forms.Label();
            this.gbViajesPasoUno = new System.Windows.Forms.GroupBox();
            this.cbTipoServicio = new System.Windows.Forms.ComboBox();
            this.lblTipoServicio = new System.Windows.Forms.Label();
            this.btnBuscarRuta = new System.Windows.Forms.Button();
            this.gbViajePasoDos = new System.Windows.Forms.GroupBox();
            this.gbViajesPasoUno.SuspendLayout();
            this.gbViajePasoDos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCiudadOrigen
            // 
            this.lblCiudadOrigen.AutoSize = true;
            this.lblCiudadOrigen.Location = new System.Drawing.Point(40, 20);
            this.lblCiudadOrigen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCiudadOrigen.Name = "lblCiudadOrigen";
            this.lblCiudadOrigen.Size = new System.Drawing.Size(74, 13);
            this.lblCiudadOrigen.TabIndex = 0;
            this.lblCiudadOrigen.Text = "Ciudad Origen";
            // 
            // lblCiudadDestino
            // 
            this.lblCiudadDestino.AutoSize = true;
            this.lblCiudadDestino.Location = new System.Drawing.Point(39, 45);
            this.lblCiudadDestino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCiudadDestino.Name = "lblCiudadDestino";
            this.lblCiudadDestino.Size = new System.Drawing.Size(79, 13);
            this.lblCiudadDestino.TabIndex = 1;
            this.lblCiudadDestino.Text = "Ciudad Destino";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Location = new System.Drawing.Point(34, 29);
            this.lblFechaSalida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(84, 13);
            this.lblFechaSalida.TabIndex = 2;
            this.lblFechaSalida.Text = "Fecha de Salida";
            // 
            // lblAeronave
            // 
            this.lblAeronave.AutoSize = true;
            this.lblAeronave.Location = new System.Drawing.Point(50, 84);
            this.lblAeronave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAeronave.Name = "lblAeronave";
            this.lblAeronave.Size = new System.Drawing.Size(53, 13);
            this.lblAeronave.TabIndex = 4;
            this.lblAeronave.Text = "Aeronave";
            // 
            // tbCiudadOrigen
            // 
            this.tbCiudadOrigen.Enabled = false;
            this.tbCiudadOrigen.Location = new System.Drawing.Point(142, 17);
            this.tbCiudadOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.tbCiudadOrigen.Name = "tbCiudadOrigen";
            this.tbCiudadOrigen.Size = new System.Drawing.Size(174, 20);
            this.tbCiudadOrigen.TabIndex = 5;
            this.tbCiudadOrigen.TextChanged += new System.EventHandler(this.tbCiudadOrigen_TextChanged);
            // 
            // btnBuscarCiudadOrigen
            // 
            this.btnBuscarCiudadOrigen.Location = new System.Drawing.Point(320, 18);
            this.btnBuscarCiudadOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCiudadOrigen.Name = "btnBuscarCiudadOrigen";
            this.btnBuscarCiudadOrigen.Size = new System.Drawing.Size(23, 18);
            this.btnBuscarCiudadOrigen.TabIndex = 6;
            this.btnBuscarCiudadOrigen.Text = "...";
            this.btnBuscarCiudadOrigen.UseVisualStyleBackColor = true;
            this.btnBuscarCiudadOrigen.Click += new System.EventHandler(this.btnBuscarCiudadOrigen_Click);
            // 
            // tbCiudadDestino
            // 
            this.tbCiudadDestino.Enabled = false;
            this.tbCiudadDestino.Location = new System.Drawing.Point(142, 43);
            this.tbCiudadDestino.Margin = new System.Windows.Forms.Padding(2);
            this.tbCiudadDestino.Name = "tbCiudadDestino";
            this.tbCiudadDestino.Size = new System.Drawing.Size(174, 20);
            this.tbCiudadDestino.TabIndex = 7;
            this.tbCiudadDestino.TextChanged += new System.EventHandler(this.tbCiudadDestino_TextChanged);
            // 
            // btnBuscarCiudadDestino
            // 
            this.btnBuscarCiudadDestino.Location = new System.Drawing.Point(320, 43);
            this.btnBuscarCiudadDestino.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCiudadDestino.Name = "btnBuscarCiudadDestino";
            this.btnBuscarCiudadDestino.Size = new System.Drawing.Size(23, 19);
            this.btnBuscarCiudadDestino.TabIndex = 8;
            this.btnBuscarCiudadDestino.Text = "...";
            this.btnBuscarCiudadDestino.UseVisualStyleBackColor = true;
            this.btnBuscarCiudadDestino.Click += new System.EventHandler(this.btnBuscarCiudadDestino_Click);
            // 
            // dpFechaSalida
            // 
            this.dpFechaSalida.Location = new System.Drawing.Point(142, 23);
            this.dpFechaSalida.Margin = new System.Windows.Forms.Padding(2);
            this.dpFechaSalida.Name = "dpFechaSalida";
            this.dpFechaSalida.Size = new System.Drawing.Size(202, 20);
            this.dpFechaSalida.TabIndex = 9;
            this.dpFechaSalida.ValueChanged += new System.EventHandler(this.dpFechaSalida_ValueChanged);
            // 
            // cbAeronaves
            // 
            this.cbAeronaves.FormattingEnabled = true;
            this.cbAeronaves.Location = new System.Drawing.Point(142, 76);
            this.cbAeronaves.Margin = new System.Windows.Forms.Padding(2);
            this.cbAeronaves.Name = "cbAeronaves";
            this.cbAeronaves.Size = new System.Drawing.Size(202, 21);
            this.cbAeronaves.TabIndex = 11;
            this.cbAeronaves.SelectedIndexChanged += new System.EventHandler(this.cbAeronaves_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(132, 102);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 32);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(176, 94);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 32);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dpFechaLlegadaEstimada
            // 
            this.dpFechaLlegadaEstimada.Enabled = false;
            this.dpFechaLlegadaEstimada.Location = new System.Drawing.Point(142, 50);
            this.dpFechaLlegadaEstimada.Margin = new System.Windows.Forms.Padding(2);
            this.dpFechaLlegadaEstimada.Name = "dpFechaLlegadaEstimada";
            this.dpFechaLlegadaEstimada.Size = new System.Drawing.Size(201, 20);
            this.dpFechaLlegadaEstimada.TabIndex = 10;
            // 
            // lblFechaLlegadaEstimada
            // 
            this.lblFechaLlegadaEstimada.AutoSize = true;
            this.lblFechaLlegadaEstimada.Location = new System.Drawing.Point(4, 56);
            this.lblFechaLlegadaEstimada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaLlegadaEstimada.Name = "lblFechaLlegadaEstimada";
            this.lblFechaLlegadaEstimada.Size = new System.Drawing.Size(134, 13);
            this.lblFechaLlegadaEstimada.TabIndex = 3;
            this.lblFechaLlegadaEstimada.Text = "Fecha de llegada estimada";
            // 
            // gbViajesPasoUno
            // 
            this.gbViajesPasoUno.Controls.Add(this.cbTipoServicio);
            this.gbViajesPasoUno.Controls.Add(this.lblTipoServicio);
            this.gbViajesPasoUno.Controls.Add(this.btnCancelar);
            this.gbViajesPasoUno.Controls.Add(this.btnBuscarRuta);
            this.gbViajesPasoUno.Controls.Add(this.lblCiudadDestino);
            this.gbViajesPasoUno.Controls.Add(this.lblCiudadOrigen);
            this.gbViajesPasoUno.Controls.Add(this.tbCiudadOrigen);
            this.gbViajesPasoUno.Controls.Add(this.btnBuscarCiudadOrigen);
            this.gbViajesPasoUno.Controls.Add(this.tbCiudadDestino);
            this.gbViajesPasoUno.Controls.Add(this.btnBuscarCiudadDestino);
            this.gbViajesPasoUno.Location = new System.Drawing.Point(10, 10);
            this.gbViajesPasoUno.Margin = new System.Windows.Forms.Padding(2);
            this.gbViajesPasoUno.Name = "gbViajesPasoUno";
            this.gbViajesPasoUno.Padding = new System.Windows.Forms.Padding(2);
            this.gbViajesPasoUno.Size = new System.Drawing.Size(349, 136);
            this.gbViajesPasoUno.TabIndex = 14;
            this.gbViajesPasoUno.TabStop = false;
            this.gbViajesPasoUno.Text = "Ruta";
            // 
            // cbTipoServicio
            // 
            this.cbTipoServicio.FormattingEnabled = true;
            this.cbTipoServicio.Location = new System.Drawing.Point(142, 68);
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(201, 21);
            this.cbTipoServicio.TabIndex = 11;
            this.cbTipoServicio.SelectedIndexChanged += new System.EventHandler(this.cbTipoServicio_SelectedIndexChanged);
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.Location = new System.Drawing.Point(34, 72);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(84, 13);
            this.lblTipoServicio.TabIndex = 10;
            this.lblTipoServicio.Text = "Tipo de Servicio";
            // 
            // btnBuscarRuta
            // 
            this.btnBuscarRuta.Location = new System.Drawing.Point(94, 94);
            this.btnBuscarRuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarRuta.Name = "btnBuscarRuta";
            this.btnBuscarRuta.Size = new System.Drawing.Size(75, 32);
            this.btnBuscarRuta.TabIndex = 9;
            this.btnBuscarRuta.Text = "Buscar Ruta";
            this.btnBuscarRuta.UseVisualStyleBackColor = true;
            this.btnBuscarRuta.Click += new System.EventHandler(this.btnBuscarRuta_Click);
            // 
            // gbViajePasoDos
            // 
            this.gbViajePasoDos.Controls.Add(this.lblAeronave);
            this.gbViajePasoDos.Controls.Add(this.cbAeronaves);
            this.gbViajePasoDos.Controls.Add(this.btnGuardar);
            this.gbViajePasoDos.Controls.Add(this.lblFechaLlegadaEstimada);
            this.gbViajePasoDos.Controls.Add(this.dpFechaLlegadaEstimada);
            this.gbViajePasoDos.Controls.Add(this.lblFechaSalida);
            this.gbViajePasoDos.Controls.Add(this.dpFechaSalida);
            this.gbViajePasoDos.Location = new System.Drawing.Point(11, 150);
            this.gbViajePasoDos.Margin = new System.Windows.Forms.Padding(2);
            this.gbViajePasoDos.Name = "gbViajePasoDos";
            this.gbViajePasoDos.Padding = new System.Windows.Forms.Padding(2);
            this.gbViajePasoDos.Size = new System.Drawing.Size(349, 138);
            this.gbViajePasoDos.TabIndex = 15;
            this.gbViajePasoDos.TabStop = false;
            this.gbViajePasoDos.Text = "Aeronaves Disponibles";
            // 
            // GeneradorViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 297);
            this.Controls.Add(this.gbViajePasoDos);
            this.Controls.Add(this.gbViajesPasoUno);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GeneradorViajes";
            this.Text = "Generación de Viajes";
            this.Load += new System.EventHandler(this.GeneradorViajes_Load);
            this.gbViajesPasoUno.ResumeLayout(false);
            this.gbViajesPasoUno.PerformLayout();
            this.gbViajePasoDos.ResumeLayout(false);
            this.gbViajePasoDos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCiudadOrigen;
        private System.Windows.Forms.Label lblCiudadDestino;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.Label lblAeronave;
        private System.Windows.Forms.TextBox tbCiudadOrigen;
        private System.Windows.Forms.Button btnBuscarCiudadOrigen;
        private System.Windows.Forms.TextBox tbCiudadDestino;
        private System.Windows.Forms.Button btnBuscarCiudadDestino;
        private System.Windows.Forms.DateTimePicker dpFechaSalida;
        private System.Windows.Forms.ComboBox cbAeronaves;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dpFechaLlegadaEstimada;
        private System.Windows.Forms.Label lblFechaLlegadaEstimada;
        private System.Windows.Forms.GroupBox gbViajesPasoUno;
        private System.Windows.Forms.Button btnBuscarRuta;
        private System.Windows.Forms.GroupBox gbViajePasoDos;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.ComboBox cbTipoServicio;
    }
}