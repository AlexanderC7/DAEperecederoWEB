using RestSharp;

namespace WinFormsApp1
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            var options = new RestClientOptions("http://localhost:8080");
            var client = new RestClient(options);
            var request = new RestRequest("/employees/", Method.Get);

            var response = client.Get(request);
            txtValue.Text=response.Content;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            var value = txtValue.Text.Trim();
            var options = new RestClientOptions("http://localhost:8080");
            var client = new RestClient(options);
            var request = new RestRequest("/employees/" + value);

            var response = client.Post(request);
            MessageBox.Show("Response: " + response.StatusCode);
        }
    }
}
