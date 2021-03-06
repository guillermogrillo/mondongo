﻿namespace AerolineaFrba.Abm_Aeronave
{
    partial class AbmAeronaves
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
            this.components = new System.ComponentModel.Container();
            this.DGVAeronave = new System.Windows.Forms.DataGridView();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butacas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeronaveModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeronavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.aeronavesTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.aeronavesTableAdapter();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.fueraServicioBtn = new System.Windows.Forms.Button();
            this.bajaBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAeronave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAeronave
            // 
            this.DGVAeronave.AllowUserToAddRows = false;
            this.DGVAeronave.AllowUserToDeleteRows = false;
            this.DGVAeronave.AllowUserToResizeColumns = false;
            this.DGVAeronave.AllowUserToResizeRows = false;
            this.DGVAeronave.AutoGenerateColumns = false;
            this.DGVAeronave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAeronave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.butacas,
            this.capacidadKg});
            this.DGVAeronave.DataSource = this.aeronaveModelBindingSource;
            this.DGVAeronave.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGVAeronave.Location = new System.Drawing.Point(13, 13);
            this.DGVAeronave.Name = "DGVAeronave";
            this.DGVAeronave.ReadOnly = true;
            this.DGVAeronave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAeronave.Size = new System.Drawing.Size(380, 150);
            this.DGVAeronave.TabIndex = 0;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // butacas
            // 
            this.butacas.DataPropertyName = "cantidadButacas";
            this.butacas.HeaderText = "butacas";
            this.butacas.Name = "butacas";
            this.butacas.ReadOnly = true;
            // 
            // capacidadKg
            // 
            this.capacidadKg.DataPropertyName = "capacidadKg";
            this.capacidadKg.HeaderText = "capacidadKg";
            this.capacidadKg.Name = "capacidadKg";
            this.capacidadKg.ReadOnly = true;
            // 
            // aeronaveModelBindingSource
            // 
            this.aeronaveModelBindingSource.DataSource = typeof(AerolineaFrba.Model.AeronaveModel);
            // 
            // aeronavesBindingSource
            // 
            this.aeronavesBindingSource.DataMember = "aeronaves";
            this.aeronavesBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aeronavesTableAdapter
            // 
            this.aeronavesTableAdapter.ClearBeforeFill = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(102, 197);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(101, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Agregar";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(209, 197);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(98, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Editar";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // fueraServicioBtn
            // 
            this.fueraServicioBtn.Location = new System.Drawing.Point(102, 226);
            this.fueraServicioBtn.Name = "fueraServicioBtn";
            this.fueraServicioBtn.Size = new System.Drawing.Size(101, 23);
            this.fueraServicioBtn.TabIndex = 4;
            this.fueraServicioBtn.Text = "Fuera de servicio";
            this.fueraServicioBtn.UseVisualStyleBackColor = true;
            this.fueraServicioBtn.Click += new System.EventHandler(this.fueraServicioBtn_Click);
            // 
            // bajaBtn
            // 
            this.bajaBtn.Location = new System.Drawing.Point(209, 226);
            this.bajaBtn.Name = "bajaBtn";
            this.bajaBtn.Size = new System.Drawing.Size(98, 23);
            this.bajaBtn.TabIndex = 5;
            this.bajaBtn.Text = "Dar de baja";
            this.bajaBtn.UseVisualStyleBackColor = true;
            this.bajaBtn.Click += new System.EventHandler(this.bajaBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AbmAeronaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 313);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bajaBtn);
            this.Controls.Add(this.fueraServicioBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.DGVAeronave);
            this.Name = "AbmAeronaves";
            this.Text = "Aeronaves";
            this.Load += new System.EventHandler(this.AbmAeronaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAeronave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAeronave;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource aeronavesBindingSource;
        private GD2C2015DataSetTableAdapters.aeronavesTableAdapter aeronavesTableAdapter;
        private System.Windows.Forms.BindingSource aeronaveModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn butacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadKg;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button fueraServicioBtn;
        private System.Windows.Forms.Button bajaBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;

    }
}