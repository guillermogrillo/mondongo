namespace AerolineaFrba.Listado_Estadistico
{
    partial class ListadosEstadisticos
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
            this.rbDestinosMasComprados = new System.Windows.Forms.RadioButton();
            this.rbDestinosAeronavesVacias = new System.Windows.Forms.RadioButton();
            this.rbClientesPuntosAcumulados = new System.Windows.Forms.RadioButton();
            this.rbDestinosPasajesCancelados = new System.Windows.Forms.RadioButton();
            this.rbAeronavesFueraServicio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // rbDestinosMasComprados
            // 
            this.rbDestinosMasComprados.AutoSize = true;
            this.rbDestinosMasComprados.Location = new System.Drawing.Point(49, 10);
            this.rbDestinosMasComprados.Name = "rbDestinosMasComprados";
            this.rbDestinosMasComprados.Size = new System.Drawing.Size(143, 17);
            this.rbDestinosMasComprados.TabIndex = 0;
            this.rbDestinosMasComprados.TabStop = true;
            this.rbDestinosMasComprados.Text = "Destinos mas comprados";
            this.rbDestinosMasComprados.UseVisualStyleBackColor = true;
            // 
            // rbDestinosAeronavesVacias
            // 
            this.rbDestinosAeronavesVacias.AutoSize = true;
            this.rbDestinosAeronavesVacias.Location = new System.Drawing.Point(49, 34);
            this.rbDestinosAeronavesVacias.Name = "rbDestinosAeronavesVacias";
            this.rbDestinosAeronavesVacias.Size = new System.Drawing.Size(198, 17);
            this.rbDestinosAeronavesVacias.TabIndex = 1;
            this.rbDestinosAeronavesVacias.TabStop = true;
            this.rbDestinosAeronavesVacias.Text = "Destinos con mas aeronaves vacías";
            this.rbDestinosAeronavesVacias.UseVisualStyleBackColor = true;
            // 
            // rbClientesPuntosAcumulados
            // 
            this.rbClientesPuntosAcumulados.AutoSize = true;
            this.rbClientesPuntosAcumulados.Location = new System.Drawing.Point(49, 58);
            this.rbClientesPuntosAcumulados.Name = "rbClientesPuntosAcumulados";
            this.rbClientesPuntosAcumulados.Size = new System.Drawing.Size(200, 17);
            this.rbClientesPuntosAcumulados.TabIndex = 2;
            this.rbClientesPuntosAcumulados.TabStop = true;
            this.rbClientesPuntosAcumulados.Text = "Clientes con mas puntos acumulados";
            this.rbClientesPuntosAcumulados.UseVisualStyleBackColor = true;
            // 
            // rbDestinosPasajesCancelados
            // 
            this.rbDestinosPasajesCancelados.AutoSize = true;
            this.rbDestinosPasajesCancelados.Location = new System.Drawing.Point(49, 82);
            this.rbDestinosPasajesCancelados.Name = "rbDestinosPasajesCancelados";
            this.rbDestinosPasajesCancelados.Size = new System.Drawing.Size(206, 17);
            this.rbDestinosPasajesCancelados.TabIndex = 3;
            this.rbDestinosPasajesCancelados.TabStop = true;
            this.rbDestinosPasajesCancelados.Text = "Destinos con mas pasajes cancelados";
            this.rbDestinosPasajesCancelados.UseVisualStyleBackColor = true;
            // 
            // rbAeronavesFueraServicio
            // 
            this.rbAeronavesFueraServicio.AutoSize = true;
            this.rbAeronavesFueraServicio.Location = new System.Drawing.Point(49, 106);
            this.rbAeronavesFueraServicio.Name = "rbAeronavesFueraServicio";
            this.rbAeronavesFueraServicio.Size = new System.Drawing.Size(224, 17);
            this.rbAeronavesFueraServicio.TabIndex = 4;
            this.rbAeronavesFueraServicio.TabStop = true;
            this.rbAeronavesFueraServicio.Text = "Aeronaves con mas días fuera de servicio";
            this.rbAeronavesFueraServicio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Semestre";
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(82, 130);
            this.tbAño.MaxLength = 4;
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(64, 20);
            this.tbAño.TabIndex = 7;
            this.tbAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(70, 154);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(154, 154);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(10, 184);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.Size = new System.Drawing.Size(298, 168);
            this.dgvListado.TabIndex = 11;
            // 
            // cbSemestre
            // 
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Location = new System.Drawing.Point(199, 130);
            this.cbSemestre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(43, 21);
            this.cbSemestre.TabIndex = 12;
            // 
            // ListadosEstadisticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 369);
            this.ControlBox = false;
            this.Controls.Add(this.cbSemestre);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbAño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbAeronavesFueraServicio);
            this.Controls.Add(this.rbDestinosPasajesCancelados);
            this.Controls.Add(this.rbClientesPuntosAcumulados);
            this.Controls.Add(this.rbDestinosAeronavesVacias);
            this.Controls.Add(this.rbDestinosMasComprados);
            this.Name = "ListadosEstadisticos";
            this.Text = "Listados Estadisticos";
            this.Load += new System.EventHandler(this.ListadosEstadisticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDestinosMasComprados;
        private System.Windows.Forms.RadioButton rbDestinosAeronavesVacias;
        private System.Windows.Forms.RadioButton rbClientesPuntosAcumulados;
        private System.Windows.Forms.RadioButton rbDestinosPasajesCancelados;
        private System.Windows.Forms.RadioButton rbAeronavesFueraServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.ComboBox cbSemestre;
    }
}