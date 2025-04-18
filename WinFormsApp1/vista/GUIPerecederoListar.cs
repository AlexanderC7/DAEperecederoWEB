using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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


        private void GUIPerecederoListar_Load(object sender, EventArgs e)
        {

        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "";
                var options = new RestClientOptions("http://localhost:8080");
                var client = new RestClient(options);
                var request = new RestRequest("/perecederos");

                var response = client.Get(request);

                if (response.IsSuccessful && response.Content != null)
                {
                    // Deserializar el JSON a una lista de objetos Perecedero
                    var perecederos = JsonSerializer.Deserialize<List<Perecedero>>(response.Content);

                    // Asignar la lista como fuente de datos del DataGridView
                    table.DataSource = perecederos;
                    table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    lblStatus.Text = "Listado Actualizado!";

                }
                else
                {
                    MessageBox.Show("No se pudo obtener la lista de perecederos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Text = "Error en el servidor";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}