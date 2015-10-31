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
            this.lblRol = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.lblEstadoRol = new System.Windows.Forms.Label();
            this.tbEstadoRol = new System.Windows.Forms.TextBox();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnBorrarRol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrarFuncionalidad = new System.Windows.Forms.Button();
            this.btnAgregarFuncionalidad = new System.Windows.Forms.Button();
            this.dgvFuncionalidades = new System.Windows.Forms.DataGridView();
            this.mondongo = new AerolineaFrba.Mondongo();
            this.funcionalidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionalidadesTableAdapter = new AerolineaFrba.MondongoTableAdapters.funcionalidadesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mondongo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(13, 13);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(88, 13);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Seleccionar Rol: ";
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(107, 10);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(259, 21);
            this.cbRol.TabIndex = 1;
            this.cbRol.SelectedIndexChanged += new System.EventHandler(this.cbRol_SelectedIndexChanged);
            // 
            // lblEstadoRol
            // 
            this.lblEstadoRol.AutoSize = true;
            this.lblEstadoRol.Location = new System.Drawing.Point(13, 40);
            this.lblEstadoRol.Name = "lblEstadoRol";
            this.lblEstadoRol.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoRol.TabIndex = 2;
            this.lblEstadoRol.Text = "Estado";
            // 
            // tbEstadoRol
            // 
            this.tbEstadoRol.Enabled = false;
            this.tbEstadoRol.Location = new System.Drawing.Point(107, 37);
            this.tbEstadoRol.Name = "tbEstadoRol";
            this.tbEstadoRol.Size = new System.Drawing.Size(93, 20);
            this.tbEstadoRol.TabIndex = 3;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(206, 35);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(73, 23);
            this.btnDeshabilitar.TabIndex = 4;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarRol
            // 
            this.btnBorrarRol.Location = new System.Drawing.Point(285, 35);
            this.btnBorrarRol.Name = "btnBorrarRol";
            this.btnBorrarRol.Size = new System.Drawing.Size(81, 23);
            this.btnBorrarRol.TabIndex = 5;
            this.btnBorrarRol.Text = "Borrar";
            this.btnBorrarRol.UseVisualStyleBackColor = true;
            this.btnBorrarRol.Click += new System.EventHandler(this.btnBorrarRol_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrarFuncionalidad);
            this.groupBox1.Controls.Add(this.btnAgregarFuncionalidad);
            this.groupBox1.Controls.Add(this.dgvFuncionalidades);
            this.groupBox1.Location = new System.Drawing.Point(16, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 235);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionalidades";
            // 
            // btnBorrarFuncionalidad
            // 
            this.btnBorrarFuncionalidad.Location = new System.Drawing.Point(190, 199);
            this.btnBorrarFuncionalidad.Name = "btnBorrarFuncionalidad";
            this.btnBorrarFuncionalidad.Size = new System.Drawing.Size(107, 23);
            this.btnBorrarFuncionalidad.TabIndex = 2;
            this.btnBorrarFuncionalidad.Text = "Borrar";
            this.btnBorrarFuncionalidad.UseVisualStyleBackColor = true;
            this.btnBorrarFuncionalidad.Click += new System.EventHandler(this.btnBorrarFuncionalidad_Click);
            // 
            // btnAgregarFuncionalidad
            // 
            this.btnAgregarFuncionalidad.Location = new System.Drawing.Point(54, 199);
            this.btnAgregarFuncionalidad.Name = "btnAgregarFuncionalidad";
            this.btnAgregarFuncionalidad.Size = new System.Drawing.Size(107, 23);
            this.btnAgregarFuncionalidad.TabIndex = 1;
            this.btnAgregarFuncionalidad.Text = "Agregar";
            this.btnAgregarFuncionalidad.UseVisualStyleBackColor = true;
            // 
            // dgvFuncionalidades
            // 
            this.dgvFuncionalidades.AllowUserToAddRows = false;
            this.dgvFuncionalidades.AllowUserToDeleteRows = false;
            this.dgvFuncionalidades.AllowUserToResizeColumns = false;
            this.dgvFuncionalidades.AllowUserToResizeRows = false;
            this.dgvFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidades.Location = new System.Drawing.Point(7, 20);
            this.dgvFuncionalidades.MultiSelect = false;
            this.dgvFuncionalidades.Name = "dgvFuncionalidades";
            this.dgvFuncionalidades.ReadOnly = true;
            this.dgvFuncionalidades.RowHeadersVisible = false;
            this.dgvFuncionalidades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionalidades.ShowCellToolTips = false;
            this.dgvFuncionalidades.ShowEditingIcon = false;
            this.dgvFuncionalidades.Size = new System.Drawing.Size(343, 173);
            this.dgvFuncionalidades.TabIndex = 0;
            this.dgvFuncionalidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionalidades_CellContentClick);
            // 
            // mondongo
            // 
            this.mondongo.DataSetName = "Mondongo";
            this.mondongo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionalidadesBindingSource
            // 
            this.funcionalidadesBindingSource.DataMember = "funcionalidades";
            this.funcionalidadesBindingSource.DataSource = this.mondongo;
            // 
            // funcionalidadesTableAdapter
            // 
            this.funcionalidadesTableAdapter.ClearBeforeFill = true;
            // 
            // ABMRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 308);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBorrarRol);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.tbEstadoRol);
            this.Controls.Add(this.lblEstadoRol);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.lblRol);
            this.Name = "ABMRoles";
            this.Text = "ABM Roles";
            this.Load += new System.EventHandler(this.ABMRoles_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mondongo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label lblEstadoRol;
        private System.Windows.Forms.TextBox tbEstadoRol;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnBorrarRol;
        private System.Windows.Forms.GroupBox groupBox1;
        private Mondongo mondongo;
        private System.Windows.Forms.BindingSource funcionalidadesBindingSource;
        private MondongoTableAdapters.funcionalidadesTableAdapter funcionalidadesTableAdapter;
        private System.Windows.Forms.DataGridView dgvFuncionalidades;
        private System.Windows.Forms.Button btnBorrarFuncionalidad;
        private System.Windows.Forms.Button btnAgregarFuncionalidad;
    }
}