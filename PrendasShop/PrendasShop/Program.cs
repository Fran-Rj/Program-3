using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Datos
{
    public string tipo { get; set; }
    public string categoria { get; set; }
    public string descripcion { get; set; }
    public string color { get; set; }
    public string talla { get; set; }
    public double precio { get; set; }

    abstract public string Detalles();
}

class Prenda : Datos
{
    public Prenda() { }

    public Prenda(string tipo, string categoria, string descripcion, string color, string talla, double precio)
    {
        this.tipo = tipo;
        this.categoria = categoria;
        this.descripcion = descripcion;
        this.color = color;
        this.talla = talla;
        this.precio = precio;
    }

    public override string Detalles()
    {
        Clear();
        return "\n---------------- Factura ----------------" +
            "\nDescripción: " + descripcion +
            "\nTipo: " + tipo +
            "\nCategoria: " + categoria +
            "\nTalla: " + talla +
            "\nPrecio: $" + precio ;
    }

    public string ColorPrenda()
    {
        Clear();
        WriteLine("\n-----------------Color-----------------");
        WriteLine("1-Rojo" + "\n2-Negro" + "\n3-Blanco" + "\n4-Azul" + "\n5-Gris" + "\n6-Celeste"+ "\n7-Morado" + "\n8-Rosa"+ "\n9-Naranja" + "\n10-Beige");

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
        if (opcion == 6)
        {
            return color = "celeste";
        }
        else if (opcion == 7)
        {
            return color = "morado";
        }
        else if (opcion == 8)
        {
            return color = "rosa";
        }
        else if (opcion == 9)
        {
            return color = "naranja";
        }
        else if (opcion == 10)
        {
            return color = "beige";
        }
        else
        {
            return "Opción inválida!";
        }
    }

    public string TallaPrenda()
    {
        Clear();
        WriteLine("\n-----------------Talla-----------------");
        WriteLine("1-XS" + "\n2-S" + "\n3-M" + "\n4-L" + "\n5-XL");

        Write("Elige tu talla: ");
        int opcion = int.Parse(ReadLine());

        if (opcion == 1)
        {
            return color = "XS";
        }
        else if (opcion == 2)
        {
            return color = "S";
        }
        else if (opcion == 3)
        {
            return color = "M";
        }
        else if (opcion == 4)
        {
            return color = "L";
        }
        else if (opcion == 5)
        {
            return color = "XL";
        }
        else
        {
            return "Opción inválida!";
        }
    }

    public void EstiloPrenda(string p1, string p2, string p3, string categ, string descrip, string colors, string tallas, double price1, double price2, double price3)
    {
        Clear();
        WriteLine("\n-----------------Estilo-----------------");
        WriteLine("1-" + p1 + "\n2-" + p2 + "\n3-" + p3);

        Write("Elige tu estilo: ");
        int opcion = int.Parse(ReadLine());

        if (opcion == 1)
        {
            tipo = p1;
            categoria = categ;
            color = colors;
            descripcion = descrip + " de color " + colors;
            talla = tallas;
            precio = price1;
        }
        else if (opcion == 2)
        {
            tipo = p2;
            categoria = categ;
            color = colors;
            descripcion = descrip + " de color " +  colors;
            talla = tallas;
            precio = price2;
        }
        else if (opcion == 3)
        {
            tipo = p3;
            categoria = categ;
            descripcion = descrip + " de color " + colors;
            talla = tallas;
            precio = price3;
        }
        else
        {
            WriteLine("\nOpción incorrecta!");
        }
    }

