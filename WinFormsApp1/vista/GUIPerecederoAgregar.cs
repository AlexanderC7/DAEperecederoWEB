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
using RestSharp;
using WinFormsApp1;

namespace SolicitudCliente
{
    public partial class GUIPerecederoAgregar : Form
    {
        public GUIPerecederoAgregar()
        {
            InitializeComponent();
        }

        private void PerecederoAgregar_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                    string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que Precio y Cantidad sean valores numéricos
                if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
                {
                    MessageBox.Show("El precio debe ser un número válido y positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 0)
                {
                    MessageBox.Show("La cantidad debe ser un número entero válido y positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener los valores ingresados
                string nombre = txtNombre.Text;
                string codigo = txtCodigo.Text;
                DateTime fechaVencimiento = dateVencimiento.Value;

                //Peticion post

                var options = new RestClientOptions("http://localhost:8080");
                var client = new RestClient(options);
                var request = new RestRequest("/perecederos");

                request.RequestFormat = DataFormat.Json;

                request.AddBody(new
                {
                    nombre = nombre,
                    codigo = codigo,
                    precio = precio,
                    cantidad = cantidad,
                    fechaVencimiento = fechaVencimiento,

                });

                var response = client.Post(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // Mostrar mensaje de éxito
                    MessageBox.Show("Producto Creado con éxito", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos después de agregar el producto
                    txtNombre.Clear();
                    txtCodigo.Clear();
                    txtPrecio.Clear();
                    txtCantidad.Clear();
                    dateVencimiento.Value = DateTime.Now;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Solicitud incorrecta: faltan parámetros.", "Fallo al crear", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Producto no encontrado");
                }
                else
                {
                    MessageBox.Show($"Error en la solicitud: {response.StatusCode}");
                }

                
            }
        }
    }
}