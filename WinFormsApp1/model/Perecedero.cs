using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitudCliente.model
{
    public class Perecedero
    {
        public string nombre { get; set; }
        public int codigo { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
        public DateTime fechaVencimiento { get; set; }
    }
}
