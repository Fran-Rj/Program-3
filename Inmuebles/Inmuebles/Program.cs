using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Inmuebles
{   
    abstract class Data
    {
        public string nombre;
        public string tipo;
        public string descripcion;
        public double precio;
        public string contrato;

        public Data(string name)
        {
            this.nombre = name;
        }
        public Data(string name, string tipe, string descrip, double price)
        {
            this.nombre = name;
            this.tipo = tipe;
            this.descripcion = descrip;
            this.precio = price;
        }

        public abstract string Datos();
    }

    class Inmueble : Data
    {
        public Inmueble(string name, string tipe, string descrip, double price) : base(name, tipe, descrip, price) { }
        
        public override string Datos()
        {
            return "Nombre-Inmueble: " + nombre + "\nTipo: " + tipo + "\nDescripción: " + descripcion + "\nPrecio: $" + precio;
        }
    }

    class Empleado : Data
    {
        public Empleado(string name) : base(name) { }

        public override string Datos()
        {
            return "Asesor: " + nombre;
        }
    }

    class Cliente : Empleado
    {
        public Cliente(string name) : base(name) { }

        public override string Datos()
        {
            return "Cliente: " + nombre;
        }
    }

    class Contrato : Data
    {
        public Contrato(string tipo) : base (tipo) { }

        public override string Datos()
        { 
            return "Tipo-contrato: " + nombre;
        }
    }

    class Informacion
    {
        public void Detalles(string n, string t, string ds, string p)
        {
            WriteLine("\nAsesores disponibles: ");
            WriteLine("1-" + Asesores.asesor1 + "\n2-" + Asesores.asesor2);

            Write("\nCuál es tu elección: ");
            int opc = int.Parse(ReadLine());

            Write("\nIngresa tu nombre: ");
            string nombre = ReadLine();

            WriteLine("\n*********Tipo de contrato********");
            WriteLine("1-Total" + "\n2-Parcial" + "\n3-Temporal" + "\n4-Indefinido");
            Write("\nSelecciona el tipo de contrato: ");
            int eleccion = int.Parse(ReadLine());

            string tipo = "";            

            if (eleccion == 1)
            {
                tipo = "Total";
            }
            else if (eleccion == 2)
            {
                tipo = "Parcial";
            }
            else if (eleccion == 3)
            {
                tipo = "Temporal";
            }
            else if (eleccion == 4)
            {
                tipo = "Indefinido";
            }
            else
            {
                tipo = "No es válido!";
            }

            Cliente c = new Cliente(nombre);
            Contrato cntrt = new Contrato(tipo);


            if (opc == 1)
            {
                Empleado e = new Empleado(Asesores.asesor1);
                Inmueble i = new Inmueble(n, t, ds, double.Parse(p));               

                WriteLine("\n-------------------------Detalles-------------------------");
                WriteLine(e.Datos());
                WriteLine(c.Datos());
                WriteLine(i.Datos());
                WriteLine(cntrt.Datos());
                WriteLine("----------------------------------------------------------");
            }
            else
            {
                Empleado e = new Empleado(Asesores.asesor2);
                Inmueble i = new Inmueble(n, t, ds, double.Parse(p));

                WriteLine("\n-------------------------Detalles-------------------------");
                WriteLine(e.Datos());
                WriteLine(c.Datos());
                WriteLine(i.Datos());
                WriteLine(cntrt.Datos());
                WriteLine("----------------------------------------------------------");
            }
        }
    }

    class Asesores
    {
        public static string asesor1;
        public static string asesor2;
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("**************Bienvenido**************");

            while (true)
            {               
                WriteLine("\nOpciones disponibles: ");
                WriteLine("1-Apartamento." +
                    "\n2-Edificio." +
                    "\n3-Hacienda." +
                    "\n4-Casa.");

                Write("\nElige una opción: ");
                int opc = int.Parse(ReadLine());

                Informacion i = new Informacion();
                Asesores a = new Asesores();

                switch (opc)
                {
                    case 1:
                    {
                        Asesores.asesor1 = "Sarah Abigail";
                        Asesores.asesor2 = "Jennifer Gabriela";

                        i.Detalles("El Dormitorio", "Apartamento", "Cómodo e inigualable!", 2450.ToString());
                        break;
                    }

                    case 2:
                    { 
                        Asesores.asesor1 = "Morena Yaneth";
                        Asesores.asesor2 = "Fátima Melissa";

                        i.Detalles("The Big Boss", "Edificio", "Lo mejor de lo mejor!", 5500.ToString());
                        break;
                    }

                    case 3:
                    {
                        Asesores.asesor1 = "Rocio Jazmin"; 
                        Asesores.asesor2 = "Fernanda Guadalupe";

                        i.Detalles("Los Catrachos", "Hacienda", "Disfruta de la mejor vista!", 4800.ToString());
                        break;
                    }

                    case 4:
                    {
                        Asesores.asesor1 = "Angie María";
                        Asesores.asesor2 = "Nayeli Andrea";
                        i.Detalles("La Unión", "Casa", "Convive en familia!", 1600.ToString("#,###"));
                        break;
                    }

                    //case 5:
                    //{
                    //    break;
                    //}

                    default:
                        WriteLine("\nOpción incorrecta!");
                        break;
                }
            }
        }
    }
}
