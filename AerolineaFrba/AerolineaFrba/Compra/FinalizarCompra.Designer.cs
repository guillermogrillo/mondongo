namespace AerolineaFrba.Compra
{
    partial class FinalizarCompra
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTextoUno = new System.Windows.Forms.Label();
            this.lblTextoDos = new System.Windows.Forms.Label();
            this.lblTextoTres = new System.Windows.Forms.Label();
            this.lblTextoCuatro = new System.Windows.Forms.Label();
            this.lblPnr = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(184, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(190, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Compra Finalizada!";
            // 
            // lblTextoUno
            // 
            this.lblTextoUno.AutoSize = true;
            this.lblTextoUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTextoUno.Location = new System.Drawing.Point(85, 54);
            this.lblTextoUno.Name = "lblTextoUno";
            this.lblTextoUno.Size = new System.Drawing.Size(254, 17);
            this.lblTextoUno.TabIndex = 1;
            this.lblTextoUno.Text = "El código único de su compra es: ";
            // 
            // lblTextoDos
            // 
            this.lblTextoDos.AutoSize = true;
            this.lblTextoDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoDos.Location = new System.Drawing.Point(24, 83);
            this.lblTextoDos.Name = "lblTextoDos";
            this.lblTextoDos.Size = new System.Drawing.Size(511, 17);
            this.lblTextoDos.TabIndex = 2;
            this.lblTextoDos.Text = "Con el mismo, usted podrá canjear el día del viaje sus pasajes en el mostrador. ";
            // 
            // lblTextoTres
            // 
            this.lblTextoTres.AutoSize = true;
            this.lblTextoTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoTres.Location = new System.Drawing.Point(9, 107);
            this.lblTextoTres.Name = "lblTextoTres";
            this.lblTextoTres.Size = new System.Drawing.Size(540, 17);
            this.lblTextoTres.TabIndex = 3;
            this.lblTextoTres.Text = "En caso de solicitar el cancelamiento de la compra, se le pedirá el Pnr de la com" +
    "pra.";
            // 
            // lblTextoCuatro
            // 
            this.lblTextoCuatro.AutoSize = true;
            this.lblTextoCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoCuatro.Location = new System.Drawing.Point(178, 134);
            this.lblTextoCuatro.Name = "lblTextoCuatro";
            this.lblTextoCuatro.Size = new System.Drawing.Size(202, 17);
            this.lblTextoCuatro.TabIndex = 4;
            this.lblTextoCuatro.Text = "Muchas gracias por su compra";
            // 
            // lblPnr
            // 
            this.lblPnr.AutoSize = true;
            this.lblPnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblPnr.Location = new System.Drawing.Point(345, 48);
            this.lblPnr.Name = "lblPnr";
            this.lblPnr.Size = new System.Drawing.Size(52, 24);
            this.lblPnr.TabIndex = 5;
            this.lblPnr.Text = "PNR";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(242, 163);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // FinalizarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 198);
            this.ControlBox = false;
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblPnr);
            this.Controls.Add(this.lblTextoCuatro);
            this.Controls.Add(this.lblTextoTres);
            this.Controls.Add(this.lblTextoDos);
            this.Controls.Add(this.lblTextoUno);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FinalizarCompra";
            this.Text = "Compra finalizada con éxito";
            this.Load += new System.EventHandler(this.FinalizarCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTextoUno;
        private System.Windows.Forms.Label lblTextoDos;
        private System.Windows.Forms.Label lblTextoTres;
        private System.Windows.Forms.Label lblTextoCuatro;
        private System.Windows.Forms.Label lblPnr;
        private System.Windows.Forms.Button btnFinalizar;
    }
}