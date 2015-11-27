namespace AerolineaFrba.Abm_Rol
{
    partial class ABMRoles
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
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.rolnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolhabilitadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mondongo = new AerolineaFrba.Mondongo();
            this.rolesTableAdapter = new AerolineaFrba.MondongoTableAdapters.rolesTableAdapter();
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.btnEditarRol = new System.Windows.Forms.Button();
            this.btnFuncionalidades = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mondongo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.AllowUserToResizeColumns = false;
            this.dgvRoles.AllowUserToResizeRows = false;
            this.dgvRoles.AutoGenerateColumns = false;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rolnombreDataGridViewTextBoxColumn,
            this.rolhabilitadoDataGridViewTextBoxColumn});
            this.dgvRoles.DataSource = this.rolesBindingSource;
            this.dgvRoles.Location = new System.Drawing.Point(12, 12);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.Size = new System.Drawing.Size(359, 176);
            this.dgvRoles.TabIndex = 0;
            this.dgvRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellContentClick);
            this.dgvRoles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRoles_CellMouseClick);
            // 
            // rolnombreDataGridViewTextBoxColumn
            // 
            this.rolnombreDataGridViewTextBoxColumn.DataPropertyName = "rol_nombre";
            this.rolnombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.rolnombreDataGridViewTextBoxColumn.Name = "rolnombreDataGridViewTextBoxColumn";
            this.rolnombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolnombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rolnombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rolnombreDataGridViewTextBoxColumn.ToolTipText = "Nombre del Rol";
            this.rolnombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // rolhabilitadoDataGridViewTextBoxColumn
            // 
            this.rolhabilitadoDataGridViewTextBoxColumn.DataPropertyName = "rol_habilitado";
            this.rolhabilitadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.rolhabilitadoDataGridViewTextBoxColumn.Name = "rolhabilitadoDataGridViewTextBoxColumn";
            this.rolhabilitadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolhabilitadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rolhabilitadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rolhabilitadoDataGridViewTextBoxColumn.Width = 115;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.mondongo;
            // 
            // mondongo
            // 
            this.mondongo.DataSetName = "Mondongo";
            this.mondongo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Location = new System.Drawing.Point(388, 12);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(100, 40);
            this.btnAgregarRol.TabIndex = 1;
            this.btnAgregarRol.Text = "Agregar Rol";
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // btnEditarRol
            // 
            this.btnEditarRol.Location = new System.Drawing.Point(388, 58);
            this.btnEditarRol.Name = "btnEditarRol";
            this.btnEditarRol.Size = new System.Drawing.Size(100, 40);
            this.btnEditarRol.TabIndex = 3;
            this.btnEditarRol.Text = "Editar Rol";
            this.btnEditarRol.UseVisualStyleBackColor = true;
            this.btnEditarRol.Click += new System.EventHandler(this.btnEditarRol_Click);
            // 
            // btnFuncionalidades
            // 
            this.btnFuncionalidades.Location = new System.Drawing.Point(388, 103);
            this.btnFuncionalidades.Name = "btnFuncionalidades";
            this.btnFuncionalidades.Size = new System.Drawing.Size(100, 40);
            this.btnFuncionalidades.TabIndex = 4;
            this.btnFuncionalidades.Text = "Administrar Funcionalidades";
            this.btnFuncionalidades.UseVisualStyleBackColor = true;
            this.btnFuncionalidades.Click += new System.EventHandler(this.btnFuncionalidades_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(388, 148);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 40);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ABMRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 193);
            this.ControlBox = false;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnFuncionalidades);
            this.Controls.Add(this.btnEditarRol);
            this.Controls.Add(this.btnAgregarRol);
            this.Controls.Add(this.dgvRoles);
            this.Name = "ABMRoles";
            this.Text = "ABM Roles";
            this.Load += new System.EventHandler(this.ABMRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mondongo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoles;
        private Mondongo mondongo;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private MondongoTableAdapters.rolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.Button btnAgregarRol;
        private System.Windows.Forms.Button btnEditarRol;
        private System.Windows.Forms.Button btnFuncionalidades;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolhabilitadoDataGridViewTextBoxColumn;

    }
}