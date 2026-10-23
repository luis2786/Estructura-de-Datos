using System;
using System.Collections.Generic;
using System.IO;
// Registro de incidencias de soporte tecnico utilizando archicos(.txt).
// 1. Guardar en una lista de incidencias atendidas en un archivo de texto(incidencias.txt).
// 2. Leer el archivo.
// 3. Generar un reporte que cuenta cuantas incidencias hay por prioridad(Alta,Maedia,Baja).
// La estructura del archivo es: ID, NOMBRE, DESCRIPCION, PRIORIDAD.

// Ejemplo: '01';'luisgalan','daño del pc','alta'

namespace nuevoejercicio
{
    internal class Program
    {
        //creando ruta para guardar incidencias.
        static string patArchivo = "incidencias.txt";


        static void Guardaraincidencias(List<string[]> incidencias)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(patArchivo, false))
                {
                    foreach (string[] inc in incidencias)
                    {
                        sw.WriteLine(inc);

                    }

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al escribir el archivo: {ex.Message}");
            }
        }

            static List<string[]> LeerIncidencias()
        {
            List<string[]> incidencias = new List<string[]>();
            if (File.Exists(patArchivo))
            {
                Console.WriteLine("El archivo no existe aun.");
                return incidencias;
            }
            try
            {
                string linea;
                using (StreamReader sr = new StreamReader(patArchivo))
                {
                    while ((linea = sr.ReadLine()) != null) { 
                        if (!string.IsNullOrWhiteSpace(linea))
                        {
                            string[] campos = linea.Split(';');
                            incidencias.Add(campos);

                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error al leer el aechivo {error.Message}");
            }
            return incidencias;
        }

        static void GenerarReporte(List<string[]> incidencias)
        {
            if(incidencias.Count == 0)
            {
                Console.WriteLine("No hay incidencias para reportar");
                return;
            }
            Dictionary<string, int> conteoporprioridad = new Dictionary<string, int>();
            foreach (string[] inc in incidencias)
            {
                if (inc.Length < 4) continue;
                string prioridad = inc[3];
                //inc['01';'luisgalan','daño del pc','alta']
                if (conteoporprioridad.ContainsKey(prioridad))
                {
                    conteoporprioridad[prioridad]++;
                
                }
                else
                    conteoporprioridad[prioridad]++;

            }

            Console.WriteLine("\n REPORTE DE INCIDENCIAS");
            Console.WriteLine($"Total Atendidas: {incidencias.Count}");
            Console.WriteLine("Detalle por prioridad");
            foreach (var inc in conteoporprioridad)
                Console.WriteLine("\nPrioridad {inc.key}: {inc.value}");
        }


        static void Main(string[] args)
        {
            List<string[]> incidenciasToday = new List<string[]>
            {
                new string[] {"1","luis carlos galan","no imprime","alra"},
                new string[] {"2","carlos martinez","olvido contraseña","baja" },
                new string[] {"3","ana guette","wifi lleno","alta" },
                new string[] {"4","juan diaz","pantalla azul","media" },
                new string[] {"5","maria gomez","pc no enciende","alta" },

            };

            Console.WriteLine("REGISTRO DE INCIDENCIAS UNICARIBE");
            Guardaraincidencias(incidenciasToday);
            List<string[]> incidenciasleidas = LeerIncidencias();

            Console.WriteLine("\n LISTADO DE INCIDENCIAS LEIDAS: ");
            Console.WriteLine($"{"ID",-4}{"Usuario",-15} {"descripcion",-20} {"prioridad", - 10}");
            Console.WriteLine(new string('-', 55));

            foreach (string[]inc in incidenciasleidas)
            {
                if (inc.Length < 4) continue;
                Console.WriteLine($"{inc[0],-4}{inc[1],-15}{inc[2],-20}{inc[3],-10}");

            }
            GenerarReporte(incidenciasleidas);
            Console.WriteLine("\npresione cualquier tecla para salir!!!!!");
            Console.ReadKey();


        }
    }
}
