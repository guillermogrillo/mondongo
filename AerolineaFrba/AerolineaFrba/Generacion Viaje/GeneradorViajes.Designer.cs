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
            this.dtFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.cbAeronaves = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtFechaLlegadaEstimada = new System.Windows.Forms.DateTimePicker();
            this.lblFechaLlegadaEstimada = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarRuta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCiudadOrigen
            // 
            this.lblCiudadOrigen.AutoSize = true;
            this.lblCiudadOrigen.Location = new System.Drawing.Point(53, 24);
            this.lblCiudadOrigen.Name = "lblCiudadOrigen";
            this.lblCiudadOrigen.Size = new System.Drawing.Size(99, 17);
            this.lblCiudadOrigen.TabIndex = 0;
            this.lblCiudadOrigen.Text = "Ciudad Origen";
            // 
            // lblCiudadDestino
            // 
            this.lblCiudadDestino.AutoSize = true;
            this.lblCiudadDestino.Location = new System.Drawing.Point(52, 53);
            this.lblCiudadDestino.Name = "lblCiudadDestino";
            this.lblCiudadDestino.Size = new System.Drawing.Size(104, 17);
            this.lblCiudadDestino.TabIndex = 1;
            this.lblCiudadDestino.Text = "Ciudad Destino";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Location = new System.Drawing.Point(46, 82);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(110, 17);
            this.lblFechaSalida.TabIndex = 2;
            this.lblFechaSalida.Text = "Fecha de Salida";
            // 
            // lblAeronave
            // 
            this.lblAeronave.AutoSize = true;
            this.lblAeronave.Location = new System.Drawing.Point(46, 32);
            this.lblAeronave.Name = "lblAeronave";
            this.lblAeronave.Size = new System.Drawing.Size(69, 17);
            this.lblAeronave.TabIndex = 4;
            this.lblAeronave.Text = "Aeronave";
            // 
            // tbCiudadOrigen
            // 
            this.tbCiudadOrigen.Enabled = false;
            this.tbCiudadOrigen.Location = new System.Drawing.Point(190, 21);
            this.tbCiudadOrigen.Name = "tbCiudadOrigen";
            this.tbCiudadOrigen.Size = new System.Drawing.Size(231, 22);
            this.tbCiudadOrigen.TabIndex = 5;
            // 
            // btnBuscarCiudadOrigen
            // 
            this.btnBuscarCiudadOrigen.Location = new System.Drawing.Point(427, 22);
            this.btnBuscarCiudadOrigen.Name = "btnBuscarCiudadOrigen";
            this.btnBuscarCiudadOrigen.Size = new System.Drawing.Size(31, 22);
            this.btnBuscarCiudadOrigen.TabIndex = 6;
            this.btnBuscarCiudadOrigen.Text = "...";
            this.btnBuscarCiudadOrigen.UseVisualStyleBackColor = true;
            this.btnBuscarCiudadOrigen.Click += new System.EventHandler(this.btnBuscarCiudadOrigen_Click);
            // 
            // tbCiudadDestino
            // 
            this.tbCiudadDestino.Enabled = false;
            this.tbCiudadDestino.Location = new System.Drawing.Point(190, 50);
            this.tbCiudadDestino.Name = "tbCiudadDestino";
            this.tbCiudadDestino.Size = new System.Drawing.Size(231, 22);
            this.tbCiudadDestino.TabIndex = 7;
            // 
            // btnBuscarCiudadDestino
            // 
            this.btnBuscarCiudadDestino.Location = new System.Drawing.Point(427, 50);
            this.btnBuscarCiudadDestino.Name = "btnBuscarCiudadDestino";
            this.btnBuscarCiudadDestino.Size = new System.Drawing.Size(31, 23);
            this.btnBuscarCiudadDestino.TabIndex = 8;
            this.btnBuscarCiudadDestino.Text = "...";
            this.btnBuscarCiudadDestino.UseVisualStyleBackColor = true;
            this.btnBuscarCiudadDestino.Click += new System.EventHandler(this.btnBuscarCiudadDestino_Click);
            // 
            // dtFechaSalida
            // 
            this.dtFechaSalida.Location = new System.Drawing.Point(190, 81);
            this.dtFechaSalida.Name = "dtFechaSalida";
            this.dtFechaSalida.Size = new System.Drawing.Size(268, 22);
            this.dtFechaSalida.TabIndex = 9;
            // 
            // cbAeronaves
            // 
            this.cbAeronaves.FormattingEnabled = true;
            this.cbAeronaves.Location = new System.Drawing.Point(189, 29);
            this.cbAeronaves.Name = "cbAeronaves";
            this.cbAeronaves.Size = new System.Drawing.Size(268, 24);
            this.cbAeronaves.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(151, 283);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 40);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(272, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 40);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtFechaLlegadaEstimada
            // 
            this.dtFechaLlegadaEstimada.Enabled = false;
            this.dtFechaLlegadaEstimada.Location = new System.Drawing.Point(190, 111);
            this.dtFechaLlegadaEstimada.Name = "dtFechaLlegadaEstimada";
            this.dtFechaLlegadaEstimada.Size = new System.Drawing.Size(268, 22);
            this.dtFechaLlegadaEstimada.TabIndex = 10;
            // 
            // lblFechaLlegadaEstimada
            // 
            this.lblFechaLlegadaEstimada.AutoSize = true;
            this.lblFechaLlegadaEstimada.Location = new System.Drawing.Point(10, 111);
            this.lblFechaLlegadaEstimada.Name = "lblFechaLlegadaEstimada";
            this.lblFechaLlegadaEstimada.Size = new System.Drawing.Size(178, 17);
            this.lblFechaLlegadaEstimada.TabIndex = 3;
            this.lblFechaLlegadaEstimada.Text = "Fecha de llegada estimada";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarRuta);
            this.groupBox1.Controls.Add(this.lblCiudadDestino);
            this.groupBox1.Controls.Add(this.lblCiudadOrigen);
            this.groupBox1.Controls.Add(this.tbCiudadOrigen);
            this.groupBox1.Controls.Add(this.dtFechaLlegadaEstimada);
            this.groupBox1.Controls.Add(this.btnBuscarCiudadOrigen);
            this.groupBox1.Controls.Add(this.dtFechaSalida);
            this.groupBox1.Controls.Add(this.tbCiudadDestino);
            this.groupBox1.Controls.Add(this.btnBuscarCiudadDestino);
            this.groupBox1.Controls.Add(this.lblFechaLlegadaEstimada);
            this.groupBox1.Controls.Add(this.lblFechaSalida);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 193);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ruta";
            // 
            // btnBuscarRuta
            // 
            this.btnBuscarRuta.Location = new System.Drawing.Point(190, 139);
            this.btnBuscarRuta.Name = "btnBuscarRuta";
            this.btnBuscarRuta.Size = new System.Drawing.Size(100, 40);
            this.btnBuscarRuta.TabIndex = 9;
            this.btnBuscarRuta.Text = "Buscar Ruta";
            this.btnBuscarRuta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAeronave);
            this.groupBox2.Controls.Add(this.cbAeronaves);
            this.groupBox2.Location = new System.Drawing.Point(14, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 65);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aeronaves Disponibles";
            // 
            // GeneradorViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 345);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "GeneradorViajes";
            this.Text = "Generación de Viajes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dtFechaSalida;
        private System.Windows.Forms.ComboBox cbAeronaves;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtFechaLlegadaEstimada;
        private System.Windows.Forms.Label lblFechaLlegadaEstimada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarRuta;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}