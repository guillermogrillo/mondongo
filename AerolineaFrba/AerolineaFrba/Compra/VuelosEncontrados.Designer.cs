namespace AerolineaFrba.Compra
{
    partial class VuelosEncontrados
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
            this.dgvVuelos = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbVuelos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
            this.gbVuelos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVuelos
            // 
            this.dgvVuelos.AllowUserToAddRows = false;
            this.dgvVuelos.AllowUserToDeleteRows = false;
            this.dgvVuelos.AllowUserToResizeColumns = false;
            this.dgvVuelos.AllowUserToResizeRows = false;
            this.dgvVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVuelos.Location = new System.Drawing.Point(7, 19);
            this.dgvVuelos.Name = "dgvVuelos";
            this.dgvVuelos.ReadOnly = true;
            this.dgvVuelos.Size = new System.Drawing.Size(777, 160);
            this.dgvVuelos.TabIndex = 0;
            this.dgvVuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVuelos_CellContentClick);
            this.dgvVuelos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVuelos_CellMouseClick);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(275, 195);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(100, 40);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(415, 195);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbVuelos
            // 
            this.gbVuelos.Controls.Add(this.dgvVuelos);
            this.gbVuelos.Controls.Add(this.btnCancelar);
            this.gbVuelos.Controls.Add(this.btnSeleccionar);
            this.gbVuelos.Location = new System.Drawing.Point(12, 12);
            this.gbVuelos.Name = "gbVuelos";
            this.gbVuelos.Size = new System.Drawing.Size(790, 248);
            this.gbVuelos.TabIndex = 3;
            this.gbVuelos.TabStop = false;
            this.gbVuelos.Text = "Vuelos Disponibles";
            // 
            // VuelosEncontrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 286);
            this.Controls.Add(this.gbVuelos);
            this.Name = "VuelosEncontrados";
            this.Text = "Vuelos Encontrados";
            this.Load += new System.EventHandler(this.VuelosEncontrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
            this.gbVuelos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVuelos;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbVuelos;
    }
}