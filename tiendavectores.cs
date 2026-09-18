using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // una tienda registra las ventas de 10 dias en un array double[]
            // y necesita calcular:
            // 1. calcular el total vendido
            // 2. calcular el promedio diario
            // 3. encontrar el dia con mayor venta
            // 4. encontrar el dia con menor venta
            // 5. contar cuantos dias superaron el promedio
            double[] ventas = { 200, 000, 302, 300, 400, 000, 300, 233, 700, 410, 740, 432, 100, 233, 99, 432, 823, 231, 902, 211 };
            double total = 0;
            double mayorventa = ventas[0];
            double menorventa = ventas[0];
            int diaMayorVenta = 0;
            int diaMenorVenta = 0;

            for (int i =0;i < ventas.Length; i++)
            {
                total += ventas[i];
                if (ventas[i] > mayorventa)
                {
                    mayorventa = ventas[i];
                    diaMayorVenta = i;
                }
                if (ventas[i] < menorventa)
                {
                    menorventa = ventas[i];
                    diaMenorVenta = i;
                }
            }

            double promedio = total / ventas.Length;
            int diasSobrePromedio = 0;

            for (int i=0;i< ventas.Length; i++)
            {
                if (ventas[i] > promedio)
                {
                    diasSobrePromedio++;
                }
            }

            Console.WriteLine("=============== REPORTE DE VENTAS ===============");
            Console.WriteLine();


            Console.WriteLine($"total vendido: ${total:F3}");
            Console.WriteLine($"promedio diario: ${total:F3}");
            Console.WriteLine();

            Console.WriteLine($"mayor venta: ${mayorventa:F3} - el dia {diaMayorVenta + 1}");
            Console.WriteLine($"mayor venta: ${menorventa:F3} - el dia {diaMenorVenta + 1}");


            Console.WriteLine($"dias que superan el promedio de ventas: {diasSobrePromedio}");
            Console.WriteLine();
            
            Console.WriteLine("ventas por dias");
            for (int i = 0; i < ventas.Length;i++)
            {
                Console.WriteLine($"dia {i * 1}: ${ventas[i]:F3}");
            }

        }
    }
}
