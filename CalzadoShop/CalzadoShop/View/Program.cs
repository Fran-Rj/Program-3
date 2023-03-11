using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalzadoShop.Negocio;

namespace CalzadoShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("-----------------Tiendas-----------------");
                WriteLine("1-Par Dos" + "\n2-Mr Shoes" + "\n3-Amapola Calzados" + "\n4-Salir");

                Write("Selecciona la tienda: ");
                int opcion = int.Parse(ReadLine());

                Calzado ca = new Calzado();
                ClsCalzado c = new ClsCalzado();

                if (opcion == 1)
                {
                    ca.tienda = "Par Dos";
                    c.Categorias(ca.tienda);
                }
                else if (opcion == 2)
                {
                    ca.tienda = "Mr Shoes";
                    c.TipoCalzado(ca.tienda);
                }
                else if (opcion == 3)
                {
                    ca.tienda = "Amapola Calzados";
                    c.Categorias(ca.tienda);
                }
                else if (opcion == 4)
                {
                    break;
                }
                else
                {
                    WriteLine("\nOpción no disponible!");
                    Write("\nPresiona Enter para continuar...");
                    ReadKey();
                    Clear();
                }
            }
        }
    }
}
