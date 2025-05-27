using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolicitudCliente.vista
{
    public partial class GUILoteAgregar : Form
    {
        public GUILoteAgregar()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void GUILoteAgregar_Load(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtProveedor.Text) ||
                    string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                    string.IsNullOrWhiteSpace(txtNum.Text))
                {
                    MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que NumLote y CodigoPerecedero sean valores numéricos
                if (!int.TryParse(txtNum.Text, out int numLote) || numLote < 0)
                {
                    MessageBox.Show("El precio debe ser un número válido y positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtCodigo.Text, out int codigoPerecedero) || codigoPerecedero < 0)
                {
                    MessageBox.Show("La cantidad debe ser un número entero válido y positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener los valores ingresados
                string proveedor = txtProveedor.Text;
                DateTime fechaAbastecimiento = dateAbastecimiento.Value;

                //Peticion post

                var options = new RestClientOptions("http://localhost:8080");
                var client = new RestClient(options);
                var request = new RestRequest($"/lotes/{codigoPerecedero}");

                request.RequestFormat = DataFormat.Json;

                request.AddBody(new
                {
                    numLote = numLote,
                    proveedor = proveedor,
                    fechaAbastecimiento = fechaAbastecimiento
                    

                });

                var response = client.Post(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // Mostrar mensaje de éxito
                    MessageBox.Show("LLote Asignado con éxito", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos después de agregar el producto
                    txtProveedor.Clear();
                    txtCodigo.Clear();
                    txtNum.Clear();
                    dateAbastecimiento.Value = DateTime.Today;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Solicitud incorrecta: faltan parámetros.", "Fallo al crear", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Lote no encontrado");
                }
                else
                {
                    MessageBox.Show($"Error en la solicitud: {response.StatusCode}");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo asociar el Lote", "Error con el servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
