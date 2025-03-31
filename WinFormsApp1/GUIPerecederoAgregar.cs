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
            MessageBox.Show("Producto creado", "Acción realizada");
        }
    }
}
