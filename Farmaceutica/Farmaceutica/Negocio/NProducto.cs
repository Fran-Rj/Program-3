using System;
using static System.Console;
using Farmaceutica.Entidad;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Farmaceutica.Negocio
{
    internal class NProducto
    {
        public void Medicamentos(string m1, string m2, string m3, string m4, Producto p)
        {
            Clear();
            WriteLine("------------Medicamentos------------");
            WriteLine($"1-{m1} \n2-{m2} \n3-{m3} \n4-{m4}");
            Write("Elige tu medicamento: ");
            int opcion = int.Parse(ReadLine());

            if (opcion == 1)
            {
                p.nombre = m1;

                if (p.nombre == "Loratadina")
                {
                    p.descripcion = "Pastillas, 10 unidades/Pack de 10 mg";
                    p.precio = 1;
                    p.vencimiento = "30/12/2024";
                }
                else if (p.nombre == "Acetaminofen")
                {
                    p.descripcion = "Jarabe líquido 160 mg/5 ml";
                    p.precio = 1.75;
                    p.vencimiento = "15/07/2023";
                }
                else if (p.nombre == "Paracetamol")
                {
                    p.descripcion = "Pastillas, 8 unidades/Pack de 10 mg";
                    p.precio = 1.10;
                    p.vencimiento = "11/01/2021";
                }
                else if (p.nombre == "Albuterol")
                {
                    p.descripcion = "Solución líquida 200 ml";
                    p.precio = 2.25;
                    p.vencimiento = "01/10/2022";
                }
                else
                {
                    WriteLine("Error...");
                }
            }
            else if (opcion == 2)
            {

                p.nombre = m2;

                if (p.nombre == "Cetirizina")
                {
                    p.descripcion = "Pastillas, 10 unidades/Pack de 12 mg";
                    p.precio = 1.9;
                    p.vencimiento = "31/11/2023";
                }
                else if (p.nombre == "Ibuprofeno")
                {
                    p.descripcion = "Capsulas, 6 unidades/Pack de 10 mg";
                    p.precio = 2.2;
                    p.vencimiento = "03/06/2025";
                }
                else if (p.nombre == "Ibuprofen")
                {
                    p.descripcion = "Capsulas, 8 unidades/Pack de 8 mg";
                    p.precio = 1.5;
                    p.vencimiento = "17/04/2026";
                }
                else if (p.nombre == "Levalbuterol")
                {
                    p.descripcion = "Sobre de 1.25 mg/3 ml";
                    p.precio = 2.5;
                    p.vencimiento = "21/02/2027";
                }
                else
                {
                    WriteLine("Error...");
                }
            }
            else if (opcion == 3)
            {
                p.nombre = m3;

                if (p.nombre == "Fexofenadina")
                {
                    p.descripcion = "Pastillas, 10 unidades/Pack de 12 mg";
                    p.precio = 0.8;
                    p.vencimiento = "12/12/2022";
                }
                else if (p.nombre == "Aspirina")
                {
                    p.descripcion = "Pastillas, 10 unidades/Pack de 10 mg";
                    p.precio = 0.95;
                    p.vencimiento = "23/05/2050";
                }
                else if (p.nombre == "Clorhidrato de Bromhexina")
                {
                    p.descripcion = "Pastillas, 10 unidades/Pack de 9 mg";
                    p.precio = 1.5;
                    p.vencimiento = "25/09/2034";
                }
                else if (p.nombre == "Metaproterenol")
                {
                    p.descripcion = "Jarabe líquido 180 mg/5 ml";
                    p.precio = 10;
                    p.vencimiento = "06/02/2023";
                }
                else
                {
                    WriteLine("Error...");
                }
            }
            else if (opcion == 4)
            {
                p.nombre = m4;

                if (p.nombre == "Clemastina")
                {
                    p.descripcion = "Pastillas, 8 unidades/Pack de 11 mg";
                    p.precio = 5;
                    p.vencimiento = "13/11/2023";
                }
                else if (p.nombre == "Diclofenaco")
                {
                    p.descripcion = "Capsulas, 6 unidades/Pack de 12 mg";
                    p.precio = 1.6;
                    p.vencimiento = "10/10/2028";
                }
                else if (p.nombre == "Pharmagrip")
                {
                    p.descripcion = "Capsulas, 8 unidades/Pack de 15 mg";
                    p.precio = 1.6;
                    p.vencimiento = "28/05/2024";
                }
                else if (p.nombre == "Benralizumab")
                {
                    p.descripcion = "Inyección, 30 mg/1 ml";
                    p.precio = 3;
                    p.vencimiento = "22/06/2024";
                }
                else
                {
                    WriteLine("Error...");
                }
            }
            else
            {
                WriteLine("\nInválida!");
            }
        }

        public void DatosCliente(Cliente c)
        {
            Write("\nIngresa tu nombre: ");
            c.nombre = ReadLine();

            Write("Ingresa tus apellidos: ");
            c.apellidos = ReadLine();

            Write("Ingresa tu edad: ");
            c.edad = int.Parse(ReadLine());
        }

        public void Data(Cliente c, Producto p)
        {
            Clear();
            WriteLine("\n*********Datos-Cliente*********");
            WriteLine($"Nombre: {c.nombre} \nApellidos: {c.apellidos} \nEdad: {c.edad} \nEnfermedad: {c.enfermedad}");

            WriteLine("\n*******Datos-Medicamento*******");
            WriteLine($"Nombre: {p.nombre} \nDescripción: {p.descripcion} \nPrecio: {p.precio} \nVencimiento: {p.vencimiento}");

            Write("\nPresiona ENTER para continuar. . .");
            ReadKey();
            Clear();
        }
    }
}