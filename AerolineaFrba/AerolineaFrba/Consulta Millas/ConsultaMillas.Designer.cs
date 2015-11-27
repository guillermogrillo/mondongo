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
            this.lblDni.Location = new System.Drawing.Point(158, 13);
            this.lblDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "Dni";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(184, 11);
            this.tbDni.Margin = new System.Windows.Forms.Padding(2);
            this.tbDni.MaxLength = 9;
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(114, 20);
            this.tbDni.TabIndex = 1;
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDni_KeyPress);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(301, 8);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(58, 24);
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
            this.dgvHistorialMillas.Location = new System.Drawing.Point(10, 42);
            this.dgvHistorialMillas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHistorialMillas.Name = "dgvHistorialMillas";
            this.dgvHistorialMillas.ReadOnly = true;
            this.dgvHistorialMillas.RowTemplate.Height = 24;
            this.dgvHistorialMillas.Size = new System.Drawing.Size(559, 204);
            this.dgvHistorialMillas.TabIndex = 3;
            // 
            // lblCantidadMillas
            // 
            this.lblCantidadMillas.AutoSize = true;
            this.lblCantidadMillas.Location = new System.Drawing.Point(184, 262);
            this.lblCantidadMillas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadMillas.Name = "lblCantidadMillas";
            this.lblCantidadMillas.Size = new System.Drawing.Size(93, 13);
            this.lblCantidadMillas.TabIndex = 4;
            this.lblCantidadMillas.Text = "Millas acumuladas";
            // 
            // tbMillasAcumuladas
            // 
            this.tbMillasAcumuladas.Enabled = false;
            this.tbMillasAcumuladas.Location = new System.Drawing.Point(281, 260);
            this.tbMillasAcumuladas.Margin = new System.Windows.Forms.Padding(2);
            this.tbMillasAcumuladas.Name = "tbMillasAcumuladas";
            this.tbMillasAcumuladas.Size = new System.Drawing.Size(114, 20);
            this.tbMillasAcumuladas.TabIndex = 5;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(364, 7);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(56, 24);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ConsultaMillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 288);
            this.ControlBox = false;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tbMillasAcumuladas);
            this.Controls.Add(this.lblCantidadMillas);
            this.Controls.Add(this.dgvHistorialMillas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lblDni);
            this.Margin = new System.Windows.Forms.Padding(2);
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