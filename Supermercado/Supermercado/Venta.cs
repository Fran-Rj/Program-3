using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    internal class Venta
    {
        public void DatosVenta(string p1, string p2, string p3, string area, string categ)
        {
            Clear();
            Datos d = new Datos();

            WriteLine("-------------Producto-------------");
            WriteLine($"1-{d.nombreP = p1} \n2-{d.nombreP = p2} \n3-{d.nombreP = p3}");

            Write("Seleccionar producto: ");
            int opc = int.Parse(ReadLine());

            Write("\nCliente: ");
            d.nombreCliente = ReadLine();

            if (opc == 1)
            {
                // MUESTRAR INFORMACION PRODUCTO
                Clear();
                WriteLine("\n--------------Detalles - Venta--------------");
                d.nombreP = p1;
                d.cantidad = 3;
                d.precio = 6;
                d.fechaVenc = "15/06/2022";
                double total = (d.cantidad * d.precio);

                WriteLine($"Nombre: {d.nombreP} \nCantidad: {d.cantidad} \nPrecio: {d.precio} \nVence: {d.fechaVenc} \nTotal a pagar: {total} \nCliente: {d.nombreCliente}");
                Write("\nPresiona Enter para continuar. . .");
                ReadKey();
                Clear();
            }
            else if (opc == 2)
            {
                Clear();
                WriteLine("\n--------------Detalles - Venta--------------");
                d.nombreP = p2;
                d.cantidad = 2;
                d.precio = 4;
                d.fechaVenc = "21/06/2022";
                double total = (d.cantidad * d.precio);

                WriteLine($"Nombre: {d.nombreP} \nCantidad: {d.cantidad} \nPrecio: {d.precio} \nVence: {d.fechaVenc} \nTotal a pagar: {total} \nCliente: {d.nombreCliente}");
                Write("\nPresiona Enter para continuar. . .");
                ReadKey();
                Clear();
            }
            else if (opc == 3)
            {
                Clear();
                WriteLine("\n--------------Detalles - Venta--------------");
                d.nombreP = p3;
                d.cantidad = 6;
                d.precio = 9;
                d.fechaVenc = "31/06/2022";
                double total = (d.cantidad * d.precio);

                WriteLine($"Nombre: {d.nombreP} \nCantidad: {d.cantidad} \nPrecio: {d.precio} \nVence: {d.fechaVenc} \nTotal a pagar: {total} \nCliente: {d.nombreCliente}");
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