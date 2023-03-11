using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalzadoShop.Negocio
{
    internal class ClsCalzado
    {        
        public void Categorias(string tiendas)
        {
            Clear();
            WriteLine("-----------------Categoria-----------------");
            WriteLine("1-Hombre" + "\n2-Mujer");

            Write("Selecciona la categoria: ");
            int eleccion = int.Parse(ReadLine());

            Calzado c = new Calzado();
            ClsCalzado cl = new ClsCalzado();

            if (eleccion == 1)
            {
                c.categoria = "Hombre";
                cl.TipoCalzado(tiendas);
            }
            else if (eleccion == 2)
            {
                c.categoria = "Mujer";
                cl.TipoCalzado(tiendas);
            }
            else
            {
                WriteLine("\nOpción no válida!");
                Write("\nPresiona Enter para continuar...");
                ReadKey();
                Clear();
            }
        }

        public void TipoCalzado(string tiendas)
        {
            Clear();
            WriteLine("\n-----------------Tipo de Calzado-----------------");
            WriteLine("1-Deportivo" + "\n2-Formal" + "\n3-Casual");

            Write("Selecciona el tipo: ");
            int opcion = int.Parse(ReadLine());

            Calzado c = new Calzado();

            if (opcion == 1)
            {
                c.EstiloCalzado(tiendas, "Tacos", "Tenis", "Zapatilla", c.categoria, "Calzado Deportivo", c.TallaCalzado(), c.MarcaCalzado(), c.ColorCalzado(), 33.5, 40, 28.99);
                WriteLine(c.Detalles());
                Write("\nPresiona Enter para continuar...");
                ReadKey();
            }
            else if (opcion == 2)
            {

                if (c.categoria == "Mujer")
                {
                    c.EstiloCalzado(tiendas, "Mocasines", "Stilettos", "Zapatillas", c.categoria, "Calzado Formal", c.TallaCalzado(), c.MarcaCalzado(), c.ColorCalzado(), 55, 32.7, 60);
                    WriteLine(c.Detalles());
                    Write("\nPresiona Enter para continuar...");
                    ReadKey();
                }
                else
                {
                    c.EstiloCalzado(tiendas, "Mocasines", "Zapato de agujetas casual", "Zapatillas", c.categoria, "Calzado Formal", c.TallaCalzado(), c.MarcaCalzado(), c.ColorCalzado(), 55, 32.7, 60);
                    WriteLine(c.Detalles());
                    Write("\nPresiona Enter para continuar...");
                    ReadKey();
                }
            }
            else if (opcion == 3)
            {
                if (c.categoria == "Mujer")
                {
                    c.EstiloCalzado(tiendas, "Botas", "Tacones", "Tenis de cuero y tela", c.categoria, "Calzado Casual", c.TallaCalzado(), c.MarcaCalzado(), c.ColorCalzado(), 27, 19, 36);
                    WriteLine(c.Detalles());
                    Write("\nPresiona Enter para continuar...");
                    ReadKey();
                }
                else
                {
                    c.EstiloCalzado(tiendas, "Botas", "Botines", "Tenis de cuero y tela", c.categoria, "Calzado Casual", c.TallaCalzado(), c.MarcaCalzado(), c.ColorCalzado(), 27, 19, 36);
                    WriteLine(c.Detalles());
                    Write("\nPresiona Enter para continuar...");
                    ReadKey();
                }
            }  
            else
            {
                WriteLine("\nOpción incorrecta!");
                Write("\nPresiona Enter para continuar...");
                ReadKey();
                Clear();
            }
            Clear();
        }
    }
}