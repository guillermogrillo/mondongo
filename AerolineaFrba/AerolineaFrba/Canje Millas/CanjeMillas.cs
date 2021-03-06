﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Canje_Millas
{
    public partial class CanjeMillas : Form
    {


        private Controller.ClienteController clienteController = null;
        private Controller.MillasController millasController = null;
        private Controller.ProductosController productosController = null;

        private Model.ClienteModel clienteEncontrado = null;
        private Model.ProductoModel productoSeleccionado = null;
        DateTime fechaSistema = Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings.Get("fechaSistema"));

        public CanjeMillas()
        {
            InitializeComponent();
            clienteController = new Controller.ClienteController();
            millasController = new Controller.MillasController();
            productosController = new Controller.ProductosController();
        }

        public void setClientePantalla(Model.ClienteModel cliente)
        {
            this.clienteEncontrado = cliente;
            gbProductosDisponibles.Visible = true;

            List<Model.HistorialMillasModel> millasHist = millasController.buscarMillas(clienteEncontrado.clienteId);
            double cantidadMillas = calcularCantidadMillas(millasHist);

            tbMillasAcum.Text = cantidadMillas.ToString();


            List<Model.ProductoModel> productosDisponibles = productosController.buscarTodosLosProductos();
            dgvProductos.DataSource = productosDisponibles;
            armarGrilla();
        }

        private void armarGrilla()
        {
            dgvProductos.AutoGenerateColumns = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvProductos.Columns[0].HeaderText = "Id. del Producto";
            dgvProductos.Columns[0].ReadOnly = true;
            dgvProductos.Columns[0].Width = 80;

            dgvProductos.Columns[1].HeaderText = "Stock Disponible";
            dgvProductos.Columns[1].ReadOnly = true;
            dgvProductos.Columns[1].Width = 80;

            dgvProductos.Columns[2].HeaderText = "Descripción";
            dgvProductos.Columns[2].ReadOnly = true;
            dgvProductos.Columns[2].Width = 150;

            dgvProductos.Columns[3].HeaderText = "Precio(en millas)";
            dgvProductos.Columns[3].ReadOnly = true;
            dgvProductos.Columns[3].Width = 100;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new AerolineasFRBA().Show();
        }

        private void CanjeMillas_Load(object sender, EventArgs e)
        {
            gbProductosDisponibles.Visible = false;
            tbCantidad.Text = "1";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String dni = tbDni.Text;
            if (!dni.Equals(""))
            {
                List<Model.ClienteModel> clientesEncontrados = clienteController.buscarClientes(dni);
                if(clientesEncontrados != null && clientesEncontrados.Count > 0){
                    if (clientesEncontrados.Count == 1)
                    {
                        clienteEncontrado = clientesEncontrados[0];

                        gbProductosDisponibles.Visible = true;

                        List<Model.HistorialMillasModel> millasHist = millasController.buscarMillas(clienteEncontrado.clienteId);
                        double cantidadMillas = calcularCantidadMillas(millasHist);

                        tbMillasAcum.Text = cantidadMillas.ToString();


                        List<Model.ProductoModel> productosDisponibles = productosController.buscarTodosLosProductos();
                        dgvProductos.DataSource = productosDisponibles;
                        armarGrilla();
                    }
                    else
                    {
                        new Canje_Millas.SeleccionClienteDuplicado(clientesEncontrados, this).Show();
                        this.Hide();
                    }
                }else{
                    MessageBox.Show("No se encontraron clientes registrados con ese dni");
                    gbProductosDisponibles.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el dni");
            }
        }

        private double calcularCantidadMillas(List<Model.HistorialMillasModel> millasHist)
        {
            double cantidadMillas = 0;
            foreach(Model.HistorialMillasModel millas in millasHist){
                if (millas.tipoOperacion.Equals(Model.TipoOperacion.ACREDITACION))
                {
                    cantidadMillas = cantidadMillas + millas.millas;
                }
                else
                {
                    cantidadMillas = cantidadMillas - millas.millas;
                }
            }

            if (cantidadMillas > 0)
            {
                return cantidadMillas;
            }
            else
            {
                return 0;
            }
            
        }

        private void dgvProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            productoSeleccionado = (Model.ProductoModel)dgvProductos.CurrentRow.DataBoundItem;            
        }

        private void btnCanjear_Click(object sender, EventArgs e)
        {
            double millasADescontar = Convert.ToDouble(tbCantidad.Text) * productoSeleccionado.costoMillas;
            double millasActuales = Convert.ToDouble(tbMillasAcum.Text);
            if (millasADescontar <= millasActuales)
            {
                Model.HistorialMillasModel histMillas = new Model.HistorialMillasModel(Convert.ToInt32(clienteEncontrado.clienteId), millasADescontar, fechaSistema, Model.TipoOperacion.CANJE, "DESCUENTO POR CANJE DE PRODUCTO");
                millasController.registrarMillas(histMillas);
                int idHistorial = millasController.buscarUltimoRegistroMillas();
                millasController.registrarCanje(productoSeleccionado.idProducto, Convert.ToInt32(clienteEncontrado.clienteId), Convert.ToInt32(tbCantidad.Text));
                millasActuales = millasActuales - millasADescontar;
                MessageBox.Show("Canje realizado con éxito");
                tbMillasAcum.Text = millasActuales.ToString();
            }
            else
            {
                MessageBox.Show("Las millas acumuladas no son suficientes para canjear el producto seleccionado.");
            }            
        }

        private void tbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
