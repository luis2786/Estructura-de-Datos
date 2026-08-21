using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS
{
    internal class Program
    {
        static double CalcularareaCirculo(double radio)
        {
            const double PI = 3.141592;

            //ahora voy a realizar el calculo con la formula
            double area = PI * Math.Pow(radio,2);
            return area;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese el radio del circulo: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double result = CalcularareaCirculo(r);
            Console.WriteLine($"el area es: {result:F2}");
           
        }
    }
}
