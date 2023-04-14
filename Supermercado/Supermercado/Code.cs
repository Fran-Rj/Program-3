using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    internal class Code
    {
        public void Codex()
        {
            int indice = 0, indice1 = 0, indiceA = 0;
            string[] ListCategorias = new string[10];
            string[] ListCategorias1 = new string[10];
            string[] ListAreas = new string[10];

            try
            {
                Datos d = new Datos();
                Producto p = new Producto();
                Venta v = new Venta();

                // Registros predefinidos

                // Alimentos
                ListCategorias[indice] = "Carnes";
                ListCategorias[indice + 1] = "Vegetales";
                ListCategorias[indice + 2] = "Frutas";
                indice += 3;

                // Bebida
                ListCategorias1[indice1] = "Jugos";
                ListCategorias1[indice1 + 1] = "Sodas";
                ListCategorias1[indice1 + 2] = "Alcóhol";
                indice1 += 3;

                ListAreas[indiceA] = "Alimentos";
                ListAreas[indiceA + 1] = "Bebidas";
                indiceA += 2;

                while (true)
                {
                    WriteLine("*******Bienvenido*******");
                    WriteLine("1-Entrar \n2-Salir");
                    Write("Elegir: ");
                    int x = int.Parse(ReadLine());

                    if (x == 1)
                    {
                        while (true)
                        {
                            Clear();
                            // INICIAR SESION
                            WriteLine("\nIngresa tus datos...");

                            Write("\nUsuario: ");
                            d.usuario = ReadLine();

                            Write("Clave: ");
                            d.clave = ReadLine();

                            if (d.usuario == "Jose" && d.clave == "j123")
                            {
                                d.id = 1;
                                d.nombre = "Jose Lemus";
                                d.edad = 20;
                                d.usuario = "Jose";
                                d.clave = "j123";
                                d.rol = "Administrador";

                                while (true)
                                {
                                    Clear();
                                    // MOSTRAR AREAS
                                    WriteLine("\n-----------Áreas-----------");
                                    for (int i = 0; i < indiceA; i++)
                                    {
                                        WriteLine(i + "-" + ListAreas[i]);
                                    }

                                    // OPCIONES - AREAS (AGREGAR, SELECCIONAR)
                                    WriteLine("\n*Seleccionar (-) \n*Agregar (+) \n*Salir (x)");
                                    Write("Elegir opción: ");
                                    string area = ReadLine();

                                    if (area == "-")
                                    {
                                        Clear();

                                        // ACTUALIZAR AREAS
                                        WriteLine("\n-----------Áreas-----------");
                                        for (int i = 0; i < indiceA; i++)
                                        {
                                            WriteLine(i + "-" + ListAreas[i]);
                                        }

                                        Write("Elegir opción: ");
                                        int opcA = int.Parse(ReadLine());

                                        if (opcA == 0) // AREA - ALIMENTOS
                                        {
                                            while (true)
                                            {
                                                Clear();
                                                // MOSTRAR CATEGORIAS
                                                WriteLine("\n-----------Categorias-----------");
                                                for (int i = 0; i < indice; i++)
                                                {
                                                    WriteLine(i + "-" + ListCategorias[i]);
                                                }

                                                WriteLine("\n*Seleccionar (-) \n*Agregar (+) \n*Salir (x)");
                                                Write("Elegir opción: ");
                                                string opcC = ReadLine();

                                                // SELECCION CATEGORIAS
                                                if (opcC == "-")
                                                {
                                                    Clear();
                                                    // ACTUALIZAR CATEGORIAS
                                                    WriteLine("\n-----------Categorias-----------");
                                                    for (int i = 0; i < indice; i++)
                                                    {
                                                        WriteLine(i + "-" + ListCategorias[i]);
                                                    }

                                                    Write("Seleccionar categoria: ");
                                                    int categoria = int.Parse(ReadLine());

                                                    // ELECCION - CATEGORIAS
                                                    if (categoria == 0)
                                                    {
                                                        d.area = "Alimentos";
                                                        d.categoria = "Carne";
                                                        p.Productos("Menudos", "Chicharrones", "Tortitas", d.area, d.categoria);
                                                        break;
                                                    }
                                                    else if (categoria == 1)
                                                    {
                                                        d.area = "Alimentos";
                                                        d.categoria = "Vegetales";
                                                        p.Productos("Papas", "Tomates", "Cebollas", d.area, d.categoria);
                                                        break;
                                                    }
                                                    else if (categoria == 2)
                                                    {
                                                        d.area = "Alimentos";
                                                        d.categoria = "Frutas";
                                                        p.Productos("Guineos", "Uvas", "Fresas", d.area, d.categoria);
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Write("\nError...");
                                                        ReadKey();
                                                        Clear();
                                                    }
                                                }
                                                else if (opcC == "+") // AGREGAR NUEVA CATEGORIA
                                                {
                                                    Write("\nIngresar categoria: ");
                                                    d.categoria = ReadLine();

                                                    if (indice < ListCategorias.Length)
                                                    {
                                                        ListCategorias[indice] = d.categoria;
                                                        indice += 1;

                                                        Write("\nAgregado!");
                                                        ReadKey();
                                                        Clear();
                                                    }
                                                    else
                                                    {
                                                        Write("\nAlmacenamiento lleno!");
                                                        ReadKey();
                                                        Clear();
                                                    }
                                                }
                                                else if (opcC == "x")
                                                {
                                                    Clear();
                                                    break;
                                                }
                                                else
                                                {
                                                    Write("\nError...");
                                                    ReadKey();
                                                }
                                            }
                                        }
                                        else if (opcA == 1) // AREA - BEBIDAS
                                        {
                                            while (true)
                                            {
                                                Clear();
                                                // MOSTRAR CATEGORIAS
                                                WriteLine("\n-----------Categorias-----------");
                                                for (int i = 0; i < indice1; i++)
                                                {
                                                    WriteLine(i + "-" + ListCategorias1[i]);
                                                }

                                                WriteLine("\n*Seleccionar (-) \n*Agregar (+) \n*Salir (x)");
                                                Write("Elegir opción: ");
                                                string opcC = ReadLine();

                                                // SELECCION CATEGORIAS
                                                if (opcC == "-")
                                                {
                                                    Clear();
                                                    // ACTUALIZAR CATEGORIAS
                                                    WriteLine("\n-----------Categorias-----------");
                                                    for (int i = 0; i < indice1; i++)
                                                    {
                                                        WriteLine(i + "-" + ListCategorias1[i]);
                                                    }

                                                    Write("Seleccionar categoria: ");
                                                    int categoria = int.Parse(ReadLine());

                                                    // ELECCION - CATEGORIAS
                                                    if (categoria == 0)
                                                    {
                                                        d.area = "Bebidas";
                                                        d.categoria = "Jugos";
                                                        p.Productos("Power", "Gatorade", "Del Valle", d.area, d.categoria);
                                                        break;
                                                    }
                                                    else if (categoria == 1)
                                                    {

                                                        d.area = "Bebidas";
                                                        d.categoria = "Sodas";
                                                        p.Productos("Coca-Cola", "Sprite", "Fanta", d.area, d.categoria);
                                                        break;
                                                    }
                                                    else if (categoria == 2)
                                                    {

                                                        d.area = "Bebidas";
                                                        d.categoria = "Alcóhol";
                                                        p.Productos("Chaparro", "Vino", "Wisky", d.area, d.categoria);
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Write("\nError...");
                                                        ReadKey();
                                                        Clear();
                                                    }
                                                }
                                                else if (opcC == "+")
                                                {
                                                    // AGREGAR NUEVA CATEGORIA
                                                    Write("\nIngresar categoria: ");
                                                    d.categoria = ReadLine();

                                                    if (indice1 < ListCategorias1.Length)
                                                    {
                                                        ListCategorias1[indice1] = d.categoria;
                                                        indice1 += 1;

                                                        Write("\nAgregado!");
                                                        ReadKey();
                                                        Clear();
                                                    }
                                                    else
                                                    {
                                                        Write("\nAlmacenamiento lleno!");
                                                        ReadKey();
                                                        Clear();
                                                    }
                                                }
                                                else if (opcC == "x")
                                                {
                                                    Clear();
                                                    break;
                                                }
                                                else
                                                {
                                                    Write("\nError...");
                                                    ReadKey();
                                                    Clear();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Write("\nError!");
                                            ReadKey();
                                            Clear();
                                        }
                                    }
                                    else if (area == "+")
                                    {
                                        // AGREGAR NUEVA AREA
                                        Write("\nIngresar nombre del área: ");
                                        d.area = ReadLine();

                                        if (indiceA < ListAreas.Length)
                                        {
                                            ListAreas[indiceA] = d.area;
                                            indiceA += 1;

                                            Write("\nAgregado!");
                                            ReadKey();
                                            Clear();
                                        }
                                        else
                                        {
                                            Write("\nAlmacenamiento lleno!");
                                            ReadKey();
                                            Clear();
                                        }
                                    }
                                    else if (area == "x")
                                    {
                                        Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Write("\nError...");
                                        ReadKey();
                                        Clear();
                                    }
                                }
                                break;
                            }
                            else if (d.usuario == "Maria" && d.clave == "m123")
                            {
                                d.id = 2;
                                d.nombre = "Maria Aguilar";
                                d.edad = 20;
                                d.usuario = "Maria";
                                d.clave = "m123";
                                d.rol = "Vendedor";

                                while (true)
                                {
                                    Clear();
                                    // MOSTRAR AREAS
                                    WriteLine("\n-----------Áreas-----------");
                                    for (int i = 0; i < indiceA; i++)
                                    {
                                        WriteLine(i + "-" + ListAreas[i]);
                                    }

                                    WriteLine("\n*Seleccionar (-) \n*Salir (x)");
                                    Write("Elegir opción: ");
                                    string opcM = ReadLine();

                                    if(opcM == "-")
                                    {
                                        Clear();
                                        WriteLine("\n-----------Áreas-----------");
                                        for (int i = 0; i < indiceA; i++)
                                        {
                                            WriteLine(i + "-" + ListAreas[i]);
                                        }

                                        Write("Elegir opción: ");
                                        int opcA = int.Parse(ReadLine());

                                        if (opcA == 0) // AREA - ALIMENTOS
                                        {
                                            while (true)
                                            {
                                                Clear();
                                                // MOSTRAR CATEGORIAS
                                                WriteLine("\n-----------Categorias-----------");
                                                for (int i = 0; i < indice; i++)
                                                {
                                                    WriteLine(i + "-" + ListCategorias[i]);
                                                }

                                                WriteLine("\n*Seleccionar (-) \n*Cancelar (x)");
                                                Write("Elegir opción: ");
                                                string opcn = ReadLine();

                                                if (opcn == "-")
                                                {
                                                    Clear();
                                                    WriteLine("\n-----------Categorias-----------");
                                                    for (int i = 0; i < indice; i++)
                                                    {
                                                        WriteLine(i + "-" + ListCategorias[i]);
                                                    }
                                                    Write("Seleccionar categoria: ");
                                                    int categoria = int.Parse(ReadLine());

                                                    // ELECCION - CATEGORIAS
                                                    if (categoria == 0)
                                                    {
                                                        d.area = "Alimentos";
                                                        d.categoria = "Carne";
                                                        v.DatosVenta("Menudos", "Chicharrones", "Tortitas", d.area, d.categoria);
                                                        break;
                                                    }
                                                    else if (categoria == 1)
                                                    {
                                                        d.area = "Alimentos";
                                                        d.categoria = "Vegetales";
                                                        v.DatosVenta("Papas", "Tomates", "Cebollas", d.area, d.categoria);
                                                        break;
                                                    }
                                                    else if (categoria == 2)
                                                    {
                                                        d.area = "Alimentos";
                                                        d.categoria = "Frutas";
                                                        v.DatosVenta("Guineos", "Uvas", "Fresas", d.area, d.categoria);
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Write("\nError...");
                                                        ReadKey();
                                                        Clear();
                                                    }
                                                }
                                                else if (opcn == "x")
                                                {
                                                    Clear();
                                                    break;
                                                }
                                                else
                                                {
                                                    Write("\nError...");
                                                    ReadKey();
                                                    Clear();
                                                }
                                            }

                                        }
                                        else if (opcA == 1) // AREA BEBIDAS
                                        {
                                            while (true)
                                            {
                                                Clear();
                                                // MOSTRAR CATEGORIAS
                                                WriteLine("\n-----------Categorias-----------");
                                                for (int i = 0; i < indice1; i++)
                                                {
                                                    WriteLine(i + "-" + ListCategorias1[i]);
                                                }

                                                WriteLine("\n*Seleccionar (-) \n*Cancelar (x)");
                                                Write("Elegir opción: ");
                                                string opcn = ReadLine();

                                                if (opcn == "-")
                                                {
                                                    Clear();
                                                    WriteLine("\n-----------Categorias-----------");
                                                    for (int i = 0; i < indice1; i++)
                                                    {
                                                        WriteLine(i + "-" + ListCategorias1[i]);
                                                    }

                                                    Write("Seleccionar categoria: ");
                                                    int categoria = int.Parse(ReadLine());

                                                    // ELECCION - CATEGORIAS
                                                    if (categoria == 0)
                                                    {
                                                        d.area = "Bebidas";
                                                        d.categoria = "Jugos";
                                                        v.DatosVenta("Power", "Gatorade", "Del Valle", d.area, d.categoria);
                                                        break;
                                                    }
                                                    else if (categoria == 1)
                                                    {

                                                        d.area = "Bebidas";
                                                        d.categoria = "Sodas";
                                                        v.DatosVenta("Coca-Cola", "Sprite", "Fanta", d.area, d.categoria);
                                                        break;
                                                    }
                                                    else if (categoria == 2)
                                                    {

                                                        d.area = "Bebidas";
                                                        d.categoria = "Alcóhol";
                                                        v.DatosVenta("Chaparro", "Vino", "Wisky", d.area, d.categoria);
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Write("\nError...");
                                                        ReadKey();
                                                        Clear();
                                                    }
                                                }
                                                else if (opcn == "x")
                                                {
                                                    Clear();
                                                    break;
                                                }
                                                else
                                                {
                                                    Write("\nError...");
                                                    ReadKey();
                                                    Clear();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Write("\nError...");
                                            ReadKey();
                                            Clear();
                                        }
                                    }
                                    else if (opcM == "x")
                                    {
                                        Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Write("\nError...");
                                        ReadKey();
                                        Clear();
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Write("\nNo estás registrado!");
                                ReadKey();
                                Clear();
                            }
                        }
                    }
                    else if(x == 2)
                    {
                        break;
                    }
                    else
                    {
                        Write("\nError...");
                        ReadKey();
                        Clear();
                    }
                }
            }
            catch (Exception e)
            {
                WriteLine("\nError: " + e.Message);
            }
        }
    }
}