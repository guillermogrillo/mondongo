namespace AerolineaFrba.Canje_Millas
{
    partial class CanjeMillas
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
            this.lblDni = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.lblMillasAcum = new System.Windows.Forms.Label();
            this.tbMillasAcum = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCanjear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.gbProductosDisponibles = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbProductosDisponibles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(96, 13);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "Dni";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(136, 10);
            this.tbDni.MaxLength = 9;
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 20);
            this.tbDni.TabIndex = 1;
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDni_KeyPress);
            // 
            // lblMillasAcum
            // 
            this.lblMillasAcum.AutoSize = true;
            this.lblMillasAcum.Location = new System.Drawing.Point(141, 16);
            this.lblMillasAcum.Name = "lblMillasAcum";
            this.lblMillasAcum.Size = new System.Drawing.Size(94, 13);
            this.lblMillasAcum.TabIndex = 2;
            this.lblMillasAcum.Text = "Millas Acumuladas";
            // 
            // tbMillasAcum
            // 
            this.tbMillasAcum.Enabled = false;
            this.tbMillasAcum.Location = new System.Drawing.Point(238, 13);
            this.tbMillasAcum.Name = "tbMillasAcum";
            this.tbMillasAcum.Size = new System.Drawing.Size(100, 20);
            this.tbMillasAcum.TabIndex = 3;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(6, 39);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(466, 158);
            this.dgvProductos.TabIndex = 4;
            this.dgvProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductos_CellMouseClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(251, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCanjear
            // 
            this.btnCanjear.Location = new System.Drawing.Point(274, 206);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Size = new System.Drawing.Size(100, 23);
            this.btnCanjear.TabIndex = 6;
            this.btnCanjear.Text = "Canjear";
            this.btnCanjear.UseVisualStyleBackColor = true;
            this.btnCanjear.Click += new System.EventHandler(this.btnCanjear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(332, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(104, 211);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(159, 208);
            this.tbCantidad.MaxLength = 2;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbCantidad.TabIndex = 9;
            // 
            // gbProductosDisponibles
            // 
            this.gbProductosDisponibles.Controls.Add(this.lblMillasAcum);
            this.gbProductosDisponibles.Controls.Add(this.tbCantidad);
            this.gbProductosDisponibles.Controls.Add(this.dgvProductos);
            this.gbProductosDisponibles.Controls.Add(this.tbMillasAcum);
            this.gbProductosDisponibles.Controls.Add(this.lblCantidad);
            this.gbProductosDisponibles.Controls.Add(this.btnCanjear);
            this.gbProductosDisponibles.Location = new System.Drawing.Point(12, 37);
            this.gbProductosDisponibles.Name = "gbProductosDisponibles";
            this.gbProductosDisponibles.Size = new System.Drawing.Size(478, 235);
            this.gbProductosDisponibles.TabIndex = 10;
            this.gbProductosDisponibles.TabStop = false;
            this.gbProductosDisponibles.Text = "Productos Disponibles";
            // 
            // CanjeMillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 282);
            this.ControlBox = false;
            this.Controls.Add(this.gbProductosDisponibles);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.btnCancelar);
            this.Name = "CanjeMillas";
            this.Text = "Canje de Millas";
            this.Load += new System.EventHandler(this.CanjeMillas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbProductosDisponibles.ResumeLayout(false);
            this.gbProductosDisponibles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label lblMillasAcum;
        private System.Windows.Forms.TextBox tbMillasAcum;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCanjear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.GroupBox gbProductosDisponibles;
    }
}