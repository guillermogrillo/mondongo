namespace AerolineaFrba.Registro_Llegada_Destino
{
    partial class RegistroLlegadaDestino
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.lblCiudadOrigen = new System.Windows.Forms.Label();
            this.lblCiudadDestino = new System.Windows.Forms.Label();
            this.tbCiudadOrigen = new System.Windows.Forms.TextBox();
            this.tbCiudadDestino = new System.Windows.Forms.TextBox();
            this.btnBuscarCiudadDesde = new System.Windows.Forms.Button();
            this.btnBuscarCiudadHasta = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbViajes = new System.Windows.Forms.GroupBox();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.lblFechaLlegada = new System.Windows.Forms.Label();
            this.dpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.dpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lblTipoServicio = new System.Windows.Forms.Label();
            this.cbTipoServicio = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbViajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(92, 84);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(52, 13);
            this.lblMatricula.TabIndex = 7;
            this.lblMatricula.Text = "Matrícula";
            // 
            // tbMatricula
            // 
            this.tbMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMatricula.Location = new System.Drawing.Point(159, 81);
            this.tbMatricula.MaxLength = 7;
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(194, 20);
            this.tbMatricula.TabIndex = 7;
            // 
            // lblCiudadOrigen
            // 
            this.lblCiudadOrigen.AutoSize = true;
            this.lblCiudadOrigen.Location = new System.Drawing.Point(83, 8);
            this.lblCiudadOrigen.Name = "lblCiudadOrigen";
            this.lblCiudadOrigen.Size = new System.Drawing.Size(74, 13);
            this.lblCiudadOrigen.TabIndex = 0;
            this.lblCiudadOrigen.Text = "Ciudad Origen";
            // 
            // lblCiudadDestino
            // 
            this.lblCiudadDestino.AutoSize = true;
            this.lblCiudadDestino.Location = new System.Drawing.Point(79, 34);
            this.lblCiudadDestino.Name = "lblCiudadDestino";
            this.lblCiudadDestino.Size = new System.Drawing.Size(79, 13);
            this.lblCiudadDestino.TabIndex = 4;
            this.lblCiudadDestino.Text = "Ciudad Destino";
            // 
            // tbCiudadOrigen
            // 
            this.tbCiudadOrigen.Enabled = false;
            this.tbCiudadOrigen.Location = new System.Drawing.Point(159, 5);
            this.tbCiudadOrigen.Name = "tbCiudadOrigen";
            this.tbCiudadOrigen.Size = new System.Drawing.Size(168, 20);
            this.tbCiudadOrigen.TabIndex = 1;
            // 
            // tbCiudadDestino
            // 
            this.tbCiudadDestino.Enabled = false;
            this.tbCiudadDestino.Location = new System.Drawing.Point(159, 31);
            this.tbCiudadDestino.Name = "tbCiudadDestino";
            this.tbCiudadDestino.Size = new System.Drawing.Size(168, 20);
            this.tbCiudadDestino.TabIndex = 5;
            // 
            // btnBuscarCiudadDesde
            // 
            this.btnBuscarCiudadDesde.Location = new System.Drawing.Point(332, 5);
            this.btnBuscarCiudadDesde.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCiudadDesde.Name = "btnBuscarCiudadDesde";
            this.btnBuscarCiudadDesde.Size = new System.Drawing.Size(21, 20);
            this.btnBuscarCiudadDesde.TabIndex = 2;
            this.btnBuscarCiudadDesde.Text = "...";
            this.btnBuscarCiudadDesde.UseVisualStyleBackColor = true;
            this.btnBuscarCiudadDesde.Click += new System.EventHandler(this.btnBuscarCiudadDesde_Click);
            // 
            // btnBuscarCiudadHasta
            // 
            this.btnBuscarCiudadHasta.Location = new System.Drawing.Point(332, 31);
            this.btnBuscarCiudadHasta.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCiudadHasta.Name = "btnBuscarCiudadHasta";
            this.btnBuscarCiudadHasta.Size = new System.Drawing.Size(21, 20);
            this.btnBuscarCiudadHasta.TabIndex = 6;
            this.btnBuscarCiudadHasta.Text = "...";
            this.btnBuscarCiudadHasta.UseVisualStyleBackColor = true;
            this.btnBuscarCiudadHasta.Click += new System.EventHandler(this.btnBuscarCiudadHasta_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(105, 134);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbViajes
            // 
            this.gbViajes.Controls.Add(this.dgvViajes);
            this.gbViajes.Location = new System.Drawing.Point(12, 163);
            this.gbViajes.Name = "gbViajes";
            this.gbViajes.Size = new System.Drawing.Size(410, 136);
            this.gbViajes.TabIndex = 15;
            this.gbViajes.TabStop = false;
            this.gbViajes.Text = "Viajes";
            // 
            // dgvViajes
            // 
            this.dgvViajes.AllowUserToAddRows = false;
            this.dgvViajes.AllowUserToDeleteRows = false;
            this.dgvViajes.AllowUserToResizeColumns = false;
            this.dgvViajes.AllowUserToResizeRows = false;
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Location = new System.Drawing.Point(6, 12);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.ReadOnly = true;
            this.dgvViajes.Size = new System.Drawing.Size(397, 118);
            this.dgvViajes.TabIndex = 0;
            this.dgvViajes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvViajes_CellMouseClick);
            // 
            // lblFechaLlegada
            // 
            this.lblFechaLlegada.AutoSize = true;
            this.lblFechaLlegada.Location = new System.Drawing.Point(71, 315);
            this.lblFechaLlegada.Name = "lblFechaLlegada";
            this.lblFechaLlegada.Size = new System.Drawing.Size(89, 13);
            this.lblFechaLlegada.TabIndex = 9;
            this.lblFechaLlegada.Text = "Fecha de llegada";
            // 
            // dpFechaLlegada
            // 
            this.dpFechaLlegada.Location = new System.Drawing.Point(162, 311);
            this.dpFechaLlegada.Name = "dpFechaLlegada";
            this.dpFechaLlegada.Size = new System.Drawing.Size(194, 20);
            this.dpFechaLlegada.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(156, 348);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 23);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Location = new System.Drawing.Point(73, 110);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(84, 13);
            this.lblFechaSalida.TabIndex = 17;
            this.lblFechaSalida.Text = "Fecha de Salida";
            // 
            // dpFechaSalida
            // 
            this.dpFechaSalida.Location = new System.Drawing.Point(159, 107);
            this.dpFechaSalida.Name = "dpFechaSalida";
            this.dpFechaSalida.Size = new System.Drawing.Size(194, 20);
            this.dpFechaSalida.TabIndex = 18;
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.Location = new System.Drawing.Point(74, 58);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(84, 13);
            this.lblTipoServicio.TabIndex = 19;
            this.lblTipoServicio.Text = "Tipo de Servicio";
            // 
            // cbTipoServicio
            // 
            this.cbTipoServicio.FormattingEnabled = true;
            this.cbTipoServicio.Location = new System.Drawing.Point(159, 55);
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(194, 21);
            this.cbTipoServicio.TabIndex = 20;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(216, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // RegistroLlegadaDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 377);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbTipoServicio);
            this.Controls.Add(this.lblTipoServicio);
            this.Controls.Add(this.dpFechaSalida);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dpFechaLlegada);
            this.Controls.Add(this.lblFechaLlegada);
            this.Controls.Add(this.gbViajes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBuscarCiudadHasta);
            this.Controls.Add(this.btnBuscarCiudadDesde);
            this.Controls.Add(this.tbCiudadDestino);
            this.Controls.Add(this.tbCiudadOrigen);
            this.Controls.Add(this.lblCiudadDestino);
            this.Controls.Add(this.lblCiudadOrigen);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Name = "RegistroLlegadaDestino";
            this.Text = "Registro de Llegada a Destino";
            this.Load += new System.EventHandler(this.RegistroLlegadaDestino_Load);
            this.gbViajes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.Label lblCiudadOrigen;
        private System.Windows.Forms.Label lblCiudadDestino;
        private System.Windows.Forms.TextBox tbCiudadOrigen;
        private System.Windows.Forms.TextBox tbCiudadDestino;
        private System.Windows.Forms.Button btnBuscarCiudadDesde;
        private System.Windows.Forms.Button btnBuscarCiudadHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbViajes;
        private System.Windows.Forms.Label lblFechaLlegada;
        private System.Windows.Forms.DateTimePicker dpFechaLlegada;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.DateTimePicker dpFechaSalida;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.ComboBox cbTipoServicio;
        private System.Windows.Forms.Button btnCancelar;
    }
}