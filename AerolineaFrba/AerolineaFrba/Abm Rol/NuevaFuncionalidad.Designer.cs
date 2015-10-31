namespace AerolineaFrba.Abm_Rol
{
    partial class NuevaFuncionalidad
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
            this.lblFuncionalidad = new System.Windows.Forms.Label();
            this.cbFuncionalidades = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mondongo = new AerolineaFrba.Mondongo();
            this.funcionalidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionalidadesTableAdapter = new AerolineaFrba.MondongoTableAdapters.funcionalidadesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mondongo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFuncionalidad
            // 
            this.lblFuncionalidad.AutoSize = true;
            this.lblFuncionalidad.Location = new System.Drawing.Point(13, 13);
            this.lblFuncionalidad.Name = "lblFuncionalidad";
            this.lblFuncionalidad.Size = new System.Drawing.Size(73, 13);
            this.lblFuncionalidad.TabIndex = 0;
            this.lblFuncionalidad.Text = "Funcionalidad";
            // 
            // cbFuncionalidades
            // 
            this.cbFuncionalidades.FormattingEnabled = true;
            this.cbFuncionalidades.Location = new System.Drawing.Point(92, 10);
            this.cbFuncionalidades.Name = "cbFuncionalidades";
            this.cbFuncionalidades.Size = new System.Drawing.Size(370, 21);
            this.cbFuncionalidades.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(71, 51);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(259, 51);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 40);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // NuevaFuncionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 126);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbFuncionalidades);
            this.Controls.Add(this.lblFuncionalidad);
            this.Name = "NuevaFuncionalidad";
            this.Text = "NuevaFuncionalidad";
            this.Load += new System.EventHandler(this.NuevaFuncionalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mondongo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuncionalidad;
        private System.Windows.Forms.ComboBox cbFuncionalidades;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private Mondongo mondongo;
        private System.Windows.Forms.BindingSource funcionalidadesBindingSource;
        private MondongoTableAdapters.funcionalidadesTableAdapter funcionalidadesTableAdapter;
    }
}