// Nombre: Juan Carlos Montero

using System;
using System.Collections.Generic;

class Factura
{
    public string Cliente;
    public string Producto;
    public int Cantidad;
    public decimal Precio;
}

class SistemaFacturacion
{
    static List<Factura> facturas = new List<Factura>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Sistema de Facturación ===");
            Console.WriteLine("1. Agregar Factura");
            Console.WriteLine("2. Ver Facturas");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
                AgregarFactura();
            else if (opcion == "2")
                VerFacturas();
            else if (opcion == "3")
                break;
        }
    }

    static void AgregarFactura()
    {
        Factura f = new Factura();
        Console.Write("Cliente: ");
        f.Cliente = Console.ReadLine();
        Console.Write("Producto: ");
        f.Producto = Console.ReadLine();
        Console.Write("Cantidad: ");
        f.Cantidad = int.Parse(Console.ReadLine());
        Console.Write("Precio: ");
        f.Precio = decimal.Parse(Console.ReadLine());

        facturas.Add(f);
        Console.WriteLine("Factura guardada correctamente!");
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }

    static void VerFacturas()
    {
        Console.WriteLine("\n=== Facturas Registradas ===");
        Console.WriteLine("Cliente\tProducto\tCantidad\tPrecio");
        foreach (var f in facturas)
        {
            Console.WriteLine($"{f.Cliente}\t{f.Producto}\t{f.Cantidad}\t{f.Precio}");
        }
        Console.WriteLine("\nPresione Enter para volver al menú...");
        Console.ReadLine();
    }
}
