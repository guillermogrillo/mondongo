using AerolineaFrba.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class AeronaveForm : Form
    {
        List<TipoServicioModel> listaTipoServicio;
        List<FabricanteModel> listaFabricantes;
        Dao.TipoServicioDao tipoServicioDao;
        Dao.FabricanteDao fabricantesDao;
        Controller.AeronaveController _controller;

        private Boolean isEdit = false;

        public AeronaveForm()
        {
            isEdit = false;
            InitializeComponent();
            init();
        }

        public AeronaveForm(AeronaveModel aeronave)
        {
            isEdit = true;
            InitializeComponent();
            init();
            
            if (aeronave != null)
            {
                this.tbMatricula.Text = aeronave.matricula;
                this.cbFabricantes.SelectedItem = getFabricante(aeronave.idFabricante);
                this.tbKilos.Text = aeronave.capacidadKg.ToString();
                this.tbModelo.Text = aeronave.modelo;
                this.tbPasillo.Text = aeronave.cantButacasPas.ToString();
                this.tbVentanilla.Text = aeronave.cantButacasVen.ToString();
                this.cbTipoServicio.SelectedItem = getTipoServicio(aeronave.idTipoServicio);

                this.tbMatricula.Enabled = false;
                this.cbFabricantes.Enabled = false;
            }
        }

        private object getTipoServicio(int ts_id)
        {
            foreach(TipoServicioModel tipoServicio in listaTipoServicio)
            {  
                if(tipoServicio.id == ts_id)
                    return tipoServicio;
            }
            return null;
        }
        private object getFabricante(int ts_id)
        {
            foreach (FabricanteModel fabricante in listaFabricantes)
            {
                if (fabricante.fabricanteId == ts_id)
                    return fabricante;
            }
            return null;
        }

        private void init()
        {
            tipoServicioDao = new Dao.TipoServicioDao();
            fabricantesDao = new Dao.FabricanteDao();
            _controller = new Controller.AeronaveController();

            llenarTiposServicio();
            llenarFabricantes();
        }

        private void llenarTiposServicio()
        {  
            if(listaTipoServicio==null)
            {
                listaTipoServicio = tipoServicioDao.buscarTiposServicio();
                cbTipoServicio.DataSource = listaTipoServicio;
                cbTipoServicio.DisplayMember = "tipoServicio";
            }
        }
        private void llenarFabricantes()
        {
            if (listaFabricantes == null)
            {
                listaFabricantes = fabricantesDao.buscarFabricantes();
                cbFabricantes.DataSource = listaFabricantes;
                cbFabricantes.DisplayMember = "nombre";
            }
        }

        private void onClickGuardar(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbKilos.Text) == 0 || Convert.ToInt32(tbVentanilla.Text) == 0 || Convert.ToInt32(tbPasillo.Text) == 0)
            {
                MessageBox.Show("Cantidad de kilos y butacas no pueden ser cero.");
                return;
            }


            if (isEdit)
                actualizar();
            else
                guardar();
        }

        private void close(object sender, EventArgs e)
        {
            volver();
        }

        private void volver()
        {
            Abm_Aeronave.AbmAeronaves abm_aeronaves = new Abm_Aeronave.AbmAeronaves();
            this.Close();
            abm_aeronaves.Show();
        }

        private void actualizar()
        {
            AeronaveModel aeronave = cargarAeronave();
            _controller.actualizarAeronave(aeronave);

            volver();
        }

        private void guardar()
        {
            AeronaveModel aeronave = cargarAeronave();
            String resultado = _controller.guardarAeronave(aeronave);
            MessageBox.Show(resultado, "Atencion");

            if (!resultado.Equals("OK"))
                return;

            volver();
        }

        private AeronaveModel cargarAeronave()
        {
            AeronaveModel aeronave = new AeronaveModel();
            aeronave.cantButacasPas = Int32.Parse(tbPasillo.Text);
            aeronave.cantButacasVen = Int32.Parse(tbVentanilla.Text);
            aeronave.capacidadKg = Int32.Parse(tbKilos.Text);
            aeronave.idTipoServicio = ((TipoServicioModel)cbTipoServicio.SelectedItem).id;
            aeronave.matricula = tbMatricula.Text;
            aeronave.modelo = tbModelo.Text;
            aeronave.idFabricante = ((FabricanteModel)cbFabricantes.SelectedItem).fabricanteId;

            return aeronave;
        }

        private void onKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
