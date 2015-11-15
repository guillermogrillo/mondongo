﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class RutaForm : Form
    {
        private Dao.TipoServicioDao _tipoServicioDao;
        private Controller.CiudadController _ciudadController;
        private Controller.RutaController _controller;

        private Boolean isEdit;
        private int rutaId;
        
        public RutaForm()
        {
            isEdit = false;
            _tipoServicioDao = new Dao.TipoServicioDao();
            _ciudadController = new Controller.CiudadController();
            _controller = new Controller.RutaController();
            InitializeComponent();
            init();
        }
        public RutaForm(Model.RutaModel ruta)
        {
            isEdit = true;
            _tipoServicioDao = new Dao.TipoServicioDao();
            _ciudadController = new Controller.CiudadController();
            _controller = new Controller.RutaController();
            InitializeComponent();
            init();
            cargarRuta(ruta);
            rutaId = ruta.idRuta;
        }

        private void cargarRuta(Model.RutaModel ruta)
        {
            tbCodigoRuta.Text = ruta.codigoRuta.ToString();
            tbHorasVuelo.Text = ruta.horasVuelo.ToString();
            tbPasajePrecio.Text = ruta.precioBasePasaje.ToString();
            tbPrecioKg.Text = ruta.precioBaseKg.ToString();
            cbTipoServicio.SelectedItem = getTipoServicio(ruta.tipoServicio);
            cbOrigen.SelectedIndex = getCiudad(ruta.ciudadOrigen);
            cbDestino.SelectedIndex = getCiudad(ruta.ciudadDestino);
        }

        private void init()
        {
            cbTipoServicio.DataSource = _tipoServicioDao.buscarTiposServicio();
            
            List<Model.CiudadModel> ciudadesOrig = _ciudadController.buscarTodasLasCiudades();
            List<Model.CiudadModel> ciudadesDest = _ciudadController.buscarTodasLasCiudades();
            cbOrigen.DataSource = ciudadesOrig;
            cbDestino.DataSource = ciudadesDest;
        }

        private object getTipoServicio(int ts_id)
        {
            foreach (Model.TipoServicioModel tipoServicio in (List<Model.TipoServicioModel>)cbTipoServicio.DataSource)
            {
                if (tipoServicio.id == ts_id)
                    return tipoServicio;
            }
            return null;
        }
        private int getCiudad(int ciu_id)
        {
            int i = 0;
            foreach (Model.CiudadModel ciudad in (List<Model.CiudadModel>)cbOrigen.DataSource)
            {
                if (ciudad.ciudadId == ciu_id)
                    return i;
                i++;
            }
            return 0;
        }

        private void onClose(object sender, FormClosedEventArgs e)
        {
            new Abm_Ruta.AbmRuta().Show();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Model.RutaModel ruta = armarRuta();

            Model.RutaModel rutaExistente = _controller.buscarRuta(ruta.ciudadOrigen, ruta.ciudadDestino, ruta.tipoServicio);
            if (rutaExistente != null)
            {
                MessageBox.Show("Ya existe una ruta con ese origen y destino");
                return;
            }

            if (isEdit)
                _controller.editarRuta(ruta);
            else
                _controller.guardarRuta(ruta);

            this.Close();
        }

        private Model.RutaModel armarRuta()
        {
            Model.RutaModel ruta = new Model.RutaModel();

            ruta.codigoRuta = Convert.ToInt32(tbCodigoRuta.Text);
            ruta.horasVuelo = Convert.ToDouble(tbHorasVuelo.Text);
            ruta.precioBasePasaje = Convert.ToDouble(tbPasajePrecio.Text);
            ruta.precioBaseKg = Convert.ToDouble(tbPrecioKg.Text);
            ruta.tipoServicio = Convert.ToInt32(((Model.TipoServicioModel)cbTipoServicio.SelectedItem).id);
            ruta.ciudadOrigen = Convert.ToInt32(((Model.CiudadModel)cbOrigen.SelectedItem).ciudadId);
            ruta.ciudadDestino = Convert.ToInt32(((Model.CiudadModel)cbDestino.SelectedItem).ciudadId);

            if (isEdit)
                ruta.idRuta = rutaId;

            return ruta;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void horasVuelo_onKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
