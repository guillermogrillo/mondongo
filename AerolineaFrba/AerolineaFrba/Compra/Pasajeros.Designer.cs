namespace AerolineaFrba.Compra
{
    partial class Pasajeros
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
            this.gbPasajeros = new System.Windows.Forms.GroupBox();
            this.lblPasajerosACargar = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblPasajerosYaCargados = new System.Windows.Forms.Label();
            this.lblPasajeros = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDetalleButaca = new System.Windows.Forms.Label();
            this.gbPasajeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPasajeros
            // 
            this.gbPasajeros.Controls.Add(this.lblDetalleButaca);
            this.gbPasajeros.Controls.Add(this.lblPasajerosACargar);
            this.gbPasajeros.Controls.Add(this.lblDe);
            this.gbPasajeros.Controls.Add(this.lblPasajerosYaCargados);
            this.gbPasajeros.Controls.Add(this.lblPasajeros);
            this.gbPasajeros.Controls.Add(this.btnEditar);
            this.gbPasajeros.Controls.Add(this.btnQuitar);
            this.gbPasajeros.Controls.Add(this.btnAgregar);
            this.gbPasajeros.Controls.Add(this.dgvClientes);
            this.gbPasajeros.Location = new System.Drawing.Point(13, 13);
            this.gbPasajeros.Name = "gbPasajeros";
            this.gbPasajeros.Size = new System.Drawing.Size(479, 231);
            this.gbPasajeros.TabIndex = 0;
            this.gbPasajeros.TabStop = false;
            this.gbPasajeros.Text = "Pasajeros";
            // 
            // lblPasajerosACargar
            // 
            this.lblPasajerosACargar.AutoSize = true;
            this.lblPasajerosACargar.Location = new System.Drawing.Point(216, 177);
            this.lblPasajerosACargar.Name = "lblPasajerosACargar";
            this.lblPasajerosACargar.Size = new System.Drawing.Size(0, 13);
            this.lblPasajerosACargar.TabIndex = 7;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(191, 177);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(19, 13);
            this.lblDe.TabIndex = 6;
            this.lblDe.Text = "de";
            // 
            // lblPasajerosYaCargados
            // 
            this.lblPasajerosYaCargados.AutoSize = true;
            this.lblPasajerosYaCargados.Location = new System.Drawing.Point(168, 177);
            this.lblPasajerosYaCargados.Name = "lblPasajerosYaCargados";
            this.lblPasajerosYaCargados.Size = new System.Drawing.Size(0, 13);
            this.lblPasajerosYaCargados.TabIndex = 5;
            // 
            // lblPasajeros
            // 
            this.lblPasajeros.AutoSize = true;
            this.lblPasajeros.Location = new System.Drawing.Point(7, 177);
            this.lblPasajeros.Name = "lblPasajeros";
            this.lblPasajeros.Size = new System.Drawing.Size(165, 13);
            this.lblPasajeros.TabIndex = 4;
            this.lblPasajeros.Text = "Cantidad de pasajeros cargados: ";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(330, 71);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(140, 45);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(330, 122);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(140, 45);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(330, 20);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 45);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(7, 20);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(317, 146);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientes_CellMouseClick);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(83, 250);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(140, 45);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(255, 250);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 45);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDetalleButaca
            // 
            this.lblDetalleButaca.AutoSize = true;
            this.lblDetalleButaca.Location = new System.Drawing.Point(10, 194);
            this.lblDetalleButaca.Name = "lblDetalleButaca";
            this.lblDetalleButaca.Size = new System.Drawing.Size(0, 13);
            this.lblDetalleButaca.TabIndex = 8;
            // 
            // Pasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 300);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.gbPasajeros);
            this.Name = "Pasajeros";
            this.Text = "Pasajeros";
            this.Load += new System.EventHandler(this.Pasajeros_Load);
            this.gbPasajeros.ResumeLayout(false);
            this.gbPasajeros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPasajeros;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblPasajeros;
        private System.Windows.Forms.Label lblPasajerosACargar;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblPasajerosYaCargados;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDetalleButaca;
    }
}