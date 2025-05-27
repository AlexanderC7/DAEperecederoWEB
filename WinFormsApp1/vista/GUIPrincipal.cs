using RestSharp;
using SolicitudCliente;
using SolicitudCliente.vista;

namespace WinFormsApp1
{
    public partial class Perecedero : Form
    {
        public Perecedero()
        {
            InitializeComponent();
        }


        private void Perecedero_Load(object sender, EventArgs e)
        {

        }

        private void menuAcciones_Click(object sender, EventArgs e)
        {

        }

        private void menuItemAdicionar_Click(object sender, EventArgs e)
        {
            GUIPerecederoAgregar gUIPerecederoAgregarperecederoAgregar = new GUIPerecederoAgregar();
            gUIPerecederoAgregarperecederoAgregar.Show();
        }

        private void menuItemBuscar_Click(object sender, EventArgs e)
        {
            GUIPerecederoBuscar gUIPerecederoBuscar = new GUIPerecederoBuscar();
            gUIPerecederoBuscar.Show();
        }

        private void menuItemAcercade_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Equipo de trabajo:\n->Jhon Cartagena\n->Leandro Vergara\n->Alejandro Vargas\n->Juan Florez\n Versión: 2.0.0", "Acerca de...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuAyuda_Click(object sender, EventArgs e)
        {

        }

        private void menuArchivo_Click(object sender, EventArgs e)
        {

        }

        private void menuItemSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void menuItemEliminar_Click(object sender, EventArgs e)
        {
            GUIPerecederoEliminar gUIPerecederoEliminar = new GUIPerecederoEliminar();
            gUIPerecederoEliminar.Show();
        }

        private void menuItemListar_Click(object sender, EventArgs e)
        {
            GUIPerecederoListar gUIPerecederoListar = new GUIPerecederoListar();
            gUIPerecederoListar.Show();
        }

        private void menuItemActualizar_Click(object sender, EventArgs e)
        {
            GUIPerecederoActualizar gUIPerecederoActualizar = new GUIPerecederoActualizar();
            gUIPerecederoActualizar.Show();
        }

        private void menuItemListarFiltro_Click(object sender, EventArgs e)
        {
            GUIPerecederoListarFiltro gUIPerecederoListarFiltro = new GUIPerecederoListarFiltro();
            gUIPerecederoListarFiltro.Show();
        }

        private void menuItemLoteAdicionar_Click(object sender, EventArgs e)
        {
            GUILoteAgregar gUILoteAgregar = new GUILoteAgregar();
            gUILoteAgregar.Show();
        }

        private void menuItemLoteActualizar_Click(object sender, EventArgs e)
        {
            GUILoteActualizar gUILoteActualizar = new GUILoteActualizar();
            gUILoteActualizar.Show();
        }

        private void menuItemLoteBuscar_Click(object sender, EventArgs e)
        {
            GUILoteBuscar gUILoteBuscar = new GUILoteBuscar();
            gUILoteBuscar.Show();
        }

        private void menuItemLoteEliminar_Click(object sender, EventArgs e)
        {
            GUILoteEliminar gUILoteEliminar = new GUILoteEliminar();
            gUILoteEliminar.Show();
        }

        private void menuItemLoteListar_Click(object sender, EventArgs e)
        {
            GUILoteListar gUILoteListar = new GUILoteListar();
            gUILoteListar.Show();
        }

        private void menuItemLoteListarFiltro_Click(object sender, EventArgs e)
        {
            GUILoteListarFiltro gUILoteListarFiltro = new GUILoteListarFiltro();
            gUILoteListarFiltro.Show();
        }
    }
}
