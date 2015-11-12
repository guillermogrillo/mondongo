namespace AerolineaFrba.Abm_Ruta
{
    partial class RutaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.cbTipoServicio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodigoRuta = new System.Windows.Forms.TextBox();
            this.tbHorasVuelo = new System.Windows.Forms.TextBox();
            this.tbPasajePrecio = new System.Windows.Forms.TextBox();
            this.tbPrecioKg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destino";
            // 
            // cbOrigen
            // 
            this.cbOrigen.DisplayMember = "nombre";
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(86, 36);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cbOrigen.TabIndex = 2;
            // 
            // cbDestino
            // 
            this.cbDestino.DisplayMember = "nombre";
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(302, 36);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(121, 21);
            this.cbDestino.TabIndex = 3;
            // 
            // cbTipoServicio
            // 
            this.cbTipoServicio.DisplayMember = "tipoServicio";
            this.cbTipoServicio.FormattingEnabled = true;
            this.cbTipoServicio.Location = new System.Drawing.Point(86, 63);
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(121, 21);
            this.cbTipoServicio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo ruta";
            // 
            // tbCodigoRuta
            // 
            this.tbCodigoRuta.Location = new System.Drawing.Point(86, 10);
            this.tbCodigoRuta.Name = "tbCodigoRuta";
            this.tbCodigoRuta.Size = new System.Drawing.Size(121, 20);
            this.tbCodigoRuta.TabIndex = 6;
            // 
            // tbHorasVuelo
            // 
            this.tbHorasVuelo.Location = new System.Drawing.Point(302, 63);
            this.tbHorasVuelo.Name = "tbHorasVuelo";
            this.tbHorasVuelo.Size = new System.Drawing.Size(121, 20);
            this.tbHorasVuelo.TabIndex = 7;
            // 
            // tbPasajePrecio
            // 
            this.tbPasajePrecio.Location = new System.Drawing.Point(86, 91);
            this.tbPasajePrecio.Name = "tbPasajePrecio";
            this.tbPasajePrecio.Size = new System.Drawing.Size(121, 20);
            this.tbPasajePrecio.TabIndex = 8;
            // 
            // tbPrecioKg
            // 
            this.tbPrecioKg.Location = new System.Drawing.Point(302, 91);
            this.tbPrecioKg.Name = "tbPrecioKg";
            this.tbPrecioKg.Size = new System.Drawing.Size(121, 20);
            this.tbPrecioKg.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Horas vuelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio kg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio pasaje";
            // 
            // RutaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 189);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPrecioKg);
            this.Controls.Add(this.tbPasajePrecio);
            this.Controls.Add(this.tbHorasVuelo);
            this.Controls.Add(this.tbCodigoRuta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipoServicio);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.cbOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RutaForm";
            this.Text = "ABM Rutas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.ComboBox cbTipoServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodigoRuta;
        private System.Windows.Forms.TextBox tbHorasVuelo;
        private System.Windows.Forms.TextBox tbPasajePrecio;
        private System.Windows.Forms.TextBox tbPrecioKg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}