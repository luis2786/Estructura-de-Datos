    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[5];//declarando e inicializando.

            //lectura/escritura de nuestro vector
            Console.WriteLine("---- Ingreso de Temperatura------");
            for (int i = 0; i < temperaturas.Length; i++ ) 
            {
                Console.Write($"Ingrese la temperatura del dia {i + 1}: ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            }
            double suma = 0;
            double maxT = temperaturas[0];
            double minT = temperaturas[0];

            foreach (double temp in temperaturas)
            {
                suma += temp;
                if (temp > maxT) maxT = temp;
                if (temp < minT) minT = temp;
            }
            double promedio = suma / temperaturas.Length;
            Console.WriteLine("n---Reporte---");
            Console.WriteLine($"Temperaturas registradas: {string.Join(",", temperaturas)}");
            Console.WriteLine($"Temperatura promedio: {promedio:F2}°C");
            Console.WriteLine($"Temperatura Maxima:{maxT}°C");
            Console.WriteLine($"Temperatura Minima:{minT}°C");

        }
    }
}
