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

namespace SolicitudCliente
{
    public partial class GUIPerecederoEliminar : Form
    {
        private Perecedero perecedero = new Perecedero();
        public GUIPerecederoEliminar()
        {
            InitializeComponent();
        }

        private void lblEstadoConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string consulta = txtValor.Text.Trim();

            var options = new RestClientOptions("http://localhost:8080");
            var client = new RestClient(options);
            var request = new RestRequest("/perecederos/find");

            if (cmbParametro.SelectedIndex == 0)
            {
                //Parametro Nombre
                request.AddParameter("nombre", consulta);
            }
            if (cmbParametro.SelectedIndex == 1)
            {
                //Parametro Codigo
                int.TryParse(txtValor.Text, out int numero);
                request.AddParameter("codigo", numero);
            }
            if (cmbParametro.SelectedIndex == 2)
            {
                //Parametro precio
                double.TryParse(consulta, out double num);
                request.AddParameter("precio", num);
            }
            if (cmbParametro.SelectedIndex == 3)
            {
                //Parametro cantidad
                int.TryParse(txtValor.Text, out int numero);
                request.AddParameter("cantidad", numero);
            }
            if (cmbParametro.SelectedIndex == 4)
            {
                //Parametro fechaVencimiento
                DateTime fecha = DateTime.Parse(consulta);
                request.AddParameter("fechaVencimiento", fecha);
            }

            var response = client.Get(request);

            if (response.IsSuccessful)
            {
                // Deserializar el JSON a un objeto Perecedero
                perecedero = JsonSerializer.Deserialize<Perecedero>(response.Content);

                txtNombre.Text = perecedero.nombre;
                txtCodigo.Text = perecedero.codigo.ToString();
                txtPrecio.Text = perecedero.precio.ToString("F2");
                txtCantidad.Text = perecedero.cantidad.ToString();
                dateVencimiento.Value = perecedero.fechaVencimiento;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                MessageBox.Show("Solicitud incorrecta: faltan parámetros.");
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                MessageBox.Show("Producto no encontrado.");
            }
            else
            {
                MessageBox.Show($"Error en la solicitud: {response.StatusCode}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var options = new RestClientOptions("http://localhost:8080");
            var client = new RestClient(options);
            var request = new RestRequest("/perecederos/delete");
            request.AddParameter("codigo", perecedero.codigo);

            var response = client.Post(request);

            if (response.IsSuccessful)
            {
                MessageBox.Show("Eliminado con éxito");
                txtNombre.Text = perecedero.nombre;
                txtCodigo.Text = perecedero.codigo.ToString();
                txtPrecio.Text = perecedero.precio.ToString("F2");
                txtCantidad.Text = perecedero.cantidad.ToString();
                dateVencimiento.Value = perecedero.fechaVencimiento;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                MessageBox.Show("Solicitud incorrecta: faltan parámetros.");
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                MessageBox.Show("Producto no encontrado.");
            }
            else
            {
                MessageBox.Show($"Error en la solicitud: {response.StatusCode}");
            }
        }
    }
}
