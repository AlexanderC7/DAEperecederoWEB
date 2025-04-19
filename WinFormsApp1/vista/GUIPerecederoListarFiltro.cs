using RestSharp;
using SolicitudCliente.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolicitudCliente.vista
{
    public partial class GUIPerecederoListarFiltro : Form
    {
        private string consulta = "";
        public GUIPerecederoListarFiltro()
        {
            InitializeComponent();
        }

        private void listarPerecederosFiltrados()
        {
            try
            {
                var options = new RestClientOptions("http://localhost:8080");
                var client = new RestClient(options);
                var request = new RestRequest("/perecederos");

                if (cmbParametro.SelectedIndex == 1)
                {
                    //Parametro Nombre
                    request.AddParameter("nombre", consulta);
                }
                if (cmbParametro.SelectedIndex == 2)
                {
                    //Parametro Codigo
                    int.TryParse(txtValor.Text, out int numero);
                    request.AddParameter("codigo", numero);
                }
                if (cmbParametro.SelectedIndex == 3)
                {
                    //Parametro precio
                    double.TryParse(consulta, out double num);
                    request.AddParameter("precio", num);
                }
                if (cmbParametro.SelectedIndex == 4)
                {
                    //Parametro cantidad
                    int.TryParse(txtValor.Text, out int numero);
                    request.AddParameter("cantidad", numero);
                }
                if (cmbParametro.SelectedIndex == 5)
                {
                    //Parametro fechaVencimiento
                    DateTime fecha = DateTime.Parse(consulta);
                    request.AddParameter("fechaVencimiento", fecha);
                }

                var response = client.Get(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // Deserializar el JSON a un objeto Perecedero
                    try
                    {
                        // Deserializar el JSON a una lista de objetos Perecedero
                        var perecederos = JsonSerializer.Deserialize<List<Perecedero>>(response.Content);

                        // Asignar la lista como fuente de datos del DataGridView
                        table.DataSource = perecederos;
                        table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        lblStatus.Text = "Listado Actualizado!";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Procesamiento de respuesta incompleta", "Fallo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Solicitud incorrecta: faltan parámetros.", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Producto no encontrado.", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show($"Error en la solicitud: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al realizar la consulta", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblParametros_Click(object sender, EventArgs e)
        {

        }

        private void GUIPerecederoListarFiltro_Load(object sender, EventArgs e)
        {
            cmbParametro.SelectedIndex = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            consulta = txtValor.Text.Trim();
            lblStatus.Text = "";

            if (string.IsNullOrEmpty(consulta) && cmbParametro.SelectedIndex != 0)
            {
                MessageBox.Show("Ingrese un valor para filtrar", "Fallo de listado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listarPerecederosFiltrados();

        }

        private void cmbParametro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbParametro.SelectedIndex == 0)
            {
                txtValor.Clear();
                txtValor.Enabled = false;
            }
            else
            {
                txtValor.Enabled = true;
            }
        }
    }
}
