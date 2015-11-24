namespace AerolineaFrba.Consulta_Millas
{
    partial class ConsultaMillas
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvHistorialMillas = new System.Windows.Forms.DataGridView();
            this.lblCantidadMillas = new System.Windows.Forms.Label();
            this.tbMillasAcumuladas = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialMillas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(210, 16);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 17);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "Dni";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(245, 14);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(150, 22);
            this.tbDni.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(401, 10);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 30);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvHistorialMillas
            // 
            this.dgvHistorialMillas.AllowUserToAddRows = false;
            this.dgvHistorialMillas.AllowUserToDeleteRows = false;
            this.dgvHistorialMillas.AllowUserToResizeColumns = false;
            this.dgvHistorialMillas.AllowUserToResizeRows = false;
            this.dgvHistorialMillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialMillas.Location = new System.Drawing.Point(13, 52);
            this.dgvHistorialMillas.Name = "dgvHistorialMillas";
            this.dgvHistorialMillas.ReadOnly = true;
            this.dgvHistorialMillas.RowTemplate.Height = 24;
            this.dgvHistorialMillas.Size = new System.Drawing.Size(745, 251);
            this.dgvHistorialMillas.TabIndex = 3;
            // 
            // lblCantidadMillas
            // 
            this.lblCantidadMillas.AutoSize = true;
            this.lblCantidadMillas.Location = new System.Drawing.Point(246, 323);
            this.lblCantidadMillas.Name = "lblCantidadMillas";
            this.lblCantidadMillas.Size = new System.Drawing.Size(123, 17);
            this.lblCantidadMillas.TabIndex = 4;
            this.lblCantidadMillas.Text = "Millas acumuladas";
            // 
            // tbMillasAcumuladas
            // 
            this.tbMillasAcumuladas.Enabled = false;
            this.tbMillasAcumuladas.Location = new System.Drawing.Point(375, 320);
            this.tbMillasAcumuladas.Name = "tbMillasAcumuladas";
            this.tbMillasAcumuladas.Size = new System.Drawing.Size(150, 22);
            this.tbMillasAcumuladas.TabIndex = 5;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(485, 9);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 30);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ConsultaMillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 354);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tbMillasAcumuladas);
            this.Controls.Add(this.lblCantidadMillas);
            this.Controls.Add(this.dgvHistorialMillas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lblDni);
            this.Name = "ConsultaMillas";
            this.Text = "Consulta de Millas";
            this.Load += new System.EventHandler(this.ConsultaMillas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialMillas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvHistorialMillas;
        private System.Windows.Forms.Label lblCantidadMillas;
        private System.Windows.Forms.TextBox tbMillasAcumuladas;
        private System.Windows.Forms.Button btnVolver;
    }
}