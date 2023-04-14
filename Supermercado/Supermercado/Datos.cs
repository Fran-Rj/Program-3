using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    internal class Datos
    {
        // USUARIO
        public int id { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string rol { get; set; }
        public int edad { get; set; }

        //PRODUCTO
        public string nombreP { get; set; }
        public string proveedor { get; set; }
        public string area { get; set; }
        public string categoria { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public string fechaCompra { get; set; }
        public string fechaVenc { get; set; }
    }
}
