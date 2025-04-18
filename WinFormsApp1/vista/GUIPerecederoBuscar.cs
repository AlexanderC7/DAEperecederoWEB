using RestSharp;
using SolicitudCliente.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace SolicitudCliente
{
    public partial class GUIPerecederoBuscar : Form
    {
        
        public GUIPerecederoBuscar()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GUIPerecederoBuscar_Load(object sender, EventArgs e)
        {
            dateVencimiento.Value = DateTime.Today;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string consulta = txtValor.Text.Trim();

            txtNombre.Clear();
            txtCodigo.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            dateVencimiento.Value = DateTime.Today;
            lblEstadoConsulta.Text = "Sin resultados";
            lblEstadoConsulta.ForeColor = Color.DarkRed;

            try
            {
                var options = new RestClientOptions("http://localhost:8080");
                var client = new RestClient(options);
                var request = new RestRequest("/perecederos/query");

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

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // Deserializar el JSON a un objeto Perecedero
                    try
                    {
                        var perecedero = JsonSerializer.Deserialize<model.Perecedero>(response.Content);
                        if (perecedero != null)
                        {
                            txtNombre.Text = perecedero.nombre;
                            txtCodigo.Text = perecedero.codigo.ToString();
                            txtPrecio.Text = perecedero.precio.ToString("F2");
                            txtCantidad.Text = perecedero.cantidad.ToString();
                            dateVencimiento.Value = perecedero.fechaVencimiento;

                            lblEstadoConsulta.Text = "Producto encontrado!";
                            lblEstadoConsulta.ForeColor = Color.Aquamarine;
                        }
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
    }
}
