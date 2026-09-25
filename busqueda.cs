
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 2. Busqueda y modificacion de informacion en vectores
            // Operaciones: Busqueda lineal, verificacion de exixtencias y actualizacion
            // de un elemto en un array.
            double[] codigos = new double[5];
            Console.WriteLine($"Codigos actuales:{string.Join(",", codigos)}");
            Console.WriteLine("Ingrese el codigo que desea actualizar:");
            int busqueda = Convert.ToInt32(Console.ReadLine());

            int indiceEncontrado = -1;
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == busqueda)
                {
                    indiceEncontrado = i;
                    break;
                }
            }
            //Validando si encontre el valor que quiero modificar
            if (indiceEncontrado != -1)
            {
                Console.WriteLine("Ingrese el nuevo codigo: ");
                codigos[indiceEncontrado] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Vector actualizado:{string.Join(",", codigos)}");
            }
            else
            {

                Console.WriteLine("Error: El codigo ingresado no existe en la base de datos.");
            }
            Console.WriteLine($"Valor del indice:{indiceEncontrado}");


        }
    }
}
