namespace AerolineaFrba.Abm_Ciudad
{
    partial class AbmCiudad
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
            this.lblError = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregarCiudad = new System.Windows.Forms.Button();
            this.btnEditarCiudad = new System.Windows.Forms.Button();
            this.btnBorrarCiudad = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgCiudades = new System.Windows.Forms.DataGridView();
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mondongo = new AerolineaFrba.Mondongo();
            this.ciudadesTableAdapter = new AerolineaFrba.MondongoTableAdapters.ciudadesTableAdapter();
            this.consultaCiudadesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCiudades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mondongo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(13, 13);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 0;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(16, 42);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(52, 17);
            this.lblCiudad.TabIndex = 1;
            this.lblCiudad.Text = "Ciudad";
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(74, 39);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(215, 22);
            this.tbCiudad.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(295, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCiudad
            // 
            this.btnAgregarCiudad.Location = new System.Drawing.Point(17, 74);
            this.btnAgregarCiudad.Name = "btnAgregarCiudad";
            this.btnAgregarCiudad.Size = new System.Drawing.Size(115, 36);
            this.btnAgregarCiudad.TabIndex = 5;
            this.btnAgregarCiudad.Text = "Agregar";
            this.btnAgregarCiudad.UseVisualStyleBackColor = true;
            // 
            // btnEditarCiudad
            // 
            this.btnEditarCiudad.Location = new System.Drawing.Point(136, 73);
            this.btnEditarCiudad.Name = "btnEditarCiudad";
            this.btnEditarCiudad.Size = new System.Drawing.Size(115, 37);
            this.btnEditarCiudad.TabIndex = 6;
            this.btnEditarCiudad.Text = "Editar";
            this.btnEditarCiudad.UseVisualStyleBackColor = true;
            // 
            // btnBorrarCiudad
            // 
            this.btnBorrarCiudad.Location = new System.Drawing.Point(255, 73);
            this.btnBorrarCiudad.Name = "btnBorrarCiudad";
            this.btnBorrarCiudad.Size = new System.Drawing.Size(115, 37);
            this.btnBorrarCiudad.TabIndex = 7;
            this.btnBorrarCiudad.Text = "Borrar";
            this.btnBorrarCiudad.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(20, 272);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(175, 36);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(195, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(175, 37);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgCiudades
            // 
            this.dgCiudades.AllowUserToAddRows = false;
            this.dgCiudades.AllowUserToDeleteRows = false;
            this.dgCiudades.AutoGenerateColumns = false;
            this.dgCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCiudades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCiudades.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCiudades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn});
            this.dgCiudades.DataSource = this.ciudadesBindingSource;
            this.dgCiudades.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgCiudades.Location = new System.Drawing.Point(20, 115);
            this.dgCiudades.Name = "dgCiudades";
            this.dgCiudades.ReadOnly = true;
            this.dgCiudades.RowTemplate.Height = 24;
            this.dgCiudades.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCiudades.ShowEditingIcon = false;
            this.dgCiudades.Size = new System.Drawing.Size(350, 151);
            this.dgCiudades.TabIndex = 10;
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "ciudades";
            this.ciudadesBindingSource.DataSource = this.mondongo;
            // 
            // mondongo
            // 
            this.mondongo.DataSetName = "Mondongo";
            this.mondongo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ciudadesTableAdapter
            // 
            this.ciudadesTableAdapter.ClearBeforeFill = true;
            // 
            // consultaCiudadesToolStripButton
            // 
            this.consultaCiudadesToolStripButton.Name = "consultaCiudadesToolStripButton";
            this.consultaCiudadesToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 77;
            // 
            // AbmCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 363);
            this.Controls.Add(this.dgCiudades);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBorrarCiudad);
            this.Controls.Add(this.btnEditarCiudad);
            this.Controls.Add(this.btnAgregarCiudad);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbCiudad);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblError);
            this.Name = "AbmCiudad";
            this.Text = "AbmCiudad";
            this.Load += new System.EventHandler(this.AbmCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCiudades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mondongo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregarCiudad;
        private System.Windows.Forms.Button btnEditarCiudad;
        private System.Windows.Forms.Button btnBorrarCiudad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgCiudades;
        private Mondongo mondongo;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private MondongoTableAdapters.ciudadesTableAdapter ciudadesTableAdapter;
        private System.Windows.Forms.ToolStripButton consultaCiudadesToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}