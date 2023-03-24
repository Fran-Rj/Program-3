using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Entidad
{
    internal class Producto
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public string vencimiento { get; set; }
    }
}