    public void TipoPrenda(string categ)
    {
        Clear();
        WriteLine("\n-----------------Tipo de ropa-----------------");
        WriteLine("1-Camisas" + "\n2-Pantalones" + "\n3-Shorts" + "\n4-Faldas" + "\n5-Vestidos");

        Write("Selecciona el tipo: ");
        int opcion = int.Parse(ReadLine());

        Prenda p = new Prenda();

        if (opcion == 1)
        {
            if (categ == "Hombre" || categ == "Mujer")
            {
                p.EstiloPrenda("Manga larga", "Manga corta sin cuello", "Manga corta de cuello", categ, "Camisa", p.ColorPrenda(), p.TallaPrenda(), 20, 15, 25);
                WriteLine(p.Detalles());
                Write("\nPresiona Enter para continuar...");
                ReadKey();
            }
            else
            {
                p.EstiloPrenda("Manga larga", "Manga corta sin cuello", "Manga corta de cuello", categ, "Camisa", p.ColorPrenda(), p.TallaPrenda(), 14, 11, 17);
                WriteLine(p.Detalles());
                Write("\nPresiona Enter para continuar...");
                ReadKey();
            }
        }
        else if (opcion == 2)
        {
            if (categ == "Hombre" || categ == "Mujer")
            {
                p.EstiloPrenda("Joggers", "Atheleisure", "Jeans", categ, "Pantalon", p.ColorPrenda(), p.TallaPrenda(), 55, 45, 35);
                WriteLine(p.Detalles());
                Write("\nPresiona Enter para continuar...");
                ReadKey();
            }
            else
            {
                p.EstiloPrenda("Joggers", "Atheleisure", "Jeans", categ, "Pantalon", p.ColorPrenda(), p.TallaPrenda(), 26, 33, 21);
                WriteLine(p.Detalles());
                Write("\nPresiona Enter para continuar...");
                ReadKey();
            }
        }
        else if (opcion == 3)
        {
            if (categ == "Hombre" || categ == "Mujer")
            {
                p.EstiloPrenda("Bermudas", "Capri", "Culottes", categ, "Short", p.ColorPrenda(), p.TallaPrenda(), 13, 18, 24);
                WriteLine(p.Detalles());
                Write("\nPresiona Enter para continuar...");
                ReadKey();
            }
            else
            {
                p.EstiloPrenda("Bermudas", "Capri", "Culottes", categ, "Short", p.ColorPrenda(), p.TallaPrenda(), 10, 15, 19);
                WriteLine(p.Detalles());
                Write("\nPresiona Enter para continuar...");
                ReadKey();
            }
        }
        else if (opcion == 4)
        {
            if (categ == "Mujer")
            {
                p.EstiloPrenda("Minifalda", "Asimétrica", "Godet", categ, "Falda", p.ColorPrenda(), p.TallaPrenda(), 22, 37, 30);
                WriteLine(p.Detalles());
                Write("\nPresiona Enter para continuar...");
                ReadKey();
            }
            else if (categ == "Niña")
            {
                p.EstiloPrenda("Minifalda", "Asimétrica", "Godet", categ, "Falda", p.ColorPrenda(), p.TallaPrenda(), 12, 17, 21);
                WriteLine(p.Detalles());
                Write("\nPresiona Enter para continuar...");
                ReadKey();
            }
            else
            {
                WriteLine("\nProducto no disponible!");
                Write("\nPresiona Enter para continuar...");
                ReadKey();
            }
        }
        else if (opcion == 5)
        {
            if (categ == "Mujer")
            {
                p.EstiloPrenda("Canesú", "Imperio", "Tubo", categ, "Vestido", p.ColorPrenda(), p.TallaPrenda(), 54, 60, 47);
                WriteLine(p.Detalles());
                Write("\nPresiona Enter para continuar...");
                ReadKey();
            }
            else if (categ == "Niña")
            {
                p.EstiloPrenda("Canesú", "Imperio", "Tubo", categ, "Vestido", p.ColorPrenda(), p.TallaPrenda(), 35, 40, 26);
                WriteLine(p.Detalles());
                Write("\nPresiona Enter para continuar...");
                ReadKey();
            }
            else
            {
                WriteLine("\nProducto no disponible!");
                Write("\nPresiona Enter para continuar...");
                ReadKey();
            }
        }
        else
        {
            WriteLine("Opción incorrecta!");
        }
        Clear();
    }
}

namespace PrendaShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("-----------------Categoria-----------------");
                WriteLine("1-Mujer" + "\n2-Hombre" + "\n3-Niño" + "\n4-Niña" + "\n5-Salir");

                Write("Selecciona la categoria: ");
                int eleccion = int.Parse(ReadLine());

                Prenda p = new Prenda();

                if (eleccion == 1)
                {
                    p.TipoPrenda("Mujer");
                }
                else if (eleccion == 2)
                {
                    p.TipoPrenda("Hombre");
                }
                else if (eleccion == 3)
                {
                    p.TipoPrenda("Niño");
                }
                else if (eleccion == 4)
                {
                    p.TipoPrenda("Niña");
                }
                else if (eleccion == 5)
                {
                    break;
                }
                else
                {
                    WriteLine("Opción incorrecta!");
                }
            }
        }
    }
}