namespace AerolineaFrba.Menu
{
    partial class Menu
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
            this.btnABMRol = new System.Windows.Forms.Button();
            this.btnABMCiudades = new System.Windows.Forms.Button();
            this.btnABMRutaAerea = new System.Windows.Forms.Button();
            this.btnABMAeronaves = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnABMRol
            // 
            this.btnABMRol.Location = new System.Drawing.Point(158, 22);
            this.btnABMRol.Name = "btnABMRol";
            this.btnABMRol.Size = new System.Drawing.Size(149, 33);
            this.btnABMRol.TabIndex = 0;
            this.btnABMRol.Text = "ABM Rol";
            this.btnABMRol.UseVisualStyleBackColor = true;
            // 
            // btnABMCiudades
            // 
            this.btnABMCiudades.Location = new System.Drawing.Point(158, 61);
            this.btnABMCiudades.Name = "btnABMCiudades";
            this.btnABMCiudades.Size = new System.Drawing.Size(149, 33);
            this.btnABMCiudades.TabIndex = 1;
            this.btnABMCiudades.Text = "ABM Ciudades";
            this.btnABMCiudades.UseVisualStyleBackColor = true;
            // 
            // btnABMRutaAerea
            // 
            this.btnABMRutaAerea.Location = new System.Drawing.Point(158, 100);
            this.btnABMRutaAerea.Name = "btnABMRutaAerea";
            this.btnABMRutaAerea.Size = new System.Drawing.Size(149, 33);
            this.btnABMRutaAerea.TabIndex = 2;
            this.btnABMRutaAerea.Text = "ABM Ruta Aerea";
            this.btnABMRutaAerea.UseVisualStyleBackColor = true;
            // 
            // btnABMAeronaves
            // 
            this.btnABMAeronaves.Location = new System.Drawing.Point(158, 139);
            this.btnABMAeronaves.Name = "btnABMAeronaves";
            this.btnABMAeronaves.Size = new System.Drawing.Size(149, 33);
            this.btnABMAeronaves.TabIndex = 3;
            this.btnABMAeronaves.Text = "ABM Aeronaves";
            this.btnABMAeronaves.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(321, 377);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(149, 33);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnABMAeronaves);
            this.Controls.Add(this.btnABMRutaAerea);
            this.Controls.Add(this.btnABMCiudades);
            this.Controls.Add(this.btnABMRol);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnABMRol;
        private System.Windows.Forms.Button btnABMCiudades;
        private System.Windows.Forms.Button btnABMRutaAerea;
        private System.Windows.Forms.Button btnABMAeronaves;
        private System.Windows.Forms.Button btnRegresar;
    }
}