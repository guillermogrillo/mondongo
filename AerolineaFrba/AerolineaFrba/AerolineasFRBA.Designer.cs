﻿namespace AerolineaFrba
{
    partial class AerolineasFRBA
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoginAdministrador = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoginAdministrador
            // 
            this.btnLoginAdministrador.Location = new System.Drawing.Point(112, 35);
            this.btnLoginAdministrador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoginAdministrador.Name = "btnLoginAdministrador";
            this.btnLoginAdministrador.Size = new System.Drawing.Size(140, 28);
            this.btnLoginAdministrador.TabIndex = 1;
            this.btnLoginAdministrador.Text = "Acceso - Administrador";
            this.btnLoginAdministrador.UseVisualStyleBackColor = true;
            this.btnLoginAdministrador.Click += new System.EventHandler(this.btnLoginAdministrador_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(112, 68);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(140, 28);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Acceso - Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // AerolineasFRBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 368);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnLoginAdministrador);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AerolineasFRBA";
            this.Text = "Aerolíneas FRBA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AerolineasFRBA_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginAdministrador;
        private System.Windows.Forms.Button btnCliente;
    }
}

