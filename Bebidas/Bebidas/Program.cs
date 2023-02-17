using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Datos
{
    public string nombre { get; set; }
    public string apellido { get; set; }    
    public int edad { get; set; }
    public string sexo { get; set; }
    public string tipo { get; set; }
    public string categoria { get; set; }
    public string descripcion { get; set; }
    public double precio { get; set; }

    public abstract string Detalles();
}

// BEBIDA
public class Bebida : Datos, IDatos
{
    public Bebida() { }

    public Bebida(string Nombre, string Tipo, string Categoria, string Descripcion, double Precio)
    {
        this.nombre = Nombre;
        this.tipo = Tipo;
        this.categoria = Categoria;
        this.descripcion = Descripcion;
        this.precio = Precio;
    }

    public override string Detalles()
    {
        return "Bebida: " + nombre +
            "\nTipo: " + tipo +
            "\nCategoria: " + categoria +
            "\nDescripción: " + descripcion +
            "\nPrecio: " + precio;
    }

    public void Bebidas(string sabor1, string sabor2, string sabor3, string sabor4, string sabor5, string tipo, string categoria, string descripcion, double precio, string asesor, string nombre, string apellido, int edad, string sexo)
    {
        WriteLine("\n++++++++++++++++++++ Bebidas ++++++++++++++++++++");
        WriteLine("1-" + sabor1 + "\n2-" + sabor2 + "\n3-" + sabor3 + "\n4-" + sabor4 + "\n5-" + sabor5);
        WriteLine("\nElige la bebida: ");
        int opc = int.Parse(ReadLine());

        if (opc == 1)
        {
            Utilidades u = new Utilidades();
            u.Datos(sabor1, tipo, categoria, descripcion, precio, asesor, nombre, apellido, edad, sexo);
        }
        else if (opc == 2)
        {
            Utilidades u = new Utilidades();
            u.Datos(sabor2, tipo, categoria, descripcion, precio, asesor, nombre, apellido, edad, sexo);
        }
        else if (opc == 3)
        {
            Utilidades u = new Utilidades();
            u.Datos(sabor3, tipo, categoria, descripcion, precio, asesor, nombre, apellido, edad, sexo);
        }
        else if (opc == 4)
        {
            Utilidades u = new Utilidades();
            u.Datos(sabor4, tipo, categoria, descripcion, precio, asesor, nombre, apellido, edad, sexo);
        }
        else if (opc == 5)
        {
            Utilidades u = new Utilidades();
            u.Datos(sabor5, tipo, categoria, descripcion, precio, asesor, nombre, apellido, edad, sexo);
        }
        else
        {
            WriteLine("Opción inválida!");
        }
    }
}


// CLIENTE
public class Cliente : Datos, IDatos
{
    public Cliente() { }

    public Cliente(string Nombre, string apellido, int Edad, string Sexo)
    {
        this.nombre = Nombre;
        this.apellido = apellido;
        this.edad = Edad;
        this.sexo = Sexo;
    }    

    public override string Detalles()
    {
        return "\n------------------------ Detalles ------------------------" +
            "\nCliente: " + nombre + " " + apellido +
            "\nEdad: " + edad +
            "\nSexo: " + sexo;
    }    
}

// EMPLEADO
public class Empleado : Datos, IDatos
{
    public Empleado(string Nombre)
    {
        this.nombre = Nombre;
    }

    public override string Detalles()
    {
        return "Despachado por: " + nombre;
    }
}

// UTILIDADES
public class Utilidades
{
    public void Datos(string sabor, string tipo,  string categoria, string descripcion, double precio, string asesor, string nombre, string apellido, int edad, string sexo)
    {
        Cliente c = new Cliente(nombre, apellido, edad, sexo);
        WriteLine(c.Detalles());

        Bebida b = new Bebida(sabor, tipo, categoria, descripcion, precio);
        WriteLine(b.Detalles());        

        Empleado e = new Empleado(asesor);
        WriteLine(e.Detalles());

        WriteLine("----------------------------------------------------------");
    }

