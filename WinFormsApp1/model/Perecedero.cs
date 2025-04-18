using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SolicitudCliente.model
{
    public class Perecedero
    {
        [JsonPropertyName("nombre")]
        public string nombre { get; set; }

        [JsonPropertyName("codigo")]
        public int codigo { get; set; }

        [JsonPropertyName("precio")]
        public double precio { get; set; }

        [JsonPropertyName("cantidad")]
        public int cantidad { get; set; }

        [JsonPropertyName("fechaVencimiento")]
        [JsonConverter(typeof(DateTimeArrayConverter))]
        public DateTime fechaVencimiento { get; set; }
    }
}
