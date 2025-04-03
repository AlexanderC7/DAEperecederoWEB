using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolicitudCliente
{
    public partial class GUIPerecederoActualizar : Form
    {
        public GUIPerecederoActualizar()
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Validación de nombre (No vacío)
            string nombre = txtNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            // Validación de código (Debe ser un número entero)
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Ingrese un código válido (número entero).");
                return;
            }

            // Validación de precio (Debe ser un número decimal/double)
            if (!double.TryParse(txtPrecio.Text, out double precio))
            {
                MessageBox.Show("Ingrese un precio válido (número decimal).");
                return;
            }

            // Validación de cantidad (Debe ser un número entero)
            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida (número entero).");
                return;
            }

            // Validación de fecha (Por ejemplo, que no sea una fecha pasada)
            DateTime fechaVencimiento = dateVencimiento.Value;
            if (fechaVencimiento < DateTime.Today)
            {
                MessageBox.Show("La fecha de vencimiento no puede ser pasada.");
                return;
            }
        }
    }
}
