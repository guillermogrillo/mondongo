namespace AerolineaFrba.Abm_Ruta
{
    partial class AbmRuta
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
            this.dgRutas = new System.Windows.Forms.DataGridView();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.rutaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoRutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCiudadOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCiudadDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioBasePasajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioBaseKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasVueloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRutas
            // 
            this.dgRutas.AllowUserToAddRows = false;
            this.dgRutas.AllowUserToDeleteRows = false;
            this.dgRutas.AllowUserToResizeColumns = false;
            this.dgRutas.AllowUserToResizeRows = false;
            this.dgRutas.AutoGenerateColumns = false;
            this.dgRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoRutaDataGridViewTextBoxColumn,
            this.nombreCiudadOrigen,
            this.nombreCiudadDestino,
            this.nombreTipoServicio,
            this.precioBasePasajeDataGridViewTextBoxColumn,
            this.precioBaseKgDataGridViewTextBoxColumn,
            this.horasVueloDataGridViewTextBoxColumn});
            this.dgRutas.DataSource = this.rutaModelBindingSource;
            this.dgRutas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgRutas.Location = new System.Drawing.Point(13, 13);
            this.dgRutas.Name = "dgRutas";
            this.dgRutas.ReadOnly = true;
            this.dgRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRutas.Size = new System.Drawing.Size(605, 150);
            this.dgRutas.TabIndex = 0;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(196, 211);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 1;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(278, 210);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(360, 210);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 3;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // rutaModelBindingSource
            // 
            this.rutaModelBindingSource.DataSource = typeof(AerolineaFrba.Model.RutaModel);
            // 
            // codigoRutaDataGridViewTextBoxColumn
            // 
            this.codigoRutaDataGridViewTextBoxColumn.DataPropertyName = "codigoRuta";
            this.codigoRutaDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoRutaDataGridViewTextBoxColumn.Name = "codigoRutaDataGridViewTextBoxColumn";
            this.codigoRutaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCiudadOrigen
            // 
            this.nombreCiudadOrigen.DataPropertyName = "nombreCiudadOrigen";
            this.nombreCiudadOrigen.HeaderText = "Origen";
            this.nombreCiudadOrigen.Name = "nombreCiudadOrigen";
            this.nombreCiudadOrigen.ReadOnly = true;
            // 
            // nombreCiudadDestino
            // 
            this.nombreCiudadDestino.DataPropertyName = "nombreCiudadDestino";
            this.nombreCiudadDestino.HeaderText = "Destino";
            this.nombreCiudadDestino.Name = "nombreCiudadDestino";
            this.nombreCiudadDestino.ReadOnly = true;
            // 
            // nombreTipoServicio
            // 
            this.nombreTipoServicio.DataPropertyName = "nombreTipoServicio";
            this.nombreTipoServicio.HeaderText = "Tipo Servicio";
            this.nombreTipoServicio.Name = "nombreTipoServicio";
            this.nombreTipoServicio.ReadOnly = true;
            // 
            // precioBasePasajeDataGridViewTextBoxColumn
            // 
            this.precioBasePasajeDataGridViewTextBoxColumn.DataPropertyName = "precioBasePasaje";
            this.precioBasePasajeDataGridViewTextBoxColumn.HeaderText = "Precio Base Pasaje";
            this.precioBasePasajeDataGridViewTextBoxColumn.Name = "precioBasePasajeDataGridViewTextBoxColumn";
            this.precioBasePasajeDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioBasePasajeDataGridViewTextBoxColumn.Width = 130;
            // 
            // precioBaseKgDataGridViewTextBoxColumn
            // 
            this.precioBaseKgDataGridViewTextBoxColumn.DataPropertyName = "precioBaseKg";
            this.precioBaseKgDataGridViewTextBoxColumn.HeaderText = "Precio Base Kg";
            this.precioBaseKgDataGridViewTextBoxColumn.Name = "precioBaseKgDataGridViewTextBoxColumn";
            this.precioBaseKgDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioBaseKgDataGridViewTextBoxColumn.Width = 120;
            // 
            // horasVueloDataGridViewTextBoxColumn
            // 
            this.horasVueloDataGridViewTextBoxColumn.DataPropertyName = "horasVuelo";
            this.horasVueloDataGridViewTextBoxColumn.HeaderText = "Horas Vuelo";
            this.horasVueloDataGridViewTextBoxColumn.Name = "horasVueloDataGridViewTextBoxColumn";
            this.horasVueloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AbmRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 261);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.dgRutas);
            this.Name = "AbmRuta";
            this.Text = ",";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onClose);
            this.Load += new System.EventHandler(this.AbmRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRutas;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.BindingSource rutaModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoRutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCiudadOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCiudadDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioBasePasajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioBaseKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasVueloDataGridViewTextBoxColumn;
    }
}