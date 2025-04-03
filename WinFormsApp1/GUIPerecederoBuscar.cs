using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string consulta = txtValor.Text.Trim();

            var options = new RestClientOptions("http://localhost:8080");
            var client = new RestClient(options);
            var request = new RestRequest("/perecederos/find");
            
            if (cmbParametro.SelectedIndex == 0){
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
                request.AddParameter("precio", consulta);
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
                
                request.AddParameter("fechaVencimiento", consulta);
            }
        }
    }
}
