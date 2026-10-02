using System;

public class HelloWorld {
    public static void Main(string[] args) {
        Console.WriteLine ("Try clicking the Run button.");

        // Cambia este valor por la cantidad dada en clase
        const int CANTIDAD_ESTUDIANTES = 3;

        // Arreglos estáticos paralelos
        string[] nombres = new string[CANTIDAD_ESTUDIANTES];
        double[] calificaciones = new double[CANTIDAD_ESTUDIANTES];

        // Registro de estudiantes
        for (int i = 0; i < CANTIDAD_ESTUDIANTES; i++)
        {
            // Validar nombre
            for (bool nombreValido = false; !nombreValido;)
            {
                Console.Write("Ingrese el nombre del estudiante " + (i + 1) + ": ");
                string nombre = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    nombres[i] = nombre;
                    nombreValido = true;
                }
                else
                {
                    Console.WriteLine("Error: el nombre no puede estar vacío.");
                }
            }

            // Validar calificación
            for (bool notaValida = false; !notaValida;)
            {
                Console.Write("Ingrese la calificación de " + nombres[i] + " (0.0 - 5.0): ");
                string entrada = Console.ReadLine();

                double nota;

                if (double.TryParse(entrada, out nota) &&
                    nota >= 0.0 && nota <= 5.0)
                {
                    calificaciones[i] = nota;
                    notaValida = true;
                }
                else
                {
                    Console.WriteLine("Error: ingrese una nota válida entre 0.0 y 5.0.");
                }
            }

            Console.WriteLine();
        }

        // Variables para las estadísticas
        double suma = 0;
        double notaMayor = calificaciones[0];
        double notaMenor = calificaciones[0];
        int aprobados = 0;
        int reprobados = 0;

        // Calcular estadísticas
        for (int i = 0; i < CANTIDAD_ESTUDIANTES; i++)
        {
            suma += calificaciones[i];

            if (calificaciones[i] > notaMayor)
            {
                notaMayor = calificaciones[i];
            }

            if (calificaciones[i] < notaMenor)
            {
                notaMenor = calificaciones[i];
            }

            if (calificaciones[i] >= 3.0)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
            }
        }

        double promedio = suma / CANTIDAD_ESTUDIANTES;

        // Reporte final
        
        Console.WriteLine("REPORTE DE CALIFICACIONES");
        

        for (int i = 0; i < CANTIDAD_ESTUDIANTES; i++)
        {
            Console.WriteLine(
                nombres[i] + " -> " + calificaciones[i].ToString("F2")
            );
        }


        Console.WriteLine("Promedio: " + promedio.ToString("F2"));
        Console.WriteLine("Nota mayor: " + notaMayor.ToString("F2"));
        Console.WriteLine("Nota menor: " + notaMenor.ToString("F2"));
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);
        
    }
}
