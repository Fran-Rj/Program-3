using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Supermercado
{
    internal class Producto
    {
    
        // METODO PARA OBTENER EL PRODUCTO
        public void Productos(string p1, string p2, string p3, string area, string categ)
        {
            Clear();
            Datos d = new Datos();

            WriteLine("-------------Producto-------------");
            WriteLine($"1-{d.nombreP = p1} \n2-{d.nombreP = p2} \n3-{d.nombreP = p3}");

            Write("Seleccionar producto: ");
            int opc = int.Parse(ReadLine());

            if (opc == 1)
            {
                // MUESTRAR INFORMACION PRODUCTO
                Clear();
                WriteLine("\n--------------Detalles-Producto--------------");
                d.nombreP = p1;
                d.proveedor = "Super Selectos";
                d.area = area;
                d.categoria = categ;
                d.cantidad = 4;
                d.precio = 6;
                d.fechaCompra = "01/01/2022";
                d.fechaVenc = "15/06/2022";

                WriteLine($"Nombre: {d.nombreP} \nCantidad: {d.cantidad} \nPrecio: {d.precio} " +
                    $"\nAdquirido: {d.fechaCompra} \nVence: {d.fechaVenc} \nCategoria: {d.categoria} " +
                    $"\nÁrea: {d.area} \nProveedor: {d.proveedor}");
                Write("\nPresiona Enter para continuar. . .");
                ReadKey();
                Clear();
            }
            else if (opc == 2)
            {
                Clear();
                WriteLine("\n--------------Detalles-Producto--------------");
                d.nombreP = p2;
                d.proveedor = "Super Selectos";
                d.area = area;
                d.categoria = categ;
                d.cantidad = 2;
                d.precio = 8;
                d.fechaCompra = "21/01/2022";
                d.fechaVenc = "31/06/2022";

                WriteLine($"Nombre: {d.nombreP} \nCantidad: {d.cantidad} \nPrecio: {d.precio} " +
                    $"\nAdquirido: {d.fechaCompra} \nVence: {d.fechaVenc} \nCategoria: {d.categoria} " +
                    $"\nÁrea:{d.area} \nProveedor: {d.proveedor}");
                Write("\nPresiona Enter para continuar. . .");
                ReadKey();
                Clear();
            }
            else if (opc == 3)
            {
                Clear();
                WriteLine("\n--------------Detalles-Producto--------------");
                d.nombreP = p3;
                d.proveedor = "Super Selectos";
                d.area = area;
                d.categoria = categ;
                d.cantidad = 2;
                d.precio = 5;
                d.fechaCompra = "02/01/2022";
                d.fechaVenc = "17/06/2022";

                WriteLine($"Nombre: {d.nombreP} \nCantidad: {d.cantidad} \nPrecio: {d.precio} " +
                    $"\nAdquirido: {d.fechaCompra} \nVence: {d.fechaVenc} \nCategoria: {d.categoria} " +
                    $"\nÁrea: {d.area} \nProveedor: {d.proveedor}");
                Write("\nPresiona Enter para continuar. . .");
                ReadKey();
                Clear();
            }
            else
            {
                Clear();
                WriteLine("\nError!");
            }
        }
    }
}
