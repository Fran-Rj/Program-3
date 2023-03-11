using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalzadoShop
{
    internal class Calzado
    {
        public string tienda { get; set; }
        public string tipo { get; set; }
        public string categoria { get; set; }
        public string marca { get; set; }
        public string descripcion { get; set; }
        public string color { get; set; }
        public string talla { get; set; }
        public double precio { get; set; }
        public double precioVenta { get; set; }
        public double descuento { get; set; }

        public Calzado() { }

        //public Calzado(string tipo, string marca, string categoria, string descripcion, string color, string talla, double precio)
        //{
        //    this.tipo = tipo;
        //    this.marca = marca;
        //    this.categoria = categoria;
        //    this.descripcion = descripcion;
        //    this.color = color;
        //    this.talla = talla;
        //    this.precio = precio;
        //}

        public string Detalles()
        {
            Clear();
            WriteLine("----------------Detalles - Compra----------------");
            return "Tienda: " + tienda +
                "\nDescripción: " + descripcion +
                "\nTipo: " + tipo +
                "\nMarca: " + marca +
                "\nCategoria: " + categoria +
                "\nTalla: " + talla +
                "\nPrecio: $" + precio +
                "\nDescuento: " + descuento +
                "\nPrecio venta: " + precioVenta;
        }

        public string ColorCalzado()
        {
            Clear();
            WriteLine("\n-----------------Color-----------------");
            WriteLine("1-Rojo" + "\n2-Negro" + "\n3-Blanco" + "\n4-Azul" + "\n5-Gris");

            Write("Elige el color: ");
            int opcion = int.Parse(ReadLine());

            if (opcion == 1)
            {
                return color = "rojo";
            }
            else if (opcion == 2)
            {
                return color = "negro";
            }
            else if (opcion == 3)
            {
                return color = "blanco";
            }
            else if (opcion == 4)
            {
                return color = "azul";
            }
            else if (opcion == 5)
            {
                return color = "gris";
            }
            else
            {
                return "\nOpción inválida!";
            }
        }

        public string TallaCalzado()
        {
            Clear();
            WriteLine("\n-----------------Talla-----------------");
            WriteLine("1-XS" + "\n2-S" + "\n3-M" + "\n4-L" + "\n5-XL");

            Write("Elige tu talla: ");
            int opcion = int.Parse(ReadLine());

            if (opcion == 1)
            {
                return talla = "XS";
            }
            else if (opcion == 2)
            {
                return talla = "S";
            }
            else if (opcion == 3)
            {
                return talla = "M";
            }
            else if (opcion == 4)
            {
                return talla = "L";
            }
            else if (opcion == 5)
            {
                return talla = "XL";
            }
            else
            {
                return "Opción inválida!";
            }
        }

        public string MarcaCalzado()
        {
            Clear();
            WriteLine("\n-----------------Marca-----------------");
            WriteLine("1-Jordan" + "\n2-Nike" + "\n3-Adidas");

            Write("Elige la marca: ");
            int opcion = int.Parse(ReadLine());

            if (opcion == 1)
            {
                return marca = "Jordan";
            }
            else if (opcion == 2)
            {
                return marca = "Nike";
            }
            else if (opcion == 3)
            {
                return marca = "Adidas";
            }
            else if (opcion == 4)
            {
                return marca = "azul";
            }
            else if (opcion == 5)
            {
                return marca = "gris";
            }
            else
            {
                return "\nOpción inválida!";
            }
        }

        public void EstiloCalzado(string tiendas, string c1, string c2, string c3, string categ, string descrip, string tallas, string marcas, string colors, double p1, double p2, double p3)
        {
            Clear();
            WriteLine("\n-----------------Estilo-----------------");
            WriteLine("1-" + c1 + "\n2-" + c2 + "\n3-" + c3);

            Write("Elige tu estilo: ");
            int opcion = int.Parse(ReadLine());

            tienda = tiendas;

            if (opcion == 1)
            {
                tipo = c1;
                marca = marcas;
                categoria = categ;
                color = colors;
                descripcion = descrip + " de color " + color;
                talla = tallas;
                precio = p1;
                descuento = 0.15;
                precioVenta = precio - (precio * descuento);
            }
            else if (opcion == 2)
            {
                tipo = c2;
                marca = marcas;
                categoria = categ;
                color = colors;
                descripcion = descrip + " de color " + color;
                talla = tallas;
                precio = p2;
                descuento = 0.20;
                precioVenta = precio - (precio * descuento);
            }
            else if (opcion == 3)
            {
                tipo = c3;
                marca = marcas;
                categoria = categ;
                color = colors;
                descripcion = descrip + " de color " + color;
                talla = tallas;
                precio = p3;
                descuento = 0.10;
                precioVenta = precio - (precio * descuento);
            }
            else
            {
                WriteLine("\nOpción incorrecta!");
                Write("\nPresiona Enter para continuar...");
                ReadKey();
                Clear();
            }
        }
    }
}
