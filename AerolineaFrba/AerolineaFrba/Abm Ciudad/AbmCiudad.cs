using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class AbmCiudad : Form
    {        
        private BindingSource bindingSource = new BindingSource();

        public AbmCiudad(Boolean modoCompleto)
        {
            InitializeComponent();            
            btnAgregarCiudad.Visible = modoCompleto;
            btnBorrarCiudad.Visible = modoCompleto;
            btnEditarCiudad.Visible = modoCompleto;
        }

        private void AbmCiudad_Load(object sender, EventArgs e)
        {            
            dgCiudades.DataSource = bindingSource;
            GetData("select nombre from mondongo.ciudades order by nombre asc");
        }


        private void GetData(string selectCommand)
        {
            try
            {
                var stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");
            

                // Create a new data adapter based on the specified query.
                var dataAdapter = new SqlDataAdapter(selectCommand, stringConexion);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dgCiudades.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("ERRORRRRR");
            }
        }



    }
}
