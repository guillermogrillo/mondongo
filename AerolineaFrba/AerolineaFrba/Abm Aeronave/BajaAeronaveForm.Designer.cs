namespace AerolineaFrba.Abm_Aeronave
{
    partial class BajaAeronaveForm
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
            this.dpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btFueraServicio = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSuplantarAeronave = new System.Windows.Forms.Button();
            this.btCanelarViajen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpFechaDesde
            // 
            this.dpFechaDesde.Location = new System.Drawing.Point(98, 13);
            this.dpFechaDesde.Name = "dpFechaDesde";
            this.dpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dpFechaDesde.TabIndex = 0;
            // 
            // dpFechaHasta
            // 
            this.dpFechaHasta.Location = new System.Drawing.Point(98, 39);
            this.dpFechaHasta.Name = "dpFechaHasta";
            this.dpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dpFechaHasta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha hasta";
            // 
            // btFueraServicio
            // 
            this.btFueraServicio.Location = new System.Drawing.Point(73, 78);
            this.btFueraServicio.Name = "btFueraServicio";
            this.btFueraServicio.Size = new System.Drawing.Size(75, 23);
            this.btFueraServicio.TabIndex = 4;
            this.btFueraServicio.Text = "Aceptar";
            this.btFueraServicio.UseVisualStyleBackColor = true;
            this.btFueraServicio.Click += new System.EventHandler(this.fueraServicio_click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(173, 78);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.cancelar_click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSuplantarAeronave);
            this.groupBox1.Controls.Add(this.btCanelarViajen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btSuplantarAeronave
            // 
            this.btSuplantarAeronave.Location = new System.Drawing.Point(151, 43);
            this.btSuplantarAeronave.Name = "btSuplantarAeronave";
            this.btSuplantarAeronave.Size = new System.Drawing.Size(110, 23);
            this.btSuplantarAeronave.TabIndex = 5;
            this.btSuplantarAeronave.Text = "Suplantar aeronave";
            this.btSuplantarAeronave.UseVisualStyleBackColor = true;
            this.btSuplantarAeronave.Click += new System.EventHandler(this.btSuplantarAeronave_Click);
            // 
            // btCanelarViajen
            // 
            this.btCanelarViajen.Location = new System.Drawing.Point(35, 43);
            this.btCanelarViajen.Name = "btCanelarViajen";
            this.btCanelarViajen.Size = new System.Drawing.Size(110, 23);
            this.btCanelarViajen.TabIndex = 4;
            this.btCanelarViajen.Text = "Cancelar viajes";
            this.btCanelarViajen.UseVisualStyleBackColor = true;
            this.btCanelarViajen.Click += new System.EventHandler(this.btCanelarViajes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "La aeronave tiene viajes asignados";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BajaAeronaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 210);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btFueraServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpFechaHasta);
            this.Controls.Add(this.dpFechaDesde);
            this.Name = "BajaAeronaveForm";
            this.Text = "Baja Aeronave";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dpFechaDesde;
        private System.Windows.Forms.DateTimePicker dpFechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFueraServicio;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSuplantarAeronave;
        private System.Windows.Forms.Button btCanelarViajen;
        private System.Windows.Forms.Label label4;
    }
}