namespace AerolineaFrba.Abm_Rol
{
    partial class ABMFuncionalidades
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
            this.dgvFuncionalidades = new System.Windows.Forms.DataGridView();
            this.funcionalidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mondongo = new AerolineaFrba.Mondongo();
            this.funcionalidadesTableAdapter = new AerolineaFrba.MondongoTableAdapters.funcionalidadesTableAdapter();
            this.btnAgregarFuncionalidad = new System.Windows.Forms.Button();
            this.btnBorrarFuncionalidad = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.funcionalidaddescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mondongo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionalidades
            // 
            this.dgvFuncionalidades.AllowUserToAddRows = false;
            this.dgvFuncionalidades.AllowUserToDeleteRows = false;
            this.dgvFuncionalidades.AllowUserToResizeColumns = false;
            this.dgvFuncionalidades.AllowUserToResizeRows = false;
            this.dgvFuncionalidades.AutoGenerateColumns = false;
            this.dgvFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.funcionalidaddescripcionDataGridViewTextBoxColumn});
            this.dgvFuncionalidades.DataSource = this.funcionalidadesBindingSource;
            this.dgvFuncionalidades.Location = new System.Drawing.Point(17, 16);
            this.dgvFuncionalidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFuncionalidades.Name = "dgvFuncionalidades";
            this.dgvFuncionalidades.Size = new System.Drawing.Size(592, 162);
            this.dgvFuncionalidades.TabIndex = 0;
            this.dgvFuncionalidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionalidades_CellContentClick);
            this.dgvFuncionalidades.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFuncionalidades_CellMouseClick);
            // 
            // funcionalidadesBindingSource
            // 
            this.funcionalidadesBindingSource.DataMember = "funcionalidades";
            this.funcionalidadesBindingSource.DataSource = this.mondongo;
            // 
            // mondongo
            // 
            this.mondongo.DataSetName = "Mondongo";
            this.mondongo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionalidadesTableAdapter
            // 
            this.funcionalidadesTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregarFuncionalidad
            // 
            this.btnAgregarFuncionalidad.Location = new System.Drawing.Point(617, 16);
            this.btnAgregarFuncionalidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarFuncionalidad.Name = "btnAgregarFuncionalidad";
            this.btnAgregarFuncionalidad.Size = new System.Drawing.Size(173, 49);
            this.btnAgregarFuncionalidad.TabIndex = 1;
            this.btnAgregarFuncionalidad.Text = "Agregar Funcionalidad";
            this.btnAgregarFuncionalidad.UseVisualStyleBackColor = true;
            this.btnAgregarFuncionalidad.Click += new System.EventHandler(this.btnAgregarFuncionalidad_Click);
            // 
            // btnBorrarFuncionalidad
            // 
            this.btnBorrarFuncionalidad.Location = new System.Drawing.Point(616, 73);
            this.btnBorrarFuncionalidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrarFuncionalidad.Name = "btnBorrarFuncionalidad";
            this.btnBorrarFuncionalidad.Size = new System.Drawing.Size(173, 49);
            this.btnBorrarFuncionalidad.TabIndex = 2;
            this.btnBorrarFuncionalidad.Text = "Borrar Funcionalidad";
            this.btnBorrarFuncionalidad.UseVisualStyleBackColor = true;
            this.btnBorrarFuncionalidad.Click += new System.EventHandler(this.btnBorrarFuncionalidad_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(616, 129);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(173, 49);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver al Menu";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // funcionalidaddescripcionDataGridViewTextBoxColumn
            // 
            this.funcionalidaddescripcionDataGridViewTextBoxColumn.DataPropertyName = "funcionalidad_descripcion";
            this.funcionalidaddescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.funcionalidaddescripcionDataGridViewTextBoxColumn.Name = "funcionalidaddescripcionDataGridViewTextBoxColumn";
            this.funcionalidaddescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.funcionalidaddescripcionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.funcionalidaddescripcionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.funcionalidaddescripcionDataGridViewTextBoxColumn.Width = 300;
            // 
            // ABMFuncionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 197);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBorrarFuncionalidad);
            this.Controls.Add(this.btnAgregarFuncionalidad);
            this.Controls.Add(this.dgvFuncionalidades);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ABMFuncionalidades";
            this.Text = "Funcionalidades";
            this.Load += new System.EventHandler(this.ABMFuncionalidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mondongo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionalidades;
        private Mondongo mondongo;
        private System.Windows.Forms.BindingSource funcionalidadesBindingSource;
        private MondongoTableAdapters.funcionalidadesTableAdapter funcionalidadesTableAdapter;
        private System.Windows.Forms.Button btnAgregarFuncionalidad;
        private System.Windows.Forms.Button btnBorrarFuncionalidad;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionalidaddescripcionDataGridViewTextBoxColumn;
    }
}