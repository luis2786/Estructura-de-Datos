using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARAMETROS
{
    internal class Program
    {
        // SUMAR E IMPRIMIR
        public static void ImprimirSuma(int a, int b)//a,b son los parametros
        {
            int suma = a + b;
            Console.WriteLine(suma);

        }
        public static void MostrarPotenciaX(double num1, double potencia)
        {
            double result = Math.Pow(num1, potencia);
            Console.WriteLine($"la suma de { num1} elevado a { potencia}es: { result}");

        }
        static void ModificarValor(int n)
        {
            n = n + 1;
            Console.WriteLine($"Dentro del Metodo: {n}");

        }

        static void Main(string[] args)


        {
            int x = 12, y = 23;

            ImprimirSuma(y, x); //y,x (argumentos actuales)
            ImprimirSuma(1000, -1);// 1000-1 (argumentos literales
            MostrarPotenciaX(x, y);
            int edad = 39;
            Console.WriteLine($"Antes del metodo: {edad}");
            ModificarValor(edad);
            Console.WriteLine($"Despues del metodo:{edad}");
        }
    }
}
