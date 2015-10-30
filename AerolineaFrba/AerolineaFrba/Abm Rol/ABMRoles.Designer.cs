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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(285, 35);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(81, 23);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFuncionalidades);
            this.groupBox1.Location = new System.Drawing.Point(16, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 199);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionalidades";
            // 
            // dgvFuncionalidades
            // 
            this.dgvFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidades.Location = new System.Drawing.Point(7, 20);
            this.dgvFuncionalidades.Name = "dgvFuncionalidades";
            this.dgvFuncionalidades.Size = new System.Drawing.Size(343, 173);
            this.dgvFuncionalidades.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(384, 312);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.tbEstadoRol);
            this.Controls.Add(this.lblEstadoRol);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.lblRol);
            this.Name = "ABMRoles";
            this.Text = "ABM Roles";
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
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Mondongo mondongo;
        private System.Windows.Forms.BindingSource funcionalidadesBindingSource;
        private MondongoTableAdapters.funcionalidadesTableAdapter funcionalidadesTableAdapter;
        private System.Windows.Forms.DataGridView dgvFuncionalidades;
    }
}