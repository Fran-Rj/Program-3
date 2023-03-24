using System;
using Farmaceutica.Entidad;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmaceutica.Negocio;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Farmaceutica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("-------------Enfermedad-------------");
                WriteLine("1-Alergia" + "\n2-Migraña" + "\n3-Gripe" + "\n4-Asma" + "\n5-Salir");
                Write("Selecciona el tipo: ");
                int opcion = int.Parse(Console.ReadLine());

                Cliente c = new Cliente();
                Producto p = new Producto();
                NProducto nP = new NProducto();

                if (opcion == 1)
                {
                    c.enfermedad = "Alergia";
                    nP.Medicamentos("Loratadina", "Cetirizina", "Fexofenadina", "Clemastina", p);
                    nP.DatosCliente(c);
                    nP.Data(c, p);
                }
                else if (opcion == 2)
                {
                    c.enfermedad = "Migraña";
                    nP.Medicamentos("Acetaminofen", "Ibuprofeno", "Aspirina", "Diclofenaco", p);
                    nP.DatosCliente(c);
                    nP.Data(c, p);
                }
                else if (opcion == 3)
                {
                    c.enfermedad = "Gripe";
                    nP.Medicamentos("Paracetamol", "Ibuprofen", "Clorhidrato de Bromhexina", "Pharmagrip", p);
                    nP.DatosCliente(c); nP.Data(c, p);
                    nP.Data(c, p);
                }
                else if (opcion == 4)
                {
                    c.enfermedad = "Asma";
                    nP.Medicamentos("Albuterol", "Levalbuterol", "Metaproterenol", "Benralizumab", p);
                    nP.DatosCliente(c);
                    nP.Data(c, p);
                }
                else if (opcion == 5)
                {
                    break;
                }
                else
                {
                    WriteLine("\nInválida!");
                }
            }
        }
    }
}
