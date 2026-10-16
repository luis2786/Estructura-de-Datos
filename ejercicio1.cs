using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "productos.csv";

        // Crear el archivo CSV
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Nombre,Precio,Stock");
            sw.WriteLine("1,Laptop,1200,10");
            sw.WriteLine("2,Mouse,25,50");
            sw.WriteLine("3,Monitor,300,15");
        }

        // Leer el archivo
        string[] lineas = File.ReadAllLines(ruta);

        // Determinar el delimitador
        char delimitador = ',';

        Console.WriteLine("DELIMITADOR: " + delimitador);

        // Analizar los campos
        string[] campos = lineas[0].Split(delimitador);

        Console.WriteLine("\nCANTIDAD DE CAMPOS: " + campos.Length);
        Console.WriteLine("\nANALISIS DE CAMPOS:");

        for (int i = 0; i < campos.Length; i++)
        {
            Console.WriteLine("Campo " + (i + 1) + ": " + campos[i]);
        }

        // Determinar los tipos de datos
        Console.WriteLine("\nTIPOS DE DATOS:");

        for (int i = 1; i < lineas.Length; i++)
        {
            string[] datos = lineas[i].Split(delimitador);

            for (int j = 0; j < datos.Length; j++)
            {
                string tipo;

                if (int.TryParse(datos[j], out int numero))
                {
                    tipo = "Entero (int)";
                }
                else if (double.TryParse(datos[j], out double decimalNum))
                {
                    tipo = "Decimal (double)";
                }
                else
                {
                    tipo = "Texto (string)";
                }

                Console.WriteLine(
                    campos[j] + ": " + datos[j] + " - " + tipo);
            }

            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
