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
            this.grpAdministrador = new System.Windows.Forms.GroupBox();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.btnGenerarViaje = new System.Windows.Forms.Button();
            this.btnRegistrarLlegada = new System.Windows.Forms.Button();
            this.btnComprarPasajes = new System.Windows.Forms.Button();
            this.btnCancelarPasajes = new System.Windows.Forms.Button();
            this.btnConsultarMillas = new System.Windows.Forms.Button();
            this.btnCanjeMillas = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.grpAdministrador.SuspendLayout();
            this.grpCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnABMRol
            // 
            this.btnABMRol.Location = new System.Drawing.Point(6, 32);
            this.btnABMRol.Name = "btnABMRol";
            this.btnABMRol.Size = new System.Drawing.Size(214, 33);
            this.btnABMRol.TabIndex = 0;
            this.btnABMRol.Text = "ABM Rol";
            this.btnABMRol.UseVisualStyleBackColor = true;
            this.btnABMRol.Click += new System.EventHandler(this.btnABMRol_Click);
            // 
            // btnABMCiudades
            // 
            this.btnABMCiudades.Location = new System.Drawing.Point(6, 71);
            this.btnABMCiudades.Name = "btnABMCiudades";
            this.btnABMCiudades.Size = new System.Drawing.Size(214, 33);
            this.btnABMCiudades.TabIndex = 1;
            this.btnABMCiudades.Text = "ABM Ciudades";
            this.btnABMCiudades.UseVisualStyleBackColor = true;
            // 
            // btnABMRutaAerea
            // 
            this.btnABMRutaAerea.Location = new System.Drawing.Point(6, 110);
            this.btnABMRutaAerea.Name = "btnABMRutaAerea";
            this.btnABMRutaAerea.Size = new System.Drawing.Size(214, 33);
            this.btnABMRutaAerea.TabIndex = 2;
            this.btnABMRutaAerea.Text = "ABM Ruta Aerea";
            this.btnABMRutaAerea.UseVisualStyleBackColor = true;
            // 
            // btnABMAeronaves
            // 
            this.btnABMAeronaves.Location = new System.Drawing.Point(6, 149);
            this.btnABMAeronaves.Name = "btnABMAeronaves";
            this.btnABMAeronaves.Size = new System.Drawing.Size(214, 33);
            this.btnABMAeronaves.TabIndex = 3;
            this.btnABMAeronaves.Text = "ABM Aeronaves";
            this.btnABMAeronaves.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(19, 345);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(213, 33);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // grpAdministrador
            // 
            this.grpAdministrador.Controls.Add(this.btnListado);
            this.grpAdministrador.Controls.Add(this.btnRegistrarLlegada);
            this.grpAdministrador.Controls.Add(this.btnGenerarViaje);
            this.grpAdministrador.Controls.Add(this.btnABMRol);
            this.grpAdministrador.Controls.Add(this.btnABMCiudades);
            this.grpAdministrador.Controls.Add(this.btnABMRutaAerea);
            this.grpAdministrador.Controls.Add(this.btnABMAeronaves);
            this.grpAdministrador.Location = new System.Drawing.Point(247, 12);
            this.grpAdministrador.Name = "grpAdministrador";
            this.grpAdministrador.Size = new System.Drawing.Size(226, 327);
            this.grpAdministrador.TabIndex = 5;
            this.grpAdministrador.TabStop = false;
            this.grpAdministrador.Text = "Administradores";
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.btnCanjeMillas);
            this.grpCliente.Controls.Add(this.btnConsultarMillas);
            this.grpCliente.Controls.Add(this.btnCancelarPasajes);
            this.grpCliente.Controls.Add(this.btnComprarPasajes);
            this.grpCliente.Location = new System.Drawing.Point(12, 12);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(226, 327);
            this.grpCliente.TabIndex = 6;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente";
            // 
            // btnGenerarViaje
            // 
            this.btnGenerarViaje.Location = new System.Drawing.Point(6, 187);
            this.btnGenerarViaje.Name = "btnGenerarViaje";
            this.btnGenerarViaje.Size = new System.Drawing.Size(214, 33);
            this.btnGenerarViaje.TabIndex = 5;
            this.btnGenerarViaje.Text = "Generar Viaje";
            this.btnGenerarViaje.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarLlegada
            // 
            this.btnRegistrarLlegada.Location = new System.Drawing.Point(6, 227);
            this.btnRegistrarLlegada.Name = "btnRegistrarLlegada";
            this.btnRegistrarLlegada.Size = new System.Drawing.Size(214, 33);
            this.btnRegistrarLlegada.TabIndex = 6;
            this.btnRegistrarLlegada.Text = "Registrar Llegada";
            this.btnRegistrarLlegada.UseVisualStyleBackColor = true;
            // 
            // btnComprarPasajes
            // 
            this.btnComprarPasajes.Location = new System.Drawing.Point(7, 32);
            this.btnComprarPasajes.Name = "btnComprarPasajes";
            this.btnComprarPasajes.Size = new System.Drawing.Size(213, 33);
            this.btnComprarPasajes.TabIndex = 0;
            this.btnComprarPasajes.Text = "Compra Pasajes/Encomiendas";
            this.btnComprarPasajes.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPasajes
            // 
            this.btnCancelarPasajes.Location = new System.Drawing.Point(7, 71);
            this.btnCancelarPasajes.Name = "btnCancelarPasajes";
            this.btnCancelarPasajes.Size = new System.Drawing.Size(213, 33);
            this.btnCancelarPasajes.TabIndex = 1;
            this.btnCancelarPasajes.Text = "Cancelar Pasaje/Encomienda";
            this.btnCancelarPasajes.UseVisualStyleBackColor = true;
            // 
            // btnConsultarMillas
            // 
            this.btnConsultarMillas.Location = new System.Drawing.Point(7, 110);
            this.btnConsultarMillas.Name = "btnConsultarMillas";
            this.btnConsultarMillas.Size = new System.Drawing.Size(213, 33);
            this.btnConsultarMillas.TabIndex = 2;
            this.btnConsultarMillas.Text = "Consultar millas";
            this.btnConsultarMillas.UseVisualStyleBackColor = true;
            // 
            // btnCanjeMillas
            // 
            this.btnCanjeMillas.Location = new System.Drawing.Point(7, 149);
            this.btnCanjeMillas.Name = "btnCanjeMillas";
            this.btnCanjeMillas.Size = new System.Drawing.Size(213, 33);
            this.btnCanjeMillas.TabIndex = 3;
            this.btnCanjeMillas.Text = "Canje millas";
            this.btnCanjeMillas.UseVisualStyleBackColor = true;
            // 
            // btnListado
            // 
            this.btnListado.Location = new System.Drawing.Point(6, 266);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(214, 33);
            this.btnListado.TabIndex = 4;
            this.btnListado.Text = "Listados Estadisticos";
            this.btnListado.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.grpAdministrador);
            this.Controls.Add(this.btnRegresar);
            this.Name = "Menu";
            this.Text = "Menu";
            this.grpAdministrador.ResumeLayout(false);
            this.grpCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnABMRol;
        private System.Windows.Forms.Button btnABMCiudades;
        private System.Windows.Forms.Button btnABMRutaAerea;
        private System.Windows.Forms.Button btnABMAeronaves;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox grpAdministrador;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Button btnRegistrarLlegada;
        private System.Windows.Forms.Button btnGenerarViaje;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnCanjeMillas;
        private System.Windows.Forms.Button btnConsultarMillas;
        private System.Windows.Forms.Button btnCancelarPasajes;
        private System.Windows.Forms.Button btnComprarPasajes;
    }
}