    public void Venta(string asesor)
    {
        WriteLine("\n----------------Ingresa tus datos----------------");
        Write("Nombre: ");
        string nombre = ReadLine();

        Write("Apellido: ");
        string apellido = ReadLine();

        Write("Edad: ");
        int edad = int.Parse(ReadLine());

        Write("Sexo: ");
        string sexo = ReadLine();

        Clear();

        WriteLine("\n*****************Menu*****************");
        WriteLine("1-Soda" + "\n2-Jugo" + "\n3-Café" + "\n4-Whisky" + "\n5-Licor");

        Write("Elige el tipo de bebida: ");
        int opc = int.Parse(ReadLine());

        if (opc == 1)
        {
            string sabor1 = "Coca-Cola";
            string sabor2 = "Pepsi";
            string sabor3 = "Sprite";
            string sabor4 = "Uva";
            string sabor5 = "Fanta";
            string tipo = "Soda";
            string categoria = "No alcohólico";
            string descripcion = "Soditas";
            double precio = 1;

            Clear();
            Bebida b = new Bebida();
            b.Bebidas(sabor1, sabor2, sabor3, sabor4, sabor5, tipo, categoria, descripcion, precio, asesor, nombre, apellido, edad, sexo);
        }
        else if (opc == 2)
        {
            string sabor1 = "Del Valle (Naranja)";
            string sabor2 = "Frutsi";
            string sabor3 = "Power";
            string sabor4 = "Gatorade";
            string sabor5 = "Batido";
            string tipo = "Jugo";
            string categoria = "No alcohólico";
            string descripcion = "Jugito";
            double precio = 1.55;

            Clear();
            Bebida b = new Bebida();
            b.Bebidas(sabor1, sabor2, sabor3, sabor4, sabor5, tipo, categoria, descripcion, precio, asesor, nombre, apellido, edad, sexo);
        }
        else if (opc == 3)
        {
            string sabor1 = "Café expresso";
            string sabor2 = "Café con leche";
            string sabor3 = "Capuchino";
            string sabor4 = "Mocca";
            string sabor5 = "Café con cremora";
            string tipo = "Café";
            string categoria = "No alcohólico";
            string descripcion = "Cafesito";
            double precio = 0.75;

            Clear();
            Bebida b = new Bebida();
            b.Bebidas(sabor1, sabor2, sabor3, sabor4, sabor5, tipo, categoria, descripcion, precio, asesor, nombre, apellido, edad, sexo);
        }
        else if (opc == 4)
        {
            if (edad >= 18)
            {
                string sabor1 = "Bulleit Frontier";
                string sabor2 = "Cardhu Gold Reserve";
                string sabor3 = "Lagavulin";
                string sabor4 = "Talisker";
                string sabor5 = "Macallan";
                string tipo = "Whisky";
                string categoria = "Alcohólico";
                string descripcion = "Whiskito";
                double precio = 25.75;

                Clear();
                Bebida b = new Bebida();
                b.Bebidas(sabor1, sabor2, sabor3, sabor4, sabor5, tipo, categoria, descripcion, precio, asesor, nombre, apellido, edad, sexo);
            }
            else
            {
                WriteLine("\nEres menor de edad!");
            }
        }
        else if (opc == 5)
        {
            if (edad >= 18)
            {
                string sabor1 = "Advocaat";
                string sabor2 = "Kummel";
                string sabor3 = "Absenta";
                string sabor4 = "Sambuca";
                string sabor5 = "Triple Sec";
                string tipo = "Licor";
                string categoria = "Alcohólico";
                string descripcion = "Licorsito";
                double precio = 23.5;

                Clear();
                Bebida b = new Bebida();
                b.Bebidas(sabor1, sabor2, sabor3, sabor4, sabor5, tipo, categoria, descripcion, precio, asesor, nombre, apellido, edad, sexo);
            }
            else
            {
                WriteLine("\nEres menor de edad!");
            }
        }
        else
        {
            WriteLine("\nOpción inválida!");
        }
    }
}

public interface IDatos
{
    string Detalles();
}

namespace Clase04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Asesores disponibles: ");
            string a1 = "Ludwin Lara";
            string a2 = "Franklin Solorzano";
            WriteLine("1-" + a1);
            WriteLine("2-" + a2);

            Write("\nSelecciona uno: ");
            int opcion = int.Parse(ReadLine());

            string asesor = "";

            Utilidades u = new Utilidades();

            if (opcion == 1)
            {
                asesor = a1;                
                u.Venta(asesor);
            }
            else if (opcion == 2)
            {
                asesor = a2;
                u.Venta(asesor);
            }
            else
            {
                WriteLine("\nNo válido!");
            }
        }
    }
}