using RestSharp;

namespace WinFormsApp1
{
    public partial class Perecedero : Form
    {
        public Perecedero()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            var options = new RestClientOptions("http://localhost:8080");
            var client = new RestClient(options);
            var request = new RestRequest("/employees/", Method.Get);

            var response = client.Get(request);
            
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            
            var options = new RestClientOptions("http://localhost:8080");
            var client = new RestClient(options);
            var request = new RestRequest("/employees/");

            var response = client.Post(request);
            MessageBox.Show("Response: " + response.StatusCode);
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Equipo de trabajo:\n->Jhon Cartagena\n->Leandro Vergara\n->Alejandro Vargas\n->Juan Florez\n Versión: 1.0.0", "Acerca de...", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
