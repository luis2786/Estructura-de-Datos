using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "ventas.txt";

        // Crear el archivo de ventas
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Arroz:20");
            sw.WriteLine("Leche:15");
            sw.WriteLine("Pan:30");
            sw.WriteLine("Arroz:10");
            sw.WriteLine("Leche:25");
        }

        string[] lineas = File.ReadAllLines(ruta);

        int total = 0;
        string productoMasVendido = "";
        int mayorCantidad = 0;

        // Leer las ventas
        for (int i = 0; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(':');

            string producto = campos[0];
            int cantidad = int.Parse(campos[1]);

            total += cantidad;

            // Sumar las cantidades del mismo producto
            int sumaProducto = cantidad;

            for (int j = 0; j < i; j++)
            {
                string[] anteriores = lineas[j].Split(':');

                if (anteriores[0] == producto)
                {
                    sumaProducto += int.Parse(anteriores[1]);
                }
            }

            // Evitar contar dos veces el mismo producto
            bool yaContado = false;

            for (int j = 0; j < i; j++)
            {
                string[] anteriores = lineas[j].Split(':');

                if (anteriores[0] == producto)
                {
                    yaContado = true;
                    break;
                }
            }

            if (!yaContado && sumaProducto > mayorCantidad)
            {
                mayorCantidad = sumaProducto;
                productoMasVendido = producto;
            }
        }

        Console.WriteLine("Total de unidades vendidas: " + total);
        Console.WriteLine("Producto más vendido: " + productoMasVendido);
        Console.WriteLine("Cantidad vendida: " + mayorCantidad);

        Console.ReadKey();
    }
}

