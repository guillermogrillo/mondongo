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
            this.codigoRutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadOrigenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioBasePasajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioBaseKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasVueloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.ciudadOrigenDataGridViewTextBoxColumn,
            this.ciudadDestinoDataGridViewTextBoxColumn,
            this.tipoServicioDataGridViewTextBoxColumn,
            this.precioBasePasajeDataGridViewTextBoxColumn,
            this.precioBaseKgDataGridViewTextBoxColumn,
            this.horasVueloDataGridViewTextBoxColumn});
            this.dgRutas.DataSource = this.rutaModelBindingSource;
            this.dgRutas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgRutas.Location = new System.Drawing.Point(13, 13);
            this.dgRutas.Name = "dgRutas";
            this.dgRutas.ReadOnly = true;
            this.dgRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRutas.Size = new System.Drawing.Size(425, 150);
            this.dgRutas.TabIndex = 0;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(106, 211);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 1;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(188, 210);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(270, 210);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 3;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // codigoRutaDataGridViewTextBoxColumn
            // 
            this.codigoRutaDataGridViewTextBoxColumn.DataPropertyName = "codigoRuta";
            this.codigoRutaDataGridViewTextBoxColumn.HeaderText = "codigoRuta";
            this.codigoRutaDataGridViewTextBoxColumn.Name = "codigoRutaDataGridViewTextBoxColumn";
            this.codigoRutaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadOrigenDataGridViewTextBoxColumn
            // 
            this.ciudadOrigenDataGridViewTextBoxColumn.DataPropertyName = "ciudadOrigen";
            this.ciudadOrigenDataGridViewTextBoxColumn.HeaderText = "ciudadOrigen";
            this.ciudadOrigenDataGridViewTextBoxColumn.Name = "ciudadOrigenDataGridViewTextBoxColumn";
            this.ciudadOrigenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadDestinoDataGridViewTextBoxColumn
            // 
            this.ciudadDestinoDataGridViewTextBoxColumn.DataPropertyName = "ciudadDestino";
            this.ciudadDestinoDataGridViewTextBoxColumn.HeaderText = "ciudadDestino";
            this.ciudadDestinoDataGridViewTextBoxColumn.Name = "ciudadDestinoDataGridViewTextBoxColumn";
            this.ciudadDestinoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoServicioDataGridViewTextBoxColumn
            // 
            this.tipoServicioDataGridViewTextBoxColumn.DataPropertyName = "tipoServicio";
            this.tipoServicioDataGridViewTextBoxColumn.HeaderText = "tipoServicio";
            this.tipoServicioDataGridViewTextBoxColumn.Name = "tipoServicioDataGridViewTextBoxColumn";
            this.tipoServicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioBasePasajeDataGridViewTextBoxColumn
            // 
            this.precioBasePasajeDataGridViewTextBoxColumn.DataPropertyName = "precioBasePasaje";
            this.precioBasePasajeDataGridViewTextBoxColumn.HeaderText = "precioBasePasaje";
            this.precioBasePasajeDataGridViewTextBoxColumn.Name = "precioBasePasajeDataGridViewTextBoxColumn";
            this.precioBasePasajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioBaseKgDataGridViewTextBoxColumn
            // 
            this.precioBaseKgDataGridViewTextBoxColumn.DataPropertyName = "precioBaseKg";
            this.precioBaseKgDataGridViewTextBoxColumn.HeaderText = "precioBaseKg";
            this.precioBaseKgDataGridViewTextBoxColumn.Name = "precioBaseKgDataGridViewTextBoxColumn";
            this.precioBaseKgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horasVueloDataGridViewTextBoxColumn
            // 
            this.horasVueloDataGridViewTextBoxColumn.DataPropertyName = "horasVuelo";
            this.horasVueloDataGridViewTextBoxColumn.HeaderText = "horasVuelo";
            this.horasVueloDataGridViewTextBoxColumn.Name = "horasVueloDataGridViewTextBoxColumn";
            this.horasVueloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rutaModelBindingSource
            // 
            this.rutaModelBindingSource.DataSource = typeof(AerolineaFrba.Model.RutaModel);
            // 
            // AbmRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 261);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.dgRutas);
            this.Name = "AbmRuta";
            this.Text = "RutaForm";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoRutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadOrigenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioBasePasajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioBaseKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasVueloDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rutaModelBindingSource;
    }
}