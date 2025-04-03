using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using SolicitudCliente.model;

namespace SolicitudCliente
{
    public partial class GUIPerecederoListar : Form
    {
        Perecedero perecedero = new Perecedero();
        public GUIPerecederoListar()
        {
            InitializeComponent();
        }

        private async void CargarDatos()
        {
            try
            {
                var options = new RestClientOptions("http://localhost:8080");
                var client = new RestClient(options);
                var request = new RestRequest("/perecederos/list", Method.Get);

                var response = await client.ExecuteAsync<List<Perecedero>>(request);

                if (response.IsSuccessful && response.Data != null)
                {
                    dataGridView1.DataSource = response.Data; // Llenar la tabla con los datos de la API
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la lista de perecederos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GUIPerecederoListar_Load(object sender, EventArgs e)
        {
            CargarDatos(); // Cargar datos al abrir la ventana
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurar que no es el encabezado
            {
                string valorCelda = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                MessageBox.Show($"Has hecho clic en: {valorCelda}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}