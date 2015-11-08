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
            this.btnABMRutaAerea = new System.Windows.Forms.Button();
            this.btnABMAeronaves = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.grpAdministrador = new System.Windows.Forms.GroupBox();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnRegistrarLlegada = new System.Windows.Forms.Button();
            this.btnGenerarViaje = new System.Windows.Forms.Button();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.btnCanjeMillas = new System.Windows.Forms.Button();
            this.btnConsultarMillas = new System.Windows.Forms.Button();
            this.btnCancelarPasajes = new System.Windows.Forms.Button();
            this.btnComprarPasajes = new System.Windows.Forms.Button();
            this.grpAdministrador.SuspendLayout();
            this.grpCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnABMRol
            // 
            this.btnABMRol.Location = new System.Drawing.Point(4, 26);
            this.btnABMRol.Margin = new System.Windows.Forms.Padding(2);
            this.btnABMRol.Name = "btnABMRol";
            this.btnABMRol.Size = new System.Drawing.Size(160, 27);
            this.btnABMRol.TabIndex = 0;
            this.btnABMRol.Text = "ABM Rol";
            this.btnABMRol.UseVisualStyleBackColor = true;
            this.btnABMRol.Click += new System.EventHandler(this.btnABMRol_Click);
            // 
            // btnABMRutaAerea
            // 
            this.btnABMRutaAerea.Location = new System.Drawing.Point(4, 58);
            this.btnABMRutaAerea.Margin = new System.Windows.Forms.Padding(2);
            this.btnABMRutaAerea.Name = "btnABMRutaAerea";
            this.btnABMRutaAerea.Size = new System.Drawing.Size(160, 27);
            this.btnABMRutaAerea.TabIndex = 2;
            this.btnABMRutaAerea.Text = "ABM Ruta Aerea";
            this.btnABMRutaAerea.UseVisualStyleBackColor = true;
            // 
            // btnABMAeronaves
            // 
            this.btnABMAeronaves.Location = new System.Drawing.Point(4, 90);
            this.btnABMAeronaves.Margin = new System.Windows.Forms.Padding(2);
            this.btnABMAeronaves.Name = "btnABMAeronaves";
            this.btnABMAeronaves.Size = new System.Drawing.Size(160, 27);
            this.btnABMAeronaves.TabIndex = 3;
            this.btnABMAeronaves.Text = "ABM Aeronaves";
            this.btnABMAeronaves.UseVisualStyleBackColor = true;
            this.btnABMAeronaves.Click += new System.EventHandler(this.btnABMAeronaves_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(14, 233);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(160, 27);
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
            this.grpAdministrador.Controls.Add(this.btnABMRutaAerea);
            this.grpAdministrador.Controls.Add(this.btnABMAeronaves);
            this.grpAdministrador.Location = new System.Drawing.Point(185, 10);
            this.grpAdministrador.Margin = new System.Windows.Forms.Padding(2);
            this.grpAdministrador.Name = "grpAdministrador";
            this.grpAdministrador.Padding = new System.Windows.Forms.Padding(2);
            this.grpAdministrador.Size = new System.Drawing.Size(170, 219);
            this.grpAdministrador.TabIndex = 5;
            this.grpAdministrador.TabStop = false;
            this.grpAdministrador.Text = "Administradores";
            // 
            // btnListado
            // 
            this.btnListado.Location = new System.Drawing.Point(4, 185);
            this.btnListado.Margin = new System.Windows.Forms.Padding(2);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(160, 27);
            this.btnListado.TabIndex = 4;
            this.btnListado.Text = "Listados Estadisticos";
            this.btnListado.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarLlegada
            // 
            this.btnRegistrarLlegada.Location = new System.Drawing.Point(4, 153);
            this.btnRegistrarLlegada.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarLlegada.Name = "btnRegistrarLlegada";
            this.btnRegistrarLlegada.Size = new System.Drawing.Size(160, 27);
            this.btnRegistrarLlegada.TabIndex = 6;
            this.btnRegistrarLlegada.Text = "Registrar Llegada";
            this.btnRegistrarLlegada.UseVisualStyleBackColor = true;
            this.btnRegistrarLlegada.Click += new System.EventHandler(this.btnRegistrarLlegada_Click);
            // 
            // btnGenerarViaje
            // 
            this.btnGenerarViaje.Location = new System.Drawing.Point(4, 121);
            this.btnGenerarViaje.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarViaje.Name = "btnGenerarViaje";
            this.btnGenerarViaje.Size = new System.Drawing.Size(160, 27);
            this.btnGenerarViaje.TabIndex = 5;
            this.btnGenerarViaje.Text = "Generar Viaje";
            this.btnGenerarViaje.UseVisualStyleBackColor = true;
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.btnCanjeMillas);
            this.grpCliente.Controls.Add(this.btnConsultarMillas);
            this.grpCliente.Controls.Add(this.btnCancelarPasajes);
            this.grpCliente.Controls.Add(this.btnComprarPasajes);
            this.grpCliente.Location = new System.Drawing.Point(9, 10);
            this.grpCliente.Margin = new System.Windows.Forms.Padding(2);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Padding = new System.Windows.Forms.Padding(2);
            this.grpCliente.Size = new System.Drawing.Size(170, 219);
            this.grpCliente.TabIndex = 6;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente";
            // 
            // btnCanjeMillas
            // 
            this.btnCanjeMillas.Location = new System.Drawing.Point(5, 121);
            this.btnCanjeMillas.Margin = new System.Windows.Forms.Padding(2);
            this.btnCanjeMillas.Name = "btnCanjeMillas";
            this.btnCanjeMillas.Size = new System.Drawing.Size(160, 27);
            this.btnCanjeMillas.TabIndex = 3;
            this.btnCanjeMillas.Text = "Canje millas";
            this.btnCanjeMillas.UseVisualStyleBackColor = true;
            // 
            // btnConsultarMillas
            // 
            this.btnConsultarMillas.Location = new System.Drawing.Point(5, 89);
            this.btnConsultarMillas.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarMillas.Name = "btnConsultarMillas";
            this.btnConsultarMillas.Size = new System.Drawing.Size(160, 27);
            this.btnConsultarMillas.TabIndex = 2;
            this.btnConsultarMillas.Text = "Consultar millas";
            this.btnConsultarMillas.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPasajes
            // 
            this.btnCancelarPasajes.Location = new System.Drawing.Point(5, 58);
            this.btnCancelarPasajes.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarPasajes.Name = "btnCancelarPasajes";
            this.btnCancelarPasajes.Size = new System.Drawing.Size(160, 27);
            this.btnCancelarPasajes.TabIndex = 1;
            this.btnCancelarPasajes.Text = "Cancelar Pasaje/Encomienda";
            this.btnCancelarPasajes.UseVisualStyleBackColor = true;
            // 
            // btnComprarPasajes
            // 
            this.btnComprarPasajes.Location = new System.Drawing.Point(5, 26);
            this.btnComprarPasajes.Margin = new System.Windows.Forms.Padding(2);
            this.btnComprarPasajes.Name = "btnComprarPasajes";
            this.btnComprarPasajes.Size = new System.Drawing.Size(160, 27);
            this.btnComprarPasajes.TabIndex = 0;
            this.btnComprarPasajes.Text = "Compra Pasajes/Encomiendas";
            this.btnComprarPasajes.UseVisualStyleBackColor = true;
            this.btnComprarPasajes.Click += new System.EventHandler(this.btnComprarPasajes_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 368);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.grpAdministrador);
            this.Controls.Add(this.btnRegresar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.grpAdministrador.ResumeLayout(false);
            this.grpCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnABMRol;
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